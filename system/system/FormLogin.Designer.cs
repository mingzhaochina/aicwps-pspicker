namespace system
{
    partial class FormLogin
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonSetting = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonEnter = new System.Windows.Forms.Button();
            this.TextBoxUsername = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAnyUser = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.TextBoxPassword = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAnyPassword = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.qComboBoxVersion = new Qios.DevSuite.Components.QComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.qComboBoxLanguage = new Qios.DevSuite.Components.QComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(57, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(57, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password:";
            // 
            // ButtonSetting
            // 
            this.ButtonSetting.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButtonSetting.Location = new System.Drawing.Point(330, 234);
            this.ButtonSetting.Name = "ButtonSetting";
            this.ButtonSetting.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonSetting.Size = new System.Drawing.Size(85, 30);
            this.ButtonSetting.TabIndex = 12;
            this.ButtonSetting.Text = "Setting";
            this.ButtonSetting.UseVisualStyleBackColor = true;
            this.ButtonSetting.Click += new System.EventHandler(this.ButtonSetting_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButtonCancel.Location = new System.Drawing.Point(202, 234);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(85, 30);
            this.ButtonCancel.TabIndex = 11;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonEnter
            // 
            this.ButtonEnter.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButtonEnter.Location = new System.Drawing.Point(74, 233);
            this.ButtonEnter.Name = "ButtonEnter";
            this.ButtonEnter.Size = new System.Drawing.Size(85, 30);
            this.ButtonEnter.TabIndex = 4;
            this.ButtonEnter.Text = "OK";
            this.ButtonEnter.UseVisualStyleBackColor = true;
            this.ButtonEnter.Click += new System.EventHandler(this.ButtonEnter_Click);
            // 
            // TextBoxUsername
            // 
            this.TextBoxUsername.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAnyUser});
            this.TextBoxUsername.Location = new System.Drawing.Point(149, 50);
            this.TextBoxUsername.Name = "TextBoxUsername";
            this.TextBoxUsername.Size = new System.Drawing.Size(266, 26);
            this.TextBoxUsername.StateActive.Border.Color1 = System.Drawing.Color.Silver;
            this.TextBoxUsername.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.TextBoxUsername.StateActive.Content.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBoxUsername.StateActive.Content.Padding = new System.Windows.Forms.Padding(2);
            this.TextBoxUsername.StateCommon.Content.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBoxUsername.StateCommon.Content.Padding = new System.Windows.Forms.Padding(2);
            this.TextBoxUsername.StateNormal.Content.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBoxUsername.TabIndex = 1;
            this.TextBoxUsername.UseMnemonic = false;
            this.TextBoxUsername.TextChanged += new System.EventHandler(this.kryptonTextBox1_TextChanged);
            // 
            // buttonSpecAnyUser
            // 
            this.buttonSpecAnyUser.Image = ((System.Drawing.Image)(resources.GetObject("buttonSpecAnyUser.Image")));
            this.buttonSpecAnyUser.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.ListItem;
            this.buttonSpecAnyUser.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.FormClose;
            this.buttonSpecAnyUser.UniqueName = "E69ED0B542CB4E75F9BC99A9D6FC6980";
            this.buttonSpecAnyUser.Click += new System.EventHandler(this.buttonSpecAnyUser_Click);
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAnyPassword});
            this.TextBoxPassword.Location = new System.Drawing.Point(149, 96);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.PasswordChar = '*';
            this.TextBoxPassword.Size = new System.Drawing.Size(266, 23);
            this.TextBoxPassword.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.TextBoxPassword.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.TextBoxPassword.TabIndex = 2;
            // 
            // buttonSpecAnyPassword
            // 
            this.buttonSpecAnyPassword.Image = ((System.Drawing.Image)(resources.GetObject("buttonSpecAnyPassword.Image")));
            this.buttonSpecAnyPassword.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.ListItem;
            this.buttonSpecAnyPassword.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.FormClose;
            this.buttonSpecAnyPassword.UniqueName = "E8EB795C959542904CBF6968CE4C09C7";
            this.buttonSpecAnyPassword.Click += new System.EventHandler(this.buttonSpecAnyPassword_Click);
            // 
            // qComboBoxVersion
            // 
            this.qComboBoxVersion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.qComboBoxVersion.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.qComboBoxVersion.Items.AddRange(new object[] {
            "Online",
            "Local"});
            this.qComboBoxVersion.Location = new System.Drawing.Point(149, 139);
            this.qComboBoxVersion.Name = "qComboBoxVersion";
            this.qComboBoxVersion.Size = new System.Drawing.Size(266, 26);
            this.qComboBoxVersion.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(57, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Version:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(57, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Language:";
            // 
            // qComboBoxLanguage
            // 
            this.qComboBoxLanguage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.qComboBoxLanguage.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.qComboBoxLanguage.Items.AddRange(new object[] {
            "English",
            "Chinese"});
            this.qComboBoxLanguage.Location = new System.Drawing.Point(149, 185);
            this.qComboBoxLanguage.Name = "qComboBoxLanguage";
            this.qComboBoxLanguage.Size = new System.Drawing.Size(266, 26);
            this.qComboBoxLanguage.TabIndex = 29;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 294);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.qComboBoxLanguage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.qComboBoxVersion);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.TextBoxUsername);
            this.Controls.Add(this.ButtonSetting);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonEnter);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(512, 333);
            this.MinimumSize = new System.Drawing.Size(512, 333);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AICWPS- PSPicker";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonSetting;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonEnter;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TextBoxUsername;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TextBoxPassword;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAnyUser;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAnyPassword;
        private Qios.DevSuite.Components.QComboBox qComboBoxVersion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Qios.DevSuite.Components.QComboBox qComboBoxLanguage;
    }
}

