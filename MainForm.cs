using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using System.IO;
using System.ComponentModel;

namespace InjectorV
{
    public partial class MainForm : Form
    {
        private List<Process> processes = new List<Process>();
        private string selectedDllPath = "";
        private Settings settings;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            settings = Settings.Load();

            LogHelper.Initialize(settings.LogFilePath, settings.EnableLogging);

            LoadProcesses();
            ApplySettings();
            LogHelper.Log("Приложение запущено");

            ApplyGuna2Styles();

            comboBoxInjectionMethod.DataSource = Enum.GetValues(typeof(InjectionMethod));
            comboBoxInjectionMethod.SelectedItem = settings.DefaultInjectionMethod;
        }


        private void ApplyGuna2Styles()
        {
            guna2Button_Inject.FillColor = Color.FromArgb(50, 150, 255);
            guna2Button_Refresh.FillColor = Color.FromArgb(100, 100, 100);
            guna2Button_Eject.FillColor = Color.FromArgb(200, 80, 80);

            guna2Panel1.FillColor = Color.FromArgb(30, 30, 30);

            this.BackColor = Color.FromArgb(240, 240, 240);
        }


        private void ApplySettings()
        {
            if (settings.AutoSelectLastProcess && !string.IsNullOrEmpty(settings.LastSelectedProcessName))
            {
                SelectLastProcess();
            }
        }

        private void SelectLastProcess()
        {
            if (processListView.IsHandleCreated)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    foreach (ListViewItem item in processListView.Items)
                    {
                        if (item.Text == settings.LastSelectedProcessName)
                        {
                            item.Selected = true;
                            processListView.Select();
                            return;
                        }
                    }
                });
            }
        }

        private void SaveSettings()
        {
            settings.LastSelectedProcessName = (processListView.SelectedItems.Count > 0) ? processListView.SelectedItems[0].Text : "";
            settings.DefaultInjectionMethod = (InjectionMethod)comboBoxInjectionMethod.SelectedItem;
            settings.Save();
        }

        private async void LoadProcesses()
        {
            await Task.Run(() =>
            {
                List<Process> tempProcesses = new List<Process>();

                try
                {
                    tempProcesses = ProcessHelper.GetRunningProcesses();
                    tempProcesses = ProcessHelper.FilterOutSystemProcesses(tempProcesses);
                    tempProcesses = ProcessHelper.FilterProcesses(tempProcesses, textBoxProcessFilter.Text, checkBoxShowOnlyWithWindows.Checked);

                    // Update the UI on the UI thread
                    this.Invoke((MethodInvoker)delegate
                    {
                        processes.Clear();
                        processListView.Items.Clear();


                        int imageIndex = 0;
                        foreach (Process process in tempProcesses)
                        {
                            ListViewItem item = new ListViewItem(process.ProcessName);
                            item.SubItems.Add(process.Id.ToString());

                            processListView.Items.Add(item);

                            imageIndex++;

                        }
                        processes = tempProcesses;
                    });

                }
                catch (Exception ex)
                {
                    LogHelper.LogError("Ошибка при загрузке процессов:", ex);

                    this.Invoke((MethodInvoker)delegate
                    {
                        MessageBox.Show($"Ошибка при загрузке процессов: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    });
                }
            });
        }



        private void guna2Button_Refresh_Click(object sender, EventArgs e)
        {
            LoadProcesses();
        }

        private void guna2Button_SelectDll_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "DLL files (*.dll)|*.dll";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedDllPath = openFileDialog.FileName;
                dllPathTextBox.Text = selectedDllPath;
                LogHelper.Log($"Выбран DLL файл: {selectedDllPath}");
            }
        }

        private async void guna2Button_Inject_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedDllPath))
            {
                MessageBox.Show("Выберите DLL файл!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (processListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберите процесс для инжекции!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            InjectionMethod selectedMethod = (InjectionMethod)comboBoxInjectionMethod.SelectedItem;

            int processId = 0;
            string processName = "";

            this.Invoke((MethodInvoker)delegate
            {
                ListViewItem selectedItem = processListView.SelectedItems[0];
                processId = int.Parse(selectedItem.SubItems[1].Text);
                processName = selectedItem.Text;
            });


            await Task.Run(() =>
            {
                try
                {


                    bool result = Injector.InjectDLL(processId, selectedDllPath, selectedMethod);

                    if (result)
                    {

                        this.Invoke((MethodInvoker)delegate
                        {
                            MessageBox.Show("DLL успешно инжектирована!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LoadProcesses();
                        });

                        LogHelper.Log($"DLL '{selectedDllPath}' успешно инжектирована в процесс {processId}.");
                    }
                    else
                    {
                        this.Invoke((MethodInvoker)delegate
                        {
                            MessageBox.Show("Не удалось инжектировать DLL.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        });
                        LogHelper.Log($"Не удалось инжектировать DLL '{selectedDllPath}' в процесс {processId}.");
                    }
                }
                catch (Win32Exception ex)
                {
                    LogHelper.LogError("Ошибка при инжекции DLL:", ex);
                    this.Invoke((MethodInvoker)delegate
                    {
                        MessageBox.Show($"Ошибка при инжекции DLL. Смотрите лог. Код ошибки: {ex.NativeErrorCode}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    });

                }
                catch (Exception ex)
                {
                    LogHelper.LogError("Ошибка при инжекции DLL:", ex);
                    this.Invoke((MethodInvoker)delegate
                    {
                        MessageBox.Show($"Ошибка при инжекции DLL. Смотрите лог.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    });

                }

            });
        }


        private void guna2Button_Eject_Click(object sender, EventArgs e)
        {
            if (processListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберите процесс для выгрузки DLL!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string moduleName = textBoxModuleName.Text;
            if (string.IsNullOrEmpty(moduleName))
            {
                MessageBox.Show("Введите имя модуля для выгрузки!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int processId = 0;

            this.Invoke((MethodInvoker)delegate
            {
                ListViewItem selectedItem = processListView.SelectedItems[0];
                processId = int.Parse(selectedItem.SubItems[1].Text);
            });


            bool result = Injector.EjectDLL(processId, moduleName);

            if (result)
            {
                MessageBox.Show("DLL успешно выгружена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LogHelper.Log($"DLL '{moduleName}' успешно выгружена из процесса {processId}.");
            }
            else
            {
                MessageBox.Show("Не удалось выгрузить DLL.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogHelper.Log($"Не удалось выгрузить DLL '{moduleName}' из процесса {processId}.");
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
            LogHelper.Log("Приложение закрывается.");
        }

        private void textBoxProcessFilter_TextChanged(object sender, EventArgs e)
        {
            LoadProcesses();
        }

        private void guna2Button_Settings_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm(settings);
            if (settingsForm.ShowDialog() == DialogResult.OK)
            {
                settings = settingsForm.GetSettings();
                settings.Save();
                LogHelper.Initialize(settings.LogFilePath, settings.EnableLogging);
                LogHelper.Log("Настройки применены.");
            }
        }

        private void guna2Button_OpenLog_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("notepad.exe", settings.LogFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось открыть файл журнала: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBoxShowOnlyWithWindows_CheckedChanged(object sender, EventArgs e)
        {
            LoadProcesses();
        }
    }
}