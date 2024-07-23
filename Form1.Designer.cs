namespace Motochek_Processor
{
    partial class Form1
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
            this.btnSelectPermit = new System.Windows.Forms.Button();
            this.permitTextBox = new System.Windows.Forms.TextBox();
            this.rucTextBox = new System.Windows.Forms.TextBox();
            this.btnSelectRuc = new System.Windows.Forms.Button();
            this.permitTextBoxLabel = new System.Windows.Forms.Label();
            this.rucTextBoxLabel = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.btnReminderProcess = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.reminderImportTitleLabel = new System.Windows.Forms.Label();
            this.fuelProcessingLabel = new System.Windows.Forms.Label();
            this.fuelTextBoxLabel = new System.Windows.Forms.Label();
            this.fuelTextBox = new System.Windows.Forms.TextBox();
            this.btnSelectVehicleDetails = new System.Windows.Forms.Button();
            this.btnFuelProcess = new System.Windows.Forms.Button();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.btnSelectVinFile = new System.Windows.Forms.Button();
            this.vinTextBox = new System.Windows.Forms.TextBox();
            this.vinTextBoxLabel = new System.Windows.Forms.Label();
            this.vinFileLabel = new System.Windows.Forms.Label();
            this.openFileDialog4 = new System.Windows.Forms.OpenFileDialog();
            this.versionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelectPermit
            // 
            this.btnSelectPermit.Location = new System.Drawing.Point(372, 37);
            this.btnSelectPermit.Name = "btnSelectPermit";
            this.btnSelectPermit.Size = new System.Drawing.Size(75, 20);
            this.btnSelectPermit.TabIndex = 0;
            this.btnSelectPermit.Text = "Select...";
            this.btnSelectPermit.UseVisualStyleBackColor = true;
            this.btnSelectPermit.Click += new System.EventHandler(this.Button1_Click);
            // 
            // permitTextBox
            // 
            this.permitTextBox.Enabled = false;
            this.permitTextBox.Location = new System.Drawing.Point(132, 38);
            this.permitTextBox.Name = "permitTextBox";
            this.permitTextBox.Size = new System.Drawing.Size(234, 20);
            this.permitTextBox.TabIndex = 1;
            // 
            // rucTextBox
            // 
            this.rucTextBox.Enabled = false;
            this.rucTextBox.Location = new System.Drawing.Point(132, 65);
            this.rucTextBox.Name = "rucTextBox";
            this.rucTextBox.Size = new System.Drawing.Size(234, 20);
            this.rucTextBox.TabIndex = 2;
            // 
            // btnSelectRuc
            // 
            this.btnSelectRuc.Location = new System.Drawing.Point(372, 65);
            this.btnSelectRuc.Name = "btnSelectRuc";
            this.btnSelectRuc.Size = new System.Drawing.Size(75, 20);
            this.btnSelectRuc.TabIndex = 3;
            this.btnSelectRuc.Text = "Select...";
            this.btnSelectRuc.UseVisualStyleBackColor = true;
            this.btnSelectRuc.Click += new System.EventHandler(this.Button2_Click);
            // 
            // permitTextBoxLabel
            // 
            this.permitTextBoxLabel.AutoSize = true;
            this.permitTextBoxLabel.Location = new System.Drawing.Point(12, 41);
            this.permitTextBoxLabel.Name = "permitTextBoxLabel";
            this.permitTextBoxLabel.Size = new System.Drawing.Size(114, 13);
            this.permitTextBoxLabel.TabIndex = 4;
            this.permitTextBoxLabel.Text = "Select Permit Data File";
            // 
            // rucTextBoxLabel
            // 
            this.rucTextBoxLabel.AutoSize = true;
            this.rucTextBoxLabel.Location = new System.Drawing.Point(12, 68);
            this.rucTextBoxLabel.Name = "rucTextBoxLabel";
            this.rucTextBoxLabel.Size = new System.Drawing.Size(108, 13);
            this.rucTextBoxLabel.TabIndex = 5;
            this.rucTextBoxLabel.Text = "Select RUC Data File";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Motochek Files (*.mc.txt)|*.mc.txt|All files (*.*)|*.*";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.Filter = "Motochek Files (*.mc.txt)|*.mc.txt|All files (*.*)|*.*";
            // 
            // btnReminderProcess
            // 
            this.btnReminderProcess.Location = new System.Drawing.Point(332, 227);
            this.btnReminderProcess.Name = "btnReminderProcess";
            this.btnReminderProcess.Size = new System.Drawing.Size(115, 23);
            this.btnReminderProcess.TabIndex = 6;
            this.btnReminderProcess.Text = "Process Reminders";
            this.btnReminderProcess.UseVisualStyleBackColor = true;
            this.btnReminderProcess.Click += new System.EventHandler(this.Button3_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // reminderImportTitleLabel
            // 
            this.reminderImportTitleLabel.AutoSize = true;
            this.reminderImportTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reminderImportTitleLabel.Location = new System.Drawing.Point(12, 9);
            this.reminderImportTitleLabel.Name = "reminderImportTitleLabel";
            this.reminderImportTitleLabel.Size = new System.Drawing.Size(236, 20);
            this.reminderImportTitleLabel.TabIndex = 7;
            this.reminderImportTitleLabel.Text = "Reminder Import Processing";
            // 
            // fuelProcessingLabel
            // 
            this.fuelProcessingLabel.AutoSize = true;
            this.fuelProcessingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fuelProcessingLabel.Location = new System.Drawing.Point(12, 97);
            this.fuelProcessingLabel.Name = "fuelProcessingLabel";
            this.fuelProcessingLabel.Size = new System.Drawing.Size(244, 20);
            this.fuelProcessingLabel.TabIndex = 8;
            this.fuelProcessingLabel.Text = "Vehicle Fuel Type Processing";
            // 
            // fuelTextBoxLabel
            // 
            this.fuelTextBoxLabel.AutoSize = true;
            this.fuelTextBoxLabel.Location = new System.Drawing.Point(13, 128);
            this.fuelTextBoxLabel.Name = "fuelTextBoxLabel";
            this.fuelTextBoxLabel.Size = new System.Drawing.Size(96, 13);
            this.fuelTextBoxLabel.TabIndex = 9;
            this.fuelTextBoxLabel.Text = "Vehicle Details File";
            // 
            // fuelTextBox
            // 
            this.fuelTextBox.Enabled = false;
            this.fuelTextBox.Location = new System.Drawing.Point(132, 125);
            this.fuelTextBox.Name = "fuelTextBox";
            this.fuelTextBox.Size = new System.Drawing.Size(234, 20);
            this.fuelTextBox.TabIndex = 10;
            // 
            // btnSelectVehicleDetails
            // 
            this.btnSelectVehicleDetails.Location = new System.Drawing.Point(372, 125);
            this.btnSelectVehicleDetails.Name = "btnSelectVehicleDetails";
            this.btnSelectVehicleDetails.Size = new System.Drawing.Size(75, 20);
            this.btnSelectVehicleDetails.TabIndex = 11;
            this.btnSelectVehicleDetails.Text = "Select...";
            this.btnSelectVehicleDetails.UseVisualStyleBackColor = true;
            this.btnSelectVehicleDetails.Click += new System.EventHandler(this.btnSelectVehicleDetails_Click);
            // 
            // btnFuelProcess
            // 
            this.btnFuelProcess.Location = new System.Drawing.Point(211, 227);
            this.btnFuelProcess.Name = "btnFuelProcess";
            this.btnFuelProcess.Size = new System.Drawing.Size(115, 23);
            this.btnFuelProcess.TabIndex = 12;
            this.btnFuelProcess.Text = "Process Fuel Types";
            this.btnFuelProcess.UseVisualStyleBackColor = true;
            this.btnFuelProcess.Click += new System.EventHandler(this.btnFuelProcess_Click);
            // 
            // openFileDialog3
            // 
            this.openFileDialog3.Filter = "Motochek Files (*.mc.txt)|*.mc.txt|All files (*.*)|*.*";
            // 
            // btnSelectVinFile
            // 
            this.btnSelectVinFile.Location = new System.Drawing.Point(372, 185);
            this.btnSelectVinFile.Name = "btnSelectVinFile";
            this.btnSelectVinFile.Size = new System.Drawing.Size(75, 20);
            this.btnSelectVinFile.TabIndex = 16;
            this.btnSelectVinFile.Text = "Select...";
            this.btnSelectVinFile.UseVisualStyleBackColor = true;
            this.btnSelectVinFile.Click += new System.EventHandler(this.BtnSelectVinFile_Click);
            // 
            // vinTextBox
            // 
            this.vinTextBox.Enabled = false;
            this.vinTextBox.Location = new System.Drawing.Point(132, 185);
            this.vinTextBox.Name = "vinTextBox";
            this.vinTextBox.Size = new System.Drawing.Size(234, 20);
            this.vinTextBox.TabIndex = 15;
            // 
            // vinTextBoxLabel
            // 
            this.vinTextBoxLabel.AutoSize = true;
            this.vinTextBoxLabel.Location = new System.Drawing.Point(13, 188);
            this.vinTextBoxLabel.Name = "vinTextBoxLabel";
            this.vinTextBoxLabel.Size = new System.Drawing.Size(96, 13);
            this.vinTextBoxLabel.TabIndex = 14;
            this.vinTextBoxLabel.Text = "Vehicle Details File";
            // 
            // vinFileLabel
            // 
            this.vinFileLabel.AutoSize = true;
            this.vinFileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vinFileLabel.Location = new System.Drawing.Point(12, 157);
            this.vinFileLabel.Name = "vinFileLabel";
            this.vinFileLabel.Size = new System.Drawing.Size(160, 20);
            this.vinFileLabel.TabIndex = 13;
            this.vinFileLabel.Text = "VIN/Username File";
            // 
            // openFileDialog4
            // 
            this.openFileDialog4.FileName = "openFileDialog4";
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(13, 237);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(10, 13);
            this.versionLabel.TabIndex = 17;
            this.versionLabel.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 262);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.btnSelectVinFile);
            this.Controls.Add(this.vinTextBox);
            this.Controls.Add(this.vinTextBoxLabel);
            this.Controls.Add(this.vinFileLabel);
            this.Controls.Add(this.btnFuelProcess);
            this.Controls.Add(this.btnSelectVehicleDetails);
            this.Controls.Add(this.fuelTextBox);
            this.Controls.Add(this.fuelTextBoxLabel);
            this.Controls.Add(this.fuelProcessingLabel);
            this.Controls.Add(this.reminderImportTitleLabel);
            this.Controls.Add(this.btnReminderProcess);
            this.Controls.Add(this.rucTextBoxLabel);
            this.Controls.Add(this.permitTextBoxLabel);
            this.Controls.Add(this.btnSelectRuc);
            this.Controls.Add(this.rucTextBox);
            this.Controls.Add(this.permitTextBox);
            this.Controls.Add(this.btnSelectPermit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Motochek Processor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectPermit;
        private System.Windows.Forms.TextBox permitTextBox;
        private System.Windows.Forms.TextBox rucTextBox;
        private System.Windows.Forms.Button btnSelectRuc;
        private System.Windows.Forms.Label permitTextBoxLabel;
        private System.Windows.Forms.Label rucTextBoxLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button btnReminderProcess;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label reminderImportTitleLabel;
        private System.Windows.Forms.Label fuelProcessingLabel;
        private System.Windows.Forms.Button btnFuelProcess;
        private System.Windows.Forms.Button btnSelectVehicleDetails;
        private System.Windows.Forms.TextBox fuelTextBox;
        private System.Windows.Forms.Label fuelTextBoxLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
        private System.Windows.Forms.Button btnSelectVinFile;
        private System.Windows.Forms.TextBox vinTextBox;
        private System.Windows.Forms.Label vinTextBoxLabel;
        private System.Windows.Forms.Label vinFileLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog4;
        private System.Windows.Forms.Label versionLabel;
    }
}

