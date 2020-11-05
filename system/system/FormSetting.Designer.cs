namespace system
{
    partial class FormSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSetting));
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.LabelSystemname = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.buttonSpecAnyDB = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAnySQL = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.ConnectSaveButton = new System.Windows.Forms.Button();
            this.ConnectButtonTest = new System.Windows.Forms.Button();
            this.LabelLocalIP = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.LabelPassword = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.LabelUserName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.LabelDB = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.LabelSQL = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.buttonSpecAnyUsername = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAnyPassword = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAnySystem = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAnyFTP = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TextBoxFTP = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.TextBoxSystem = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.TextBoxPassword = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.TextBoxUsername = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.TextBoxSQL = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.TextBoxDB = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonManager1
            // 
            this.kryptonManager1.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.ProfessionalSystem;
            // 
            // LabelSystemname
            // 
            this.LabelSystemname.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LabelSystemname.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.SuperTip;
            this.LabelSystemname.Location = new System.Drawing.Point(8, 143);
            this.LabelSystemname.Margin = new System.Windows.Forms.Padding(1);
            this.LabelSystemname.Name = "LabelSystemname";
            this.LabelSystemname.Size = new System.Drawing.Size(108, 29);
            this.LabelSystemname.StateCommon.ShortText.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelSystemname.StateNormal.ShortText.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelSystemname.TabIndex = 4;
            this.LabelSystemname.Values.Text = "System name";
            // 
            // buttonSpecAnyDB
            // 
            this.buttonSpecAnyDB.Image = ((System.Drawing.Image)(resources.GetObject("buttonSpecAnyDB.Image")));
            this.buttonSpecAnyDB.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.ListItem;
            this.buttonSpecAnyDB.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.FormClose;
            this.buttonSpecAnyDB.UniqueName = "E69ED0B542CB4E75F9BC99A9D6FC6980";
            this.buttonSpecAnyDB.Click += new System.EventHandler(this.buttonSpecAnyDB_Click);
            // 
            // buttonSpecAnySQL
            // 
            this.buttonSpecAnySQL.Image = ((System.Drawing.Image)(resources.GetObject("buttonSpecAnySQL.Image")));
            this.buttonSpecAnySQL.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.ListItem;
            this.buttonSpecAnySQL.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.FormClose;
            this.buttonSpecAnySQL.UniqueName = "E69ED0B542CB4E75F9BC99A9D6FC6980";
            this.buttonSpecAnySQL.Click += new System.EventHandler(this.buttonSpecAnySQL_Click);
            // 
            // kryptonPanel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.kryptonPanel1, 2);
            this.kryptonPanel1.Controls.Add(this.ConnectSaveButton);
            this.kryptonPanel1.Controls.Add(this.ConnectButtonTest);
            this.kryptonPanel1.Location = new System.Drawing.Point(2, 212);
            this.kryptonPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.FormMain;
            this.kryptonPanel1.Size = new System.Drawing.Size(386, 43);
            this.kryptonPanel1.TabIndex = 21;
            // 
            // ConnectSaveButton
            // 
            this.ConnectSaveButton.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ConnectSaveButton.Location = new System.Drawing.Point(229, 10);
            this.ConnectSaveButton.Margin = new System.Windows.Forms.Padding(2);
            this.ConnectSaveButton.Name = "ConnectSaveButton";
            this.ConnectSaveButton.Size = new System.Drawing.Size(88, 26);
            this.ConnectSaveButton.TabIndex = 6;
            this.ConnectSaveButton.Text = "Save";
            this.ConnectSaveButton.UseVisualStyleBackColor = true;
            this.ConnectSaveButton.Click += new System.EventHandler(this.ConnectSaveButton_Click);
            // 
            // ConnectButtonTest
            // 
            this.ConnectButtonTest.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ConnectButtonTest.Location = new System.Drawing.Point(69, 10);
            this.ConnectButtonTest.Margin = new System.Windows.Forms.Padding(2);
            this.ConnectButtonTest.Name = "ConnectButtonTest";
            this.ConnectButtonTest.Size = new System.Drawing.Size(88, 26);
            this.ConnectButtonTest.TabIndex = 5;
            this.ConnectButtonTest.Text = "Test";
            this.ConnectButtonTest.UseVisualStyleBackColor = true;
            this.ConnectButtonTest.Click += new System.EventHandler(this.ConnectButtonTest_Click);
            // 
            // LabelLocalIP
            // 
            this.LabelLocalIP.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LabelLocalIP.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.SuperTip;
            this.LabelLocalIP.Location = new System.Drawing.Point(48, 178);
            this.LabelLocalIP.Margin = new System.Windows.Forms.Padding(1);
            this.LabelLocalIP.Name = "LabelLocalIP";
            this.LabelLocalIP.Size = new System.Drawing.Size(68, 29);
            this.LabelLocalIP.StateCommon.ShortText.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelLocalIP.StateNormal.ShortText.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelLocalIP.TabIndex = 5;
            this.LabelLocalIP.Values.Text = "Local ip";
            // 
            // LabelPassword
            // 
            this.LabelPassword.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LabelPassword.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.SuperTip;
            this.LabelPassword.Location = new System.Drawing.Point(35, 108);
            this.LabelPassword.Margin = new System.Windows.Forms.Padding(1);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(81, 29);
            this.LabelPassword.StateCommon.ShortText.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelPassword.StateNormal.ShortText.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelPassword.TabIndex = 3;
            this.LabelPassword.Values.Text = "Password";
            // 
            // LabelUserName
            // 
            this.LabelUserName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LabelUserName.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.SuperTip;
            this.LabelUserName.Location = new System.Drawing.Point(31, 73);
            this.LabelUserName.Margin = new System.Windows.Forms.Padding(1);
            this.LabelUserName.Name = "LabelUserName";
            this.LabelUserName.Size = new System.Drawing.Size(85, 29);
            this.LabelUserName.StateCommon.ShortText.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelUserName.StateNormal.ShortText.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelUserName.TabIndex = 2;
            this.LabelUserName.Values.Text = "Username";
            // 
            // LabelDB
            // 
            this.LabelDB.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LabelDB.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.SuperTip;
            this.LabelDB.Location = new System.Drawing.Point(14, 38);
            this.LabelDB.Margin = new System.Windows.Forms.Padding(1);
            this.LabelDB.Name = "LabelDB";
            this.LabelDB.Size = new System.Drawing.Size(102, 29);
            this.LabelDB.StateCommon.ShortText.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelDB.StateNormal.ShortText.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelDB.TabIndex = 1;
            this.LabelDB.Values.Text = "Server name";
            // 
            // LabelSQL
            // 
            this.LabelSQL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LabelSQL.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.SuperTip;
            this.LabelSQL.Location = new System.Drawing.Point(46, 3);
            this.LabelSQL.Margin = new System.Windows.Forms.Padding(1);
            this.LabelSQL.Name = "LabelSQL";
            this.LabelSQL.Size = new System.Drawing.Size(70, 29);
            this.LabelSQL.StateCommon.ShortText.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelSQL.StateNormal.ShortText.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelSQL.TabIndex = 0;
            this.LabelSQL.Values.Text = "Sever ip";
            // 
            // buttonSpecAnyUsername
            // 
            this.buttonSpecAnyUsername.Image = ((System.Drawing.Image)(resources.GetObject("buttonSpecAnyUsername.Image")));
            this.buttonSpecAnyUsername.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.ListItem;
            this.buttonSpecAnyUsername.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.FormClose;
            this.buttonSpecAnyUsername.UniqueName = "E69ED0B542CB4E75F9BC99A9D6FC6980";
            this.buttonSpecAnyUsername.Click += new System.EventHandler(this.buttonSpecAnyUsername_Click);
            // 
            // buttonSpecAnyPassword
            // 
            this.buttonSpecAnyPassword.Image = ((System.Drawing.Image)(resources.GetObject("buttonSpecAnyPassword.Image")));
            this.buttonSpecAnyPassword.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.ListItem;
            this.buttonSpecAnyPassword.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.FormClose;
            this.buttonSpecAnyPassword.UniqueName = "E69ED0B542CB4E75F9BC99A9D6FC6980";
            this.buttonSpecAnyPassword.Click += new System.EventHandler(this.buttonSpecAnyPassword_Click);
            // 
            // buttonSpecAnySystem
            // 
            this.buttonSpecAnySystem.Image = ((System.Drawing.Image)(resources.GetObject("buttonSpecAnySystem.Image")));
            this.buttonSpecAnySystem.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.ListItem;
            this.buttonSpecAnySystem.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.FormClose;
            this.buttonSpecAnySystem.UniqueName = "E69ED0B542CB4E75F9BC99A9D6FC6980";
            this.buttonSpecAnySystem.Click += new System.EventHandler(this.buttonSpecAnySystem_Click);
            // 
            // buttonSpecAnyFTP
            // 
            this.buttonSpecAnyFTP.Image = ((System.Drawing.Image)(resources.GetObject("buttonSpecAnyFTP.Image")));
            this.buttonSpecAnyFTP.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.ListItem;
            this.buttonSpecAnyFTP.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.FormClose;
            this.buttonSpecAnyFTP.UniqueName = "E69ED0B542CB4E75F9BC99A9D6FC6980";
            this.buttonSpecAnyFTP.Click += new System.EventHandler(this.buttonSpecAnyFTP_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.TextBoxFTP, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.TextBoxSystem, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.TextBoxPassword, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.TextBoxUsername, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.LabelSQL, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LabelDB, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LabelUserName, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.LabelPassword, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.LabelLocalIP, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.kryptonPanel1, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.TextBoxSQL, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.TextBoxDB, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.LabelSystemname, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(391, 256);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // TextBoxFTP
            // 
            this.TextBoxFTP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBoxFTP.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAnyFTP});
            this.TextBoxFTP.Location = new System.Drawing.Point(119, 180);
            this.TextBoxFTP.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxFTP.Name = "TextBoxFTP";
            this.TextBoxFTP.Size = new System.Drawing.Size(269, 24);
            this.TextBoxFTP.StateActive.Border.Color1 = System.Drawing.Color.Silver;
            this.TextBoxFTP.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.TextBoxFTP.StateCommon.Content.Padding = new System.Windows.Forms.Padding(2);
            this.TextBoxFTP.TabIndex = 21;
            this.TextBoxFTP.UseMnemonic = false;
            // 
            // TextBoxSystem
            // 
            this.TextBoxSystem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBoxSystem.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAnySystem});
            this.TextBoxSystem.Location = new System.Drawing.Point(119, 145);
            this.TextBoxSystem.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxSystem.Name = "TextBoxSystem";
            this.TextBoxSystem.Size = new System.Drawing.Size(269, 24);
            this.TextBoxSystem.StateActive.Border.Color1 = System.Drawing.Color.Silver;
            this.TextBoxSystem.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.TextBoxSystem.StateCommon.Content.Padding = new System.Windows.Forms.Padding(2);
            this.TextBoxSystem.TabIndex = 20;
            this.TextBoxSystem.UseMnemonic = false;
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBoxPassword.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAnyPassword});
            this.TextBoxPassword.Location = new System.Drawing.Point(119, 110);
            this.TextBoxPassword.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.PasswordChar = '●';
            this.TextBoxPassword.Size = new System.Drawing.Size(269, 24);
            this.TextBoxPassword.StateActive.Border.Color1 = System.Drawing.Color.Silver;
            this.TextBoxPassword.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.TextBoxPassword.StateCommon.Content.Padding = new System.Windows.Forms.Padding(2);
            this.TextBoxPassword.TabIndex = 19;
            this.TextBoxPassword.UseMnemonic = false;
            this.TextBoxPassword.UseSystemPasswordChar = true;
            // 
            // TextBoxUsername
            // 
            this.TextBoxUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBoxUsername.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAnyUsername});
            this.TextBoxUsername.Location = new System.Drawing.Point(119, 75);
            this.TextBoxUsername.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxUsername.Name = "TextBoxUsername";
            this.TextBoxUsername.Size = new System.Drawing.Size(269, 24);
            this.TextBoxUsername.StateActive.Border.Color1 = System.Drawing.Color.Silver;
            this.TextBoxUsername.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.TextBoxUsername.StateCommon.Content.Padding = new System.Windows.Forms.Padding(2);
            this.TextBoxUsername.TabIndex = 18;
            this.TextBoxUsername.UseMnemonic = false;
            // 
            // TextBoxSQL
            // 
            this.TextBoxSQL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBoxSQL.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAnySQL});
            this.TextBoxSQL.Location = new System.Drawing.Point(119, 5);
            this.TextBoxSQL.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxSQL.Name = "TextBoxSQL";
            this.TextBoxSQL.Size = new System.Drawing.Size(269, 24);
            this.TextBoxSQL.StateActive.Border.Color1 = System.Drawing.Color.Silver;
            this.TextBoxSQL.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.TextBoxSQL.StateCommon.Content.Padding = new System.Windows.Forms.Padding(2);
            this.TextBoxSQL.TabIndex = 16;
            this.TextBoxSQL.UseMnemonic = false;
            // 
            // TextBoxDB
            // 
            this.TextBoxDB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBoxDB.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAnyDB});
            this.TextBoxDB.Location = new System.Drawing.Point(119, 40);
            this.TextBoxDB.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxDB.Name = "TextBoxDB";
            this.TextBoxDB.Size = new System.Drawing.Size(269, 24);
            this.TextBoxDB.StateActive.Border.Color1 = System.Drawing.Color.Silver;
            this.TextBoxDB.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.TextBoxDB.StateCommon.Content.Padding = new System.Windows.Forms.Padding(2);
            this.TextBoxDB.TabIndex = 17;
            this.TextBoxDB.UseMnemonic = false;
            // 
            // FormSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 256);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSetting";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connection setting";
            this.Load += new System.EventHandler(this.FormSetting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel LabelSystemname;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAnyDB;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAnySQL;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TextBoxFTP;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAnyFTP;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TextBoxSystem;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAnySystem;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TextBoxPassword;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAnyPassword;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TextBoxUsername;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAnyUsername;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel LabelSQL;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel LabelDB;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel LabelUserName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel LabelPassword;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel LabelLocalIP;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TextBoxSQL;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TextBoxDB;
        private System.Windows.Forms.Button ConnectSaveButton;
        private System.Windows.Forms.Button ConnectButtonTest;
    }
}