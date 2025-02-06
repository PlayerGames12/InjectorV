namespace InjectorV
{
    partial class SettingsForm
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
            this.checkBoxAutoSelect = new System.Windows.Forms.CheckBox();
            this.textBoxLogFilePath = new System.Windows.Forms.TextBox();
            this.checkBoxEnableLogging = new System.Windows.Forms.CheckBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // checkBoxAutoSelect
            //
            this.checkBoxAutoSelect.AutoSize = true;
            this.checkBoxAutoSelect.Location = new System.Drawing.Point(12, 12);
            this.checkBoxAutoSelect.Name = "checkBoxAutoSelect";
            this.checkBoxAutoSelect.Size = new System.Drawing.Size(168, 17);
            this.checkBoxAutoSelect.TabIndex = 0;
            this.checkBoxAutoSelect.Text = "Auto Select Last Process";
            this.checkBoxAutoSelect.UseVisualStyleBackColor = true;
            //
            // textBoxLogFilePath
            //
            this.textBoxLogFilePath.Location = new System.Drawing.Point(12, 41);
            this.textBoxLogFilePath.Name = "textBoxLogFilePath";
            this.textBoxLogFilePath.Size = new System.Drawing.Size(260, 20);
            this.textBoxLogFilePath.TabIndex = 1;
            //
            // checkBoxEnableLogging
            //
            this.checkBoxEnableLogging.AutoSize = true;
            this.checkBoxEnableLogging.Location = new System.Drawing.Point(12, 67);
            this.checkBoxEnableLogging.Name = "checkBoxEnableLogging";
            this.checkBoxEnableLogging.Size = new System.Drawing.Size(102, 17);
            this.checkBoxEnableLogging.TabIndex = 2;
            this.checkBoxEnableLogging.Text = "Enable Logging";
            this.checkBoxEnableLogging.UseVisualStyleBackColor = true;
            //
            // buttonSave
            //
            this.buttonSave.Location = new System.Drawing.Point(116, 96);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            //
            // buttonCancel
            //
            this.buttonCancel.Location = new System.Drawing.Point(197, 96);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            //
            // SettingsForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 131);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.checkBoxEnableLogging);
            this.Controls.Add(this.textBoxLogFilePath);
            this.Controls.Add(this.checkBoxAutoSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxAutoSelect;
        private System.Windows.Forms.TextBox textBoxLogFilePath;
        private System.Windows.Forms.CheckBox checkBoxEnableLogging;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}