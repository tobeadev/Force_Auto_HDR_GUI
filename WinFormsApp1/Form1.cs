using Microsoft.Win32;
using System;

namespace WinFormsApp1
{
    public partial class FormForceAutoHDR : Form
    {
        public FormForceAutoHDR()
        {
            InitializeComponent();
        }

        private String fullPath = "";
        private String folderPath = "";
        private String fileName = "";
        private String registryPath = "";
        private String fullPathUninstall = "";
        private String fileNameUninstall = "";      

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            labelStatus.Text = "";
            fullPath = "";
            folderPath = "";
            fileName = "";
            registryPath = "";

        OpenFileDialog openFileDialogAppPath = new OpenFileDialog
            {

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "exe",
                Filter = "Execution File (*.exe)|*.exe",
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialogAppPath.ShowDialog() == DialogResult.OK)
            {
                fullPath = openFileDialogAppPath.FileName;
                textBoxPath.Text = fullPath;
#pragma warning disable CS8601 // Possible null reference assignment.
                folderPath = Path.GetDirectoryName(fullPath);
#pragma warning restore CS8601 // Possible null reference assignment.
                fileName = Path.GetFileNameWithoutExtension(fullPath);

            }
        }

        private void buttonInstall_Click(object sender, EventArgs e)
        {
            labelStatus.Text = "";

            if (string.IsNullOrEmpty(fullPath))
            {
                MessageBox.Show("Please click the Browse button!");

            }
            else
            {
                registryPath = "SOFTWARE\\Microsoft\\Direct3D\\" + fileName;

                if (checkBox10Bit.Checked)
                {

                    RegistryKey key = Registry.CurrentUser.CreateSubKey(registryPath);

                    key.SetValue("D3DBehaviors", "BufferUpgradeOverride=1;BufferUpgradeEnable10Bit=1");
                    key.SetValue("Name", folderPath);
                    key.Close();

                    labelStatus.Text = "Installed!";

                }
                else
                {
                    RegistryKey key = Registry.CurrentUser.CreateSubKey(registryPath);

                    key.SetValue("D3DBehaviors", "BufferUpgradeOverride=1");
                    key.SetValue("Name", folderPath);
                    key.Close();

                    labelStatus.Text = "Installed!";
                }

            }

        }

        private void buttonBrowseUninstall_Click(object sender, EventArgs e)
        {
            labelStatus2.Text = "";

            OpenFileDialog openFileDialogAppPathUninstall = new OpenFileDialog
            {
                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "exe",
                Filter = "Execution File (*.exe)|*.exe",
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialogAppPathUninstall.ShowDialog() == DialogResult.OK)
            {
                fullPathUninstall = openFileDialogAppPathUninstall.FileName;
                textBoxPath2.Text = fullPathUninstall;
                fileNameUninstall = Path.GetFileNameWithoutExtension(fullPathUninstall);

            }
        }

        private void buttonUninstall_Click(object sender, EventArgs e)
        {

            labelStatus2.Text = "";

            if (string.IsNullOrEmpty(fullPathUninstall))
            {
                MessageBox.Show("Please click the Browse button!");
            }
            else
            {
                string explorerKeyPath = @"Software\Microsoft\Direct3D";

                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(explorerKeyPath, writable: true))
                {
                    if (key != null)
                    {
                        key.DeleteSubKey(fileNameUninstall);
                    }
                }

                labelStatus2.Text = "Uninstalled!";

            }


        }

    }
}
