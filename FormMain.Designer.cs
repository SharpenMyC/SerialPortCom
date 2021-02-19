
namespace SerialPortCom
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageString = new System.Windows.Forms.TabPage();
            this.buttonSendSerial = new System.Windows.Forms.Button();
            this.buttonRead = new System.Windows.Forms.Button();
            this.buttonSaveFile = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBoxAH = new System.Windows.Forms.TextBox();
            this.labelAH = new System.Windows.Forms.Label();
            this.textBoxAL = new System.Windows.Forms.TextBox();
            this.labelAL = new System.Windows.Forms.Label();
            this.textBoxURV = new System.Windows.Forms.TextBox();
            this.labelURV = new System.Windows.Forms.Label();
            this.textBoxLRV = new System.Windows.Forms.TextBox();
            this.labelLRV = new System.Windows.Forms.Label();
            this.textBoxTagname = new System.Windows.Forms.TextBox();
            this.labelTagname = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonMessageBox = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.buttonShowForm = new System.Windows.Forms.Button();
            this.buttonResult = new System.Windows.Forms.Button();
            this.checkBoxCase = new System.Windows.Forms.CheckBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.textBoxInput2 = new System.Windows.Forms.TextBox();
            this.textBoxInput1 = new System.Windows.Forms.TextBox();
            this.tabPageLoop = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxVab = new System.Windows.Forms.ListBox();
            this.listBoxVb = new System.Windows.Forms.ListBox();
            this.listBoxVa = new System.Windows.Forms.ListBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonReadFile = new System.Windows.Forms.Button();
            this.textBoxTextFile = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.labelY = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.labelX = new System.Windows.Forms.Label();
            this.buttonAddXY = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPageLis = new System.Windows.Forms.TabPage();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listBoxStuff = new System.Windows.Forms.ListBox();
            this.comboBoxRemove = new System.Windows.Forms.ComboBox();
            this.textBoxAdd = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tabPageSerial = new System.Windows.Forms.TabPage();
            this.textBoxSend = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.labelBaud = new System.Windows.Forms.Label();
            this.labelPorts = new System.Windows.Forms.Label();
            this.radioButtonConnected = new System.Windows.Forms.RadioButton();
            this.buttonReceive = new System.Windows.Forms.Button();
            this.textBoxReceive = new System.Windows.Forms.TextBox();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.comboBoxBaud = new System.Windows.Forms.ComboBox();
            this.comboBoxPorts = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timerSerialReceive = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.timerChartAdd = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialogConfig = new System.Windows.Forms.SaveFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.saveFileDialogCSV = new System.Windows.Forms.SaveFileDialog();
            this.tabControlMain.SuspendLayout();
            this.tabPageString.SuspendLayout();
            this.tabPageLoop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPageLis.SuspendLayout();
            this.tabPageSerial.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageString);
            this.tabControlMain.Controls.Add(this.tabPageLoop);
            this.tabControlMain.Controls.Add(this.tabPageLis);
            this.tabControlMain.Controls.Add(this.tabPageSerial);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(962, 355);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageString
            // 
            this.tabPageString.Controls.Add(this.buttonSendSerial);
            this.tabPageString.Controls.Add(this.buttonRead);
            this.tabPageString.Controls.Add(this.buttonSaveFile);
            this.tabPageString.Controls.Add(this.buttonUpdate);
            this.tabPageString.Controls.Add(this.textBoxAH);
            this.tabPageString.Controls.Add(this.labelAH);
            this.tabPageString.Controls.Add(this.textBoxAL);
            this.tabPageString.Controls.Add(this.labelAL);
            this.tabPageString.Controls.Add(this.textBoxURV);
            this.tabPageString.Controls.Add(this.labelURV);
            this.tabPageString.Controls.Add(this.textBoxLRV);
            this.tabPageString.Controls.Add(this.labelLRV);
            this.tabPageString.Controls.Add(this.textBoxTagname);
            this.tabPageString.Controls.Add(this.labelTagname);
            this.tabPageString.Controls.Add(this.buttonSave);
            this.tabPageString.Controls.Add(this.buttonMessageBox);
            this.tabPageString.Controls.Add(this.buttonPrint);
            this.tabPageString.Controls.Add(this.buttonOpenFile);
            this.tabPageString.Controls.Add(this.buttonShowForm);
            this.tabPageString.Controls.Add(this.buttonResult);
            this.tabPageString.Controls.Add(this.checkBoxCase);
            this.tabPageString.Controls.Add(this.textBoxResult);
            this.tabPageString.Controls.Add(this.textBoxInput2);
            this.tabPageString.Controls.Add(this.textBoxInput1);
            this.tabPageString.Location = new System.Drawing.Point(4, 22);
            this.tabPageString.Name = "tabPageString";
            this.tabPageString.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageString.Size = new System.Drawing.Size(954, 329);
            this.tabPageString.TabIndex = 0;
            this.tabPageString.Text = "String";
            this.tabPageString.UseVisualStyleBackColor = true;
            // 
            // buttonSendSerial
            // 
            this.buttonSendSerial.Location = new System.Drawing.Point(377, 247);
            this.buttonSendSerial.Name = "buttonSendSerial";
            this.buttonSendSerial.Size = new System.Drawing.Size(185, 29);
            this.buttonSendSerial.TabIndex = 20;
            this.buttonSendSerial.Text = "Send Serial";
            this.buttonSendSerial.UseVisualStyleBackColor = true;
            this.buttonSendSerial.Click += new System.EventHandler(this.buttonSendSerial_Click);
            // 
            // buttonRead
            // 
            this.buttonRead.Location = new System.Drawing.Point(377, 200);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(54, 33);
            this.buttonRead.TabIndex = 8;
            this.buttonRead.Text = "Read";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // buttonSaveFile
            // 
            this.buttonSaveFile.Location = new System.Drawing.Point(509, 200);
            this.buttonSaveFile.Name = "buttonSaveFile";
            this.buttonSaveFile.Size = new System.Drawing.Size(54, 33);
            this.buttonSaveFile.TabIndex = 7;
            this.buttonSaveFile.Text = "Save";
            this.buttonSaveFile.UseVisualStyleBackColor = true;
            this.buttonSaveFile.Click += new System.EventHandler(this.buttonSaveFile_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(443, 200);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(54, 33);
            this.buttonUpdate.TabIndex = 6;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // textBoxAH
            // 
            this.textBoxAH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAH.Location = new System.Drawing.Point(377, 159);
            this.textBoxAH.Name = "textBoxAH";
            this.textBoxAH.Size = new System.Drawing.Size(186, 24);
            this.textBoxAH.TabIndex = 5;
            // 
            // labelAH
            // 
            this.labelAH.AutoSize = true;
            this.labelAH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAH.Location = new System.Drawing.Point(248, 162);
            this.labelAH.Name = "labelAH";
            this.labelAH.Size = new System.Drawing.Size(80, 18);
            this.labelAH.TabIndex = 19;
            this.labelAH.Text = "Alarm High";
            // 
            // textBoxAL
            // 
            this.textBoxAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAL.Location = new System.Drawing.Point(377, 129);
            this.textBoxAL.Name = "textBoxAL";
            this.textBoxAL.Size = new System.Drawing.Size(186, 24);
            this.textBoxAL.TabIndex = 5;
            // 
            // labelAL
            // 
            this.labelAL.AutoSize = true;
            this.labelAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAL.Location = new System.Drawing.Point(250, 132);
            this.labelAL.Name = "labelAL";
            this.labelAL.Size = new System.Drawing.Size(78, 18);
            this.labelAL.TabIndex = 17;
            this.labelAL.Text = "Alarm Low";
            // 
            // textBoxURV
            // 
            this.textBoxURV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxURV.Location = new System.Drawing.Point(377, 99);
            this.textBoxURV.Name = "textBoxURV";
            this.textBoxURV.Size = new System.Drawing.Size(186, 24);
            this.textBoxURV.TabIndex = 3;
            // 
            // labelURV
            // 
            this.labelURV.AutoSize = true;
            this.labelURV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelURV.Location = new System.Drawing.Point(248, 102);
            this.labelURV.Name = "labelURV";
            this.labelURV.Size = new System.Drawing.Size(127, 18);
            this.labelURV.TabIndex = 15;
            this.labelURV.Text = "Upper range value";
            // 
            // textBoxLRV
            // 
            this.textBoxLRV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLRV.Location = new System.Drawing.Point(377, 69);
            this.textBoxLRV.Name = "textBoxLRV";
            this.textBoxLRV.Size = new System.Drawing.Size(186, 24);
            this.textBoxLRV.TabIndex = 2;
            // 
            // labelLRV
            // 
            this.labelLRV.AutoSize = true;
            this.labelLRV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLRV.Location = new System.Drawing.Point(247, 72);
            this.labelLRV.Name = "labelLRV";
            this.labelLRV.Size = new System.Drawing.Size(128, 18);
            this.labelLRV.TabIndex = 13;
            this.labelLRV.Text = "Lower range value";
            // 
            // textBoxTagname
            // 
            this.textBoxTagname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTagname.Location = new System.Drawing.Point(377, 39);
            this.textBoxTagname.Name = "textBoxTagname";
            this.textBoxTagname.PasswordChar = '*';
            this.textBoxTagname.Size = new System.Drawing.Size(186, 24);
            this.textBoxTagname.TabIndex = 1;
            // 
            // labelTagname
            // 
            this.labelTagname.AutoSize = true;
            this.labelTagname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTagname.Location = new System.Drawing.Point(247, 42);
            this.labelTagname.Name = "labelTagname";
            this.labelTagname.Size = new System.Drawing.Size(70, 18);
            this.labelTagname.TabIndex = 11;
            this.labelTagname.Text = "Tagname";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(735, 138);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(197, 27);
            this.buttonSave.TabIndex = 13;
            this.buttonSave.Text = "Save File";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonMessageBox
            // 
            this.buttonMessageBox.Location = new System.Drawing.Point(735, 106);
            this.buttonMessageBox.Name = "buttonMessageBox";
            this.buttonMessageBox.Size = new System.Drawing.Size(197, 26);
            this.buttonMessageBox.TabIndex = 12;
            this.buttonMessageBox.Text = "Message Box";
            this.buttonMessageBox.UseVisualStyleBackColor = true;
            this.buttonMessageBox.Click += new System.EventHandler(this.buttonMessageBox_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.Location = new System.Drawing.Point(735, 18);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(197, 23);
            this.buttonPrint.TabIndex = 9;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(735, 47);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(197, 23);
            this.buttonOpenFile.TabIndex = 10;
            this.buttonOpenFile.Text = "Open File";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // buttonShowForm
            // 
            this.buttonShowForm.Location = new System.Drawing.Point(735, 76);
            this.buttonShowForm.Name = "buttonShowForm";
            this.buttonShowForm.Size = new System.Drawing.Size(197, 23);
            this.buttonShowForm.TabIndex = 11;
            this.buttonShowForm.Text = "About";
            this.buttonShowForm.UseVisualStyleBackColor = true;
            this.buttonShowForm.Click += new System.EventHandler(this.buttonShowForm_Click);
            // 
            // buttonResult
            // 
            this.buttonResult.Location = new System.Drawing.Point(19, 112);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(197, 23);
            this.buttonResult.TabIndex = 4;
            this.buttonResult.TabStop = false;
            this.buttonResult.Text = "Result";
            this.buttonResult.UseVisualStyleBackColor = true;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // checkBoxCase
            // 
            this.checkBoxCase.AutoSize = true;
            this.checkBoxCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCase.Location = new System.Drawing.Point(19, 82);
            this.checkBoxCase.Name = "checkBoxCase";
            this.checkBoxCase.Size = new System.Drawing.Size(133, 24);
            this.checkBoxCase.TabIndex = 3;
            this.checkBoxCase.TabStop = false;
            this.checkBoxCase.Text = "Case Sensitive";
            this.checkBoxCase.UseVisualStyleBackColor = true;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxResult.Location = new System.Drawing.Point(19, 141);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(202, 166);
            this.textBoxResult.TabIndex = 2;
            this.textBoxResult.TabStop = false;
            // 
            // textBoxInput2
            // 
            this.textBoxInput2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInput2.Location = new System.Drawing.Point(19, 50);
            this.textBoxInput2.Name = "textBoxInput2";
            this.textBoxInput2.Size = new System.Drawing.Size(197, 26);
            this.textBoxInput2.TabIndex = 2;
            this.textBoxInput2.TabStop = false;
            // 
            // textBoxInput1
            // 
            this.textBoxInput1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInput1.Location = new System.Drawing.Point(19, 18);
            this.textBoxInput1.Name = "textBoxInput1";
            this.textBoxInput1.Size = new System.Drawing.Size(197, 26);
            this.textBoxInput1.TabIndex = 1;
            this.textBoxInput1.TabStop = false;
            // 
            // tabPageLoop
            // 
            this.tabPageLoop.Controls.Add(this.button1);
            this.tabPageLoop.Controls.Add(this.label3);
            this.tabPageLoop.Controls.Add(this.label2);
            this.tabPageLoop.Controls.Add(this.label1);
            this.tabPageLoop.Controls.Add(this.listBoxVab);
            this.tabPageLoop.Controls.Add(this.listBoxVb);
            this.tabPageLoop.Controls.Add(this.listBoxVa);
            this.tabPageLoop.Controls.Add(this.buttonStart);
            this.tabPageLoop.Controls.Add(this.buttonReadFile);
            this.tabPageLoop.Controls.Add(this.textBoxTextFile);
            this.tabPageLoop.Controls.Add(this.textBoxY);
            this.tabPageLoop.Controls.Add(this.labelY);
            this.tabPageLoop.Controls.Add(this.textBoxX);
            this.tabPageLoop.Controls.Add(this.labelX);
            this.tabPageLoop.Controls.Add(this.buttonAddXY);
            this.tabPageLoop.Controls.Add(this.chart1);
            this.tabPageLoop.Location = new System.Drawing.Point(4, 22);
            this.tabPageLoop.Name = "tabPageLoop";
            this.tabPageLoop.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLoop.Size = new System.Drawing.Size(954, 329);
            this.tabPageLoop.TabIndex = 1;
            this.tabPageLoop.Text = "Loop";
            this.tabPageLoop.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(191, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Vba: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Vb: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Va: ";
            // 
            // listBoxVab
            // 
            this.listBoxVab.FormattingEnabled = true;
            this.listBoxVab.Location = new System.Drawing.Point(231, 135);
            this.listBoxVab.Name = "listBoxVab";
            this.listBoxVab.Size = new System.Drawing.Size(51, 186);
            this.listBoxVab.TabIndex = 10;
            // 
            // listBoxVb
            // 
            this.listBoxVb.FormattingEnabled = true;
            this.listBoxVb.Location = new System.Drawing.Point(135, 135);
            this.listBoxVb.Name = "listBoxVb";
            this.listBoxVb.Size = new System.Drawing.Size(50, 186);
            this.listBoxVb.TabIndex = 9;
            // 
            // listBoxVa
            // 
            this.listBoxVa.FormattingEnabled = true;
            this.listBoxVa.Location = new System.Drawing.Point(50, 135);
            this.listBoxVa.Name = "listBoxVa";
            this.listBoxVa.Size = new System.Drawing.Size(50, 186);
            this.listBoxVa.TabIndex = 8;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(288, 135);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(100, 24);
            this.buttonStart.TabIndex = 7;
            this.buttonStart.Text = "Start Auto";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonReadFile
            // 
            this.buttonReadFile.Location = new System.Drawing.Point(288, 93);
            this.buttonReadFile.Name = "buttonReadFile";
            this.buttonReadFile.Size = new System.Drawing.Size(100, 23);
            this.buttonReadFile.TabIndex = 6;
            this.buttonReadFile.Text = "Read File";
            this.buttonReadFile.UseVisualStyleBackColor = true;
            this.buttonReadFile.Click += new System.EventHandler(this.buttonReadFile_Click);
            // 
            // textBoxTextFile
            // 
            this.textBoxTextFile.Location = new System.Drawing.Point(170, 33);
            this.textBoxTextFile.Multiline = true;
            this.textBoxTextFile.Name = "textBoxTextFile";
            this.textBoxTextFile.Size = new System.Drawing.Size(112, 83);
            this.textBoxTextFile.TabIndex = 5;
            // 
            // textBoxY
            // 
            this.textBoxY.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxY.Location = new System.Drawing.Point(48, 63);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(100, 24);
            this.textBoxY.TabIndex = 2;
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Enabled = false;
            this.labelY.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelY.Location = new System.Drawing.Point(24, 66);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(25, 18);
            this.labelY.TabIndex = 4;
            this.labelY.Text = "Y: ";
            // 
            // textBoxX
            // 
            this.textBoxX.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxX.Location = new System.Drawing.Point(48, 33);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(100, 24);
            this.textBoxX.TabIndex = 1;
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX.Location = new System.Drawing.Point(24, 36);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(26, 18);
            this.labelX.TabIndex = 2;
            this.labelX.Text = "X: ";
            // 
            // buttonAddXY
            // 
            this.buttonAddXY.Location = new System.Drawing.Point(48, 93);
            this.buttonAddXY.Name = "buttonAddXY";
            this.buttonAddXY.Size = new System.Drawing.Size(100, 23);
            this.buttonAddXY.TabIndex = 3;
            this.buttonAddXY.Text = "Add Point";
            this.buttonAddXY.UseVisualStyleBackColor = true;
            this.buttonAddXY.Click += new System.EventHandler(this.buttonAddXY_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            legend1.Title = "Test Legend";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(359, 9);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "SeriesVa";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "SeriesVb";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "SeriesVab";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(587, 315);
            this.chart1.TabIndex = 0;
            this.chart1.TabStop = false;
            this.chart1.Text = "chart1";
            // 
            // tabPageLis
            // 
            this.tabPageLis.Controls.Add(this.buttonRemove);
            this.tabPageLis.Controls.Add(this.buttonAdd);
            this.tabPageLis.Controls.Add(this.listBoxStuff);
            this.tabPageLis.Controls.Add(this.comboBoxRemove);
            this.tabPageLis.Controls.Add(this.textBoxAdd);
            this.tabPageLis.Controls.Add(this.menuStrip1);
            this.tabPageLis.Location = new System.Drawing.Point(4, 22);
            this.tabPageLis.Name = "tabPageLis";
            this.tabPageLis.Size = new System.Drawing.Size(954, 329);
            this.tabPageLis.TabIndex = 2;
            this.tabPageLis.Text = "List";
            this.tabPageLis.UseVisualStyleBackColor = true;
            this.tabPageLis.Click += new System.EventHandler(this.tabPageLis_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Image = global::SerialPortCom.Properties.Resources.RemoveSingleDriverTest_16x;
            this.buttonRemove.Location = new System.Drawing.Point(231, 69);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(30, 28);
            this.buttonRemove.TabIndex = 4;
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Image = global::SerialPortCom.Properties.Resources.AddVariable_16x;
            this.buttonAdd.Location = new System.Drawing.Point(231, 37);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(30, 26);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // listBoxStuff
            // 
            this.listBoxStuff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxStuff.FormattingEnabled = true;
            this.listBoxStuff.ItemHeight = 20;
            this.listBoxStuff.Items.AddRange(new object[] {
            "cat",
            "dog",
            "horse",
            "lama",
            "pig",
            "sheep"});
            this.listBoxStuff.Location = new System.Drawing.Point(283, 37);
            this.listBoxStuff.Name = "listBoxStuff";
            this.listBoxStuff.ScrollAlwaysVisible = true;
            this.listBoxStuff.Size = new System.Drawing.Size(224, 164);
            this.listBoxStuff.TabIndex = 2;
            this.listBoxStuff.TabStop = false;
            // 
            // comboBoxRemove
            // 
            this.comboBoxRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRemove.FormattingEnabled = true;
            this.comboBoxRemove.Location = new System.Drawing.Point(24, 69);
            this.comboBoxRemove.Name = "comboBoxRemove";
            this.comboBoxRemove.Size = new System.Drawing.Size(201, 28);
            this.comboBoxRemove.TabIndex = 3;
            this.comboBoxRemove.Enter += new System.EventHandler(this.comboBoxRemove_Enter);
            // 
            // textBoxAdd
            // 
            this.textBoxAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAdd.Location = new System.Drawing.Point(24, 37);
            this.textBoxAdd.Name = "textBoxAdd";
            this.textBoxAdd.Size = new System.Drawing.Size(201, 26);
            this.textBoxAdd.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(954, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tabPageSerial
            // 
            this.tabPageSerial.Controls.Add(this.textBoxSend);
            this.tabPageSerial.Controls.Add(this.buttonSend);
            this.tabPageSerial.Controls.Add(this.labelBaud);
            this.tabPageSerial.Controls.Add(this.labelPorts);
            this.tabPageSerial.Controls.Add(this.radioButtonConnected);
            this.tabPageSerial.Controls.Add(this.buttonReceive);
            this.tabPageSerial.Controls.Add(this.textBoxReceive);
            this.tabPageSerial.Controls.Add(this.buttonDisconnect);
            this.tabPageSerial.Controls.Add(this.buttonConnect);
            this.tabPageSerial.Controls.Add(this.comboBoxBaud);
            this.tabPageSerial.Controls.Add(this.comboBoxPorts);
            this.tabPageSerial.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPageSerial.Location = new System.Drawing.Point(4, 22);
            this.tabPageSerial.Name = "tabPageSerial";
            this.tabPageSerial.Size = new System.Drawing.Size(954, 329);
            this.tabPageSerial.TabIndex = 3;
            this.tabPageSerial.Text = "Serial";
            this.tabPageSerial.UseVisualStyleBackColor = true;
            // 
            // textBoxSend
            // 
            this.textBoxSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSend.Location = new System.Drawing.Point(419, 28);
            this.textBoxSend.Name = "textBoxSend";
            this.textBoxSend.Size = new System.Drawing.Size(250, 23);
            this.textBoxSend.TabIndex = 10;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(292, 28);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(121, 23);
            this.buttonSend.TabIndex = 9;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // labelBaud
            // 
            this.labelBaud.AutoSize = true;
            this.labelBaud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBaud.Location = new System.Drawing.Point(8, 64);
            this.labelBaud.Name = "labelBaud";
            this.labelBaud.Size = new System.Drawing.Size(90, 20);
            this.labelBaud.TabIndex = 8;
            this.labelBaud.Text = "Baud Rate:";
            // 
            // labelPorts
            // 
            this.labelPorts.AutoSize = true;
            this.labelPorts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPorts.Location = new System.Drawing.Point(8, 28);
            this.labelPorts.Name = "labelPorts";
            this.labelPorts.Size = new System.Drawing.Size(86, 20);
            this.labelPorts.TabIndex = 7;
            this.labelPorts.Text = "Com ports:";
            // 
            // radioButtonConnected
            // 
            this.radioButtonConnected.AutoSize = true;
            this.radioButtonConnected.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButtonConnected.Location = new System.Drawing.Point(236, 112);
            this.radioButtonConnected.Name = "radioButtonConnected";
            this.radioButtonConnected.Size = new System.Drawing.Size(14, 13);
            this.radioButtonConnected.TabIndex = 6;
            this.radioButtonConnected.TabStop = true;
            this.radioButtonConnected.UseVisualStyleBackColor = true;
            // 
            // buttonReceive
            // 
            this.buttonReceive.Location = new System.Drawing.Point(292, 64);
            this.buttonReceive.Name = "buttonReceive";
            this.buttonReceive.Size = new System.Drawing.Size(121, 23);
            this.buttonReceive.TabIndex = 5;
            this.buttonReceive.Text = "Receive";
            this.buttonReceive.UseVisualStyleBackColor = true;
            this.buttonReceive.Click += new System.EventHandler(this.buttonReceive_Click);
            // 
            // textBoxReceive
            // 
            this.textBoxReceive.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxReceive.Location = new System.Drawing.Point(419, 66);
            this.textBoxReceive.Multiline = true;
            this.textBoxReceive.Name = "textBoxReceive";
            this.textBoxReceive.ReadOnly = true;
            this.textBoxReceive.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxReceive.Size = new System.Drawing.Size(250, 156);
            this.textBoxReceive.TabIndex = 4;
            this.textBoxReceive.TabStop = false;
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Location = new System.Drawing.Point(100, 135);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(121, 22);
            this.buttonDisconnect.TabIndex = 3;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(100, 107);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(121, 23);
            this.buttonConnect.TabIndex = 2;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // comboBoxBaud
            // 
            this.comboBoxBaud.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBaud.FormattingEnabled = true;
            this.comboBoxBaud.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "19200",
            "38400"});
            this.comboBoxBaud.Location = new System.Drawing.Point(100, 63);
            this.comboBoxBaud.Name = "comboBoxBaud";
            this.comboBoxBaud.Size = new System.Drawing.Size(121, 24);
            this.comboBoxBaud.TabIndex = 1;
            // 
            // comboBoxPorts
            // 
            this.comboBoxPorts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPorts.FormattingEnabled = true;
            this.comboBoxPorts.Location = new System.Drawing.Point(100, 27);
            this.comboBoxPorts.Name = "comboBoxPorts";
            this.comboBoxPorts.Size = new System.Drawing.Size(121, 24);
            this.comboBoxPorts.Sorted = true;
            this.comboBoxPorts.TabIndex = 0;
            this.comboBoxPorts.Enter += new System.EventHandler(this.comboBoxPorts_Enter);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timerSerialReceive
            // 
            this.timerSerialReceive.Tick += new System.EventHandler(this.timerSerialReceive_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            this.openFileDialog1.FilterIndex = 2;
            // 
            // printDialog1
            // 
            this.printDialog1.AllowCurrentPage = true;
            this.printDialog1.AllowSelection = true;
            this.printDialog1.AllowSomePages = true;
            this.printDialog1.UseEXDialog = true;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.FileName = "SerialConfiguration";
            this.saveFileDialog1.InitialDirectory = "C:\\tmp";
            this.saveFileDialog1.OverwritePrompt = false;
            // 
            // timerChartAdd
            // 
            this.timerChartAdd.Interval = 10;
            this.timerChartAdd.Tick += new System.EventHandler(this.timerChartAdd_Tick);
            // 
            // saveFileDialogConfig
            // 
            this.saveFileDialogConfig.DefaultExt = "ccs";
            this.saveFileDialogConfig.FileName = "Instrumentconfig";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(288, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveFileDialogCSV
            // 
            this.saveFileDialogCSV.DefaultExt = "csv";
            this.saveFileDialogCSV.FileName = "measuredpoints";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 355);
            this.Controls.Add(this.tabControlMain);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serial Port Communication";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageString.ResumeLayout(false);
            this.tabPageString.PerformLayout();
            this.tabPageLoop.ResumeLayout(false);
            this.tabPageLoop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPageLis.ResumeLayout(false);
            this.tabPageLis.PerformLayout();
            this.tabPageSerial.ResumeLayout(false);
            this.tabPageSerial.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageString;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.CheckBox checkBoxCase;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.TextBox textBoxInput2;
        private System.Windows.Forms.TextBox textBoxInput1;
        private System.Windows.Forms.TabPage tabPageLoop;
        private System.Windows.Forms.TabPage tabPageLis;
        private System.Windows.Forms.TabPage tabPageSerial;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListBox listBoxStuff;
        private System.Windows.Forms.ComboBox comboBoxRemove;
        private System.Windows.Forms.TextBox textBoxAdd;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button buttonReceive;
        private System.Windows.Forms.TextBox textBoxReceive;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.ComboBox comboBoxBaud;
        private System.Windows.Forms.ComboBox comboBoxPorts;
        private System.Windows.Forms.RadioButton radioButtonConnected;
        private System.Windows.Forms.TextBox textBoxSend;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label labelBaud;
        private System.Windows.Forms.Label labelPorts;
        private System.Windows.Forms.Timer timerSerialReceive;
        private System.Windows.Forms.Button buttonShowForm;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button buttonMessageBox;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Button buttonAddXY;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button buttonReadFile;
        private System.Windows.Forms.TextBox textBoxTextFile;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Timer timerChartAdd;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxVab;
        private System.Windows.Forms.ListBox listBoxVb;
        private System.Windows.Forms.ListBox listBoxVa;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.Button buttonSaveFile;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textBoxAH;
        private System.Windows.Forms.Label labelAH;
        private System.Windows.Forms.TextBox textBoxAL;
        private System.Windows.Forms.Label labelAL;
        private System.Windows.Forms.TextBox textBoxURV;
        private System.Windows.Forms.Label labelURV;
        private System.Windows.Forms.TextBox textBoxLRV;
        private System.Windows.Forms.Label labelLRV;
        private System.Windows.Forms.TextBox textBoxTagname;
        private System.Windows.Forms.Label labelTagname;
        private System.Windows.Forms.SaveFileDialog saveFileDialogConfig;
        private System.Windows.Forms.Button buttonSendSerial;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog saveFileDialogCSV;
    }
}

