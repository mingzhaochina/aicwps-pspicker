namespace system
{
    partial class FormRunOption
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRunOption));
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDefault = new System.Windows.Forms.Button();
            this.groupBoxSetting = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.qComboBoxMultithreading = new Qios.DevSuite.Components.QComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.qTextBoxProbability = new Qios.DevSuite.Components.QTextBox();
            this.qComboBoxDevice = new Qios.DevSuite.Components.QComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.qTextBoxPfNum = new Qios.DevSuite.Components.QTextBox();
            this.qComboBoxPrintPicture = new Qios.DevSuite.Components.QComboBox();
            this.qComboBoxOutputType = new Qios.DevSuite.Components.QComboBox();
            this.groupBoxPath = new System.Windows.Forms.GroupBox();
            this.buttonChangeDocker = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.LbDockerPath = new System.Windows.Forms.Label();
            this.LbOutputPath = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LbInputPath = new System.Windows.Forms.Label();
            this.buttonChangeOutput = new System.Windows.Forms.Button();
            this.buttonChangeInput = new System.Windows.Forms.Button();
            this.groupBoxSetting.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBoxPath.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSave.Location = new System.Drawing.Point(88, 241);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(92, 27);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonDefault
            // 
            this.buttonDefault.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonDefault.Location = new System.Drawing.Point(226, 241);
            this.buttonDefault.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDefault.Name = "buttonDefault";
            this.buttonDefault.Size = new System.Drawing.Size(92, 27);
            this.buttonDefault.TabIndex = 2;
            this.buttonDefault.Text = "Defult";
            this.buttonDefault.UseVisualStyleBackColor = true;
            this.buttonDefault.Click += new System.EventHandler(this.buttonDefault_Click);
            // 
            // groupBoxSetting
            // 
            this.groupBoxSetting.Controls.Add(this.buttonSave);
            this.groupBoxSetting.Controls.Add(this.buttonDefault);
            this.groupBoxSetting.Controls.Add(this.tableLayoutPanel1);
            this.groupBoxSetting.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBoxSetting.Location = new System.Drawing.Point(12, 12);
            this.groupBoxSetting.Name = "groupBoxSetting";
            this.groupBoxSetting.Size = new System.Drawing.Size(409, 286);
            this.groupBoxSetting.TabIndex = 3;
            this.groupBoxSetting.TabStop = false;
            this.groupBoxSetting.Text = "Algorithm";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.5841F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.4159F));
            this.tableLayoutPanel1.Controls.Add(this.qComboBoxMultithreading, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.qTextBoxProbability, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.qComboBoxDevice, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.qComboBoxOutputType, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 19);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(399, 206);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // qComboBoxMultithreading
            // 
            this.qComboBoxMultithreading.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.qComboBoxMultithreading.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.qComboBoxMultithreading.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.qComboBoxMultithreading.Location = new System.Drawing.Point(101, 89);
            this.qComboBoxMultithreading.Name = "qComboBoxMultithreading";
            this.qComboBoxMultithreading.Size = new System.Drawing.Size(279, 26);
            this.qComboBoxMultithreading.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(2, 164);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 42);
            this.label5.TabIndex = 8;
            this.label5.Text = "Print picture";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // qTextBoxProbability
            // 
            this.qTextBoxProbability.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.qTextBoxProbability.CueText = "Floating point number : 0~1";
            this.qTextBoxProbability.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.qTextBoxProbability.Location = new System.Drawing.Point(101, 7);
            this.qTextBoxProbability.Name = "qTextBoxProbability";
            this.qTextBoxProbability.Size = new System.Drawing.Size(279, 26);
            this.qTextBoxProbability.TabIndex = 24;
            // 
            // qComboBoxDevice
            // 
            this.qComboBoxDevice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.qComboBoxDevice.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.qComboBoxDevice.Items.AddRange(new object[] {
            "cpu",
            "gpu",
            "fpga"});
            this.qComboBoxDevice.Location = new System.Drawing.Point(101, 48);
            this.qComboBoxDevice.Name = "qComboBoxDevice";
            this.qComboBoxDevice.Size = new System.Drawing.Size(279, 26);
            this.qComboBoxDevice.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(2, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 41);
            this.label4.TabIndex = 6;
            this.label4.Text = "Output type";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(2, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 41);
            this.label3.TabIndex = 4;
            this.label3.Text = "Multithreading";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(94, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Probability threshold";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(2, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "Operating equipment";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.Controls.Add(this.qTextBoxPfNum, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.qComboBoxPrintPicture, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(100, 166);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(297, 38);
            this.tableLayoutPanel3.TabIndex = 27;
            // 
            // qTextBoxPfNum
            // 
            this.qTextBoxPfNum.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.qTextBoxPfNum.CueText = "Integer";
            this.qTextBoxPfNum.Enabled = false;
            this.qTextBoxPfNum.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.qTextBoxPfNum.Location = new System.Drawing.Point(210, 6);
            this.qTextBoxPfNum.Name = "qTextBoxPfNum";
            this.qTextBoxPfNum.Size = new System.Drawing.Size(79, 26);
            this.qTextBoxPfNum.TabIndex = 25;
            // 
            // qComboBoxPrintPicture
            // 
            this.qComboBoxPrintPicture.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.qComboBoxPrintPicture.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.qComboBoxPrintPicture.Items.AddRange(new object[] {
            "pt",
            "pl",
            "pf"});
            this.qComboBoxPrintPicture.Location = new System.Drawing.Point(3, 6);
            this.qComboBoxPrintPicture.Name = "qComboBoxPrintPicture";
            this.qComboBoxPrintPicture.Size = new System.Drawing.Size(190, 26);
            this.qComboBoxPrintPicture.TabIndex = 27;
            this.qComboBoxPrintPicture.TextChanged += new System.EventHandler(this.qComboBoxPrintPicture_TextChanged);
            // 
            // qComboBoxOutputType
            // 
            this.qComboBoxOutputType.Dock = System.Windows.Forms.DockStyle.Left;
            this.qComboBoxOutputType.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.qComboBoxOutputType.Items.AddRange(new object[] {
            "csv",
            "json",
            "jopens"});
            this.qComboBoxOutputType.Location = new System.Drawing.Point(101, 126);
            this.qComboBoxOutputType.Name = "qComboBoxOutputType";
            this.qComboBoxOutputType.Size = new System.Drawing.Size(277, 26);
            this.qComboBoxOutputType.TabIndex = 26;
            // 
            // groupBoxPath
            // 
            this.groupBoxPath.Controls.Add(this.buttonChangeDocker);
            this.groupBoxPath.Controls.Add(this.tableLayoutPanel2);
            this.groupBoxPath.Controls.Add(this.buttonChangeOutput);
            this.groupBoxPath.Controls.Add(this.buttonChangeInput);
            this.groupBoxPath.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBoxPath.Location = new System.Drawing.Point(427, 12);
            this.groupBoxPath.Name = "groupBoxPath";
            this.groupBoxPath.Size = new System.Drawing.Size(410, 151);
            this.groupBoxPath.TabIndex = 4;
            this.groupBoxPath.TabStop = false;
            this.groupBoxPath.Text = "Path";
            // 
            // buttonChangeDocker
            // 
            this.buttonChangeDocker.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonChangeDocker.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonChangeDocker.Location = new System.Drawing.Point(335, 106);
            this.buttonChangeDocker.Margin = new System.Windows.Forms.Padding(2);
            this.buttonChangeDocker.Name = "buttonChangeDocker";
            this.buttonChangeDocker.Size = new System.Drawing.Size(60, 26);
            this.buttonChangeDocker.TabIndex = 33;
            this.buttonChangeDocker.Text = "Change";
            this.buttonChangeDocker.UseVisualStyleBackColor = true;
            this.buttonChangeDocker.Click += new System.EventHandler(this.buttonChangeDocker_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.65517F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.34483F));
            this.tableLayoutPanel2.Controls.Add(this.LbDockerPath, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.LbOutputPath, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.LbInputPath, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(5, 19);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(326, 122);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // LbDockerPath
            // 
            this.LbDockerPath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LbDockerPath.AutoSize = true;
            this.LbDockerPath.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LbDockerPath.Location = new System.Drawing.Point(98, 92);
            this.LbDockerPath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbDockerPath.Name = "LbDockerPath";
            this.LbDockerPath.Size = new System.Drawing.Size(0, 17);
            this.LbDockerPath.TabIndex = 35;
            // 
            // LbOutputPath
            // 
            this.LbOutputPath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LbOutputPath.AutoSize = true;
            this.LbOutputPath.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LbOutputPath.Location = new System.Drawing.Point(98, 51);
            this.LbOutputPath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbOutputPath.Name = "LbOutputPath";
            this.LbOutputPath.Size = new System.Drawing.Size(0, 17);
            this.LbOutputPath.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(2, 80);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 42);
            this.label8.TabIndex = 30;
            this.label8.Text = "Docker path";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(2, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(92, 40);
            this.label6.TabIndex = 0;
            this.label6.Text = "Input path";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(2, 40);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 40);
            this.label7.TabIndex = 1;
            this.label7.Text = "Output path";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbInputPath
            // 
            this.LbInputPath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LbInputPath.AutoSize = true;
            this.LbInputPath.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LbInputPath.Location = new System.Drawing.Point(98, 11);
            this.LbInputPath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbInputPath.Name = "LbInputPath";
            this.LbInputPath.Size = new System.Drawing.Size(0, 17);
            this.LbInputPath.TabIndex = 31;
            // 
            // buttonChangeOutput
            // 
            this.buttonChangeOutput.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonChangeOutput.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonChangeOutput.Location = new System.Drawing.Point(335, 65);
            this.buttonChangeOutput.Margin = new System.Windows.Forms.Padding(2);
            this.buttonChangeOutput.Name = "buttonChangeOutput";
            this.buttonChangeOutput.Size = new System.Drawing.Size(60, 26);
            this.buttonChangeOutput.TabIndex = 32;
            this.buttonChangeOutput.Text = "Change";
            this.buttonChangeOutput.UseVisualStyleBackColor = true;
            this.buttonChangeOutput.Click += new System.EventHandler(this.buttonChangeOutput_Click);
            // 
            // buttonChangeInput
            // 
            this.buttonChangeInput.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonChangeInput.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonChangeInput.Location = new System.Drawing.Point(335, 26);
            this.buttonChangeInput.Margin = new System.Windows.Forms.Padding(2);
            this.buttonChangeInput.Name = "buttonChangeInput";
            this.buttonChangeInput.Size = new System.Drawing.Size(60, 26);
            this.buttonChangeInput.TabIndex = 31;
            this.buttonChangeInput.Text = "Change";
            this.buttonChangeInput.UseVisualStyleBackColor = true;
            this.buttonChangeInput.Click += new System.EventHandler(this.buttonChangeInput_Click);
            // 
            // FormRunOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 555);
            this.Controls.Add(this.groupBoxSetting);
            this.Controls.Add(this.groupBoxPath);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormRunOption";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.FormRunOption_Load);
            this.groupBoxSetting.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBoxPath.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDefault;
        private System.Windows.Forms.GroupBox groupBoxSetting;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxPath;
        private Qios.DevSuite.Components.QTextBox qTextBoxProbability;
        private Qios.DevSuite.Components.QComboBox qComboBoxDevice;
        private Qios.DevSuite.Components.QComboBox qComboBoxMultithreading;
        private System.Windows.Forms.Button buttonChangeDocker;
        private System.Windows.Forms.Button buttonChangeOutput;
        private System.Windows.Forms.Button buttonChangeInput;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label LbDockerPath;
        private System.Windows.Forms.Label LbOutputPath;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LbInputPath;
        private Qios.DevSuite.Components.QComboBox qComboBoxPrintPicture;
        private Qios.DevSuite.Components.QComboBox qComboBoxOutputType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private Qios.DevSuite.Components.QTextBox qTextBoxPfNum;
    }
}