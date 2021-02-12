using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;



namespace SerialPortCom
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
       
        double chartXValue = 0.0;
        double chartYValue = 0.0;

        private void buttonResult_Click(object sender, EventArgs e)
        {

            /*
            if (checkBoxCase.Checked)
            {
                textBoxResult.AppendText(""+textBoxInput1.Text.Equals(textBoxInput2.Text)+"\r\n");
            }
            else
            {
                textBoxResult.AppendText("" + textBoxInput1.Text.Equals(textBoxInput2.Text,StringComparison.CurrentCultureIgnoreCase) + "\r\n");
            }
            int compareInputs = string.Compare(textBoxInput1.Text, textBoxInput2.Text, !checkBoxCase.Checked);
            
            switch (compareInputs)
            {
                case -1:
                    textBoxResult.AppendText(String.Format("{0} is before {1} \r\n", textBoxInput1.Text, textBoxInput2.Text));
                    break;
                case 0:
                    textBoxResult.AppendText(String.Format("{0} is equal to {1} \r\n", textBoxInput1.Text, textBoxInput2.Text));
                    break;
                case 1:
                    textBoxResult.AppendText(String.Format("{0} is after {1} \r\n", textBoxInput1.Text, textBoxInput2.Text));
                    break;
                default:
                    break;
            }
            for (int i = 0, j=0; i < 100; i+=2,j+=i)
            {
                textBoxResult.AppendText(String.Format("i = {0}, j = {1} \r\n", i, j));
            }
            */
            if (checkBoxCase.Checked)
            {
                textBoxResult.AppendText("" + textBoxInput1.Text.IndexOf(textBoxInput2.Text) + "\r\n");
            }
            else
            {
                textBoxResult.AppendText("" + textBoxInput1.Text.ToLower().IndexOf(textBoxInput2.Text.ToLower()) + "\r\n");
            }

            string[] splitInput = textBoxInput1.Text.Split(';');
            for (int i = 0; i < splitInput.Length; i++)
            {
                textBoxResult.AppendText(String.Format("string no {0} is: {1} \r\n", i, splitInput[i]));
            }


            //textBoxInput1.Clear();
            //textBoxInput2.Clear();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tabPageLis_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxAdd.Text.Length > 0)
            {
                listBoxStuff.Items.Add(textBoxAdd.Text);
                textBoxAdd.Clear();
            }
            else
            {
                MessageBox.Show("Nothing to add.");
            }
        }

        private void comboBoxRemove_Enter(object sender, EventArgs e)
        {
            comboBoxRemove.Items.Clear();
            foreach (var item in listBoxStuff.Items)
            {
                comboBoxRemove.Items.Add(item);
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (comboBoxRemove.SelectedIndex > -1)
            {
                listBoxStuff.Items.RemoveAt(comboBoxRemove.SelectedIndex);
                comboBoxRemove.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("No stuff chosen to remove.");
            }
        }

        private void comboBoxPorts_Enter(object sender, EventArgs e)
        {
            comboBoxPorts.Items.Clear();
            string[] comPorts = SerialPort.GetPortNames();
            foreach (string ports in comPorts)
            {
                comboBoxPorts.Items.Add(ports);
            }
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (comboBoxPorts.SelectedIndex > -1)
            {
                serialPort1.PortName = comboBoxPorts.Items[comboBoxPorts.SelectedIndex].ToString();
                if (comboBoxBaud.SelectedIndex > -1)
                {
                    serialPort1.BaudRate = Convert.ToInt32(comboBoxBaud.Items[comboBoxBaud.SelectedIndex]);
                    serialPort1.Open();
                    radioButtonConnected.Checked = true;
                    //        timer1.Enabled = true;
                }
            }

        }

        private void buttonReceive_Click(object sender, EventArgs e)
        {


        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (textBoxSend.Text.Length > 0)
            {
                serialPort1.WriteLine(textBoxSend.Text);
            }
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            radioButtonConnected.Checked = false;
            timerSerialReceive.Enabled = false;
        }


        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            /*string availableData = "";
            availableData += serialPort1.ReadExisting().ToString();
            SetText(availableData.ToString());
            // byte[] inputAsASCII = Encoding.ASCII.GetBytes(availableData);
            */
        }

        delegate void SetTextCallback(string text);

        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.textBoxReceive.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.textBoxReceive.AppendText(text);
            }
        }

        private void buttonShowForm_Click(object sender, EventArgs e)
        {
            FormExtra extraForm = new FormExtra();
            extraForm.Show();
            
            /*AboutBox1 aboutWindow = new AboutBox1();
            aboutWindow.Show();
            this.Visible = false;
            aboutWindow.FormClosed += new FormClosedEventHandler(aboutWindow_FormClosed);*/
        }
        void aboutWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = true;
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            var fileName = string.Empty;

            openFileDialog1.InitialDirectory = "c:\\";
           // openFileDialog1.Filter = "";
            //openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                fileName = openFileDialog1.FileName;
                MessageBox.Show(fileName);
            }
        }

        private  void buttonPrint_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK);
        }

        private void buttonMessageBox_Click(object sender, EventArgs e)
        {
            //MessageBox.Show() Method variabels:
            string message = "Specific message about some operation. Cancel this operation?";
            string caption = "Continue with operation?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Warning;
            DialogResult result;

            //MessageBoxIcon.Warning // for Warning  
            //MessageBoxIcon.Error // for Error 
            //MessageBoxIcon.Information  // for Information
            //MessageBoxIcon.Question // for Question
            //MessageBoxIcon.Asterisk //For Info Asterisk
            //MessageBoxIcon.Exclamati  on //For triangle Warning

            // Displays the MessageBox.
            result = MessageBox.Show(this, message, caption, buttons, icon);
            if (result == DialogResult.Yes)
            {
                // Closes the parent form.
                MessageBox.Show("Yahoo!");
            }
        }

        private void buttonAddXY_Click(object sender, EventArgs e)
        {
            /*
            FileStream fileWrite = new FileStream(@"C:\tmp\test.txt", FileMode.Create, FileAccess.Write, FileShare.None);
            var textToWrite = "Xvalue;Yvalue\r\n10.0;10.0\r\n11.0;11.0\r\n";
            byte[] writeArray = Encoding.UTF8.GetBytes(textToWrite);
            fileWrite.Write(writeArray, 0, textToWrite.Length);
            fileWrite.Close();
            
            string[] lines = { "Xvalue; Yvalue", "10.0; 10.0", "11.0; 11.0" };
            StreamWriter outputFile = new StreamWriter(@"C:\tmp\Test.txt");
            foreach (string line in lines)
            {
                outputFile.WriteLine(line);
            }
            outputFile.Close();
            

            string[] lines = { "Xvalue; Yvalue", "11.0; 11.0", "12.0; 12.0" };
            File.WriteAllLines(@"C:\tmp\Test.txt", lines);
           



            FileStream readTestTextFile = new FileStream(@"C:\tmp\Test.txt", FileMode.Open, FileAccess.Read, FileShare.Read);

            */
            chart1.Series[0].Points.AddXY(Convert.ToDouble(textBoxX.Text),
                                          Convert.ToDouble(textBoxY.Text));
            textBoxX.Text = textBoxY.Text = "";
        }


        private void buttonReadFile_Click(object sender, EventArgs e)
        {
            textBoxTextFile.Clear();
            /*
            var inputFile = new StreamReader(@"C:\tmp\Test.txt");

            // Read the stream as a string, and write the string to textbox.
            textBoxTextFile.Text = inputFile.ReadToEnd();
            inputFile.Close();
            */
            //string fileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (string line in File.ReadLines(openFileDialog1.FileName)) 
                {
                    textBoxTextFile.AppendText(line);
                }
            }

            

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string fileName = "";
            string[] textFileContent = { "Hello", "World" };
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                fileName = saveFileDialog1.FileName;
                File.WriteAllLines(fileName, textFileContent);
                
                MessageBox.Show(fileName);
            }
        }

        private void timerChartAdd_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("readanalog");
                timerSerialReceive.Enabled = true;
                timerChartAdd.Enabled = false;
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            timerChartAdd.Enabled = true;
        }

        private void timerSerialReceive_Tick(object sender, EventArgs e)
        {
            if (serialPort1.BytesToRead > 0)
            {
                string availableData = "";
                availableData += serialPort1.ReadExisting().ToString();
                string[] analogReadings = availableData.Split(';');
                textBoxTextFile.AppendText(availableData);
                if (analogReadings.Length == 4)
                {
                    listBoxVa.Items.Add(analogReadings[0]);
                    chart1.Series[0].Points.AddXY(Convert.ToDouble(listBoxVa.Items.Count-1), 
                                                   Convert.ToDouble(listBoxVa.Items[listBoxVa.Items.Count - 1]));
                    listBoxVb.Items.Add(analogReadings[1]);
                    chart1.Series[1].Points.AddXY(Convert.ToDouble(listBoxVb.Items.Count - 1),
                               Convert.ToDouble(listBoxVb.Items[listBoxVb.Items.Count - 1]));
                    listBoxVab.Items.Add(analogReadings[2]);
                    chart1.Series[2].Points.AddXY(Convert.ToDouble(listBoxVab.Items.Count - 1),
                                                  Convert.ToDouble(listBoxVab.Items[listBoxVa.Items.Count - 1]));
                }
                
                timerChartAdd.Enabled = true;
                timerSerialReceive.Enabled = false;
            }
        }


    }
}
