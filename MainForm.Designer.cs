namespace InjectorV
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dllPathTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button_SelectDll = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button_Inject = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button_Refresh = new Guna.UI2.WinForms.Guna2Button();
            this.processListView = new System.Windows.Forms.ListView();
            this.columnHeaderProcessName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderProcessID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxProcessFilter = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxModuleName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button_Eject = new Guna.UI2.WinForms.Guna2Button();
            this.comboBoxInjectionMethod = new System.Windows.Forms.ComboBox();
            this.guna2Button_Settings = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button_OpenLog = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.checkBoxShowOnlyWithWindows = new System.Windows.Forms.CheckBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dllPathTextBox
            // 
            this.dllPathTextBox.BorderRadius = 5;
            this.dllPathTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dllPathTextBox.DefaultText = "";
            this.dllPathTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.dllPathTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.dllPathTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.dllPathTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.dllPathTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dllPathTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dllPathTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dllPathTextBox.Location = new System.Drawing.Point(12, 59);
            this.dllPathTextBox.Name = "dllPathTextBox";
            this.dllPathTextBox.PasswordChar = '\0';
            this.dllPathTextBox.PlaceholderText = "DLL Path";
            this.dllPathTextBox.SelectedText = "";
            this.dllPathTextBox.Size = new System.Drawing.Size(400, 36);
            this.dllPathTextBox.TabIndex = 0;
            // 
            // guna2Button_SelectDll
            // 
            this.guna2Button_SelectDll.BorderRadius = 5;
            this.guna2Button_SelectDll.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button_SelectDll.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button_SelectDll.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button_SelectDll.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button_SelectDll.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button_SelectDll.ForeColor = System.Drawing.Color.White;
            this.guna2Button_SelectDll.Location = new System.Drawing.Point(420, 59);
            this.guna2Button_SelectDll.Name = "guna2Button_SelectDll";
            this.guna2Button_SelectDll.Size = new System.Drawing.Size(100, 36);
            this.guna2Button_SelectDll.TabIndex = 1;
            this.guna2Button_SelectDll.Text = "Select DLL";
            this.guna2Button_SelectDll.Click += new System.EventHandler(this.guna2Button_SelectDll_Click);
            // 
            // guna2Button_Inject
            // 
            this.guna2Button_Inject.BorderRadius = 5;
            this.guna2Button_Inject.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button_Inject.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button_Inject.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button_Inject.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button_Inject.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button_Inject.ForeColor = System.Drawing.Color.White;
            this.guna2Button_Inject.Location = new System.Drawing.Point(526, 59);
            this.guna2Button_Inject.Name = "guna2Button_Inject";
            this.guna2Button_Inject.Size = new System.Drawing.Size(100, 36);
            this.guna2Button_Inject.TabIndex = 2;
            this.guna2Button_Inject.Text = "Inject";
            this.guna2Button_Inject.Click += new System.EventHandler(this.guna2Button_Inject_Click);
            // 
            // guna2Button_Refresh
            // 
            this.guna2Button_Refresh.BorderRadius = 5;
            this.guna2Button_Refresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button_Refresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button_Refresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button_Refresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button_Refresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button_Refresh.ForeColor = System.Drawing.Color.White;
            this.guna2Button_Refresh.Location = new System.Drawing.Point(12, 101);
            this.guna2Button_Refresh.Name = "guna2Button_Refresh";
            this.guna2Button_Refresh.Size = new System.Drawing.Size(100, 36);
            this.guna2Button_Refresh.TabIndex = 3;
            this.guna2Button_Refresh.Text = "Refresh";
            this.guna2Button_Refresh.Click += new System.EventHandler(this.guna2Button_Refresh_Click);
            // 
            // processListView
            // 
            this.processListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderProcessName,
            this.columnHeaderProcessID});
            this.processListView.FullRowSelect = true;
            this.processListView.HideSelection = false;
            this.processListView.Location = new System.Drawing.Point(12, 143);
            this.processListView.Name = "processListView";
            this.processListView.Size = new System.Drawing.Size(400, 250);
            this.processListView.TabIndex = 4;
            this.processListView.UseCompatibleStateImageBehavior = false;
            this.processListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderProcessName
            // 
            this.columnHeaderProcessName.Text = "Process Name";
            this.columnHeaderProcessName.Width = 200;
            // 
            // columnHeaderProcessID
            // 
            this.columnHeaderProcessID.Text = "Process ID";
            this.columnHeaderProcessID.Width = 80;
            // 
            // textBoxProcessFilter
            // 
            this.textBoxProcessFilter.BorderRadius = 5;
            this.textBoxProcessFilter.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxProcessFilter.DefaultText = "";
            this.textBoxProcessFilter.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxProcessFilter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxProcessFilter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxProcessFilter.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxProcessFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxProcessFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxProcessFilter.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxProcessFilter.Location = new System.Drawing.Point(118, 101);
            this.textBoxProcessFilter.Name = "textBoxProcessFilter";
            this.textBoxProcessFilter.PasswordChar = '\0';
            this.textBoxProcessFilter.PlaceholderText = "Filter Processes";
            this.textBoxProcessFilter.SelectedText = "";
            this.textBoxProcessFilter.Size = new System.Drawing.Size(294, 36);
            this.textBoxProcessFilter.TabIndex = 5;
            this.textBoxProcessFilter.TextChanged += new System.EventHandler(this.textBoxProcessFilter_TextChanged);
            // 
            // textBoxModuleName
            // 
            this.textBoxModuleName.BorderRadius = 5;
            this.textBoxModuleName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxModuleName.DefaultText = "";
            this.textBoxModuleName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxModuleName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxModuleName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxModuleName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxModuleName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxModuleName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxModuleName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxModuleName.Location = new System.Drawing.Point(420, 143);
            this.textBoxModuleName.Name = "textBoxModuleName";
            this.textBoxModuleName.PasswordChar = '\0';
            this.textBoxModuleName.PlaceholderText = "Module Name";
            this.textBoxModuleName.SelectedText = "";
            this.textBoxModuleName.Size = new System.Drawing.Size(206, 36);
            this.textBoxModuleName.TabIndex = 6;
            // 
            // guna2Button_Eject
            // 
            this.guna2Button_Eject.BorderRadius = 5;
            this.guna2Button_Eject.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button_Eject.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button_Eject.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button_Eject.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button_Eject.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button_Eject.ForeColor = System.Drawing.Color.White;
            this.guna2Button_Eject.Location = new System.Drawing.Point(420, 185);
            this.guna2Button_Eject.Name = "guna2Button_Eject";
            this.guna2Button_Eject.Size = new System.Drawing.Size(100, 36);
            this.guna2Button_Eject.TabIndex = 7;
            this.guna2Button_Eject.Text = "Eject";
            this.guna2Button_Eject.Click += new System.EventHandler(this.guna2Button_Eject_Click);
            // 
            // comboBoxInjectionMethod
            // 
            this.comboBoxInjectionMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxInjectionMethod.FormattingEnabled = true;
            this.comboBoxInjectionMethod.Location = new System.Drawing.Point(420, 227);
            this.comboBoxInjectionMethod.Name = "comboBoxInjectionMethod";
            this.comboBoxInjectionMethod.Size = new System.Drawing.Size(206, 21);
            this.comboBoxInjectionMethod.TabIndex = 8;
            // 
            // guna2Button_Settings
            // 
            this.guna2Button_Settings.BorderRadius = 5;
            this.guna2Button_Settings.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button_Settings.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button_Settings.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button_Settings.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button_Settings.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button_Settings.ForeColor = System.Drawing.Color.White;
            this.guna2Button_Settings.Location = new System.Drawing.Point(420, 254);
            this.guna2Button_Settings.Name = "guna2Button_Settings";
            this.guna2Button_Settings.Size = new System.Drawing.Size(100, 36);
            this.guna2Button_Settings.TabIndex = 9;
            this.guna2Button_Settings.Text = "Settings";
            this.guna2Button_Settings.Click += new System.EventHandler(this.guna2Button_Settings_Click);
            // 
            // guna2Button_OpenLog
            // 
            this.guna2Button_OpenLog.BorderRadius = 5;
            this.guna2Button_OpenLog.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button_OpenLog.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button_OpenLog.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button_OpenLog.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button_OpenLog.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button_OpenLog.ForeColor = System.Drawing.Color.White;
            this.guna2Button_OpenLog.Location = new System.Drawing.Point(420, 296);
            this.guna2Button_OpenLog.Name = "guna2Button_OpenLog";
            this.guna2Button_OpenLog.Size = new System.Drawing.Size(100, 36);
            this.guna2Button_OpenLog.TabIndex = 10;
            this.guna2Button_OpenLog.Text = "Open Log";
            this.guna2Button_OpenLog.Click += new System.EventHandler(this.guna2Button_OpenLog_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // checkBoxShowOnlyWithWindows
            // 
            this.checkBoxShowOnlyWithWindows.AutoSize = true;
            this.checkBoxShowOnlyWithWindows.Location = new System.Drawing.Point(420, 348);
            this.checkBoxShowOnlyWithWindows.Name = "checkBoxShowOnlyWithWindows";
            this.checkBoxShowOnlyWithWindows.Size = new System.Drawing.Size(141, 17);
            this.checkBoxShowOnlyWithWindows.TabIndex = 11;
            this.checkBoxShowOnlyWithWindows.Text = "Show only with windows";
            this.checkBoxShowOnlyWithWindows.UseVisualStyleBackColor = true;
            this.checkBoxShowOnlyWithWindows.CheckedChanged += new System.EventHandler(this.checkBoxShowOnlyWithWindows_CheckedChanged);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2Panel1.Controls.Add(this.guna2ControlBox1);
            this.guna2Panel1.Controls.Add(this.guna2ControlBox3);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(638, 37);
            this.guna2Panel1.TabIndex = 12;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(593, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 37);
            this.guna2ControlBox1.TabIndex = 3;
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2ControlBox3.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox3.Location = new System.Drawing.Point(542, 0);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(45, 37);
            this.guna2ControlBox3.TabIndex = 1;
            this.guna2ControlBox3.Click += new System.EventHandler(this.guna2ControlBox3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "InjectorV";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator1.Location = new System.Drawing.Point(-16, 30);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(677, 10);
            this.guna2Separator1.TabIndex = 13;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.guna2Panel1;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(638, 405);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.checkBoxShowOnlyWithWindows);
            this.Controls.Add(this.guna2Button_OpenLog);
            this.Controls.Add(this.guna2Button_Settings);
            this.Controls.Add(this.comboBoxInjectionMethod);
            this.Controls.Add(this.guna2Button_Eject);
            this.Controls.Add(this.textBoxModuleName);
            this.Controls.Add(this.textBoxProcessFilter);
            this.Controls.Add(this.processListView);
            this.Controls.Add(this.guna2Button_Refresh);
            this.Controls.Add(this.guna2Button_Inject);
            this.Controls.Add(this.guna2Button_SelectDll);
            this.Controls.Add(this.dllPathTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(638, 405);
            this.MinimumSize = new System.Drawing.Size(638, 405);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InjectorV";
            this.TransparencyKey = System.Drawing.Color.DimGray;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox dllPathTextBox;
        private Guna.UI2.WinForms.Guna2Button guna2Button_SelectDll;
        private Guna.UI2.WinForms.Guna2Button guna2Button_Inject;
        private Guna.UI2.WinForms.Guna2Button guna2Button_Refresh;
        private System.Windows.Forms.ListView processListView;
        private System.Windows.Forms.ColumnHeader columnHeaderProcessName;
        private System.Windows.Forms.ColumnHeader columnHeaderProcessID;
        private Guna.UI2.WinForms.Guna2TextBox textBoxProcessFilter;
        private Guna.UI2.WinForms.Guna2TextBox textBoxModuleName;
        private Guna.UI2.WinForms.Guna2Button guna2Button_Eject;
        private System.Windows.Forms.ComboBox comboBoxInjectionMethod;
        private Guna.UI2.WinForms.Guna2Button guna2Button_Settings;
        private Guna.UI2.WinForms.Guna2Button guna2Button_OpenLog;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.CheckBox checkBoxShowOnlyWithWindows;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}

