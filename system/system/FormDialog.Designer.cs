namespace system
{
    partial class FormDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDialog));
            this.ButtonOpenFile = new System.Windows.Forms.Button();
            this.TextBoxDialog = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.LabelDialog = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.SuspendLayout();
            // 
            // ButtonOpenFile
            // 
            this.ButtonOpenFile.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButtonOpenFile.Location = new System.Drawing.Point(47, 57);
            this.ButtonOpenFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonOpenFile.Name = "ButtonOpenFile";
            this.ButtonOpenFile.Size = new System.Drawing.Size(134, 43);
            this.ButtonOpenFile.TabIndex = 0;
            this.ButtonOpenFile.Text = "Choose file";
            this.ButtonOpenFile.UseVisualStyleBackColor = true;
            this.ButtonOpenFile.Click += new System.EventHandler(this.ButtonOpenFile_Click);
            // 
            // TextBoxDialog
            // 
            this.TextBoxDialog.Location = new System.Drawing.Point(47, 145);
            this.TextBoxDialog.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxDialog.Name = "TextBoxDialog";
            this.TextBoxDialog.Size = new System.Drawing.Size(796, 351);
            this.TextBoxDialog.TabIndex = 2;
            this.TextBoxDialog.Text = "";
            // 
            // LabelDialog
            // 
            this.LabelDialog.Location = new System.Drawing.Point(47, 117);
            this.LabelDialog.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LabelDialog.Name = "LabelDialog";
            this.LabelDialog.Size = new System.Drawing.Size(77, 20);
            this.LabelDialog.TabIndex = 3;
            this.LabelDialog.Values.Text = "File selected";
            // 
            // FormDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 540);
            this.Controls.Add(this.LabelDialog);
            this.Controls.Add(this.TextBoxDialog);
            this.Controls.Add(this.ButtonOpenFile);
            this.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormDialog";
            this.RightToLeftLayout = true;
            this.Text = "Dialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonOpenFile;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox TextBoxDialog;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel LabelDialog;
    }
}