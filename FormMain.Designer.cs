
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
            System.Windows.Forms.Label locationIDLabel;
            System.Windows.Forms.Label manufacturerIDLabel;
            System.Windows.Forms.Label rDCIDLabel;
            System.Windows.Forms.Label configUpdateDateLabel;
            System.Windows.Forms.Label installationDateLabel;
            System.Windows.Forms.Label cOMPortLabel;
            System.Windows.Forms.Label baudRateLabel;
            System.Windows.Forms.Label deviceNameLabel;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label dAUIDLabel;
            System.Windows.Forms.Label deviceNameLabel1;
            System.Windows.Forms.Label baudRateLabel1;
            System.Windows.Forms.Label cOMPortLabel1;
            System.Windows.Forms.Label installationDateLabel1;
            System.Windows.Forms.Label configUpdateDateLabel1;
            System.Windows.Forms.Label rDCIDLabel1;
            System.Windows.Forms.Label manufacturerIDLabel1;
            System.Windows.Forms.Label locationIDLabel1;
            System.Windows.Forms.Label tagnameLabel;
            System.Windows.Forms.Label tagDescriptionLabel;
            System.Windows.Forms.Label lowerRangeValueLabel;
            System.Windows.Forms.Label upperRangeValueLabel;
            System.Windows.Forms.Label alarmLowLabel;
            System.Windows.Forms.Label alarmHighLabel;
            System.Windows.Forms.Label dAUIDLabel1;
            System.Windows.Forms.Label channelLabel;
            System.Windows.Forms.Label manufacturerIDLabel2;
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataAcqusitionUnitsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.softSensDBDataSet1 = new SerialPortCom.SoftSensDBDataSet1();
            this.locationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manufacturersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.remoteDataCollectorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timerSerialReceive = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.timerChartAdd = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialogConfig = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialogCSV = new System.Windows.Forms.SaveFileDialog();
            this.tabPageLis = new System.Windows.Forms.TabPage();
            this.buttonResult = new System.Windows.Forms.Button();
            this.checkBoxCase = new System.Windows.Forms.CheckBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.textBoxInput2 = new System.Windows.Forms.TextBox();
            this.textBoxInput1 = new System.Windows.Forms.TextBox();
            this.textBoxTextFile = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxAdd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxVab = new System.Windows.Forms.ListBox();
            this.listBoxVb = new System.Windows.Forms.ListBox();
            this.listBoxVa = new System.Windows.Forms.ListBox();
            this.labelY = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.buttonAddXY = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listBoxStuff = new System.Windows.Forms.ListBox();
            this.comboBoxRemove = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tabPageLoop = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonReadFile = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPageString = new System.Windows.Forms.TabPage();
            this.comboBoxInstrumentFind = new System.Windows.Forms.ComboBox();
            this.tagnameTextBox = new System.Windows.Forms.TextBox();
            this.instrumentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.softSensDBDataSet = new SerialPortCom.SoftSensDBDataSet();
            this.tagDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.lowerRangeValueTextBox = new System.Windows.Forms.TextBox();
            this.upperRangeValueTextBox = new System.Windows.Forms.TextBox();
            this.alarmLowTextBox = new System.Windows.Forms.TextBox();
            this.alarmHighTextBox = new System.Windows.Forms.TextBox();
            this.dAUIDTextBox = new System.Windows.Forms.TextBox();
            this.channelTextBox = new System.Windows.Forms.TextBox();
            this.manufacturerIDTextBox = new System.Windows.Forms.TextBox();
            this.buttonSendSerial = new System.Windows.Forms.Button();
            this.buttonRead = new System.Windows.Forms.Button();
            this.buttonSaveFile = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBoxAH = new System.Windows.Forms.TextBox();
            this.textBoxAL = new System.Windows.Forms.TextBox();
            this.textBoxURV = new System.Windows.Forms.TextBox();
            this.textBoxLRV = new System.Windows.Forms.TextBox();
            this.textBoxTagname = new System.Windows.Forms.TextBox();
            this.labelAH = new System.Windows.Forms.Label();
            this.labelAL = new System.Windows.Forms.Label();
            this.labelURV = new System.Windows.Forms.Label();
            this.labelLRV = new System.Windows.Forms.Label();
            this.labelTagname = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonMessageBox = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.buttonShowForm = new System.Windows.Forms.Button();
            this.instrumentsToComboBoxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageDAU = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxSend = new System.Windows.Forms.TextBox();
            this.textBoxReceive = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.buttonReceive = new System.Windows.Forms.Button();
            this.labelBaud = new System.Windows.Forms.Label();
            this.labelPorts = new System.Windows.Forms.Label();
            this.radioButtonConnected = new System.Windows.Forms.RadioButton();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.comboBoxBaud = new System.Windows.Forms.ComboBox();
            this.comboBoxPorts = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonBaud = new System.Windows.Forms.Button();
            this.comboBoxLocation = new System.Windows.Forms.ComboBox();
            this.dataAcqusitionUnitsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxCompany = new System.Windows.Forms.ComboBox();
            this.comboBoxDeviceFind = new System.Windows.Forms.ComboBox();
            this.rDCIDcomboBox = new System.Windows.Forms.ComboBox();
            this.remoteDataCollectorsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.buttonRegister = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.deviceNameTextBox = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.baudRateTextBox = new System.Windows.Forms.TextBox();
            this.cOMPortTextBox = new System.Windows.Forms.TextBox();
            this.installationDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.configUpdateDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageDatabase = new System.Windows.Forms.TabPage();
            this.buttonDAUCancel = new System.Windows.Forms.Button();
            this.buttonDAUNew = new System.Windows.Forms.Button();
            this.buttonDAUSave = new System.Windows.Forms.Button();
            this.buttonDAUChange = new System.Windows.Forms.Button();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.locationsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.manufacturersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.remoteDataCollectorsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.softSensDBDataSet2 = new SerialPortCom.SoftSensDBDataSet();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.deviceNameTextBox1 = new System.Windows.Forms.TextBox();
            this.baudRateTextBox1 = new System.Windows.Forms.TextBox();
            this.cOMPortTextBox1 = new System.Windows.Forms.TextBox();
            this.installationDateDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.configUpdateDateDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataAcqusitionUnitsTableAdapter = new SerialPortCom.SoftSensDBDataSetTableAdapters.DataAcqusitionUnitsTableAdapter();
            this.remoteDataCollectorsTableAdapter = new SerialPortCom.SoftSensDBDataSetTableAdapters.RemoteDataCollectorsTableAdapter();
            this.manufacturersTableAdapter = new SerialPortCom.SoftSensDBDataSetTableAdapters.ManufacturersTableAdapter();
            this.locationsTableAdapter = new SerialPortCom.SoftSensDBDataSetTableAdapters.LocationsTableAdapter();
            this.tableAdapterManager = new SerialPortCom.SoftSensDBDataSetTableAdapters.TableAdapterManager();
            this.dataAcqusitionUnits1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataAcqusitionUnits1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataAcqusitionUnits1BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataAcqusitionUnits1BindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dataAcqusitionUnits1TableAdapter = new SerialPortCom.SoftSensDBDataSetTableAdapters.DataAcqusitionUnits1TableAdapter();
            this.instrumentsTableAdapter = new SerialPortCom.SoftSensDBDataSetTableAdapters.InstrumentsTableAdapter();
            this.instrumentsToComboBoxTableAdapter = new SerialPortCom.SoftSensDBDataSetTableAdapters.InstrumentsToComboBoxTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            locationIDLabel = new System.Windows.Forms.Label();
            manufacturerIDLabel = new System.Windows.Forms.Label();
            rDCIDLabel = new System.Windows.Forms.Label();
            configUpdateDateLabel = new System.Windows.Forms.Label();
            installationDateLabel = new System.Windows.Forms.Label();
            cOMPortLabel = new System.Windows.Forms.Label();
            baudRateLabel = new System.Windows.Forms.Label();
            deviceNameLabel = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            dAUIDLabel = new System.Windows.Forms.Label();
            deviceNameLabel1 = new System.Windows.Forms.Label();
            baudRateLabel1 = new System.Windows.Forms.Label();
            cOMPortLabel1 = new System.Windows.Forms.Label();
            installationDateLabel1 = new System.Windows.Forms.Label();
            configUpdateDateLabel1 = new System.Windows.Forms.Label();
            rDCIDLabel1 = new System.Windows.Forms.Label();
            manufacturerIDLabel1 = new System.Windows.Forms.Label();
            locationIDLabel1 = new System.Windows.Forms.Label();
            tagnameLabel = new System.Windows.Forms.Label();
            tagDescriptionLabel = new System.Windows.Forms.Label();
            lowerRangeValueLabel = new System.Windows.Forms.Label();
            upperRangeValueLabel = new System.Windows.Forms.Label();
            alarmLowLabel = new System.Windows.Forms.Label();
            alarmHighLabel = new System.Windows.Forms.Label();
            dAUIDLabel1 = new System.Windows.Forms.Label();
            channelLabel = new System.Windows.Forms.Label();
            manufacturerIDLabel2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataAcqusitionUnitsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.softSensDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remoteDataCollectorsBindingSource)).BeginInit();
            this.tabPageLis.SuspendLayout();
            this.tabPageLoop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPageString.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.softSensDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentsToComboBoxBindingSource)).BeginInit();
            this.tabPageDAU.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataAcqusitionUnitsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remoteDataCollectorsBindingSource1)).BeginInit();
            this.tabControlMain.SuspendLayout();
            this.tabPageDatabase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locationsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remoteDataCollectorsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.softSensDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataAcqusitionUnits1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataAcqusitionUnits1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataAcqusitionUnits1BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataAcqusitionUnits1BindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // locationIDLabel
            // 
            locationIDLabel.AutoSize = true;
            locationIDLabel.Location = new System.Drawing.Point(41, 300);
            locationIDLabel.Name = "locationIDLabel";
            locationIDLabel.Size = new System.Drawing.Size(66, 17);
            locationIDLabel.TabIndex = 52;
            locationIDLabel.Text = "Location:";
            // 
            // manufacturerIDLabel
            // 
            manufacturerIDLabel.AutoSize = true;
            manufacturerIDLabel.Location = new System.Drawing.Point(41, 275);
            manufacturerIDLabel.Name = "manufacturerIDLabel";
            manufacturerIDLabel.Size = new System.Drawing.Size(96, 17);
            manufacturerIDLabel.TabIndex = 50;
            manufacturerIDLabel.Text = "Manufacturer:";
            // 
            // rDCIDLabel
            // 
            rDCIDLabel.AutoSize = true;
            rDCIDLabel.Location = new System.Drawing.Point(41, 249);
            rDCIDLabel.Name = "rDCIDLabel";
            rDCIDLabel.Size = new System.Drawing.Size(41, 17);
            rDCIDLabel.TabIndex = 49;
            rDCIDLabel.Text = "RDC:";
            // 
            // configUpdateDateLabel
            // 
            configUpdateDateLabel.AutoSize = true;
            configUpdateDateLabel.Location = new System.Drawing.Point(41, 224);
            configUpdateDateLabel.Name = "configUpdateDateLabel";
            configUpdateDateLabel.Size = new System.Drawing.Size(136, 17);
            configUpdateDateLabel.TabIndex = 47;
            configUpdateDateLabel.Text = "Config Update Date:";
            configUpdateDateLabel.Visible = false;
            // 
            // installationDateLabel
            // 
            installationDateLabel.AutoSize = true;
            installationDateLabel.Location = new System.Drawing.Point(41, 199);
            installationDateLabel.Name = "installationDateLabel";
            installationDateLabel.Size = new System.Drawing.Size(113, 17);
            installationDateLabel.TabIndex = 45;
            installationDateLabel.Text = "Installation Date:";
            // 
            // cOMPortLabel
            // 
            cOMPortLabel.AutoSize = true;
            cOMPortLabel.Location = new System.Drawing.Point(41, 172);
            cOMPortLabel.Name = "cOMPortLabel";
            cOMPortLabel.Size = new System.Drawing.Size(69, 17);
            cOMPortLabel.TabIndex = 43;
            cOMPortLabel.Text = "COMPort:";
            // 
            // baudRateLabel
            // 
            baudRateLabel.AutoSize = true;
            baudRateLabel.Location = new System.Drawing.Point(41, 147);
            baudRateLabel.Name = "baudRateLabel";
            baudRateLabel.Size = new System.Drawing.Size(79, 17);
            baudRateLabel.TabIndex = 41;
            baudRateLabel.Text = "Baud Rate:";
            // 
            // deviceNameLabel
            // 
            deviceNameLabel.AutoSize = true;
            deviceNameLabel.Location = new System.Drawing.Point(42, 24);
            deviceNameLabel.Name = "deviceNameLabel";
            deviceNameLabel.Size = new System.Drawing.Size(86, 17);
            deviceNameLabel.TabIndex = 39;
            deviceNameLabel.Text = "Find Device:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(41, 121);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(96, 17);
            label7.TabIndex = 56;
            label7.Text = "Device Name:";
            // 
            // dAUIDLabel
            // 
            dAUIDLabel.AutoSize = true;
            dAUIDLabel.Location = new System.Drawing.Point(39, 66);
            dAUIDLabel.Name = "dAUIDLabel";
            dAUIDLabel.Size = new System.Drawing.Size(86, 17);
            dAUIDLabel.TabIndex = 0;
            dAUIDLabel.Text = "Find Device:";
            // 
            // deviceNameLabel1
            // 
            deviceNameLabel1.AutoSize = true;
            deviceNameLabel1.Location = new System.Drawing.Point(39, 159);
            deviceNameLabel1.Name = "deviceNameLabel1";
            deviceNameLabel1.Size = new System.Drawing.Size(96, 17);
            deviceNameLabel1.TabIndex = 2;
            deviceNameLabel1.Text = "Device Name:";
            // 
            // baudRateLabel1
            // 
            baudRateLabel1.AutoSize = true;
            baudRateLabel1.Location = new System.Drawing.Point(39, 187);
            baudRateLabel1.Name = "baudRateLabel1";
            baudRateLabel1.Size = new System.Drawing.Size(79, 17);
            baudRateLabel1.TabIndex = 4;
            baudRateLabel1.Text = "Baud Rate:";
            // 
            // cOMPortLabel1
            // 
            cOMPortLabel1.AutoSize = true;
            cOMPortLabel1.Location = new System.Drawing.Point(39, 215);
            cOMPortLabel1.Name = "cOMPortLabel1";
            cOMPortLabel1.Size = new System.Drawing.Size(69, 17);
            cOMPortLabel1.TabIndex = 6;
            cOMPortLabel1.Text = "COMPort:";
            // 
            // installationDateLabel1
            // 
            installationDateLabel1.AutoSize = true;
            installationDateLabel1.Location = new System.Drawing.Point(39, 244);
            installationDateLabel1.Name = "installationDateLabel1";
            installationDateLabel1.Size = new System.Drawing.Size(113, 17);
            installationDateLabel1.TabIndex = 8;
            installationDateLabel1.Text = "Installation Date:";
            // 
            // configUpdateDateLabel1
            // 
            configUpdateDateLabel1.AutoSize = true;
            configUpdateDateLabel1.Location = new System.Drawing.Point(39, 272);
            configUpdateDateLabel1.Name = "configUpdateDateLabel1";
            configUpdateDateLabel1.Size = new System.Drawing.Size(136, 17);
            configUpdateDateLabel1.TabIndex = 10;
            configUpdateDateLabel1.Text = "Config Update Date:";
            // 
            // rDCIDLabel1
            // 
            rDCIDLabel1.AutoSize = true;
            rDCIDLabel1.Location = new System.Drawing.Point(39, 299);
            rDCIDLabel1.Name = "rDCIDLabel1";
            rDCIDLabel1.Size = new System.Drawing.Size(54, 17);
            rDCIDLabel1.TabIndex = 12;
            rDCIDLabel1.Text = "RDCID:";
            // 
            // manufacturerIDLabel1
            // 
            manufacturerIDLabel1.AutoSize = true;
            manufacturerIDLabel1.Location = new System.Drawing.Point(39, 327);
            manufacturerIDLabel1.Name = "manufacturerIDLabel1";
            manufacturerIDLabel1.Size = new System.Drawing.Size(113, 17);
            manufacturerIDLabel1.TabIndex = 14;
            manufacturerIDLabel1.Text = "Manufacturer ID:";
            // 
            // locationIDLabel1
            // 
            locationIDLabel1.AutoSize = true;
            locationIDLabel1.Location = new System.Drawing.Point(39, 355);
            locationIDLabel1.Name = "locationIDLabel1";
            locationIDLabel1.Size = new System.Drawing.Size(83, 17);
            locationIDLabel1.TabIndex = 16;
            locationIDLabel1.Text = "Location ID:";
            // 
            // tagnameLabel
            // 
            tagnameLabel.AutoSize = true;
            tagnameLabel.Location = new System.Drawing.Point(23, 131);
            tagnameLabel.Name = "tagnameLabel";
            tagnameLabel.Size = new System.Drawing.Size(72, 17);
            tagnameLabel.TabIndex = 20;
            tagnameLabel.Text = "Tagname:";
            // 
            // tagDescriptionLabel
            // 
            tagDescriptionLabel.AutoSize = true;
            tagDescriptionLabel.Location = new System.Drawing.Point(23, 159);
            tagDescriptionLabel.Name = "tagDescriptionLabel";
            tagDescriptionLabel.Size = new System.Drawing.Size(112, 17);
            tagDescriptionLabel.TabIndex = 22;
            tagDescriptionLabel.Text = "Tag Description:";
            // 
            // lowerRangeValueLabel
            // 
            lowerRangeValueLabel.AutoSize = true;
            lowerRangeValueLabel.Location = new System.Drawing.Point(23, 187);
            lowerRangeValueLabel.Name = "lowerRangeValueLabel";
            lowerRangeValueLabel.Size = new System.Drawing.Size(136, 17);
            lowerRangeValueLabel.TabIndex = 24;
            lowerRangeValueLabel.Text = "Lower Range Value:";
            // 
            // upperRangeValueLabel
            // 
            upperRangeValueLabel.AutoSize = true;
            upperRangeValueLabel.Location = new System.Drawing.Point(23, 215);
            upperRangeValueLabel.Name = "upperRangeValueLabel";
            upperRangeValueLabel.Size = new System.Drawing.Size(137, 17);
            upperRangeValueLabel.TabIndex = 26;
            upperRangeValueLabel.Text = "Upper Range Value:";
            // 
            // alarmLowLabel
            // 
            alarmLowLabel.AutoSize = true;
            alarmLowLabel.Location = new System.Drawing.Point(23, 243);
            alarmLowLabel.Name = "alarmLowLabel";
            alarmLowLabel.Size = new System.Drawing.Size(77, 17);
            alarmLowLabel.TabIndex = 28;
            alarmLowLabel.Text = "Alarm Low:";
            // 
            // alarmHighLabel
            // 
            alarmHighLabel.AutoSize = true;
            alarmHighLabel.Location = new System.Drawing.Point(23, 271);
            alarmHighLabel.Name = "alarmHighLabel";
            alarmHighLabel.Size = new System.Drawing.Size(81, 17);
            alarmHighLabel.TabIndex = 30;
            alarmHighLabel.Text = "Alarm High:";
            // 
            // dAUIDLabel1
            // 
            dAUIDLabel1.AutoSize = true;
            dAUIDLabel1.Location = new System.Drawing.Point(23, 299);
            dAUIDLabel1.Name = "dAUIDLabel1";
            dAUIDLabel1.Size = new System.Drawing.Size(54, 17);
            dAUIDLabel1.TabIndex = 32;
            dAUIDLabel1.Text = "DAUID:";
            // 
            // channelLabel
            // 
            channelLabel.AutoSize = true;
            channelLabel.Location = new System.Drawing.Point(23, 327);
            channelLabel.Name = "channelLabel";
            channelLabel.Size = new System.Drawing.Size(64, 17);
            channelLabel.TabIndex = 34;
            channelLabel.Text = "Channel:";
            // 
            // manufacturerIDLabel2
            // 
            manufacturerIDLabel2.AutoSize = true;
            manufacturerIDLabel2.Location = new System.Drawing.Point(23, 355);
            manufacturerIDLabel2.Name = "manufacturerIDLabel2";
            manufacturerIDLabel2.Size = new System.Drawing.Size(113, 17);
            manufacturerIDLabel2.TabIndex = 36;
            manufacturerIDLabel2.Text = "Manufacturer ID:";
            // 
            // dataAcqusitionUnitsBindingSource
            // 
            this.dataAcqusitionUnitsBindingSource.DataMember = "DataAcqusitionUnits";
            this.dataAcqusitionUnitsBindingSource.DataSource = this.bindingSource1;
            // 
            // bindingSource1
            // 
            this.bindingSource1.AllowNew = true;
            this.bindingSource1.DataSource = this.softSensDBDataSet1;
            this.bindingSource1.Position = 0;
            // 
            // softSensDBDataSet1
            // 
            this.softSensDBDataSet1.DataSetName = "SoftSensDBDataSet1";
            this.softSensDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // locationsBindingSource
            // 
            this.locationsBindingSource.DataMember = "Locations";
            this.locationsBindingSource.DataSource = this.bindingSource1;
            // 
            // manufacturersBindingSource
            // 
            this.manufacturersBindingSource.DataMember = "Manufacturers";
            this.manufacturersBindingSource.DataSource = this.bindingSource1;
            // 
            // remoteDataCollectorsBindingSource
            // 
            this.remoteDataCollectorsBindingSource.DataMember = "RemoteDataCollectors";
            this.remoteDataCollectorsBindingSource.DataSource = this.bindingSource1;
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
            // saveFileDialogCSV
            // 
            this.saveFileDialogCSV.DefaultExt = "csv";
            this.saveFileDialogCSV.FileName = "measuredpoints";
            // 
            // tabPageLis
            // 
            this.tabPageLis.Controls.Add(this.buttonResult);
            this.tabPageLis.Controls.Add(this.checkBoxCase);
            this.tabPageLis.Controls.Add(this.textBoxResult);
            this.tabPageLis.Controls.Add(this.textBoxInput2);
            this.tabPageLis.Controls.Add(this.textBoxInput1);
            this.tabPageLis.Controls.Add(this.textBoxTextFile);
            this.tabPageLis.Controls.Add(this.textBoxY);
            this.tabPageLis.Controls.Add(this.textBoxX);
            this.tabPageLis.Controls.Add(this.textBoxAdd);
            this.tabPageLis.Controls.Add(this.label3);
            this.tabPageLis.Controls.Add(this.label2);
            this.tabPageLis.Controls.Add(this.label1);
            this.tabPageLis.Controls.Add(this.listBoxVab);
            this.tabPageLis.Controls.Add(this.listBoxVb);
            this.tabPageLis.Controls.Add(this.listBoxVa);
            this.tabPageLis.Controls.Add(this.labelY);
            this.tabPageLis.Controls.Add(this.labelX);
            this.tabPageLis.Controls.Add(this.buttonAddXY);
            this.tabPageLis.Controls.Add(this.buttonRemove);
            this.tabPageLis.Controls.Add(this.buttonAdd);
            this.tabPageLis.Controls.Add(this.listBoxStuff);
            this.tabPageLis.Controls.Add(this.comboBoxRemove);
            this.tabPageLis.Controls.Add(this.menuStrip1);
            this.tabPageLis.Location = new System.Drawing.Point(4, 25);
            this.tabPageLis.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageLis.Name = "tabPageLis";
            this.tabPageLis.Size = new System.Drawing.Size(1084, 400);
            this.tabPageLis.TabIndex = 2;
            this.tabPageLis.Text = "List";
            this.tabPageLis.UseVisualStyleBackColor = true;
            this.tabPageLis.Click += new System.EventHandler(this.tabPageLis_Click);
            // 
            // buttonResult
            // 
            this.buttonResult.Location = new System.Drawing.Point(777, 138);
            this.buttonResult.Margin = new System.Windows.Forms.Padding(4);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(263, 28);
            this.buttonResult.TabIndex = 30;
            this.buttonResult.TabStop = false;
            this.buttonResult.Text = "Result";
            this.buttonResult.UseVisualStyleBackColor = true;
            // 
            // checkBoxCase
            // 
            this.checkBoxCase.AutoSize = true;
            this.checkBoxCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCase.Location = new System.Drawing.Point(777, 101);
            this.checkBoxCase.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxCase.Name = "checkBoxCase";
            this.checkBoxCase.Size = new System.Drawing.Size(166, 29);
            this.checkBoxCase.TabIndex = 29;
            this.checkBoxCase.TabStop = false;
            this.checkBoxCase.Text = "Case Sensitive";
            this.checkBoxCase.UseVisualStyleBackColor = true;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxResult.Location = new System.Drawing.Point(777, 174);
            this.textBoxResult.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(268, 203);
            this.textBoxResult.TabIndex = 27;
            this.textBoxResult.TabStop = false;
            // 
            // textBoxInput2
            // 
            this.textBoxInput2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInput2.Location = new System.Drawing.Point(777, 62);
            this.textBoxInput2.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxInput2.Name = "textBoxInput2";
            this.textBoxInput2.Size = new System.Drawing.Size(262, 30);
            this.textBoxInput2.TabIndex = 28;
            this.textBoxInput2.TabStop = false;
            // 
            // textBoxInput1
            // 
            this.textBoxInput1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInput1.Location = new System.Drawing.Point(777, 22);
            this.textBoxInput1.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxInput1.Name = "textBoxInput1";
            this.textBoxInput1.Size = new System.Drawing.Size(262, 30);
            this.textBoxInput1.TabIndex = 26;
            this.textBoxInput1.TabStop = false;
            // 
            // textBoxTextFile
            // 
            this.textBoxTextFile.Location = new System.Drawing.Point(610, 23);
            this.textBoxTextFile.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTextFile.Multiline = true;
            this.textBoxTextFile.Name = "textBoxTextFile";
            this.textBoxTextFile.Size = new System.Drawing.Size(148, 102);
            this.textBoxTextFile.TabIndex = 19;
            // 
            // textBoxY
            // 
            this.textBoxY.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxY.Location = new System.Drawing.Point(447, 60);
            this.textBoxY.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(132, 28);
            this.textBoxY.TabIndex = 15;
            // 
            // textBoxX
            // 
            this.textBoxX.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxX.Location = new System.Drawing.Point(447, 23);
            this.textBoxX.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(132, 28);
            this.textBoxX.TabIndex = 14;
            // 
            // textBoxAdd
            // 
            this.textBoxAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAdd.Location = new System.Drawing.Point(32, 46);
            this.textBoxAdd.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAdd.Name = "textBoxAdd";
            this.textBoxAdd.Size = new System.Drawing.Size(267, 30);
            this.textBoxAdd.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(637, 149);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 24);
            this.label3.TabIndex = 25;
            this.label3.Text = "Vba: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(519, 149);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 24);
            this.label2.TabIndex = 24;
            this.label2.Text = "Vb: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(404, 149);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "Va: ";
            // 
            // listBoxVab
            // 
            this.listBoxVab.FormattingEnabled = true;
            this.listBoxVab.ItemHeight = 16;
            this.listBoxVab.Location = new System.Drawing.Point(691, 149);
            this.listBoxVab.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxVab.Name = "listBoxVab";
            this.listBoxVab.Size = new System.Drawing.Size(66, 228);
            this.listBoxVab.TabIndex = 22;
            // 
            // listBoxVb
            // 
            this.listBoxVb.FormattingEnabled = true;
            this.listBoxVb.ItemHeight = 16;
            this.listBoxVb.Location = new System.Drawing.Point(563, 149);
            this.listBoxVb.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxVb.Name = "listBoxVb";
            this.listBoxVb.Size = new System.Drawing.Size(65, 228);
            this.listBoxVb.TabIndex = 21;
            // 
            // listBoxVa
            // 
            this.listBoxVa.FormattingEnabled = true;
            this.listBoxVa.ItemHeight = 16;
            this.listBoxVa.Location = new System.Drawing.Point(450, 149);
            this.listBoxVa.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxVa.Name = "listBoxVa";
            this.listBoxVa.Size = new System.Drawing.Size(65, 228);
            this.listBoxVa.TabIndex = 20;
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Enabled = false;
            this.labelY.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelY.Location = new System.Drawing.Point(415, 64);
            this.labelY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(32, 24);
            this.labelY.TabIndex = 18;
            this.labelY.Text = "Y: ";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX.Location = new System.Drawing.Point(415, 26);
            this.labelX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(34, 24);
            this.labelX.TabIndex = 16;
            this.labelX.Text = "X: ";
            // 
            // buttonAddXY
            // 
            this.buttonAddXY.Location = new System.Drawing.Point(447, 97);
            this.buttonAddXY.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddXY.Name = "buttonAddXY";
            this.buttonAddXY.Size = new System.Drawing.Size(133, 28);
            this.buttonAddXY.TabIndex = 17;
            this.buttonAddXY.Text = "Add Point";
            this.buttonAddXY.UseVisualStyleBackColor = true;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Image = global::SerialPortCom.Properties.Resources.RemoveSingleDriverTest_16x;
            this.buttonRemove.Location = new System.Drawing.Point(308, 85);
            this.buttonRemove.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(40, 34);
            this.buttonRemove.TabIndex = 4;
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Image = global::SerialPortCom.Properties.Resources.AddVariable_16x;
            this.buttonAdd.Location = new System.Drawing.Point(308, 46);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(40, 32);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // listBoxStuff
            // 
            this.listBoxStuff.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBoxStuff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxStuff.FormattingEnabled = true;
            this.listBoxStuff.ItemHeight = 25;
            this.listBoxStuff.Items.AddRange(new object[] {
            "cat",
            "dog",
            "horse",
            "lama",
            "pig",
            "sheep"});
            this.listBoxStuff.Location = new System.Drawing.Point(30, 74);
            this.listBoxStuff.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxStuff.Name = "listBoxStuff";
            this.listBoxStuff.ScrollAlwaysVisible = true;
            this.listBoxStuff.Size = new System.Drawing.Size(297, 179);
            this.listBoxStuff.TabIndex = 2;
            this.listBoxStuff.TabStop = false;
            // 
            // comboBoxRemove
            // 
            this.comboBoxRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRemove.FormattingEnabled = true;
            this.comboBoxRemove.Location = new System.Drawing.Point(32, 90);
            this.comboBoxRemove.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxRemove.Name = "comboBoxRemove";
            this.comboBoxRemove.Size = new System.Drawing.Size(267, 33);
            this.comboBoxRemove.TabIndex = 3;
            this.comboBoxRemove.Enter += new System.EventHandler(this.comboBoxRemove_Enter);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1084, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tabPageLoop
            // 
            this.tabPageLoop.Controls.Add(this.button1);
            this.tabPageLoop.Controls.Add(this.buttonStart);
            this.tabPageLoop.Controls.Add(this.buttonReadFile);
            this.tabPageLoop.Controls.Add(this.chart1);
            this.tabPageLoop.Location = new System.Drawing.Point(4, 25);
            this.tabPageLoop.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageLoop.Name = "tabPageLoop";
            this.tabPageLoop.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageLoop.Size = new System.Drawing.Size(1084, 400);
            this.tabPageLoop.TabIndex = 1;
            this.tabPageLoop.Text = "Loop";
            this.tabPageLoop.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 85);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 28);
            this.button1.TabIndex = 14;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(8, 47);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(133, 30);
            this.buttonStart.TabIndex = 7;
            this.buttonStart.Text = "Start Auto";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonReadFile
            // 
            this.buttonReadFile.Location = new System.Drawing.Point(13, 333);
            this.buttonReadFile.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReadFile.Name = "buttonReadFile";
            this.buttonReadFile.Size = new System.Drawing.Size(133, 35);
            this.buttonReadFile.TabIndex = 6;
            this.buttonReadFile.Text = "Read File";
            this.buttonReadFile.UseVisualStyleBackColor = true;
            this.buttonReadFile.Click += new System.EventHandler(this.buttonReadFile_Click);
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            legend3.Title = "Test Legend";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(177, 8);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.Name = "SeriesVa";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend1";
            series8.Name = "SeriesVb";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Legend = "Legend1";
            series9.Name = "SeriesVab";
            this.chart1.Series.Add(series7);
            this.chart1.Series.Add(series8);
            this.chart1.Series.Add(series9);
            this.chart1.Size = new System.Drawing.Size(864, 388);
            this.chart1.TabIndex = 0;
            this.chart1.TabStop = false;
            this.chart1.Text = "chart1";
            // 
            // tabPageString
            // 
            this.tabPageString.Controls.Add(this.label8);
            this.tabPageString.Controls.Add(this.comboBoxInstrumentFind);
            this.tabPageString.Controls.Add(tagnameLabel);
            this.tabPageString.Controls.Add(this.tagnameTextBox);
            this.tabPageString.Controls.Add(tagDescriptionLabel);
            this.tabPageString.Controls.Add(this.tagDescriptionTextBox);
            this.tabPageString.Controls.Add(lowerRangeValueLabel);
            this.tabPageString.Controls.Add(this.lowerRangeValueTextBox);
            this.tabPageString.Controls.Add(upperRangeValueLabel);
            this.tabPageString.Controls.Add(this.upperRangeValueTextBox);
            this.tabPageString.Controls.Add(alarmLowLabel);
            this.tabPageString.Controls.Add(this.alarmLowTextBox);
            this.tabPageString.Controls.Add(alarmHighLabel);
            this.tabPageString.Controls.Add(this.alarmHighTextBox);
            this.tabPageString.Controls.Add(dAUIDLabel1);
            this.tabPageString.Controls.Add(this.dAUIDTextBox);
            this.tabPageString.Controls.Add(channelLabel);
            this.tabPageString.Controls.Add(this.channelTextBox);
            this.tabPageString.Controls.Add(manufacturerIDLabel2);
            this.tabPageString.Controls.Add(this.manufacturerIDTextBox);
            this.tabPageString.Controls.Add(this.buttonSendSerial);
            this.tabPageString.Controls.Add(this.buttonRead);
            this.tabPageString.Controls.Add(this.buttonSaveFile);
            this.tabPageString.Controls.Add(this.buttonUpdate);
            this.tabPageString.Controls.Add(this.textBoxAH);
            this.tabPageString.Controls.Add(this.textBoxAL);
            this.tabPageString.Controls.Add(this.textBoxURV);
            this.tabPageString.Controls.Add(this.textBoxLRV);
            this.tabPageString.Controls.Add(this.textBoxTagname);
            this.tabPageString.Controls.Add(this.labelAH);
            this.tabPageString.Controls.Add(this.labelAL);
            this.tabPageString.Controls.Add(this.labelURV);
            this.tabPageString.Controls.Add(this.labelLRV);
            this.tabPageString.Controls.Add(this.labelTagname);
            this.tabPageString.Controls.Add(this.buttonSave);
            this.tabPageString.Controls.Add(this.buttonMessageBox);
            this.tabPageString.Controls.Add(this.buttonPrint);
            this.tabPageString.Controls.Add(this.buttonOpenFile);
            this.tabPageString.Controls.Add(this.buttonShowForm);
            this.tabPageString.Location = new System.Drawing.Point(4, 25);
            this.tabPageString.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageString.Name = "tabPageString";
            this.tabPageString.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageString.Size = new System.Drawing.Size(1084, 400);
            this.tabPageString.TabIndex = 0;
            this.tabPageString.Text = "Config";
            this.tabPageString.UseVisualStyleBackColor = true;
            this.tabPageString.Enter += new System.EventHandler(this.tabPageString_Enter);
            // 
            // comboBoxInstrumentFind
            // 
            this.comboBoxInstrumentFind.FormattingEnabled = true;
            this.comboBoxInstrumentFind.Location = new System.Drawing.Point(166, 69);
            this.comboBoxInstrumentFind.Name = "comboBoxInstrumentFind";
            this.comboBoxInstrumentFind.Size = new System.Drawing.Size(121, 24);
            this.comboBoxInstrumentFind.TabIndex = 38;
            this.comboBoxInstrumentFind.SelectedIndexChanged += new System.EventHandler(this.comboBoxInstrumentFind_SelectedIndexChanged);
            // 
            // tagnameTextBox
            // 
            this.tagnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.instrumentsBindingSource, "Tagname", true));
            this.tagnameTextBox.Location = new System.Drawing.Point(166, 128);
            this.tagnameTextBox.Name = "tagnameTextBox";
            this.tagnameTextBox.Size = new System.Drawing.Size(121, 22);
            this.tagnameTextBox.TabIndex = 21;
            // 
            // instrumentsBindingSource
            // 
            this.instrumentsBindingSource.DataMember = "Instruments";
            this.instrumentsBindingSource.DataSource = this.softSensDBDataSet;
            // 
            // softSensDBDataSet
            // 
            this.softSensDBDataSet.DataSetName = "SoftSensDBDataSet";
            this.softSensDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tagDescriptionTextBox
            // 
            this.tagDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.instrumentsBindingSource, "TagDescription", true));
            this.tagDescriptionTextBox.Location = new System.Drawing.Point(166, 156);
            this.tagDescriptionTextBox.Name = "tagDescriptionTextBox";
            this.tagDescriptionTextBox.Size = new System.Drawing.Size(121, 22);
            this.tagDescriptionTextBox.TabIndex = 23;
            // 
            // lowerRangeValueTextBox
            // 
            this.lowerRangeValueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.instrumentsBindingSource, "LowerRangeValue", true));
            this.lowerRangeValueTextBox.Location = new System.Drawing.Point(166, 184);
            this.lowerRangeValueTextBox.Name = "lowerRangeValueTextBox";
            this.lowerRangeValueTextBox.Size = new System.Drawing.Size(121, 22);
            this.lowerRangeValueTextBox.TabIndex = 25;
            // 
            // upperRangeValueTextBox
            // 
            this.upperRangeValueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.instrumentsBindingSource, "UpperRangeValue", true));
            this.upperRangeValueTextBox.Location = new System.Drawing.Point(166, 212);
            this.upperRangeValueTextBox.Name = "upperRangeValueTextBox";
            this.upperRangeValueTextBox.Size = new System.Drawing.Size(121, 22);
            this.upperRangeValueTextBox.TabIndex = 27;
            // 
            // alarmLowTextBox
            // 
            this.alarmLowTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.instrumentsBindingSource, "AlarmLow", true));
            this.alarmLowTextBox.Location = new System.Drawing.Point(166, 240);
            this.alarmLowTextBox.Name = "alarmLowTextBox";
            this.alarmLowTextBox.Size = new System.Drawing.Size(121, 22);
            this.alarmLowTextBox.TabIndex = 29;
            // 
            // alarmHighTextBox
            // 
            this.alarmHighTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.instrumentsBindingSource, "AlarmHigh", true));
            this.alarmHighTextBox.Location = new System.Drawing.Point(166, 268);
            this.alarmHighTextBox.Name = "alarmHighTextBox";
            this.alarmHighTextBox.Size = new System.Drawing.Size(121, 22);
            this.alarmHighTextBox.TabIndex = 31;
            // 
            // dAUIDTextBox
            // 
            this.dAUIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.instrumentsBindingSource, "DAUID", true));
            this.dAUIDTextBox.Location = new System.Drawing.Point(166, 296);
            this.dAUIDTextBox.Name = "dAUIDTextBox";
            this.dAUIDTextBox.Size = new System.Drawing.Size(121, 22);
            this.dAUIDTextBox.TabIndex = 33;
            // 
            // channelTextBox
            // 
            this.channelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.instrumentsBindingSource, "Channel", true));
            this.channelTextBox.Location = new System.Drawing.Point(166, 324);
            this.channelTextBox.Name = "channelTextBox";
            this.channelTextBox.Size = new System.Drawing.Size(121, 22);
            this.channelTextBox.TabIndex = 35;
            // 
            // manufacturerIDTextBox
            // 
            this.manufacturerIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.instrumentsBindingSource, "ManufacturerID", true));
            this.manufacturerIDTextBox.Location = new System.Drawing.Point(166, 352);
            this.manufacturerIDTextBox.Name = "manufacturerIDTextBox";
            this.manufacturerIDTextBox.Size = new System.Drawing.Size(121, 22);
            this.manufacturerIDTextBox.TabIndex = 37;
            // 
            // buttonSendSerial
            // 
            this.buttonSendSerial.Location = new System.Drawing.Point(342, 214);
            this.buttonSendSerial.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSendSerial.Name = "buttonSendSerial";
            this.buttonSendSerial.Size = new System.Drawing.Size(159, 36);
            this.buttonSendSerial.TabIndex = 20;
            this.buttonSendSerial.Text = "Send Serial";
            this.buttonSendSerial.UseVisualStyleBackColor = true;
            this.buttonSendSerial.Click += new System.EventHandler(this.buttonSendSerial_Click);
            // 
            // buttonRead
            // 
            this.buttonRead.Location = new System.Drawing.Point(342, 154);
            this.buttonRead.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(51, 41);
            this.buttonRead.TabIndex = 8;
            this.buttonRead.Text = "Read";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // buttonSaveFile
            // 
            this.buttonSaveFile.Location = new System.Drawing.Point(523, 109);
            this.buttonSaveFile.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSaveFile.Name = "buttonSaveFile";
            this.buttonSaveFile.Size = new System.Drawing.Size(55, 41);
            this.buttonSaveFile.TabIndex = 7;
            this.buttonSaveFile.Text = "Save";
            this.buttonSaveFile.UseVisualStyleBackColor = true;
            this.buttonSaveFile.Click += new System.EventHandler(this.buttonSaveFile_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(401, 154);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(62, 41);
            this.buttonUpdate.TabIndex = 6;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // textBoxAH
            // 
            this.textBoxAH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAH.Location = new System.Drawing.Point(844, 233);
            this.textBoxAH.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAH.Name = "textBoxAH";
            this.textBoxAH.Size = new System.Drawing.Size(94, 28);
            this.textBoxAH.TabIndex = 5;
            // 
            // textBoxAL
            // 
            this.textBoxAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAL.Location = new System.Drawing.Point(844, 195);
            this.textBoxAL.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAL.Name = "textBoxAL";
            this.textBoxAL.Size = new System.Drawing.Size(94, 28);
            this.textBoxAL.TabIndex = 5;
            // 
            // textBoxURV
            // 
            this.textBoxURV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxURV.Location = new System.Drawing.Point(844, 158);
            this.textBoxURV.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxURV.Name = "textBoxURV";
            this.textBoxURV.Size = new System.Drawing.Size(94, 28);
            this.textBoxURV.TabIndex = 3;
            // 
            // textBoxLRV
            // 
            this.textBoxLRV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLRV.Location = new System.Drawing.Point(844, 122);
            this.textBoxLRV.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLRV.Name = "textBoxLRV";
            this.textBoxLRV.Size = new System.Drawing.Size(94, 28);
            this.textBoxLRV.TabIndex = 2;
            // 
            // textBoxTagname
            // 
            this.textBoxTagname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTagname.Location = new System.Drawing.Point(844, 85);
            this.textBoxTagname.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTagname.Name = "textBoxTagname";
            this.textBoxTagname.PasswordChar = '*';
            this.textBoxTagname.Size = new System.Drawing.Size(94, 28);
            this.textBoxTagname.TabIndex = 1;
            // 
            // labelAH
            // 
            this.labelAH.AutoSize = true;
            this.labelAH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAH.Location = new System.Drawing.Point(672, 236);
            this.labelAH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAH.Name = "labelAH";
            this.labelAH.Size = new System.Drawing.Size(104, 24);
            this.labelAH.TabIndex = 19;
            this.labelAH.Text = "Alarm High";
            // 
            // labelAL
            // 
            this.labelAL.AutoSize = true;
            this.labelAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAL.Location = new System.Drawing.Point(674, 199);
            this.labelAL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAL.Name = "labelAL";
            this.labelAL.Size = new System.Drawing.Size(99, 24);
            this.labelAL.TabIndex = 17;
            this.labelAL.Text = "Alarm Low";
            // 
            // labelURV
            // 
            this.labelURV.AutoSize = true;
            this.labelURV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelURV.Location = new System.Drawing.Point(672, 162);
            this.labelURV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelURV.Name = "labelURV";
            this.labelURV.Size = new System.Drawing.Size(166, 24);
            this.labelURV.TabIndex = 15;
            this.labelURV.Text = "Upper range value";
            // 
            // labelLRV
            // 
            this.labelLRV.AutoSize = true;
            this.labelLRV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLRV.Location = new System.Drawing.Point(670, 126);
            this.labelLRV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLRV.Name = "labelLRV";
            this.labelLRV.Size = new System.Drawing.Size(166, 24);
            this.labelLRV.TabIndex = 13;
            this.labelLRV.Text = "Lower range value";
            // 
            // labelTagname
            // 
            this.labelTagname.AutoSize = true;
            this.labelTagname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTagname.Location = new System.Drawing.Point(670, 89);
            this.labelTagname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTagname.Name = "labelTagname";
            this.labelTagname.Size = new System.Drawing.Size(91, 24);
            this.labelTagname.TabIndex = 11;
            this.labelTagname.Text = "Tagname";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(947, 216);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(102, 34);
            this.buttonSave.TabIndex = 13;
            this.buttonSave.Text = "Save File";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonMessageBox
            // 
            this.buttonMessageBox.Location = new System.Drawing.Point(947, 177);
            this.buttonMessageBox.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMessageBox.Name = "buttonMessageBox";
            this.buttonMessageBox.Size = new System.Drawing.Size(102, 32);
            this.buttonMessageBox.TabIndex = 12;
            this.buttonMessageBox.Text = "Message Box";
            this.buttonMessageBox.UseVisualStyleBackColor = true;
            this.buttonMessageBox.Click += new System.EventHandler(this.buttonMessageBox_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.Location = new System.Drawing.Point(947, 69);
            this.buttonPrint.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(102, 28);
            this.buttonPrint.TabIndex = 9;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(947, 104);
            this.buttonOpenFile.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(102, 28);
            this.buttonOpenFile.TabIndex = 10;
            this.buttonOpenFile.Text = "Open File";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // buttonShowForm
            // 
            this.buttonShowForm.Location = new System.Drawing.Point(947, 140);
            this.buttonShowForm.Margin = new System.Windows.Forms.Padding(4);
            this.buttonShowForm.Name = "buttonShowForm";
            this.buttonShowForm.Size = new System.Drawing.Size(102, 28);
            this.buttonShowForm.TabIndex = 11;
            this.buttonShowForm.Text = "About";
            this.buttonShowForm.UseVisualStyleBackColor = true;
            this.buttonShowForm.Click += new System.EventHandler(this.buttonShowForm_Click);
            // 
            // instrumentsToComboBoxBindingSource
            // 
            this.instrumentsToComboBoxBindingSource.DataMember = "InstrumentsToComboBox";
            this.instrumentsToComboBoxBindingSource.DataSource = this.softSensDBDataSet;
            // 
            // tabPageDAU
            // 
            this.tabPageDAU.Controls.Add(this.label6);
            this.tabPageDAU.Controls.Add(this.label5);
            this.tabPageDAU.Controls.Add(this.panel2);
            this.tabPageDAU.Controls.Add(this.panel1);
            this.tabPageDAU.Controls.Add(this.label4);
            this.tabPageDAU.Location = new System.Drawing.Point(4, 25);
            this.tabPageDAU.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageDAU.Name = "tabPageDAU";
            this.tabPageDAU.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageDAU.Size = new System.Drawing.Size(1084, 400);
            this.tabPageDAU.TabIndex = 4;
            this.tabPageDAU.Text = "DAU";
            this.tabPageDAU.UseVisualStyleBackColor = true;
            this.tabPageDAU.Enter += new System.EventHandler(this.tabPageDAU_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 20);
            this.label6.TabIndex = 38;
            this.label6.Text = "DAU Database";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(507, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 20);
            this.label5.TabIndex = 37;
            this.label5.Text = "DAU Serial Com Setup";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxSend);
            this.panel2.Controls.Add(this.textBoxReceive);
            this.panel2.Controls.Add(this.buttonSend);
            this.panel2.Controls.Add(this.buttonReceive);
            this.panel2.Controls.Add(this.labelBaud);
            this.panel2.Controls.Add(this.labelPorts);
            this.panel2.Controls.Add(this.radioButtonConnected);
            this.panel2.Controls.Add(this.buttonDisconnect);
            this.panel2.Controls.Add(this.buttonConnect);
            this.panel2.Controls.Add(this.comboBoxBaud);
            this.panel2.Controls.Add(this.comboBoxPorts);
            this.panel2.Location = new System.Drawing.Point(511, 96);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(268, 295);
            this.panel2.TabIndex = 36;
            // 
            // textBoxSend
            // 
            this.textBoxSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSend.Location = new System.Drawing.Point(107, 180);
            this.textBoxSend.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSend.Name = "textBoxSend";
            this.textBoxSend.Size = new System.Drawing.Size(116, 26);
            this.textBoxSend.TabIndex = 19;
            // 
            // textBoxReceive
            // 
            this.textBoxReceive.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxReceive.Location = new System.Drawing.Point(100, 215);
            this.textBoxReceive.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxReceive.Multiline = true;
            this.textBoxReceive.Name = "textBoxReceive";
            this.textBoxReceive.ReadOnly = true;
            this.textBoxReceive.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxReceive.Size = new System.Drawing.Size(123, 63);
            this.textBoxReceive.TabIndex = 16;
            this.textBoxReceive.TabStop = false;
            // 
            // buttonSend
            // 
            this.buttonSend.Enabled = false;
            this.buttonSend.Location = new System.Drawing.Point(15, 180);
            this.buttonSend.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(68, 28);
            this.buttonSend.TabIndex = 18;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSendSerial_Click);
            // 
            // buttonReceive
            // 
            this.buttonReceive.Enabled = false;
            this.buttonReceive.Location = new System.Drawing.Point(15, 212);
            this.buttonReceive.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReceive.Name = "buttonReceive";
            this.buttonReceive.Size = new System.Drawing.Size(68, 28);
            this.buttonReceive.TabIndex = 17;
            this.buttonReceive.Text = "Receive";
            this.buttonReceive.UseVisualStyleBackColor = true;
            this.buttonReceive.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // labelBaud
            // 
            this.labelBaud.AutoSize = true;
            this.labelBaud.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBaud.Location = new System.Drawing.Point(12, 70);
            this.labelBaud.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBaud.Name = "labelBaud";
            this.labelBaud.Size = new System.Drawing.Size(79, 17);
            this.labelBaud.TabIndex = 15;
            this.labelBaud.Text = "Baud Rate:";
            // 
            // labelPorts
            // 
            this.labelPorts.AutoSize = true;
            this.labelPorts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPorts.Location = new System.Drawing.Point(15, 26);
            this.labelPorts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPorts.Name = "labelPorts";
            this.labelPorts.Size = new System.Drawing.Size(76, 17);
            this.labelPorts.TabIndex = 14;
            this.labelPorts.Text = "Com ports:";
            // 
            // radioButtonConnected
            // 
            this.radioButtonConnected.AutoSize = true;
            this.radioButtonConnected.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButtonConnected.Location = new System.Drawing.Point(231, 110);
            this.radioButtonConnected.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonConnected.Name = "radioButtonConnected";
            this.radioButtonConnected.Size = new System.Drawing.Size(17, 16);
            this.radioButtonConnected.TabIndex = 13;
            this.radioButtonConnected.TabStop = true;
            this.radioButtonConnected.UseVisualStyleBackColor = true;
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Location = new System.Drawing.Point(126, 136);
            this.buttonDisconnect.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(96, 27);
            this.buttonDisconnect.TabIndex = 12;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(126, 100);
            this.buttonConnect.Margin = new System.Windows.Forms.Padding(4);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(96, 28);
            this.buttonConnect.TabIndex = 11;
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
            this.comboBoxBaud.Location = new System.Drawing.Point(128, 65);
            this.comboBoxBaud.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxBaud.Name = "comboBoxBaud";
            this.comboBoxBaud.Size = new System.Drawing.Size(95, 28);
            this.comboBoxBaud.TabIndex = 10;
            // 
            // comboBoxPorts
            // 
            this.comboBoxPorts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPorts.FormattingEnabled = true;
            this.comboBoxPorts.Location = new System.Drawing.Point(128, 21);
            this.comboBoxPorts.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxPorts.Name = "comboBoxPorts";
            this.comboBoxPorts.Size = new System.Drawing.Size(95, 28);
            this.comboBoxPorts.Sorted = true;
            this.comboBoxPorts.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonBaud);
            this.panel1.Controls.Add(this.comboBoxLocation);
            this.panel1.Controls.Add(this.comboBoxCompany);
            this.panel1.Controls.Add(this.comboBoxDeviceFind);
            this.panel1.Controls.Add(label7);
            this.panel1.Controls.Add(this.rDCIDcomboBox);
            this.panel1.Controls.Add(deviceNameLabel);
            this.panel1.Controls.Add(this.buttonRegister);
            this.panel1.Controls.Add(this.buttonChange);
            this.panel1.Controls.Add(this.deviceNameTextBox);
            this.panel1.Controls.Add(this.buttonCancel);
            this.panel1.Controls.Add(baudRateLabel);
            this.panel1.Controls.Add(this.buttonNew);
            this.panel1.Controls.Add(this.baudRateTextBox);
            this.panel1.Controls.Add(cOMPortLabel);
            this.panel1.Controls.Add(this.cOMPortTextBox);
            this.panel1.Controls.Add(installationDateLabel);
            this.panel1.Controls.Add(this.installationDateDateTimePicker);
            this.panel1.Controls.Add(configUpdateDateLabel);
            this.panel1.Controls.Add(this.configUpdateDateDateTimePicker);
            this.panel1.Controls.Add(rDCIDLabel);
            this.panel1.Controls.Add(manufacturerIDLabel);
            this.panel1.Controls.Add(locationIDLabel);
            this.panel1.Location = new System.Drawing.Point(12, 67);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 325);
            this.panel1.TabIndex = 35;
            // 
            // buttonBaud
            // 
            this.buttonBaud.Image = global::SerialPortCom.Properties.Resources.AddTransition_16x;
            this.buttonBaud.Location = new System.Drawing.Point(370, 146);
            this.buttonBaud.Name = "buttonBaud";
            this.buttonBaud.Size = new System.Drawing.Size(29, 46);
            this.buttonBaud.TabIndex = 60;
            this.buttonBaud.UseVisualStyleBackColor = true;
            this.buttonBaud.Click += new System.EventHandler(this.buttonBaud_Click);
            // 
            // comboBoxLocation
            // 
            this.comboBoxLocation.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataAcqusitionUnitsBindingSource1, "LocationID", true));
            this.comboBoxLocation.DataSource = this.locationsBindingSource;
            this.comboBoxLocation.DisplayMember = "LocationName";
            this.comboBoxLocation.Enabled = false;
            this.comboBoxLocation.FormattingEnabled = true;
            this.comboBoxLocation.Location = new System.Drawing.Point(184, 298);
            this.comboBoxLocation.Name = "comboBoxLocation";
            this.comboBoxLocation.Size = new System.Drawing.Size(178, 24);
            this.comboBoxLocation.TabIndex = 59;
            this.comboBoxLocation.ValueMember = "LocationID";
            // 
            // dataAcqusitionUnitsBindingSource1
            // 
            this.dataAcqusitionUnitsBindingSource1.DataMember = "DataAcqusitionUnits";
            this.dataAcqusitionUnitsBindingSource1.DataSource = this.softSensDBDataSet;
            // 
            // comboBoxCompany
            // 
            this.comboBoxCompany.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataAcqusitionUnitsBindingSource1, "ManufacturerID", true));
            this.comboBoxCompany.DataSource = this.manufacturersBindingSource;
            this.comboBoxCompany.DisplayMember = "CompanyName";
            this.comboBoxCompany.Enabled = false;
            this.comboBoxCompany.FormattingEnabled = true;
            this.comboBoxCompany.Location = new System.Drawing.Point(184, 272);
            this.comboBoxCompany.Name = "comboBoxCompany";
            this.comboBoxCompany.Size = new System.Drawing.Size(178, 24);
            this.comboBoxCompany.TabIndex = 58;
            this.comboBoxCompany.ValueMember = "ManufacturerID";
            // 
            // comboBoxDeviceFind
            // 
            this.comboBoxDeviceFind.FormattingEnabled = true;
            this.comboBoxDeviceFind.Location = new System.Drawing.Point(184, 21);
            this.comboBoxDeviceFind.Name = "comboBoxDeviceFind";
            this.comboBoxDeviceFind.Size = new System.Drawing.Size(175, 24);
            this.comboBoxDeviceFind.TabIndex = 57;
            this.comboBoxDeviceFind.SelectedIndexChanged += new System.EventHandler(this.comboBoxDeviceFind_SelectedIndexChanged);
            // 
            // rDCIDcomboBox
            // 
            this.rDCIDcomboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataAcqusitionUnitsBindingSource1, "RDCID", true));
            this.rDCIDcomboBox.DataSource = this.remoteDataCollectorsBindingSource1;
            this.rDCIDcomboBox.DisplayMember = "RDCName";
            this.rDCIDcomboBox.Enabled = false;
            this.rDCIDcomboBox.FormattingEnabled = true;
            this.rDCIDcomboBox.Location = new System.Drawing.Point(184, 246);
            this.rDCIDcomboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rDCIDcomboBox.Name = "rDCIDcomboBox";
            this.rDCIDcomboBox.Size = new System.Drawing.Size(178, 24);
            this.rDCIDcomboBox.TabIndex = 54;
            this.rDCIDcomboBox.ValueMember = "RDCID";
            // 
            // remoteDataCollectorsBindingSource1
            // 
            this.remoteDataCollectorsBindingSource1.DataMember = "RemoteDataCollectors";
            this.remoteDataCollectorsBindingSource1.DataSource = this.softSensDBDataSet;
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(283, 83);
            this.buttonRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(76, 24);
            this.buttonRegister.TabIndex = 7;
            this.buttonRegister.Text = "Save";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Visible = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChange.Location = new System.Drawing.Point(184, 55);
            this.buttonChange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(76, 24);
            this.buttonChange.TabIndex = 6;
            this.buttonChange.Text = "Change";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // deviceNameTextBox
            // 
            this.deviceNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataAcqusitionUnitsBindingSource1, "DeviceName", true));
            this.deviceNameTextBox.Enabled = false;
            this.deviceNameTextBox.Location = new System.Drawing.Point(184, 118);
            this.deviceNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deviceNameTextBox.Name = "deviceNameTextBox";
            this.deviceNameTextBox.Size = new System.Drawing.Size(178, 22);
            this.deviceNameTextBox.TabIndex = 40;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(184, 83);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(76, 24);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Visible = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNew.Location = new System.Drawing.Point(283, 54);
            this.buttonNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(76, 24);
            this.buttonNew.TabIndex = 1;
            this.buttonNew.Text = "New...";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // baudRateTextBox
            // 
            this.baudRateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataAcqusitionUnitsBindingSource1, "BaudRate", true));
            this.baudRateTextBox.Enabled = false;
            this.baudRateTextBox.Location = new System.Drawing.Point(184, 144);
            this.baudRateTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.baudRateTextBox.Name = "baudRateTextBox";
            this.baudRateTextBox.Size = new System.Drawing.Size(178, 22);
            this.baudRateTextBox.TabIndex = 42;
            // 
            // cOMPortTextBox
            // 
            this.cOMPortTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataAcqusitionUnitsBindingSource1, "COMPort", true));
            this.cOMPortTextBox.Enabled = false;
            this.cOMPortTextBox.Location = new System.Drawing.Point(184, 170);
            this.cOMPortTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cOMPortTextBox.Name = "cOMPortTextBox";
            this.cOMPortTextBox.Size = new System.Drawing.Size(178, 22);
            this.cOMPortTextBox.TabIndex = 44;
            // 
            // installationDateDateTimePicker
            // 
            this.installationDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dataAcqusitionUnitsBindingSource1, "InstallationDate", true));
            this.installationDateDateTimePicker.Enabled = false;
            this.installationDateDateTimePicker.Location = new System.Drawing.Point(184, 195);
            this.installationDateDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.installationDateDateTimePicker.Name = "installationDateDateTimePicker";
            this.installationDateDateTimePicker.Size = new System.Drawing.Size(178, 22);
            this.installationDateDateTimePicker.TabIndex = 46;
            // 
            // configUpdateDateDateTimePicker
            // 
            this.configUpdateDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dataAcqusitionUnitsBindingSource1, "ConfigUpdateDate", true));
            this.configUpdateDateDateTimePicker.Enabled = false;
            this.configUpdateDateDateTimePicker.Location = new System.Drawing.Point(184, 221);
            this.configUpdateDateDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.configUpdateDateDateTimePicker.Name = "configUpdateDateDateTimePicker";
            this.configUpdateDateDateTimePicker.Size = new System.Drawing.Size(178, 22);
            this.configUpdateDateDateTimePicker.TabIndex = 48;
            this.configUpdateDateDateTimePicker.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Data Acquisition Unit ";
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageDatabase);
            this.tabControlMain.Controls.Add(this.tabPageDAU);
            this.tabControlMain.Controls.Add(this.tabPageString);
            this.tabControlMain.Controls.Add(this.tabPageLoop);
            this.tabControlMain.Controls.Add(this.tabPageLis);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1092, 429);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageDatabase
            // 
            this.tabPageDatabase.Controls.Add(this.buttonDAUCancel);
            this.tabPageDatabase.Controls.Add(this.buttonDAUNew);
            this.tabPageDatabase.Controls.Add(this.buttonDAUSave);
            this.tabPageDatabase.Controls.Add(this.buttonDAUChange);
            this.tabPageDatabase.Controls.Add(this.comboBox4);
            this.tabPageDatabase.Controls.Add(this.comboBox3);
            this.tabPageDatabase.Controls.Add(this.comboBox2);
            this.tabPageDatabase.Controls.Add(this.comboBox1);
            this.tabPageDatabase.Controls.Add(dAUIDLabel);
            this.tabPageDatabase.Controls.Add(deviceNameLabel1);
            this.tabPageDatabase.Controls.Add(this.deviceNameTextBox1);
            this.tabPageDatabase.Controls.Add(baudRateLabel1);
            this.tabPageDatabase.Controls.Add(this.baudRateTextBox1);
            this.tabPageDatabase.Controls.Add(cOMPortLabel1);
            this.tabPageDatabase.Controls.Add(this.cOMPortTextBox1);
            this.tabPageDatabase.Controls.Add(installationDateLabel1);
            this.tabPageDatabase.Controls.Add(this.installationDateDateTimePicker1);
            this.tabPageDatabase.Controls.Add(configUpdateDateLabel1);
            this.tabPageDatabase.Controls.Add(this.configUpdateDateDateTimePicker1);
            this.tabPageDatabase.Controls.Add(rDCIDLabel1);
            this.tabPageDatabase.Controls.Add(manufacturerIDLabel1);
            this.tabPageDatabase.Controls.Add(locationIDLabel1);
            this.tabPageDatabase.Location = new System.Drawing.Point(4, 25);
            this.tabPageDatabase.Name = "tabPageDatabase";
            this.tabPageDatabase.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDatabase.Size = new System.Drawing.Size(1084, 400);
            this.tabPageDatabase.TabIndex = 5;
            this.tabPageDatabase.Text = "DBtest";
            this.tabPageDatabase.UseVisualStyleBackColor = true;
            this.tabPageDatabase.Enter += new System.EventHandler(this.tabPageDatabase_Enter);
            // 
            // buttonDAUCancel
            // 
            this.buttonDAUCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDAUCancel.Location = new System.Drawing.Point(255, 122);
            this.buttonDAUCancel.Name = "buttonDAUCancel";
            this.buttonDAUCancel.Size = new System.Drawing.Size(68, 23);
            this.buttonDAUCancel.TabIndex = 25;
            this.buttonDAUCancel.Text = "Cancel";
            this.buttonDAUCancel.UseVisualStyleBackColor = true;
            this.buttonDAUCancel.Click += new System.EventHandler(this.buttonDAUCancel_Click);
            // 
            // buttonDAUNew
            // 
            this.buttonDAUNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDAUNew.Location = new System.Drawing.Point(181, 122);
            this.buttonDAUNew.Name = "buttonDAUNew";
            this.buttonDAUNew.Size = new System.Drawing.Size(68, 23);
            this.buttonDAUNew.TabIndex = 24;
            this.buttonDAUNew.Text = "New";
            this.buttonDAUNew.UseVisualStyleBackColor = true;
            this.buttonDAUNew.Click += new System.EventHandler(this.buttonDAUNew_Click);
            // 
            // buttonDAUSave
            // 
            this.buttonDAUSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDAUSave.Location = new System.Drawing.Point(255, 93);
            this.buttonDAUSave.Name = "buttonDAUSave";
            this.buttonDAUSave.Size = new System.Drawing.Size(68, 23);
            this.buttonDAUSave.TabIndex = 23;
            this.buttonDAUSave.Text = "Save";
            this.buttonDAUSave.UseVisualStyleBackColor = true;
            this.buttonDAUSave.Click += new System.EventHandler(this.buttonDAUSave_Click);
            // 
            // buttonDAUChange
            // 
            this.buttonDAUChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDAUChange.Location = new System.Drawing.Point(181, 93);
            this.buttonDAUChange.Name = "buttonDAUChange";
            this.buttonDAUChange.Size = new System.Drawing.Size(68, 23);
            this.buttonDAUChange.TabIndex = 22;
            this.buttonDAUChange.Text = "Change";
            this.buttonDAUChange.UseVisualStyleBackColor = true;
            this.buttonDAUChange.Click += new System.EventHandler(this.buttonDAUChange_Click);
            // 
            // comboBox4
            // 
            this.comboBox4.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataAcqusitionUnitsBindingSource1, "LocationID", true));
            this.comboBox4.DataSource = this.locationsBindingSource1;
            this.comboBox4.DisplayMember = "LocationName";
            this.comboBox4.Enabled = false;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(181, 352);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(142, 24);
            this.comboBox4.TabIndex = 21;
            this.comboBox4.ValueMember = "LocationID";
            // 
            // locationsBindingSource1
            // 
            this.locationsBindingSource1.DataMember = "Locations";
            this.locationsBindingSource1.DataSource = this.softSensDBDataSet;
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataAcqusitionUnitsBindingSource1, "ManufacturerID", true));
            this.comboBox3.DataSource = this.manufacturersBindingSource1;
            this.comboBox3.DisplayMember = "CompanyName";
            this.comboBox3.Enabled = false;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(181, 324);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(142, 24);
            this.comboBox3.TabIndex = 20;
            this.comboBox3.ValueMember = "ManufacturerID";
            // 
            // manufacturersBindingSource1
            // 
            this.manufacturersBindingSource1.DataMember = "Manufacturers";
            this.manufacturersBindingSource1.DataSource = this.softSensDBDataSet;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataAcqusitionUnitsBindingSource1, "RDCID", true));
            this.comboBox2.DataSource = this.remoteDataCollectorsBindingSource2;
            this.comboBox2.DisplayMember = "RDCName";
            this.comboBox2.Enabled = false;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(181, 294);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(142, 24);
            this.comboBox2.TabIndex = 19;
            this.comboBox2.ValueMember = "RDCID";
            // 
            // remoteDataCollectorsBindingSource2
            // 
            this.remoteDataCollectorsBindingSource2.DataMember = "RemoteDataCollectors";
            this.remoteDataCollectorsBindingSource2.DataSource = this.softSensDBDataSet2;
            // 
            // softSensDBDataSet2
            // 
            this.softSensDBDataSet2.DataSetName = "SoftSensDBDataSet";
            this.softSensDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(181, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(142, 24);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // deviceNameTextBox1
            // 
            this.deviceNameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataAcqusitionUnitsBindingSource1, "DeviceName", true));
            this.deviceNameTextBox1.Enabled = false;
            this.deviceNameTextBox1.Location = new System.Drawing.Point(181, 156);
            this.deviceNameTextBox1.Name = "deviceNameTextBox1";
            this.deviceNameTextBox1.Size = new System.Drawing.Size(142, 22);
            this.deviceNameTextBox1.TabIndex = 3;
            // 
            // baudRateTextBox1
            // 
            this.baudRateTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataAcqusitionUnitsBindingSource1, "BaudRate", true));
            this.baudRateTextBox1.Enabled = false;
            this.baudRateTextBox1.Location = new System.Drawing.Point(181, 184);
            this.baudRateTextBox1.Name = "baudRateTextBox1";
            this.baudRateTextBox1.Size = new System.Drawing.Size(142, 22);
            this.baudRateTextBox1.TabIndex = 5;
            // 
            // cOMPortTextBox1
            // 
            this.cOMPortTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataAcqusitionUnitsBindingSource1, "COMPort", true));
            this.cOMPortTextBox1.Enabled = false;
            this.cOMPortTextBox1.Location = new System.Drawing.Point(181, 212);
            this.cOMPortTextBox1.Name = "cOMPortTextBox1";
            this.cOMPortTextBox1.Size = new System.Drawing.Size(142, 22);
            this.cOMPortTextBox1.TabIndex = 7;
            // 
            // installationDateDateTimePicker1
            // 
            this.installationDateDateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dataAcqusitionUnitsBindingSource1, "InstallationDate", true));
            this.installationDateDateTimePicker1.Enabled = false;
            this.installationDateDateTimePicker1.Location = new System.Drawing.Point(181, 240);
            this.installationDateDateTimePicker1.Name = "installationDateDateTimePicker1";
            this.installationDateDateTimePicker1.Size = new System.Drawing.Size(142, 22);
            this.installationDateDateTimePicker1.TabIndex = 9;
            // 
            // configUpdateDateDateTimePicker1
            // 
            this.configUpdateDateDateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dataAcqusitionUnitsBindingSource1, "ConfigUpdateDate", true));
            this.configUpdateDateDateTimePicker1.Enabled = false;
            this.configUpdateDateDateTimePicker1.Location = new System.Drawing.Point(181, 268);
            this.configUpdateDateDateTimePicker1.Name = "configUpdateDateDateTimePicker1";
            this.configUpdateDateDateTimePicker1.Size = new System.Drawing.Size(142, 22);
            this.configUpdateDateDateTimePicker1.TabIndex = 11;
            // 
            // dataAcqusitionUnitsTableAdapter
            // 
            this.dataAcqusitionUnitsTableAdapter.ClearBeforeFill = true;
            // 
            // remoteDataCollectorsTableAdapter
            // 
            this.remoteDataCollectorsTableAdapter.ClearBeforeFill = true;
            // 
            // manufacturersTableAdapter
            // 
            this.manufacturersTableAdapter.ClearBeforeFill = true;
            // 
            // locationsTableAdapter
            // 
            this.locationsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DataAcqusitionUnits1TableAdapter = null;
            this.tableAdapterManager.DataAcqusitionUnitsTableAdapter = this.dataAcqusitionUnitsTableAdapter;
            this.tableAdapterManager.InstrumentLogTableAdapter = null;
            this.tableAdapterManager.InstrumentsTableAdapter = null;
            this.tableAdapterManager.InstrumentsToComboBoxTableAdapter = null;
            this.tableAdapterManager.LocationsTableAdapter = this.locationsTableAdapter;
            this.tableAdapterManager.ManufacturersTableAdapter = this.manufacturersTableAdapter;
            this.tableAdapterManager.RemoteDataCollectorsTableAdapter = this.remoteDataCollectorsTableAdapter;
            this.tableAdapterManager.UpdateOrder = SerialPortCom.SoftSensDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataAcqusitionUnits1BindingSource
            // 
            this.dataAcqusitionUnits1BindingSource.DataMember = "DataAcqusitionUnits1";
            this.dataAcqusitionUnits1BindingSource.DataSource = this.softSensDBDataSet;
            // 
            // dataAcqusitionUnits1BindingSource1
            // 
            this.dataAcqusitionUnits1BindingSource1.DataMember = "DataAcqusitionUnits1";
            this.dataAcqusitionUnits1BindingSource1.DataSource = this.softSensDBDataSet;
            // 
            // dataAcqusitionUnits1BindingSource2
            // 
            this.dataAcqusitionUnits1BindingSource2.DataMember = "DataAcqusitionUnits1";
            this.dataAcqusitionUnits1BindingSource2.DataSource = this.softSensDBDataSet;
            // 
            // dataAcqusitionUnits1BindingSource3
            // 
            this.dataAcqusitionUnits1BindingSource3.DataMember = "DataAcqusitionUnits1";
            this.dataAcqusitionUnits1BindingSource3.DataSource = this.softSensDBDataSet;
            // 
            // dataAcqusitionUnits1TableAdapter
            // 
            this.dataAcqusitionUnits1TableAdapter.ClearBeforeFill = true;
            // 
            // instrumentsTableAdapter
            // 
            this.instrumentsTableAdapter.ClearBeforeFill = true;
            // 
            // instrumentsToComboBoxTableAdapter
            // 
            this.instrumentsToComboBoxTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(347, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 39;
            this.label8.Text = "label8";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 429);
            this.Controls.Add(this.tabControlMain);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SoftSensConf";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataAcqusitionUnitsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.softSensDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remoteDataCollectorsBindingSource)).EndInit();
            this.tabPageLis.ResumeLayout(false);
            this.tabPageLis.PerformLayout();
            this.tabPageLoop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPageString.ResumeLayout(false);
            this.tabPageString.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.softSensDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentsToComboBoxBindingSource)).EndInit();
            this.tabPageDAU.ResumeLayout(false);
            this.tabPageDAU.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataAcqusitionUnitsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remoteDataCollectorsBindingSource1)).EndInit();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageDatabase.ResumeLayout(false);
            this.tabPageDatabase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locationsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remoteDataCollectorsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.softSensDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataAcqusitionUnits1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataAcqusitionUnits1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataAcqusitionUnits1BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataAcqusitionUnits1BindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timerSerialReceive;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Timer timerChartAdd;
        private System.Windows.Forms.SaveFileDialog saveFileDialogConfig;
        private System.Windows.Forms.SaveFileDialog saveFileDialogCSV;
        private System.Windows.Forms.BindingSource bindingSource1;
        private SoftSensDBDataSet softSensDBDataSet;
        private System.Windows.Forms.BindingSource dataAcqusitionUnitsBindingSource;
        private SoftSensDBDataSetTableAdapters.DataAcqusitionUnitsTableAdapter dataAcqusitionUnitsTableAdapter;
        private System.Windows.Forms.BindingSource remoteDataCollectorsBindingSource;
        private SoftSensDBDataSetTableAdapters.RemoteDataCollectorsTableAdapter remoteDataCollectorsTableAdapter;
        private System.Windows.Forms.BindingSource manufacturersBindingSource;
        private SoftSensDBDataSetTableAdapters.ManufacturersTableAdapter manufacturersTableAdapter;
        private System.Windows.Forms.BindingSource locationsBindingSource;
        private SoftSensDBDataSetTableAdapters.LocationsTableAdapter locationsTableAdapter;
        private System.Windows.Forms.BindingSource dataAcqusitionUnitsBindingSource1;
        private System.Windows.Forms.BindingSource remoteDataCollectorsBindingSource1;
        private SoftSensDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource dataAcqusitionUnits1BindingSource;
        private System.Windows.Forms.TabPage tabPageLis;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.CheckBox checkBoxCase;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.TextBox textBoxInput2;
        private System.Windows.Forms.TextBox textBoxInput1;
        private System.Windows.Forms.TextBox textBoxTextFile;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxVab;
        private System.Windows.Forms.ListBox listBoxVb;
        private System.Windows.Forms.ListBox listBoxVa;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Button buttonAddXY;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListBox listBoxStuff;
        private System.Windows.Forms.ComboBox comboBoxRemove;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TabPage tabPageLoop;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonReadFile;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TabPage tabPageString;
        private System.Windows.Forms.Button buttonSendSerial;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.Button buttonSaveFile;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textBoxAH;
        private System.Windows.Forms.TextBox textBoxAL;
        private System.Windows.Forms.TextBox textBoxURV;
        private System.Windows.Forms.TextBox textBoxLRV;
        private System.Windows.Forms.TextBox textBoxTagname;
        private System.Windows.Forms.Label labelAH;
        private System.Windows.Forms.Label labelAL;
        private System.Windows.Forms.Label labelURV;
        private System.Windows.Forms.Label labelLRV;
        private System.Windows.Forms.Label labelTagname;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonMessageBox;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Button buttonShowForm;
        private System.Windows.Forms.TabPage tabPageDAU;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxSend;
        private System.Windows.Forms.TextBox textBoxReceive;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button buttonReceive;
        private System.Windows.Forms.Label labelBaud;
        private System.Windows.Forms.Label labelPorts;
        private System.Windows.Forms.RadioButton radioButtonConnected;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.ComboBox comboBoxBaud;
        private System.Windows.Forms.ComboBox comboBoxPorts;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxDeviceFind;
        private System.Windows.Forms.ComboBox rDCIDcomboBox;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.TextBox deviceNameTextBox;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.TextBox baudRateTextBox;
        private System.Windows.Forms.TextBox cOMPortTextBox;
        private System.Windows.Forms.DateTimePicker installationDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker configUpdateDateDateTimePicker;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonCancel;
        public System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.ComboBox comboBoxCompany;
        private System.Windows.Forms.ComboBox comboBoxLocation;
        private System.Windows.Forms.Button buttonBaud;
        private System.Windows.Forms.TabPage tabPageDatabase;
        private System.Windows.Forms.TextBox deviceNameTextBox1;
        private System.Windows.Forms.TextBox baudRateTextBox1;
        private System.Windows.Forms.TextBox cOMPortTextBox1;
        private System.Windows.Forms.DateTimePicker installationDateDateTimePicker1;
        private System.Windows.Forms.DateTimePicker configUpdateDateDateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private SoftSensDBDataSet1 softSensDBDataSet1;
        private System.Windows.Forms.BindingSource dataAcqusitionUnits1BindingSource3;
        private System.Windows.Forms.BindingSource dataAcqusitionUnits1BindingSource1;
        private System.Windows.Forms.BindingSource dataAcqusitionUnits1BindingSource2;
        private System.Windows.Forms.ComboBox comboBox2;
        private SoftSensDBDataSet softSensDBDataSet2;
        private System.Windows.Forms.BindingSource remoteDataCollectorsBindingSource2;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.BindingSource locationsBindingSource1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.BindingSource manufacturersBindingSource1;
        private System.Windows.Forms.Button buttonDAUChange;
        private System.Windows.Forms.Button buttonDAUSave;
        private System.Windows.Forms.Button buttonDAUNew;
        private SoftSensDBDataSetTableAdapters.DataAcqusitionUnits1TableAdapter dataAcqusitionUnits1TableAdapter;
        private System.Windows.Forms.Button buttonDAUCancel;
        private System.Windows.Forms.BindingSource instrumentsBindingSource;
        private SoftSensDBDataSetTableAdapters.InstrumentsTableAdapter instrumentsTableAdapter;
        private System.Windows.Forms.TextBox tagnameTextBox;
        private System.Windows.Forms.TextBox tagDescriptionTextBox;
        private System.Windows.Forms.TextBox lowerRangeValueTextBox;
        private System.Windows.Forms.TextBox upperRangeValueTextBox;
        private System.Windows.Forms.TextBox alarmLowTextBox;
        private System.Windows.Forms.TextBox alarmHighTextBox;
        private System.Windows.Forms.TextBox dAUIDTextBox;
        private System.Windows.Forms.TextBox channelTextBox;
        private System.Windows.Forms.TextBox manufacturerIDTextBox;
        private System.Windows.Forms.ComboBox comboBoxInstrumentFind;
        private System.Windows.Forms.BindingSource instrumentsToComboBoxBindingSource;
        private SoftSensDBDataSetTableAdapters.InstrumentsToComboBoxTableAdapter instrumentsToComboBoxTableAdapter;
        private System.Windows.Forms.Label label8;
    }
}

