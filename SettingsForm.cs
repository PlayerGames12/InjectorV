using System;
using System.Windows.Forms;

namespace InjectorV
{
    public partial class SettingsForm : Form
    {
        private Settings settings;

        public SettingsForm(Settings currentSettings)
        {
            InitializeComponent();
            settings = currentSettings;
            checkBoxAutoSelect.Checked = settings.AutoSelectLastProcess;
            textBoxLogFilePath.Text = settings.LogFilePath;
            checkBoxEnableLogging.Checked = settings.EnableLogging;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            settings.AutoSelectLastProcess = checkBoxAutoSelect.Checked;
            settings.LogFilePath = textBoxLogFilePath.Text;
            settings.EnableLogging = checkBoxEnableLogging.Checked;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        public Settings GetSettings()
        {
            return settings;
        }
    }
}