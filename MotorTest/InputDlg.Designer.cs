using System.Windows.Forms;

namespace MotorTest
{
    partial class InputDlg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputDlg));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.InputCustomerName = new System.Windows.Forms.TextBox();
            this.InputFieldName = new System.Windows.Forms.TextBox();
            this.InputTestedBy = new System.Windows.Forms.TextBox();
            this.InputMotorSN = new System.Windows.Forms.TextBox();
            this.InputTestDate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.InputChooseSupplier = new System.Windows.Forms.ComboBox();
            this.InputChooseSeries = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.InputChooseModel = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.InputMonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.InputChooseLoadData = new System.Windows.Forms.ComboBox();
            this.label72 = new System.Windows.Forms.Label();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonReport = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label71 = new System.Windows.Forms.Label();
            this.InputPITestForMotorAtTempBellow38C = new System.Windows.Forms.TextBox();
            this.label69 = new System.Windows.Forms.Label();
            this.InputTempAtWhichPIWasPerformed = new System.Windows.Forms.TextBox();
            this.label70 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.InputCurrentICWithMaxVoltUnbalancePercent1point5 = new System.Windows.Forms.TextBox();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.InputCurrentIBWithMaxVoltUnbalancePercent1point5 = new System.Windows.Forms.TextBox();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.InputCurrentIAWithMaxVoltUnbalancePercent1point5 = new System.Windows.Forms.TextBox();
            this.label47 = new System.Windows.Forms.Label();
            this.OutputIsMAVDSmallerThanPercent1point5 = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.InputVoltVc = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.InputVoltVb = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.InputMotorTemp = new System.Windows.Forms.TextBox();
            this.InputVoltVa = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.InputMotorWindingResistanceAB = new System.Windows.Forms.TextBox();
            this.InputMotorWindingResistanceABAfterIdle = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.InputMotorWindingResistanceBC = new System.Windows.Forms.TextBox();
            this.InputMotorTempAfterIdle = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.InputMotorWindingResistanceBCAfterIdle = new System.Windows.Forms.TextBox();
            this.InputMotorWindingResistanceCA = new System.Windows.Forms.TextBox();
            this.label58 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.OutputInsulationResistanceCheckMinVoltRequired = new System.Windows.Forms.TextBox();
            this.label62 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.InputMotorWindingResistanceCAAfterIdle = new System.Windows.Forms.TextBox();
            this.InputMeasuredInsulationResistance = new System.Windows.Forms.TextBox();
            this.InputRPMAt60HzWhenMotorTempReached60C = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.InputMotorTempRiseAfter11MinutesOfFullVoltTest = new System.Windows.Forms.TextBox();
            this.OutputInsulationResistanceCorrectedTo40C = new System.Windows.Forms.TextBox();
            this.OutputInsulationResistanceCheckMinVoltRequiredAfterIdle = new System.Windows.Forms.TextBox();
            this.label65 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.InputMeasuredInsulationResistanceAfterIdle = new System.Windows.Forms.TextBox();
            this.label67 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.InputRPMAfterLowVoltStart = new System.Windows.Forms.TextBox();
            this.InputChooseDidMotorStartedWithLowVoltAt60Hz = new System.Windows.Forms.ComboBox();
            this.label36 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.OutputRecommendedLowVoltStartAt60Hz = new System.Windows.Forms.TextBox();
            this.InputChooseIsAirTestPassed = new System.Windows.Forms.ComboBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.InputOilQualityCheck = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.InputShaftExtensionBase = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.InputShaftExtensionHead = new System.Windows.Forms.TextBox();
            this.InputChooseMotorConfigForShaftExtension = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.InputShaftSidePlay = new System.Windows.Forms.TextBox();
            this.ButtonUpdate = new System.Windows.Forms.Button();
            this.label73 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.InputReportID = new System.Windows.Forms.TextBox();
            this.InputRuntimeForIdleTest = new System.Windows.Forms.TextBox();
            this.label74 = new System.Windows.Forms.Label();
            this.motortestdataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motortestdataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(414, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(448, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Field name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(458, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Motor SN:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(456, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tested by:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label5.Location = new System.Drawing.Point(459, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Test date:";
            // 
            // InputCustomerName
            // 
            this.InputCustomerName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.motortestdataBindingSource, "InputCustomerName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.InputCustomerName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputCustomerName.Location = new System.Drawing.Point(563, 20);
            this.InputCustomerName.Name = "InputCustomerName";
            this.InputCustomerName.Size = new System.Drawing.Size(227, 25);
            this.InputCustomerName.TabIndex = 0;
            this.InputCustomerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // InputFieldName
            // 
            this.InputFieldName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.motortestdataBindingSource, "InputFieldName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.InputFieldName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputFieldName.Location = new System.Drawing.Point(563, 48);
            this.InputFieldName.Name = "InputFieldName";
            this.InputFieldName.Size = new System.Drawing.Size(227, 25);
            this.InputFieldName.TabIndex = 1;
            this.InputFieldName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // InputTestedBy
            // 
            this.InputTestedBy.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.motortestdataBindingSource, "InputTestedBy", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.InputTestedBy.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputTestedBy.Location = new System.Drawing.Point(563, 104);
            this.InputTestedBy.Name = "InputTestedBy";
            this.InputTestedBy.Size = new System.Drawing.Size(227, 25);
            this.InputTestedBy.TabIndex = 3;
            this.InputTestedBy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // InputMotorSN
            // 
            this.InputMotorSN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.motortestdataBindingSource, "InputMotorSN", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.InputMotorSN.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputMotorSN.Location = new System.Drawing.Point(563, 76);
            this.InputMotorSN.Name = "InputMotorSN";
            this.InputMotorSN.Size = new System.Drawing.Size(227, 25);
            this.InputMotorSN.TabIndex = 2;
            this.InputMotorSN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // InputTestDate
            // 
            this.InputTestDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.motortestdataBindingSource, "InputTestDate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.InputTestDate.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputTestDate.Location = new System.Drawing.Point(563, 132);
            this.InputTestDate.Name = "InputTestDate";
            this.InputTestDate.Size = new System.Drawing.Size(227, 25);
            this.InputTestDate.TabIndex = 5;
            this.InputTestDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.InputTestDate.Click += new System.EventHandler(this.InputTestDate_Enter);
            this.InputTestDate.Enter += new System.EventHandler(this.InputTestDate_Enter);
            this.InputTestDate.Leave += new System.EventHandler(this.InputTestDate_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label7.Location = new System.Drawing.Point(835, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "Supplier:";
            // 
            // InputChooseSupplier
            // 
            this.InputChooseSupplier.BackColor = System.Drawing.SystemColors.Window;
            this.InputChooseSupplier.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.motortestdataBindingSource, "InputChooseSupplier", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.InputChooseSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InputChooseSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.InputChooseSupplier.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputChooseSupplier.FormattingEnabled = true;
            this.InputChooseSupplier.Items.AddRange(new object[] {
            "OD - GmbH"});
            this.InputChooseSupplier.Location = new System.Drawing.Point(926, 21);
            this.InputChooseSupplier.Name = "InputChooseSupplier";
            this.InputChooseSupplier.Size = new System.Drawing.Size(110, 23);
            this.InputChooseSupplier.TabIndex = 6;
            // 
            // InputChooseSeries
            // 
            this.InputChooseSeries.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.motortestdataBindingSource, "InputChooseSeries", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.InputChooseSeries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InputChooseSeries.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.InputChooseSeries.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputChooseSeries.FormattingEnabled = true;
            this.InputChooseSeries.Items.AddRange(new object[] {
            "375",
            "456",
            "540",
            "562",
            "738"});
            this.InputChooseSeries.Location = new System.Drawing.Point(926, 53);
            this.InputChooseSeries.Name = "InputChooseSeries";
            this.InputChooseSeries.Size = new System.Drawing.Size(91, 23);
            this.InputChooseSeries.TabIndex = 7;
            this.InputChooseSeries.SelectedIndexChanged += new System.EventHandler(this.InputChooseSeries_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label8.Location = new System.Drawing.Point(849, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 18);
            this.label8.TabIndex = 13;
            this.label8.Text = "Series:";
            // 
            // InputChooseModel
            // 
            this.InputChooseModel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.motortestdataBindingSource, "InputChooseModel", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.InputChooseModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InputChooseModel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.InputChooseModel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputChooseModel.FormattingEnabled = true;
            this.InputChooseModel.Location = new System.Drawing.Point(926, 87);
            this.InputChooseModel.Name = "InputChooseModel";
            this.InputChooseModel.Size = new System.Drawing.Size(302, 23);
            this.InputChooseModel.TabIndex = 8;
            this.InputChooseModel.SelectedIndexChanged += new System.EventHandler(this.InputChooseModel_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label9.Location = new System.Drawing.Point(851, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 18);
            this.label9.TabIndex = 15;
            this.label9.Text = "Model:";
            // 
            // InputMonthCalendar
            // 
            this.InputMonthCalendar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputMonthCalendar.Location = new System.Drawing.Point(563, 169);
            this.InputMonthCalendar.MaxSelectionCount = 1;
            this.InputMonthCalendar.Name = "InputMonthCalendar";
            this.InputMonthCalendar.TabIndex = 4;
            this.InputMonthCalendar.Visible = false;
            this.InputMonthCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.InputMonthCalendar_DateSelected);
            this.InputMonthCalendar.Leave += new System.EventHandler(this.InputMonthCalendar_Leave);
            // 
            // InputChooseLoadData
            // 
            this.InputChooseLoadData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InputChooseLoadData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.InputChooseLoadData.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputChooseLoadData.FormattingEnabled = true;
            this.InputChooseLoadData.Items.AddRange(new object[] {
            "Motor SN: 54999 - Wednesday, June 20, 2018",
            "Motor SN: 54888 - Wednesday, June 02, 2018"});
            this.InputChooseLoadData.Location = new System.Drawing.Point(926, 120);
            this.InputChooseLoadData.Name = "InputChooseLoadData";
            this.InputChooseLoadData.Size = new System.Drawing.Size(302, 23);
            this.InputChooseLoadData.TabIndex = 40;
            this.InputChooseLoadData.SelectedIndexChanged += new System.EventHandler(this.InputChooseLoadData_SelectedIndexChanged);
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label72.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label72.Location = new System.Drawing.Point(825, 121);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(83, 18);
            this.label72.TabIndex = 19;
            this.label72.Text = "Load Data:";
            // 
            // ButtonClear
            // 
            this.ButtonClear.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonClear.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ButtonClear.Location = new System.Drawing.Point(828, 149);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(96, 31);
            this.ButtonClear.TabIndex = 37;
            this.ButtonClear.Text = "Clear All";
            this.ButtonClear.UseVisualStyleBackColor = false;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ButtonSave.Location = new System.Drawing.Point(1032, 149);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(96, 31);
            this.ButtonSave.TabIndex = 38;
            this.ButtonSave.Text = "Save Test";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonReport
            // 
            this.ButtonReport.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ButtonReport.Location = new System.Drawing.Point(1134, 149);
            this.ButtonReport.Name = "ButtonReport";
            this.ButtonReport.Size = new System.Drawing.Size(96, 31);
            this.ButtonReport.TabIndex = 39;
            this.ButtonReport.Text = "To Report";
            this.ButtonReport.UseVisualStyleBackColor = true;
            this.ButtonReport.Click += new System.EventHandler(this.ButtonReport_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MotorTest.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(47, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(302, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label71.ForeColor = System.Drawing.Color.Blue;
            this.label71.Location = new System.Drawing.Point(650, 703);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(331, 18);
            this.label71.TabIndex = 210;
            this.label71.Text = "PI Test for Motor at Temperature Bellow 38ºC:";
            // 
            // InputPITestForMotorAtTempBellow38C
            // 
            this.InputPITestForMotorAtTempBellow38C.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.motortestdataBindingSource, "InputPITestForMotorAtTempBellow38C", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.InputPITestForMotorAtTempBellow38C.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputPITestForMotorAtTempBellow38C.Location = new System.Drawing.Point(1078, 696);
            this.InputPITestForMotorAtTempBellow38C.Name = "InputPITestForMotorAtTempBellow38C";
            this.InputPITestForMotorAtTempBellow38C.Size = new System.Drawing.Size(75, 25);
            this.InputPITestForMotorAtTempBellow38C.TabIndex = 35;
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label69.ForeColor = System.Drawing.Color.Blue;
            this.label69.Location = new System.Drawing.Point(650, 673);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(286, 18);
            this.label69.TabIndex = 207;
            this.label69.Text = "Temperature at Which PI was Performd:";
            // 
            // InputTempAtWhichPIWasPerformed
            // 
            this.InputTempAtWhichPIWasPerformed.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.motortestdataBindingSource, "InputTempAtWhichPIWasPerformed", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.InputTempAtWhichPIWasPerformed.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputTempAtWhichPIWasPerformed.Location = new System.Drawing.Point(1078, 666);
            this.InputTempAtWhichPIWasPerformed.Name = "InputTempAtWhichPIWasPerformed";
            this.InputTempAtWhichPIWasPerformed.Size = new System.Drawing.Size(75, 25);
            this.InputTempAtWhichPIWasPerformed.TabIndex = 34;
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label70.ForeColor = System.Drawing.Color.Blue;
            this.label70.Location = new System.Drawing.Point(1170, 669);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(25, 18);
            this.label70.TabIndex = 208;
            this.label70.Text = "°C";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.ForeColor = System.Drawing.Color.Blue;
            this.label46.Location = new System.Drawing.Point(70, 706);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(359, 18);
            this.label46.TabIndex = 204;
            this.label46.Text = "Current IC with maximum voltage unbalance 1.5%:";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.ForeColor = System.Drawing.Color.Blue;
            this.label48.Location = new System.Drawing.Point(579, 706);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(17, 18);
            this.label48.TabIndex = 205;
            this.label48.Text = "A";
            // 
            // InputCurrentICWithMaxVoltUnbalancePercent1point5
            // 
            this.InputCurrentICWithMaxVoltUnbalancePercent1point5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.motortestdataBindingSource, "InputCurrentICWithMaxVoltUnbalancePercent1point5", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.InputCurrentICWithMaxVoltUnbalancePercent1point5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputCurrentICWithMaxVoltUnbalancePercent1point5.Location = new System.Drawing.Point(481, 703);
            this.InputCurrentICWithMaxVoltUnbalancePercent1point5.Name = "InputCurrentICWithMaxVoltUnbalancePercent1point5";
            this.InputCurrentICWithMaxVoltUnbalancePercent1point5.Size = new System.Drawing.Size(75, 25);
            this.InputCurrentICWithMaxVoltUnbalancePercent1point5.TabIndex = 22;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.ForeColor = System.Drawing.Color.Blue;
            this.label49.Location = new System.Drawing.Point(70, 676);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(359, 18);
            this.label49.TabIndex = 201;
            this.label49.Text = "Current IB with maximum voltage unbalance 1.5%:";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.ForeColor = System.Drawing.Color.Blue;
            this.label50.Location = new System.Drawing.Point(579, 676);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(17, 18);
            this.label50.TabIndex = 202;
            this.label50.Text = "A";
            // 
            // InputCurrentIBWithMaxVoltUnbalancePercent1point5
            // 
            this.InputCurrentIBWithMaxVoltUnbalancePercent1point5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.motortestdataBindingSource, "InputCurrentIBWithMaxVoltUnbalancePercent1point5", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.InputCurrentIBWithMaxVoltUnbalancePercent1point5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputCurrentIBWithMaxVoltUnbalancePercent1point5.Location = new System.Drawing.Point(481, 673);
            this.InputCurrentIBWithMaxVoltUnbalancePercent1point5.Name = "InputCurrentIBWithMaxVoltUnbalancePercent1point5";
            this.InputCurrentIBWithMaxVoltUnbalancePercent1point5.Size = new System.Drawing.Size(75, 25);
            this.InputCurrentIBWithMaxVoltUnbalancePercent1point5.TabIndex = 21;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label51.ForeColor = System.Drawing.Color.Blue;
            this.label51.Location = new System.Drawing.Point(70, 646);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(356, 18);
            this.label51.TabIndex = 198;
            this.label51.Text = "Current IA with maximum voltage unbalance 1.5%:";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.ForeColor = System.Drawing.Color.Blue;
            this.label52.Location = new System.Drawing.Point(579, 646);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(17, 18);
            this.label52.TabIndex = 199;
            this.label52.Text = "A";
            // 
            // InputCurrentIAWithMaxVoltUnbalancePercent1point5
            // 
            this.InputCurrentIAWithMaxVoltUnbalancePercent1point5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.motortestdataBindingSource, "InputCurrentIAWithMaxVoltUnbalancePercent1point5", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.InputCurrentIAWithMaxVoltUnbalancePercent1point5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputCurrentIAWithMaxVoltUnbalancePercent1point5.Location = new System.Drawing.Point(481, 643);
            this.InputCurrentIAWithMaxVoltUnbalancePercent1point5.Name = "InputCurrentIAWithMaxVoltUnbalancePercent1point5";
            this.InputCurrentIAWithMaxVoltUnbalancePercent1point5.Size = new System.Drawing.Size(75, 25);
            this.InputCurrentIAWithMaxVoltUnbalancePercent1point5.TabIndex = 20;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.ForeColor = System.Drawing.Color.Blue;
            this.label47.Location = new System.Drawing.Point(70, 616);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(321, 18);
            this.label47.TabIndex = 196;
            this.label47.Text = "Is Voltage Unbalance Smaller or Equal 1.5%?";
            // 
            // OutputIsMAVDSmallerThanPercent1point5
            // 
            this.OutputIsMAVDSmallerThanPercent1point5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.OutputIsMAVDSmallerThanPercent1point5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.motortestdataBindingSource, "OutputIsMAVDSmallerThanPercent1point5", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.OutputIsMAVDSmallerThanPercent1point5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputIsMAVDSmallerThanPercent1point5.Location = new System.Drawing.Point(481, 613);
            this.OutputIsMAVDSmallerThanPercent1point5.Name = "OutputIsMAVDSmallerThanPercent1point5";
            this.OutputIsMAVDSmallerThanPercent1point5.ReadOnly = true;
            this.OutputIsMAVDSmallerThanPercent1point5.Size = new System.Drawing.Size(75, 25);
            this.OutputIsMAVDSmallerThanPercent1point5.TabIndex = 195;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.ForeColor = System.Drawing.Color.Blue;
            this.label44.Location = new System.Drawing.Point(70, 586);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(85, 18);
            this.label44.TabIndex = 193;
            this.label44.Text = "Voltage Vc:";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.ForeColor = System.Drawing.Color.Blue;
            this.label45.Location = new System.Drawing.Point(579, 586);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(17, 18);
            this.label45.TabIndex = 194;
            this.label45.Text = "V";
            // 
            // InputVoltVc
            // 
            this.InputVoltVc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.motortestdataBindingSource, "InputVoltVc", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.InputVoltVc.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputVoltVc.Location = new System.Drawing.Point(481, 583);
            this.InputVoltVc.Name = "InputVoltVc";
            this.InputVoltVc.Size = new System.Drawing.Size(75, 25);
            this.InputVoltVc.TabIndex = 19;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.ForeColor = System.Drawing.Color.Blue;
            this.label42.Location = new System.Drawing.Point(70, 556);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(86, 18);
            this.label42.TabIndex = 190;
            this.label42.Text = "Voltage Vb:";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.ForeColor = System.Drawing.Color.Blue;
            this.label43.Location = new System.Drawing.Point(579, 556);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(17, 18);
            this.label43.TabIndex = 191;
            this.label43.Text = "V";
            // 
            // InputVoltVb
            // 
            this.InputVoltVb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.motortestdataBindingSource, "InputVoltVb", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.InputVoltVb.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputVoltVb.Location = new System.Drawing.Point(481, 553);
            this.InputVoltVb.Name = "InputVoltVb";
            this.InputVoltVb.Size = new System.Drawing.Size(75, 25);
            this.InputVoltVb.TabIndex = 18;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.ForeColor = System.Drawing.Color.Blue;
            this.label40.Location = new System.Drawing.Point(70, 526);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(84, 18);
            this.label40.TabIndex = 187;
            this.label40.Text = "Voltage Va:";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.ForeColor = System.Drawing.Color.Blue;
            this.label41.Location = new System.Drawing.Point(579, 526);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(17, 18);
            this.label41.TabIndex = 188;
            this.label41.Text = "V";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(649, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 18);
            this.label10.TabIndex = 120;
            this.label10.Text = "Motor Temperature:";
            // 
            // InputMotorTemp
            // 
            this.InputMotorTemp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.motortestdataBindingSource, "InputMotorTemp", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.InputMotorTemp.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputMotorTemp.Location = new System.Drawing.Point(1077, 201);
            this.InputMotorTemp.Name = "InputMotorTemp";
            this.InputMotorTemp.Size = new System.Drawing.Size(75, 25);
            this.InputMotorTemp.TabIndex = 23;
            // 
            // InputVoltVa
            // 
            this.InputVoltVa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.motortestdataBindingSource, "InputVoltVa", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.InputVoltVa.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputVoltVa.Location = new System.Drawing.Point(481, 523);
            this.InputVoltVa.Name = "InputVoltVa";
            this.InputVoltVa.Size = new System.Drawing.Size(75, 25);
            this.InputVoltVa.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(1169, 204);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 18);
            this.label11.TabIndex = 123;
            this.label11.Text = "°C";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.ForeColor = System.Drawing.Color.Blue;
            this.label39.Location = new System.Drawing.Point(70, 478);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(280, 36);
            this.label39.TabIndex = 185;
            this.label39.Text = "Start clock once full voltage test starts\r\nNameplate voltage 60Hz operation";
            // 
            // InputMotorWindingResistanceAB
            // 
            this.InputMotorWindingResistanceAB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.motortestdataBindingSource, "InputMotorWindingResistanceAB", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.InputMotorWindingResistanceAB.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputMotorWindingResistanceAB.Location = new System.Drawing.Point(1077, 232);
            this.InputMotorWindingResistanceAB.Name = "InputMotorWindingResistanceAB";
            this.InputMotorWindingResistanceAB.Size = new System.Drawing.Size(75, 25);
            this.InputMotorWindingResistanceAB.TabIndex = 24;
            // 
            // InputMotorWindingResistanceABAfterIdle
            // 
            this.InputMotorWindingResistanceABAfterIdle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.motortestdataBindingSource, "InputMotorWindingResistanceABAfterIdle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.InputMotorWindingResistanceABAfterIdle.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputMotorWindingResistanceABAfterIdle.Location = new System.Drawing.Point(1078, 513);
            this.InputMotorWindingResistanceABAfterIdle.Name = "InputMotorWindingResistanceABAfterIdle";
            this.InputMotorWindingResistanceABAfterIdle.Size = new System.Drawing.Size(75, 25);
            this.InputMotorWindingResistanceABAfterIdle.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Blue;
            this.label13.Location = new System.Drawing.Point(1175, 235);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 18);
            this.label13.TabIndex = 125;
            this.label13.Text = "Ω";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label57.ForeColor = System.Drawing.Color.Blue;
            this.label57.Location = new System.Drawing.Point(649, 486);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(374, 18);
            this.label57.TabIndex = 183;
            this.label57.Text = "Motor Temperature For ohms and megs Verification:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Location = new System.Drawing.Point(649, 235);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(342, 18);
            this.label12.TabIndex = 124;
            this.label12.Text = "Motor Winding Resistance, Phase A to Phase B:";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label59.ForeColor = System.Drawing.Color.Blue;
            this.label59.Location = new System.Drawing.Point(1176, 516);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(20, 18);
            this.label59.TabIndex = 151;
            this.label59.Text = "Ω";
            // 
            // InputMotorWindingResistanceBC
            // 
            this.InputMotorWindingResistanceBC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.motortestdataBindingSource, "InputMotorWindingResistanceBC", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.InputMotorWindingResistanceBC.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputMotorWindingResistanceBC.Location = new System.Drawing.Point(1077, 261);
            this.InputMotorWindingResistanceBC.Name = "InputMotorWindingResistanceBC";
            this.InputMotorWindingResistanceBC.Size = new System.Drawing.Size(75, 25);
            this.InputMotorWindingResistanceBC.TabIndex = 25;
            // 
            // InputMotorTempAfterIdle
            // 
            this.InputMotorTempAfterIdle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.motortestdataBindingSource, "InputMotorTempAfterIdle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.InputMotorTempAfterIdle.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputMotorTempAfterIdle.Location = new System.Drawing.Point(1077, 479);
            this.InputMotorTempAfterIdle.Name = "InputMotorTempAfterIdle";
            this.InputMotorTempAfterIdle.Size = new System.Drawing.Size(75, 25);
            this.InputMotorTempAfterIdle.TabIndex = 29;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Blue;
            this.label15.Location = new System.Drawing.Point(1175, 264);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(20, 18);
            this.label15.TabIndex = 127;
            this.label15.Text = "Ω";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label60.ForeColor = System.Drawing.Color.Blue;
            this.label60.Location = new System.Drawing.Point(650, 516);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(342, 18);
            this.label60.TabIndex = 149;
            this.label60.Text = "Motor Winding Resistance, Phase A to Phase B:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Blue;
            this.label14.Location = new System.Drawing.Point(649, 264);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(346, 18);
            this.label14.TabIndex = 126;
            this.label14.Text = "Motor Winding Resistance, Phase B to Phase C:";
            // 
            // InputMotorWindingResistanceBCAfterIdle
            // 
            this.InputMotorWindingResistanceBCAfterIdle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.motortestdataBindingSource, "InputMotorWindingResistanceBCAfterIdle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.InputMotorWindingResistanceBCAfterIdle.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputMotorWindingResistanceBCAfterIdle.Location = new System.Drawing.Point(1078, 542);
            this.InputMotorWindingResistanceBCAfterIdle.Name = "InputMotorWindingResistanceBCAfterIdle";
            this.InputMotorWindingResistanceBCAfterIdle.Size = new System.Drawing.Size(75, 25);
            this.InputMotorWindingResistanceBCAfterIdle.TabIndex = 31;
            // 
            // InputMotorWindingResistanceCA
            // 
            this.InputMotorWindingResistanceCA.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.motortestdataBindingSource, "InputMotorWindingResistanceCA", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.InputMotorWindingResistanceCA.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputMotorWindingResistanceCA.Location = new System.Drawing.Point(1077, 290);
            this.InputMotorWindingResistanceCA.Name = "InputMotorWindingResistanceCA";
            this.InputMotorWindingResistanceCA.Size = new System.Drawing.Size(75, 25);
            this.InputMotorWindingResistanceCA.TabIndex = 26;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label58.ForeColor = System.Drawing.Color.Blue;
            this.label58.Location = new System.Drawing.Point(1169, 482);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(25, 18);
            this.label58.TabIndex = 184;
            this.label58.Text = "°C";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Blue;
            this.label17.Location = new System.Drawing.Point(1175, 293);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(20, 18);
            this.label17.TabIndex = 129;
            this.label17.Text = "Ω";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label61.ForeColor = System.Drawing.Color.Blue;
            this.label61.Location = new System.Drawing.Point(1176, 545);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(20, 18);
            this.label61.TabIndex = 155;
            this.label61.Text = "Ω";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Blue;
            this.label16.Location = new System.Drawing.Point(649, 293);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(343, 18);
            this.label16.TabIndex = 128;
            this.label16.Text = "Motor Winding Resistance, Phase C to Phase A:\r\n";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label55.ForeColor = System.Drawing.Color.Blue;
            this.label55.Location = new System.Drawing.Point(649, 449);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(391, 18);
            this.label55.TabIndex = 180;
            this.label55.Text = "RPM at 60Hz When Motor Reached Temperature 60°C:";
            // 
            // OutputInsulationResistanceCheckMinVoltRequired
            // 
            this.OutputInsulationResistanceCheckMinVoltRequired.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.OutputInsulationResistanceCheckMinVoltRequired.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.motortestdataBindingSource, "OutputInsulationResistanceCheckMinVoltRequired", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.OutputInsulationResistanceCheckMinVoltRequired.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputInsulationResistanceCheckMinVoltRequired.Location = new System.Drawing.Point(1077, 319);
            this.OutputInsulationResistanceCheckMinVoltRequired.Name = "OutputInsulationResistanceCheckMinVoltRequired";
            this.OutputInsulationResistanceCheckMinVoltRequired.ReadOnly = true;
            this.OutputInsulationResistanceCheckMinVoltRequired.Size = new System.Drawing.Size(75, 25);
            this.OutputInsulationResistanceCheckMinVoltRequired.TabIndex = 130;
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label62.ForeColor = System.Drawing.Color.Blue;
            this.label62.Location = new System.Drawing.Point(650, 545);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(346, 18);
            this.label62.TabIndex = 153;
            this.label62.Text = "Motor Winding Resistance, Phase B to Phase C:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Blue;
            this.label19.Location = new System.Drawing.Point(1177, 322);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(17, 18);
            this.label19.TabIndex = 132;
            this.label19.Text = "V";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label56.ForeColor = System.Drawing.Color.Blue;
            this.label56.Location = new System.Drawing.Point(1169, 449);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(42, 18);
            this.label56.TabIndex = 181;
            this.label56.Text = "RPM";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Blue;
            this.label18.Location = new System.Drawing.Point(649, 322);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(397, 18);
            this.label18.TabIndex = 131;
            this.label18.Text = "insulation resistance check, minimum voltage required:";
            // 
            // InputMotorWindingResistanceCAAfterIdle
            // 
            this.InputMotorWindingResistanceCAAfterIdle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.motortestdataBindingSource, "InputMotorWindingResistanceCAAfterIdle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.InputMotorWindingResistanceCAAfterIdle.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputMotorWindingResistanceCAAfterIdle.Location = new System.Drawing.Point(1078, 571);
            this.InputMotorWindingResistanceCAAfterIdle.Name = "InputMotorWindingResistanceCAAfterIdle";
            this.InputMotorWindingResistanceCAAfterIdle.Size = new System.Drawing.Size(75, 25);
            this.InputMotorWindingResistanceCAAfterIdle.TabIndex = 32;
            // 
            // InputMeasuredInsulationResistance
            // 
            this.InputMeasuredInsulationResistance.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.motortestdataBindingSource, "InputMeasuredInsulationResistance", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.InputMeasuredInsulationResistance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputMeasuredInsulationResistance.Location = new System.Drawing.Point(1077, 348);
            this.InputMeasuredInsulationResistance.Name = "InputMeasuredInsulationResistance";
            this.InputMeasuredInsulationResistance.Size = new System.Drawing.Size(75, 25);
            this.InputMeasuredInsulationResistance.TabIndex = 27;
            // 
            // InputRPMAt60HzWhenMotorTempReached60C
            // 
            this.InputRPMAt60HzWhenMotorTempReached60C.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.motortestdataBindingSource, "InputRPMAt60HzWhenMotorTempReached60C", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.InputRPMAt60HzWhenMotorTempReached60C.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputRPMAt60HzWhenMotorTempReached60C.Location = new System.Drawing.Point(1077, 446);
            this.InputRPMAt60HzWhenMotorTempReached60C.Name = "InputRPMAt60HzWhenMotorTempReached60C";
            this.InputRPMAt60HzWhenMotorTempReached60C.Size = new System.Drawing.Size(75, 25);
            this.InputRPMAt60HzWhenMotorTempReached60C.TabIndex = 28;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Blue;
            this.label21.Location = new System.Drawing.Point(1169, 351);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(33, 18);
            this.label21.TabIndex = 135;
            this.label21.Text = "MΩ";
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label63.ForeColor = System.Drawing.Color.Blue;
            this.label63.Location = new System.Drawing.Point(1176, 574);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(20, 18);
            this.label63.TabIndex = 158;
            this.label63.Text = "Ω";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Blue;
            this.label22.Location = new System.Drawing.Point(649, 380);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(392, 18);
            this.label22.TabIndex = 137;
            this.label22.Text = "Insulation Resistance (in meg-ohms) corrected to 40°C";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label53.ForeColor = System.Drawing.Color.Blue;
            this.label53.Location = new System.Drawing.Point(649, 730);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(419, 18);
            this.label53.TabIndex = 143;
            this.label53.Text = "Motor Temperature Rise After 11 Minutes of Full Volts Test";
            this.label53.Visible = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Blue;
            this.label20.Location = new System.Drawing.Point(649, 351);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(205, 18);
            this.label20.TabIndex = 134;
            this.label20.Text = "insulation resistance check:";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label64.ForeColor = System.Drawing.Color.Blue;
            this.label64.Location = new System.Drawing.Point(650, 574);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(343, 18);
            this.label64.TabIndex = 156;
            this.label64.Text = "Motor Winding Resistance, Phase C to Phase A:\r\n";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Blue;
            this.label23.Location = new System.Drawing.Point(1169, 380);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(33, 18);
            this.label23.TabIndex = 138;
            this.label23.Text = "MΩ";
            // 
            // InputMotorTempRiseAfter11MinutesOfFullVoltTest
            // 
            this.InputMotorTempRiseAfter11MinutesOfFullVoltTest.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.motortestdataBindingSource, "InputMotorTempRiseAfter11MinutesOfFullVoltTest", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.InputMotorTempRiseAfter11MinutesOfFullVoltTest.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputMotorTempRiseAfter11MinutesOfFullVoltTest.Location = new System.Drawing.Point(1077, 723);
            this.InputMotorTempRiseAfter11MinutesOfFullVoltTest.Name = "InputMotorTempRiseAfter11MinutesOfFullVoltTest";
            this.InputMotorTempRiseAfter11MinutesOfFullVoltTest.Size = new System.Drawing.Size(75, 25);
            this.InputMotorTempRiseAfter11MinutesOfFullVoltTest.TabIndex = 36;
            this.InputMotorTempRiseAfter11MinutesOfFullVoltTest.Visible = false;
            // 
            // OutputInsulationResistanceCorrectedTo40C
            // 
            this.OutputInsulationResistanceCorrectedTo40C.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.OutputInsulationResistanceCorrectedTo40C.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.motortestdataBindingSource, "OutputInsulationResistanceCorrectedTo40C", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.OutputInsulationResistanceCorrectedTo40C.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputInsulationResistanceCorrectedTo40C.Location = new System.Drawing.Point(1077, 377);
            this.OutputInsulationResistanceCorrectedTo40C.Name = "OutputInsulationResistanceCorrectedTo40C";
            this.OutputInsulationResistanceCorrectedTo40C.ReadOnly = true;
            this.OutputInsulationResistanceCorrectedTo40C.Size = new System.Drawing.Size(75, 25);
            this.OutputInsulationResistanceCorrectedTo40C.TabIndex = 136;
            // 
            // OutputInsulationResistanceCheckMinVoltRequiredAfterIdle
            // 
            this.OutputInsulationResistanceCheckMinVoltRequiredAfterIdle.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.OutputInsulationResistanceCheckMinVoltRequiredAfterIdle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.motortestdataBindingSource, "OutputInsulationResistanceCheckMinVoltRequired", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.OutputInsulationResistanceCheckMinVoltRequiredAfterIdle.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputInsulationResistanceCheckMinVoltRequiredAfterIdle.Location = new System.Drawing.Point(1078, 600);
            this.OutputInsulationResistanceCheckMinVoltRequiredAfterIdle.Name = "OutputInsulationResistanceCheckMinVoltRequiredAfterIdle";
            this.OutputInsulationResistanceCheckMinVoltRequiredAfterIdle.ReadOnly = true;
            this.OutputInsulationResistanceCheckMinVoltRequiredAfterIdle.Size = new System.Drawing.Size(75, 25);
            this.OutputInsulationResistanceCheckMinVoltRequiredAfterIdle.TabIndex = 160;
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label65.ForeColor = System.Drawing.Color.Blue;
            this.label65.Location = new System.Drawing.Point(1178, 603);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(17, 18);
            this.label65.TabIndex = 165;
            this.label65.Text = "V";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54.ForeColor = System.Drawing.Color.Blue;
            this.label54.Location = new System.Drawing.Point(1169, 726);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(25, 18);
            this.label54.TabIndex = 146;
            this.label54.Text = "°C";
            this.label54.Visible = false;
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label66.ForeColor = System.Drawing.Color.Blue;
            this.label66.Location = new System.Drawing.Point(650, 603);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(397, 18);
            this.label66.TabIndex = 162;
            this.label66.Text = "insulation resistance check, minimum voltage required:";
            // 
            // InputMeasuredInsulationResistanceAfterIdle
            // 
            this.InputMeasuredInsulationResistanceAfterIdle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.motortestdataBindingSource, "InputMeasuredInsulationResistanceAfterIdle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.InputMeasuredInsulationResistanceAfterIdle.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputMeasuredInsulationResistanceAfterIdle.Location = new System.Drawing.Point(1078, 629);
            this.InputMeasuredInsulationResistanceAfterIdle.Name = "InputMeasuredInsulationResistanceAfterIdle";
            this.InputMeasuredInsulationResistanceAfterIdle.Size = new System.Drawing.Size(75, 25);
            this.InputMeasuredInsulationResistanceAfterIdle.TabIndex = 33;
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label67.ForeColor = System.Drawing.Color.Blue;
            this.label67.Location = new System.Drawing.Point(1170, 632);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(33, 18);
            this.label67.TabIndex = 169;
            this.label67.Text = "MΩ";
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label68.ForeColor = System.Drawing.Color.Blue;
            this.label68.Location = new System.Drawing.Point(650, 632);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(205, 18);
            this.label68.TabIndex = 168;
            this.label68.Text = "insulation resistance check:";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.ForeColor = System.Drawing.Color.Blue;
            this.label37.Location = new System.Drawing.Point(70, 448);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(210, 18);
            this.label37.TabIndex = 177;
            this.label37.Text = "RPM After Low Voltage Start:";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.ForeColor = System.Drawing.Color.Blue;
            this.label38.Location = new System.Drawing.Point(566, 448);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(42, 18);
            this.label38.TabIndex = 178;
            this.label38.Text = "RPM";
            // 
            // InputRPMAfterLowVoltStart
            // 
            this.InputRPMAfterLowVoltStart.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.motortestdataBindingSource, "InputRPMAfterLowVoltStart", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.InputRPMAfterLowVoltStart.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputRPMAfterLowVoltStart.Location = new System.Drawing.Point(481, 445);
            this.InputRPMAfterLowVoltStart.Name = "InputRPMAfterLowVoltStart";
            this.InputRPMAfterLowVoltStart.Size = new System.Drawing.Size(75, 25);
            this.InputRPMAfterLowVoltStart.TabIndex = 16;
            // 
            // InputChooseDidMotorStartedWithLowVoltAt60Hz
            // 
            this.InputChooseDidMotorStartedWithLowVoltAt60Hz.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.motortestdataBindingSource, "InputChooseDidMotorStartedWithLowVoltAt60Hz", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.InputChooseDidMotorStartedWithLowVoltAt60Hz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InputChooseDidMotorStartedWithLowVoltAt60Hz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InputChooseDidMotorStartedWithLowVoltAt60Hz.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputChooseDidMotorStartedWithLowVoltAt60Hz.FormattingEnabled = true;
            this.InputChooseDidMotorStartedWithLowVoltAt60Hz.Items.AddRange(new object[] {
            "NO",
            "YES"});
            this.InputChooseDidMotorStartedWithLowVoltAt60Hz.Location = new System.Drawing.Point(481, 415);
            this.InputChooseDidMotorStartedWithLowVoltAt60Hz.Name = "InputChooseDidMotorStartedWithLowVoltAt60Hz";
            this.InputChooseDidMotorStartedWithLowVoltAt60Hz.Size = new System.Drawing.Size(94, 25);
            this.InputChooseDidMotorStartedWithLowVoltAt60Hz.TabIndex = 15;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.Color.Blue;
            this.label36.Location = new System.Drawing.Point(70, 418);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(323, 18);
            this.label36.TabIndex = 174;
            this.label36.Text = "Did Motor Started With Low Voltage At 60Hz?";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.Color.Blue;
            this.label34.Location = new System.Drawing.Point(70, 388);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(385, 18);
            this.label34.TabIndex = 172;
            this.label34.Text = "Recommended Voltage For Low Voltage Start At 60Hz:";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.Color.Blue;
            this.label35.Location = new System.Drawing.Point(579, 388);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(17, 18);
            this.label35.TabIndex = 173;
            this.label35.Text = "V";
            // 
            // OutputRecommendedLowVoltStartAt60Hz
            // 
            this.OutputRecommendedLowVoltStartAt60Hz.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.OutputRecommendedLowVoltStartAt60Hz.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.motortestdataBindingSource, "OutputRecommendedLowVoltStartAt60Hz", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.OutputRecommendedLowVoltStartAt60Hz.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputRecommendedLowVoltStartAt60Hz.Location = new System.Drawing.Point(481, 385);
            this.OutputRecommendedLowVoltStartAt60Hz.Name = "OutputRecommendedLowVoltStartAt60Hz";
            this.OutputRecommendedLowVoltStartAt60Hz.ReadOnly = true;
            this.OutputRecommendedLowVoltStartAt60Hz.Size = new System.Drawing.Size(75, 25);
            this.OutputRecommendedLowVoltStartAt60Hz.TabIndex = 40;
            // 
            // InputChooseIsAirTestPassed
            // 
            this.InputChooseIsAirTestPassed.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.motortestdataBindingSource, "InputChooseIsAirTestPassed", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.InputChooseIsAirTestPassed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InputChooseIsAirTestPassed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InputChooseIsAirTestPassed.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputChooseIsAirTestPassed.FormattingEnabled = true;
            this.InputChooseIsAirTestPassed.Items.AddRange(new object[] {
            "NO",
            "YES"});
            this.InputChooseIsAirTestPassed.Location = new System.Drawing.Point(481, 355);
            this.InputChooseIsAirTestPassed.Name = "InputChooseIsAirTestPassed";
            this.InputChooseIsAirTestPassed.Size = new System.Drawing.Size(94, 25);
            this.InputChooseIsAirTestPassed.TabIndex = 14;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.Color.Blue;
            this.label33.Location = new System.Drawing.Point(70, 358);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(110, 18);
            this.label33.TabIndex = 167;
            this.label33.Text = "AirTestPassed";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.Color.Blue;
            this.label31.Location = new System.Drawing.Point(70, 328);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(134, 18);
            this.label31.TabIndex = 163;
            this.label31.Text = "Oil Quality Check:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.Color.Blue;
            this.label32.Location = new System.Drawing.Point(575, 328);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(25, 18);
            this.label32.TabIndex = 164;
            this.label32.Text = "kV";
            // 
            // InputOilQualityCheck
            // 
            this.InputOilQualityCheck.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.motortestdataBindingSource, "InputOilQualityCheck", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.InputOilQualityCheck.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputOilQualityCheck.Location = new System.Drawing.Point(481, 325);
            this.InputOilQualityCheck.Name = "InputOilQualityCheck";
            this.InputOilQualityCheck.Size = new System.Drawing.Size(75, 25);
            this.InputOilQualityCheck.TabIndex = 13;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.Blue;
            this.label29.Location = new System.Drawing.Point(70, 298);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(48, 18);
            this.label29.TabIndex = 157;
            this.label29.Text = "Base:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.Blue;
            this.label30.Location = new System.Drawing.Point(571, 298);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(32, 18);
            this.label30.TabIndex = 159;
            this.label30.Text = "mm";
            // 
            // InputShaftExtensionBase
            // 
            this.InputShaftExtensionBase.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.motortestdataBindingSource, "InputShaftExtensionBase", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.InputShaftExtensionBase.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputShaftExtensionBase.Location = new System.Drawing.Point(481, 295);
            this.InputShaftExtensionBase.Name = "InputShaftExtensionBase";
            this.InputShaftExtensionBase.Size = new System.Drawing.Size(75, 25);
            this.InputShaftExtensionBase.TabIndex = 12;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.Blue;
            this.label27.Location = new System.Drawing.Point(70, 268);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(49, 18);
            this.label27.TabIndex = 150;
            this.label27.Text = "Head:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.Blue;
            this.label28.Location = new System.Drawing.Point(571, 268);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(32, 18);
            this.label28.TabIndex = 152;
            this.label28.Text = "mm";
            // 
            // InputShaftExtensionHead
            // 
            this.InputShaftExtensionHead.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.motortestdataBindingSource, "InputShaftExtensionHead", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.InputShaftExtensionHead.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputShaftExtensionHead.Location = new System.Drawing.Point(481, 265);
            this.InputShaftExtensionHead.Name = "InputShaftExtensionHead";
            this.InputShaftExtensionHead.Size = new System.Drawing.Size(75, 25);
            this.InputShaftExtensionHead.TabIndex = 11;
            // 
            // InputChooseMotorConfigForShaftExtension
            // 
            this.InputChooseMotorConfigForShaftExtension.BackColor = System.Drawing.SystemColors.Window;
            this.InputChooseMotorConfigForShaftExtension.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.motortestdataBindingSource, "InputChooseMotorConfigForShaftExtension", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.InputChooseMotorConfigForShaftExtension.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InputChooseMotorConfigForShaftExtension.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InputChooseMotorConfigForShaftExtension.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputChooseMotorConfigForShaftExtension.FormattingEnabled = true;
            this.InputChooseMotorConfigForShaftExtension.Items.AddRange(new object[] {
            "UT",
            "CT"});
            this.InputChooseMotorConfigForShaftExtension.Location = new System.Drawing.Point(481, 235);
            this.InputChooseMotorConfigForShaftExtension.Name = "InputChooseMotorConfigForShaftExtension";
            this.InputChooseMotorConfigForShaftExtension.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.InputChooseMotorConfigForShaftExtension.Size = new System.Drawing.Size(94, 25);
            this.InputChooseMotorConfigForShaftExtension.TabIndex = 10;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Blue;
            this.label24.Location = new System.Drawing.Point(70, 208);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(118, 18);
            this.label24.TabIndex = 142;
            this.label24.Text = "Shaft Side Play:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.Blue;
            this.label26.Location = new System.Drawing.Point(70, 238);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(304, 18);
            this.label26.TabIndex = 122;
            this.label26.Text = "Choose Configuration for Shaft Extension";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.Blue;
            this.label25.Location = new System.Drawing.Point(571, 208);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(32, 18);
            this.label25.TabIndex = 145;
            this.label25.Text = "mm";
            // 
            // InputShaftSidePlay
            // 
            this.InputShaftSidePlay.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.motortestdataBindingSource, "InputShaftSidePlay", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.InputShaftSidePlay.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputShaftSidePlay.Location = new System.Drawing.Point(481, 205);
            this.InputShaftSidePlay.Name = "InputShaftSidePlay";
            this.InputShaftSidePlay.Size = new System.Drawing.Size(75, 25);
            this.InputShaftSidePlay.TabIndex = 9;
            // 
            // ButtonUpdate
            // 
            this.ButtonUpdate.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonUpdate.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ButtonUpdate.Location = new System.Drawing.Point(930, 149);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.Size = new System.Drawing.Size(96, 31);
            this.ButtonUpdate.TabIndex = 211;
            this.ButtonUpdate.Text = "Update Test";
            this.ButtonUpdate.UseVisualStyleBackColor = false;
            this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label73.ForeColor = System.Drawing.Color.Blue;
            this.label73.Location = new System.Drawing.Point(649, 415);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(168, 18);
            this.label73.TabIndex = 213;
            this.label73.Text = "Runtime for IDLE Test:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label6.Location = new System.Drawing.Point(70, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 214;
            this.label6.Text = "Report ID:";
            // 
            // InputReportID
            // 
            this.InputReportID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.motortestdataBindingSource, "InputReportID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.InputReportID.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputReportID.Location = new System.Drawing.Point(166, 146);
            this.InputReportID.Name = "InputReportID";
            this.InputReportID.Size = new System.Drawing.Size(183, 25);
            this.InputReportID.TabIndex = 215;
            this.InputReportID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // InputRuntimeForIdleTest
            // 
            this.InputRuntimeForIdleTest.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.motortestdataBindingSource, "InputRuntimeForIdleTest", true));
            this.InputRuntimeForIdleTest.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputRuntimeForIdleTest.Location = new System.Drawing.Point(1077, 412);
            this.InputRuntimeForIdleTest.Name = "InputRuntimeForIdleTest";
            this.InputRuntimeForIdleTest.Size = new System.Drawing.Size(75, 25);
            this.InputRuntimeForIdleTest.TabIndex = 216;
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label74.ForeColor = System.Drawing.Color.Blue;
            this.label74.Location = new System.Drawing.Point(1169, 415);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(34, 18);
            this.label74.TabIndex = 217;
            this.label74.Text = "Min";
            // 
            // motortestdataBindingSource
            // 
            this.motortestdataBindingSource.DataSource = typeof(MotorTest.Motor_test_data);
            // 
            // InputDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 757);
            this.Controls.Add(this.label74);
            this.Controls.Add(this.InputRuntimeForIdleTest);
            this.Controls.Add(this.InputReportID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label73);
            this.Controls.Add(this.ButtonUpdate);
            this.Controls.Add(this.InputMonthCalendar);
            this.Controls.Add(this.label71);
            this.Controls.Add(this.InputPITestForMotorAtTempBellow38C);
            this.Controls.Add(this.label69);
            this.Controls.Add(this.InputTempAtWhichPIWasPerformed);
            this.Controls.Add(this.label70);
            this.Controls.Add(this.label46);
            this.Controls.Add(this.label48);
            this.Controls.Add(this.InputCurrentICWithMaxVoltUnbalancePercent1point5);
            this.Controls.Add(this.label49);
            this.Controls.Add(this.label50);
            this.Controls.Add(this.InputCurrentIBWithMaxVoltUnbalancePercent1point5);
            this.Controls.Add(this.label51);
            this.Controls.Add(this.label52);
            this.Controls.Add(this.InputCurrentIAWithMaxVoltUnbalancePercent1point5);
            this.Controls.Add(this.label47);
            this.Controls.Add(this.OutputIsMAVDSmallerThanPercent1point5);
            this.Controls.Add(this.label44);
            this.Controls.Add(this.label45);
            this.Controls.Add(this.InputVoltVc);
            this.Controls.Add(this.label42);
            this.Controls.Add(this.label43);
            this.Controls.Add(this.InputVoltVb);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.InputMotorTemp);
            this.Controls.Add(this.InputVoltVa);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.InputMotorWindingResistanceAB);
            this.Controls.Add(this.InputMotorWindingResistanceABAfterIdle);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label57);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label59);
            this.Controls.Add(this.InputMotorWindingResistanceBC);
            this.Controls.Add(this.InputMotorTempAfterIdle);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label60);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.InputMotorWindingResistanceBCAfterIdle);
            this.Controls.Add(this.InputMotorWindingResistanceCA);
            this.Controls.Add(this.label58);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label61);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label55);
            this.Controls.Add(this.OutputInsulationResistanceCheckMinVoltRequired);
            this.Controls.Add(this.label62);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label56);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.InputMotorWindingResistanceCAAfterIdle);
            this.Controls.Add(this.InputMeasuredInsulationResistance);
            this.Controls.Add(this.InputRPMAt60HzWhenMotorTempReached60C);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label63);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label53);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label64);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.InputMotorTempRiseAfter11MinutesOfFullVoltTest);
            this.Controls.Add(this.OutputInsulationResistanceCorrectedTo40C);
            this.Controls.Add(this.OutputInsulationResistanceCheckMinVoltRequiredAfterIdle);
            this.Controls.Add(this.label65);
            this.Controls.Add(this.label54);
            this.Controls.Add(this.label66);
            this.Controls.Add(this.InputMeasuredInsulationResistanceAfterIdle);
            this.Controls.Add(this.label67);
            this.Controls.Add(this.label68);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.InputRPMAfterLowVoltStart);
            this.Controls.Add(this.InputChooseDidMotorStartedWithLowVoltAt60Hz);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.OutputRecommendedLowVoltStartAt60Hz);
            this.Controls.Add(this.InputChooseIsAirTestPassed);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.InputOilQualityCheck);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.InputShaftExtensionBase);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.InputShaftExtensionHead);
            this.Controls.Add(this.InputChooseMotorConfigForShaftExtension);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.InputShaftSidePlay);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ButtonReport);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.ButtonClear);
            this.Controls.Add(this.InputChooseLoadData);
            this.Controls.Add(this.label72);
            this.Controls.Add(this.InputChooseModel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.InputChooseSeries);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.InputChooseSupplier);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.InputTestDate);
            this.Controls.Add(this.InputTestedBy);
            this.Controls.Add(this.InputMotorSN);
            this.Controls.Add(this.InputFieldName);
            this.Controls.Add(this.InputCustomerName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "InputDlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Motor Test Bench";
            this.Load += new System.EventHandler(this.InputDlg_Load);
            this.Click += new System.EventHandler(this.InputDlg_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motortestdataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox InputCustomerName;
        private System.Windows.Forms.TextBox InputFieldName;
        private System.Windows.Forms.TextBox InputTestedBy;
        private System.Windows.Forms.TextBox InputMotorSN;
        private System.Windows.Forms.TextBox InputTestDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox InputChooseSupplier;
        private System.Windows.Forms.ComboBox InputChooseSeries;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox InputChooseModel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MonthCalendar InputMonthCalendar;
        private System.Windows.Forms.ComboBox InputChooseLoadData;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.Button ButtonClear;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonReport;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource motortestdataBindingSource;
        private Label label71;
        private TextBox InputPITestForMotorAtTempBellow38C;
        private Label label69;
        private TextBox InputTempAtWhichPIWasPerformed;
        private Label label70;
        private Label label46;
        private Label label48;
        private TextBox InputCurrentICWithMaxVoltUnbalancePercent1point5;
        private Label label49;
        private Label label50;
        private TextBox InputCurrentIBWithMaxVoltUnbalancePercent1point5;
        private Label label51;
        private Label label52;
        private TextBox InputCurrentIAWithMaxVoltUnbalancePercent1point5;
        private Label label47;
        private TextBox OutputIsMAVDSmallerThanPercent1point5;
        private Label label44;
        private Label label45;
        private TextBox InputVoltVc;
        private Label label42;
        private Label label43;
        private TextBox InputVoltVb;
        private Label label40;
        private Label label41;
        private Label label10;
        private TextBox InputMotorTemp;
        private TextBox InputVoltVa;
        private Label label11;
        private Label label39;
        private TextBox InputMotorWindingResistanceAB;
        private TextBox InputMotorWindingResistanceABAfterIdle;
        private Label label13;
        private Label label57;
        private Label label12;
        private Label label59;
        private TextBox InputMotorWindingResistanceBC;
        private TextBox InputMotorTempAfterIdle;
        private Label label15;
        private Label label60;
        private Label label14;
        private TextBox InputMotorWindingResistanceBCAfterIdle;
        private TextBox InputMotorWindingResistanceCA;
        private Label label58;
        private Label label17;
        private Label label61;
        private Label label16;
        private Label label55;
        private TextBox OutputInsulationResistanceCheckMinVoltRequired;
        private Label label62;
        private Label label19;
        private Label label56;
        private Label label18;
        private TextBox InputMotorWindingResistanceCAAfterIdle;
        private TextBox InputMeasuredInsulationResistance;
        private TextBox InputRPMAt60HzWhenMotorTempReached60C;
        private Label label21;
        private Label label63;
        private Label label22;
        private Label label53;
        private Label label20;
        private Label label64;
        private Label label23;
        private TextBox InputMotorTempRiseAfter11MinutesOfFullVoltTest;
        private TextBox OutputInsulationResistanceCorrectedTo40C;
        private TextBox OutputInsulationResistanceCheckMinVoltRequiredAfterIdle;
        private Label label65;
        private Label label54;
        private Label label66;
        private TextBox InputMeasuredInsulationResistanceAfterIdle;
        private Label label67;
        private Label label68;
        private Label label37;
        private Label label38;
        private TextBox InputRPMAfterLowVoltStart;
        private ComboBox InputChooseDidMotorStartedWithLowVoltAt60Hz;
        private Label label36;
        private Label label34;
        private Label label35;
        private TextBox OutputRecommendedLowVoltStartAt60Hz;
        private ComboBox InputChooseIsAirTestPassed;
        private Label label33;
        private Label label31;
        private Label label32;
        private TextBox InputOilQualityCheck;
        private Label label29;
        private Label label30;
        private TextBox InputShaftExtensionBase;
        private Label label27;
        private Label label28;
        private TextBox InputShaftExtensionHead;
        private ComboBox InputChooseMotorConfigForShaftExtension;
        private Label label24;
        private Label label26;
        private Label label25;
        private TextBox InputShaftSidePlay;
        private Button ButtonUpdate;
        private Label label73;
        private Label label6;
        private TextBox InputReportID;
        private TextBox InputRuntimeForIdleTest;
        private Label label74;
    }
}

