namespace WinFormsApp1
{
    partial class FormForceAutoHDR
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPageInstall = new TabPage();
            labelStatus = new Label();
            buttonInstall = new Button();
            checkBox10Bit = new CheckBox();
            textBoxPath = new TextBox();
            label1 = new Label();
            buttonBrowse = new Button();
            tabPageUninstall = new TabPage();
            label2 = new Label();
            labelStatus2 = new Label();
            buttonUninstall = new Button();
            textBoxPath2 = new TextBox();
            label3 = new Label();
            buttonBrowseUninstall = new Button();
            openFileDialogAppPath = new OpenFileDialog();
            openFileDialog1 = new OpenFileDialog();
            openFileDialogAppPathUninstall = new OpenFileDialog();
            tabControl1.SuspendLayout();
            tabPageInstall.SuspendLayout();
            tabPageUninstall.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageInstall);
            tabControl1.Controls.Add(tabPageUninstall);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(563, 270);
            tabControl1.TabIndex = 0;
            // 
            // tabPageInstall
            // 
            tabPageInstall.Controls.Add(labelStatus);
            tabPageInstall.Controls.Add(buttonInstall);
            tabPageInstall.Controls.Add(checkBox10Bit);
            tabPageInstall.Controls.Add(textBoxPath);
            tabPageInstall.Controls.Add(label1);
            tabPageInstall.Controls.Add(buttonBrowse);
            tabPageInstall.Location = new Point(4, 29);
            tabPageInstall.Name = "tabPageInstall";
            tabPageInstall.Padding = new Padding(3);
            tabPageInstall.Size = new Size(555, 237);
            tabPageInstall.TabIndex = 0;
            tabPageInstall.Text = "Install";
            tabPageInstall.UseVisualStyleBackColor = true;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelStatus.Location = new Point(22, 192);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(0, 24);
            labelStatus.TabIndex = 7;
            // 
            // buttonInstall
            // 
            buttonInstall.Location = new Point(22, 146);
            buttonInstall.Name = "buttonInstall";
            buttonInstall.Size = new Size(94, 29);
            buttonInstall.TabIndex = 6;
            buttonInstall.Text = "Install";
            buttonInstall.UseVisualStyleBackColor = true;
            buttonInstall.Click += buttonInstall_Click;
            // 
            // checkBox10Bit
            // 
            checkBox10Bit.AutoSize = true;
            checkBox10Bit.Location = new Point(22, 106);
            checkBox10Bit.Name = "checkBox10Bit";
            checkBox10Bit.Size = new Size(118, 24);
            checkBox10Bit.TabIndex = 5;
            checkBox10Bit.Text = "Enable 10 Bit";
            checkBox10Bit.UseVisualStyleBackColor = true;
            // 
            // textBoxPath
            // 
            textBoxPath.Location = new Point(135, 58);
            textBoxPath.Name = "textBoxPath";
            textBoxPath.Size = new Size(395, 27);
            textBoxPath.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 22);
            label1.Name = "label1";
            label1.Size = new Size(216, 20);
            label1.TabIndex = 3;
            label1.Text = "App (.exe) to install Auto HDR: ";
            // 
            // buttonBrowse
            // 
            buttonBrowse.Location = new Point(22, 58);
            buttonBrowse.Name = "buttonBrowse";
            buttonBrowse.Size = new Size(94, 29);
            buttonBrowse.TabIndex = 2;
            buttonBrowse.Text = "Browse";
            buttonBrowse.UseVisualStyleBackColor = true;
            buttonBrowse.Click += buttonBrowse_Click;
            // 
            // tabPageUninstall
            // 
            tabPageUninstall.Controls.Add(label2);
            tabPageUninstall.Controls.Add(labelStatus2);
            tabPageUninstall.Controls.Add(buttonUninstall);
            tabPageUninstall.Controls.Add(textBoxPath2);
            tabPageUninstall.Controls.Add(label3);
            tabPageUninstall.Controls.Add(buttonBrowseUninstall);
            tabPageUninstall.Location = new Point(4, 29);
            tabPageUninstall.Name = "tabPageUninstall";
            tabPageUninstall.Padding = new Padding(3);
            tabPageUninstall.Size = new Size(555, 237);
            tabPageUninstall.TabIndex = 1;
            tabPageUninstall.Text = "Uninstall";
            tabPageUninstall.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 22);
            label2.Name = "label2";
            label2.Size = new Size(232, 20);
            label2.TabIndex = 15;
            label2.Text = "App (.exe) to uninstall Auto HDR: ";
            // 
            // labelStatus2
            // 
            labelStatus2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelStatus2.Location = new Point(22, 149);
            labelStatus2.Name = "labelStatus2";
            labelStatus2.Size = new Size(181, 23);
            labelStatus2.TabIndex = 0;
            // 
            // buttonUninstall
            // 
            buttonUninstall.Location = new Point(22, 102);
            buttonUninstall.Name = "buttonUninstall";
            buttonUninstall.Size = new Size(94, 29);
            buttonUninstall.TabIndex = 12;
            buttonUninstall.Text = "Uninstall";
            buttonUninstall.UseVisualStyleBackColor = true;
            buttonUninstall.Click += buttonUninstall_Click;
            // 
            // textBoxPath2
            // 
            textBoxPath2.Location = new Point(135, 58);
            textBoxPath2.Name = "textBoxPath2";
            textBoxPath2.Size = new Size(395, 27);
            textBoxPath2.TabIndex = 13;
            // 
            // label3
            // 
            label3.Location = new Point(120, 82);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 14;
            // 
            // buttonBrowseUninstall
            // 
            buttonBrowseUninstall.Location = new Point(22, 58);
            buttonBrowseUninstall.Name = "buttonBrowseUninstall";
            buttonBrowseUninstall.Size = new Size(94, 29);
            buttonBrowseUninstall.TabIndex = 8;
            buttonBrowseUninstall.Text = "Browse";
            buttonBrowseUninstall.UseVisualStyleBackColor = true;
            buttonBrowseUninstall.Click += buttonBrowseUninstall_Click;
            // 
            // openFileDialogAppPath
            // 
            openFileDialogAppPath.FileName = "AppPath";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "AppPath";
            // 
            // openFileDialogAppPathUninstall
            // 
            openFileDialogAppPathUninstall.FileName = "openFileDialog2";
            // 
            // FormForceAutoHDR
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 293);
            Controls.Add(tabControl1);
            Name = "FormForceAutoHDR";
            Text = "Force Auto HDR";
            tabControl1.ResumeLayout(false);
            tabPageInstall.ResumeLayout(false);
            tabPageInstall.PerformLayout();
            tabPageUninstall.ResumeLayout(false);
            tabPageUninstall.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageInstall;
        private TabPage tabPageUninstall;
        private Label label1;
        private Button buttonBrowse;
        private OpenFileDialog openFileDialogAppPath;
        private Button buttonInstall;
        private CheckBox checkBox10Bit;
        private TextBox textBoxPath;
        private Label labelStatus;
        private Label labelStatus2;
        private Button buttonUninstall;
        private TextBox textBoxPath2;
        private Label label3;
        private Button buttonBrowseUninstall;
        private OpenFileDialog openFileDialog1;
        private OpenFileDialog openFileDialogAppPathUninstall;
        private Label label2;
    }
}
