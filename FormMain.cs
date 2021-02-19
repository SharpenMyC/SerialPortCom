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
        string receivedConfig = "QT420;0.0;500.0;50;450";
        string[] instrumentConfigs;
        List<MeasurementPoint> allMeasuredPoints = new List<MeasurementPoint>();    

        double chartXValue = 0.0;
        double chartYValue = 0.0;

        private void buttonResult_Click(object sender, EventArgs e)
        {

   
            
           try
           {
               int tmpInteger = int.Parse(textBoxInput1.Text);
               textBoxInput2.Text = tmpInteger.ToString();
           }
           catch (FormatException)
           {
                MessageBox.Show("Not an integer!");
                
                // Exception err = new Exception("Something is wrong...");
              // throw (err);
           }

            /*
                       //Exception err = new Exception("There was a problem");
                       //  throw err;


                       int[] arrayOfInts = { 1, 2, 3, 4, 5, 6 };  //reference in stack, values in heap memory
                       string[] daysOfWeek = { "Monday",
                                               "Tuesday",
                                               "Wednesday",
                                               "Thursday",
                                               "Friday",
                                               "Saturday",
                                               "Sunday"
                                              };
                       string[] weekEnd = new string[2];
                       Array.Copy(daysOfWeek, 5, weekEnd, 0, 2);
                       foreach (string day in weekEnd)
                       {
                           textBoxResult.AppendText(day + "\r\n");
                       }

                       daysOfWeek = daysOfWeek.Reverse().ToArray();
                       textBoxResult.AppendText(string.Join(" ", daysOfWeek));

                       string[][] monthDayArray =
                       {
                           new string[] {"January","February","March","April","May","June","July","August","Septembre","October","November","December"},
                           new string[] { "Monday","Tuesday","Wednesday","Thursday","Friday","Saturday","Sunday"}
                       };



                       //Array.Sort(daysOfWeek);
                       foreach (string day in daysOfWeek)
                       {
                           textBoxResult.AppendText(day + "\r\n");
                       }




                        for (int day = 0; day < daysOfWeek.Length; day++)
                        {
                            textBoxResult.AppendText(daysOfWeek[day].ToString()+"\r\n");
                        }

                        //arrayOfInts = new int[6]; //array of 6 elements created in Heap memory

                        int[,] array2D =
                            { 
                                {1,2}, 
                                {3,4}, 
                                {5,6}, 
                                {7,8}
                            };
                        for (int row = 0; row < array2D.GetLength(0); row++)
                        {
                            for (int col = 0; col < array2D.GetLength(1); col++)
                            {
                                string tmpString = string.Format("Element({0},{1})={2}\n", row, col, array2D[row, col]); 
                                textBoxResult.AppendText(tmpString);
                            }
                        }

                        int[] lengths4dArray = new int[4] { 2, 3, 4, 5 };
                        Array array4d = Array.CreateInstance(typeof(String), lengths4dArray);
                        for (int i = 0; i < array4d.GetLength(0); i++)
                        {
                            for (int j = 0; j < array4d.GetLength(1); j++)
                            {
                                for (int k = 0; k < array4d.GetLength(2); k++)
                                {
                                    for (int l = 0; l < array4d.GetLength(3); l++)
                                    {
                                        int[] indicesArray = new int[4] { i, j, k, l };
                                        array4d.SetValue(Convert.ToString(i) + j + k + l, indicesArray);
                                    }
                                }
                            }
                        }
                        int[] indexArray = { 1, 2, 3, 4 };
                        textBoxResult.AppendText(array4d.GetValue(indexArray).ToString()+"\r\n\n");


                        // arrayOfInts = arrayOfInts.Reverse().ToArray();  
                        //  textBoxResult.AppendText(string.Join(" ",arrayOfInts));


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
                    try
                    {
                        serialPort1.Open();
                        radioButtonConnected.Checked = true;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Unable to connect");
                        radioButtonConnected.Checked = false;
                    }
                    
                    
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

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK) ;
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
                serialPort1.WriteLine("ReadSensor");
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
                MeasurementPoint measuredPoint;   
                string availableData = "";
                availableData += serialPort1.ReadExisting().ToString();
                string[] analogReadings = availableData.Split(';');

                

                textBoxTextFile.AppendText(availableData);
                if (analogReadings.Length == 3)
                {
                    measuredPoint = new MeasurementPoint(DateTime.Now.ToLongTimeString(), Convert.ToInt32(analogReadings[0]), Convert.ToInt32(analogReadings[1]), Convert.ToInt32(analogReadings[2]));
                    chart1.Series[0].Points.AddXY(measuredPoint.time, measuredPoint.va);
                    chart1.Series[1].Points.AddXY(measuredPoint.time, measuredPoint.vb);
                    chart1.Series[2].Points.AddXY(measuredPoint.time, measuredPoint.vab);
                    allMeasuredPoints.Add(measuredPoint);

                    //listBoxVa.Items.Add(analogReadings[0]);
                    /*
                    chart1.Series[0].Points.AddXY(Convert.ToDouble(listBoxVa.Items.Count - 1),
                                                   Convert.ToDouble(listBoxVa.Items[listBoxVa.Items.Count - 1]));
                    listBoxVb.Items.Add(analogReadings[1]);
                    chart1.Series[1].Points.AddXY(Convert.ToDouble(listBoxVb.Items.Count - 1),
                               Convert.ToDouble(listBoxVb.Items[listBoxVb.Items.Count - 1]));
                    listBoxVab.Items.Add(analogReadings[2]);
                    chart1.Series[2].Points.AddXY(Convert.ToDouble(listBoxVab.Items.Count - 1),
                                                  Convert.ToDouble(listBoxVab.Items[listBoxVa.Items.Count - 1]));
                
                    */
                }

                timerChartAdd.Enabled = true;
                timerSerialReceive.Enabled = false;
            }
        }


        public class MeasurementPoint
        {
            //The objects variables
            //{get; set;} makes it possible to both change the variable(set) and read the variable(get)
            //It is possible to remove either get and set or both to make the object more rigid.
            public String time { get; set; }
            public int va { get; set; }
            public int vb { get; set; }
            public int vab { get; set; }
            //The constructor of the object Needs to be called when you want to create a new object of this type
            public MeasurementPoint(String time, int va, int vb, int vab)
            {
                //"this" referes to the objects variable. 
                //It is needed because the variables sent to the constructor and the objects variables are named the same. 
                this.time = time;
                this.va = va;
                this.vb = vb;
                this.vab = vab;
            }
            //overrides the base object ToString(). makes it possible to decide what is printed when ToString is called.
            public override string ToString()
            {
                return time + ";" + va + ";" + vb + ";" + vab;
            }
        }

        public class Instrument
        {
            //class body

            //Field declaration
            private int measurement;

            //A constructor
            public Instrument(int measurement)
            {
                this.measurement = measurement;
            }
            //Another constructor
            public Instrument(string tagname, string unit, double lrv, double urv)
            {
                this.tagname = tagname;
                this.unit = unit;
                this.lrv = lrv;
                this.urv = urv;
            }

            //Properties Definitions
            public string tagname
            {
                get { return tagname; }
                set { tagname = value; }
            }
            public string unit { get; set; }
            public double lrv { get; set; }
            public double urv { get; set; }

            //Method declaration
            public double Scaled()
            {
                return measurement / 10.0;
            }

        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            instrumentConfigs = receivedConfig.Split(';');
            TextBox[] textboxes = { textBoxTagname,
                                    textBoxLRV,
                                    textBoxURV,
                                    textBoxAL,
                                    textBoxAH,
            };
            textboxes[0].Text = instrumentConfigs[0];
            //textBoxTagname.Text = instrumentConfigs[0];
            textBoxLRV.Text = instrumentConfigs[1];
            textBoxURV.Text = instrumentConfigs[2];
            textBoxAL.Text = instrumentConfigs[3];
            textBoxAH.Text = instrumentConfigs[4];



        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < instrumentConfigs.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        if (textBoxTagname.Text == "")
                        {
                            MessageBox.Show("Configuration empty");
                            textBoxTagname.Focus();
                        }
                        break;
                    case 1:
                        if (textBoxLRV.Text == "")
                        {
                            MessageBox.Show("Configuration empty");
                            textBoxLRV.Focus();
                        }
                        break;

                    case 2:
                        if (textBoxURV.Text == "")
                        {
                            MessageBox.Show("Configuration empty");
                            textBoxURV.Focus();
                        }
                        break;
                    case 3:
                        if (textBoxAL.Text == "")
                        {
                            MessageBox.Show("Configuration empty");
                            textBoxAL.Focus();
                        }
                        break;
                    case 4:
                        if (textBoxAH.Text == "")
                        {
                            MessageBox.Show("Configuration empty");
                            textBoxAH.Focus();
                        }
                        break;

                    default:
                        instrumentConfigs[i] = textBoxTagname.Text;
                        instrumentConfigs[i] = textBoxLRV.Text;
                        instrumentConfigs[i] = textBoxURV.Text;
                        instrumentConfigs[i] = textBoxAL.Text;
                        instrumentConfigs[i] = textBoxAH.Text;
                        break;
                }




            }

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            instrumentConfigs = new string[5];
        }

        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            if (saveFileDialogConfig.ShowDialog() == DialogResult.OK)
            {

                File.WriteAllText(saveFileDialogConfig.FileName, string.Join(";", instrumentConfigs));
            }
        }

        private void buttonSendSerial_Click(object sender, EventArgs e)
        {
            string writeString;
            string passwordString = "Passord123";

            writeString = "writeconf>" + passwordString +">" + string.Join(";", instrumentConfigs);
            textBoxResult.Clear();
            textBoxResult.Text = writeString;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (saveFileDialogCSV.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter streamWritePoints = new StreamWriter(saveFileDialogCSV.FileName))

                    foreach (MeasurementPoint point in allMeasuredPoints)
                {
                        streamWritePoints.WriteLine(point.ToString());
                }
                
            }
        }
    }
}
