using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Text.RegularExpressions;

namespace GrblOutput {
	public partial class Form1 : Form {
		string RxString;
		List<string> lines = new List<string>();
		int CurrentRow = 0;
		bool transfer = false;
        bool settingsload = false;
        private Thread settingsthread = null;

		public Form1() {
			InitializeComponent();

			System.Windows.Forms.Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
			AppDomain currentDomain = AppDomain.CurrentDomain;
			currentDomain.UnhandledException += new UnhandledExceptionEventHandler(Application_UnhandledException);

			disableControlsForPrinting();
			stopPrintBtn.Enabled = false;
		}

		private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e) {
			Exception ex = e.Exception;
			MessageBox.Show(ex.Message, "Thread exception");
		}

		private static void Application_UnhandledException(object sender, UnhandledExceptionEventArgs e) {
			if (e.ExceptionObject != null) {
				Exception ex = (Exception)e.ExceptionObject;
				MessageBox.Show(ex.Message, "Application exception");
			}
		}

		private void BrowseBtn_Click(object sender, EventArgs e) {
			openFileDialog1.Filter = "G-code Files(*.CNC;*.NC;*.TAP;*.TXT)|*.CNC;*.NC;*.TAP;*.TXT|All files (*.*)|*.*";
			openFileDialog1.FileName = "";
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				textBox1.Text = openFileDialog1.FileName;

				if(File.Exists(textBox1.Text)) {
					using (StreamReader r = new StreamReader(textBox1.Text)) {
						string line = String.Empty;
						int rowCounter = 0;
						while ((line = r.ReadLine()) != null) {
							if (line.Trim() != "")
								rowCounter++;
						}
						rowsInFileLbl.Text = "Rows: " + rowCounter.ToString();
					}
				}

			}
		}

		private void buttonStart_Click(object sender, EventArgs e) {
			serialPort1.PortName = comboBox1.SelectedItem.ToString();
			serialPort1.BaudRate = 9600;

			serialPort1.Open();
			if (serialPort1.IsOpen) {
				comboBox1.Enabled = false;
				ReloadBtn.Enabled = false;
				StartBtn.Enabled = false;
				StopBtn.Enabled = true;
				textBox3.ReadOnly = false;
				enableControlsForPrinting();
			}
		}

		private void buttonStop_Click(object sender, EventArgs e) {
			if (serialPort1.IsOpen) {
				serialPort1.Close();}

				comboBox1.Enabled = true;
				ReloadBtn.Enabled = true;
				StartBtn.Enabled = true;
				StopBtn.Enabled = false;
				textBox3.ReadOnly = true;
				transfer = false;
				disableControlsForPrinting();
				BrowseBtn.Enabled = true;
				stopPrintBtn.Enabled = false;
			

		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
			if (serialPort1.IsOpen) serialPort1.Close();
		}

		private void textBox1_KeyPress(object sender, KeyPressEventArgs e) {
			if (e.KeyChar == (char)13) {
				if (!serialPort1.IsOpen) return;
				textBox3.Text += "\r\n";
				char[] buff = new char[textBox3.Text.Length];
				buff = textBox3.Text.ToCharArray();
				serialPort1.Write(buff, 0, buff.Count());
				textBox3.Text = "";
                e.Handled = true;
			}
		}

		private void DisplayText(object sender, EventArgs e) {
			string[] arr = RxString.Replace("\n\r", "\r\n").Replace("\r\n", "\n").Trim('\n').Split('\n');
			foreach (string item in arr) {
				if (item != "ok") {
					serialResponseList.Items.Add(item);
					serialResponseList.TopIndex = serialResponseList.Items.Count - 1;
				}
			}
		}

		private void DisplayCurrentRow(object sender, EventArgs e) {
			serialResponseList.Items.Add(lines[CurrentRow-1]);
			if(scrollOutputChkbox.Checked)
				serialResponseList.TopIndex = serialResponseList.Items.Count - 1;
			sentRowsLbl.Text = "Sent rows: " + CurrentRow.ToString();
		}

		private void PrintDone(object sender, EventArgs e) {
			MessageBox.Show("Yeay, all the G-code was sent to Grbl.", "Done...", MessageBoxButtons.OK, MessageBoxIcon.Information);
			transfer = false;
			enableControlsForPrinting();
		}

		private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e) 
        {
            if (settingsload == true)
            {
               SettingsLoad();
               settingsload = false;
               return;
            }
			RxString += serialPort1.ReadExisting();
			if ((RxString.EndsWith("\r\n") && radioButton2.Checked) || (RxString.EndsWith("\n\r") && radioButton1.Checked)) {				// NORMAL: \n\r
				this.Invoke(new EventHandler(DisplayText));
				RxString = String.Empty;
				if (transfer)
					sendNextLine();
			}
		}

		private void sendNextLine() {
			try {
				if(serialPort1.IsOpen) {
					if (CurrentRow < lines.Count) {
						// Check if we need to override and F command. This is a little rude, we just replaces first F in line...
						if (lines[CurrentRow].ToLower().IndexOf('f') > -1 && overrideSpeedChkbox.Checked) {
							// Yea, this can be done a lot better.
							int startPos = lines[CurrentRow].ToLower().IndexOf('f') + 1;
							string firstPart = lines[CurrentRow].Substring(0, startPos);
							string lastPart = lines[CurrentRow].Substring(startPos);
							lastPart = Regex.Replace(lastPart, "^\\d+(.\\d*)", speedOverrideNumber.Value.ToString());
							lines[CurrentRow] = firstPart + lastPart;
						}
						serialPort1.WriteLine(lines[CurrentRow]);
						CurrentRow++;
						this.Invoke(new EventHandler(DisplayCurrentRow));
					} else {
						transfer = false;
						this.Invoke(new EventHandler(PrintDone));
					}
				} else {
					MessageBox.Show("Port not open.");
				}
			} catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}

		private void PrintBtn_Click(object sender, EventArgs e) {
			if (File.Exists(textBox1.Text)) {
				using (StreamReader r = new StreamReader(textBox1.Text)) {
					disableControlsForPrinting();
					lines = new List<string>();
					CurrentRow = 0;
					transfer = true;

					string line;
					while ((line = r.ReadLine()) != null) {
						if (line.Trim() != "")
							lines.Add(line.Trim());
					}
					rowsInFileLbl.Text = "Rows: " + lines.Count.ToString();
					sendNextLine();
				}
			}
		}

		private void enableControlsForPrinting() {
			stopPrintBtn.Enabled = false;
			PrintBtn.Enabled = true;
			BrowseBtn.Enabled = true;
			overrideSpeedChkbox.Enabled = true;
			speedOverrideNumber.Enabled = true;
			textBox1.Enabled = true;
		}

		private void disableControlsForPrinting() {
			PrintBtn.Enabled = false;
			BrowseBtn.Enabled = false;
			overrideSpeedChkbox.Enabled = false;
			speedOverrideNumber.Enabled = false;
			stopPrintBtn.Enabled = true;
			textBox1.Enabled = false;
		}

		private void loadPortSelector() {
			List<String> tList = new List<String>();

			comboBox1.Items.Clear();

			foreach (string s in SerialPort.GetPortNames()) {
				tList.Add(s);
			}

			if (tList.Count < 1) {
				MessageBox.Show("No serial ports found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} else {
				tList.Sort();
				comboBox1.Items.AddRange(tList.ToArray());
				comboBox1.SelectedIndex = 0;
			}
		}

		private void Form1_Load(object sender, EventArgs e) {
			loadPortSelector();
		}

		private void ReloadBtn_Click(object sender, EventArgs e) {
			loadPortSelector();
		}

		private void Form1_FormClosing_1(object sender, FormClosingEventArgs e) {
			try {
				if (serialPort1.IsOpen)
					serialPort1.Close();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void stopPrintBtn_Click(object sender, EventArgs e) {
			transfer = false;
			enableControlsForPrinting();
			serialPort1.WriteLine("M5");
			serialPort1.WriteLine("G0 X0 Y0");
		}

		private void serialResponseList_DrawItem(object sender, DrawItemEventArgs e) {
			if (e.Index > -1)
			{
				Color C = Color.White;
				if (serialResponseList.Items[e.Index].ToString().Contains("error:"))
					C = Color.LightPink;
				else if (serialResponseList.Items[e.Index].ToString().Contains("Grbl") || serialResponseList.Items[e.Index].ToString().Contains('$'))
					C = Color.LightSkyBlue;

				e.DrawBackground();
				Graphics g = e.Graphics;

				// draw the background color you want
				g.FillRectangle(new SolidBrush(C), e.Bounds);

				// draw the text of the list item, not doing this will only show the background color
				g.DrawString(serialResponseList.Items[e.Index].ToString(), e.Font, new SolidBrush(Color.Black), new PointF(e.Bounds.X, e.Bounds.Y));

				e.DrawFocusRectangle();
			}
		}

        private void settingsBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                
            }


        }

        private void AddSettingButton1_Click(object sender, EventArgs e)
        {
            settingsBox1.Items.Add(AddSettingTextBox.Text);
            AddSettingTextBox.Text = "";
        }

        private void ApplySettingsButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem i in settingsBox1.Items)
            {
                SendString(i.Text);
                DisplayText("Applied Settings");
            }
            
        }

        private void AddSettingTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                
                AddSettingTextBox.Text = "";
                e.Handled = true;
            }

        }

        private void SendString(string s)
        {
            if (!serialPort1.IsOpen) return;
            s += "\r\n";
            char[] buff = new char[s.Length];
            buff = s.ToCharArray();
            serialPort1.Write(buff, 0, buff.Count());
        }

        private void LoadDeviceSettingsButton_Click(object sender, EventArgs e)
        {
            settingsBox1.Items.Clear();
            settingsload = true;
            SendString("$$");
        }

        private void SettingsLoad()
        {
            Thread.Sleep(1000);
            RxString += serialPort1.ReadExisting();
            string[] settings = RxString.Replace("\n\r", "\r\n").Replace("\r\n", "\n").Trim('\n').Split('\n');

            foreach (string setting in settings)
            {
                if (setting.StartsWith("$"))
                {
                    AddSetting(setting);
                }
                else
                {
                    settingsload = false;
                }
            }
            RxString = "";

        }
        delegate void AddSettingCallBack(string s);

        private void AddSetting(string s)
        {
            if (InvokeRequired == true)
            {
                AddSettingCallBack d = new AddSettingCallBack(AddSetting);
                this.Invoke(d, new object[] { s });
            }
            else
            {
                ListViewItem item = new ListViewItem(s.Split('('));
                item.SubItems[0].Text = item.SubItems[0].Text.TrimEnd(' ');
                settingsBox1.Items.Add(item);
            }
        }

        private void settingsBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            foreach (ListViewItem i in settingsBox1.SelectedItems)
            {
                SendString(i.Text);
                DisplayText("Applied Setting: " + i.Text + " " + i.SubItems[1].Text);
            }
        }

        private void DisplayText(string s)
        {
            serialResponseList.Items.Add(s);
            serialResponseList.TopIndex = serialResponseList.Items.Count - 1;
        }

        private void BinaryTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (BinaryTextBox.Text != "")
                {
                    IntegerTextBox.Text = Convert.ToString(Convert.ToInt16(BinaryTextBox.Text, 2), 10);
                    e.Handled = true;
                }
                return;
            }
            if (!((e.KeyChar == '1') || (e.KeyChar == '0')||(e.KeyChar == (char)Keys.Delete)||(e.KeyChar == (char)Keys.Back)))
            {
                System.Media.SystemSounds.Beep.Play();
                e.Handled = true;
            }
        }

        private void ToIntButton_Click(object sender, EventArgs e)
        {
            KeyPressEventArgs enter = new KeyPressEventArgs((char)Keys.Enter);
            BinaryTextBox_KeyPress(this, enter);
        }

        private void IntegerTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (IntegerTextBox.Text != "")
                {
                    int value = Convert.ToInt16(IntegerTextBox.Text, 10);
                    if (value < 256) { BinaryTextBox.Text = Convert.ToString(value, 2); }
                    else { System.Media.SystemSounds.Beep.Play(); }

                    e.Handled = true;
                }
                return;
            }
            if (!(((e.KeyChar >=  '0')&&(e.KeyChar <='9')) || (e.KeyChar == (char)Keys.Delete) || (e.KeyChar == (char)Keys.Back)))
            {
                System.Media.SystemSounds.Beep.Play();
                e.Handled = true;
            }
            
        }







	}

}
