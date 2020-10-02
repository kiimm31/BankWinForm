namespace BankWinForm
{
    partial class CreateNewAccountPage
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
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.fileAddress = new System.Windows.Forms.OpenFileDialog();
            this.fileIdentity = new System.Windows.Forms.OpenFileDialog();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtIdNumber = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dpDateOfBirth = new System.Windows.Forms.MonthCalendar();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblIDNumber = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblMobileNumber = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.cbxAccountType = new System.Windows.Forms.ComboBox();
            this.lblAccountType = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblProofAddress = new System.Windows.Forms.Label();
            this.lblProofIC = new System.Windows.Forms.Label();
            this.txtAddressFilePath = new System.Windows.Forms.TextBox();
            this.txtIdentityFilePath = new System.Windows.Forms.TextBox();
            this.btnAddressBrowse = new System.Windows.Forms.Button();
            this.btnIdentityBrowse = new System.Windows.Forms.Button();
            this.backgroundClockTimer = new System.Windows.Forms.Timer(this.components);
            this.lblClock = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(442, 400);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(239, 400);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // fileAddress
            // 
            this.fileAddress.FileName = "fileAddress";
            // 
            // fileIdentity
            // 
            this.fileIdentity.FileName = "fileIdentity";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(128, 45);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(121, 20);
            this.txtFirstName.TabIndex = 2;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(128, 95);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(121, 20);
            this.txtLastName.TabIndex = 3;
            // 
            // txtIdNumber
            // 
            this.txtIdNumber.Location = new System.Drawing.Point(128, 143);
            this.txtIdNumber.Name = "txtIdNumber";
            this.txtIdNumber.Size = new System.Drawing.Size(121, 20);
            this.txtIdNumber.TabIndex = 4;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(128, 187);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(121, 20);
            this.txtAddress.TabIndex = 5;
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(128, 233);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(121, 20);
            this.txtMobile.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(128, 280);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(121, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // dpDateOfBirth
            // 
            this.dpDateOfBirth.FirstDayOfWeek = System.Windows.Forms.Day.Sunday;
            this.dpDateOfBirth.Location = new System.Drawing.Point(478, 45);
            this.dpDateOfBirth.MaxSelectionCount = 1;
            this.dpDateOfBirth.Name = "dpDateOfBirth";
            this.dpDateOfBirth.TabIndex = 8;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(65, 48);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 9;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(64, 95);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 10;
            this.lblLastName.Text = "Last Name";
            // 
            // lblIDNumber
            // 
            this.lblIDNumber.AutoSize = true;
            this.lblIDNumber.Location = new System.Drawing.Point(64, 143);
            this.lblIDNumber.Name = "lblIDNumber";
            this.lblIDNumber.Size = new System.Drawing.Size(58, 13);
            this.lblIDNumber.TabIndex = 11;
            this.lblIDNumber.Text = "ID Number";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(77, 187);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 12;
            this.lblAddress.Text = "Address";
            // 
            // lblMobileNumber
            // 
            this.lblMobileNumber.AutoSize = true;
            this.lblMobileNumber.Location = new System.Drawing.Point(44, 236);
            this.lblMobileNumber.Name = "lblMobileNumber";
            this.lblMobileNumber.Size = new System.Drawing.Size(78, 13);
            this.lblMobileNumber.TabIndex = 13;
            this.lblMobileNumber.Text = "Mobile Number";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(90, 283);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "Email";
            // 
            // cbxAccountType
            // 
            this.cbxAccountType.FormattingEnabled = true;
            this.cbxAccountType.Location = new System.Drawing.Point(128, 333);
            this.cbxAccountType.Name = "cbxAccountType";
            this.cbxAccountType.Size = new System.Drawing.Size(121, 21);
            this.cbxAccountType.TabIndex = 15;
            // 
            // lblAccountType
            // 
            this.lblAccountType.AutoSize = true;
            this.lblAccountType.Location = new System.Drawing.Point(48, 336);
            this.lblAccountType.Name = "lblAccountType";
            this.lblAccountType.Size = new System.Drawing.Size(74, 13);
            this.lblAccountType.TabIndex = 16;
            this.lblAccountType.Text = "Account Type";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(400, 45);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(66, 13);
            this.lblDateOfBirth.TabIndex = 17;
            this.lblDateOfBirth.Text = "Date of Birth";
            // 
            // lblProofAddress
            // 
            this.lblProofAddress.AutoSize = true;
            this.lblProofAddress.Location = new System.Drawing.Point(379, 234);
            this.lblProofAddress.Name = "lblProofAddress";
            this.lblProofAddress.Size = new System.Drawing.Size(87, 13);
            this.lblProofAddress.TabIndex = 18;
            this.lblProofAddress.Text = "Proof Of Address";
            // 
            // lblProofIC
            // 
            this.lblProofIC.AutoSize = true;
            this.lblProofIC.Location = new System.Drawing.Point(379, 280);
            this.lblProofIC.Name = "lblProofIC";
            this.lblProofIC.Size = new System.Drawing.Size(83, 13);
            this.lblProofIC.TabIndex = 19;
            this.lblProofIC.Text = "Proof Of Identity";
            // 
            // txtAddressFilePath
            // 
            this.txtAddressFilePath.Location = new System.Drawing.Point(478, 232);
            this.txtAddressFilePath.Name = "txtAddressFilePath";
            this.txtAddressFilePath.Size = new System.Drawing.Size(121, 20);
            this.txtAddressFilePath.TabIndex = 20;
            // 
            // txtIdentityFilePath
            // 
            this.txtIdentityFilePath.Location = new System.Drawing.Point(478, 277);
            this.txtIdentityFilePath.Name = "txtIdentityFilePath";
            this.txtIdentityFilePath.Size = new System.Drawing.Size(121, 20);
            this.txtIdentityFilePath.TabIndex = 21;
            // 
            // btnAddressBrowse
            // 
            this.btnAddressBrowse.Location = new System.Drawing.Point(605, 229);
            this.btnAddressBrowse.Name = "btnAddressBrowse";
            this.btnAddressBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnAddressBrowse.TabIndex = 22;
            this.btnAddressBrowse.Text = "Browse";
            this.btnAddressBrowse.UseVisualStyleBackColor = true;
            this.btnAddressBrowse.Click += new System.EventHandler(this.btnAddressBrowse_Click);
            // 
            // btnIdentityBrowse
            // 
            this.btnIdentityBrowse.Location = new System.Drawing.Point(605, 275);
            this.btnIdentityBrowse.Name = "btnIdentityBrowse";
            this.btnIdentityBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnIdentityBrowse.TabIndex = 23;
            this.btnIdentityBrowse.Text = "Browse";
            this.btnIdentityBrowse.UseVisualStyleBackColor = true;
            this.btnIdentityBrowse.Click += new System.EventHandler(this.btnIdentityBrowse_Click);
            // 
            // backgroundClockTimer
            // 
            this.backgroundClockTimer.Enabled = true;
            this.backgroundClockTimer.Tick += new System.EventHandler(this.backgroundClockTimer_Tick);
            // 
            // lblClock
            // 
            this.lblClock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClock.AutoSize = true;
            this.lblClock.Location = new System.Drawing.Point(715, 9);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(35, 13);
            this.lblClock.TabIndex = 24;
            this.lblClock.Text = "label1";
            // 
            // CreateNewAccountPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblClock);
            this.Controls.Add(this.btnIdentityBrowse);
            this.Controls.Add(this.btnAddressBrowse);
            this.Controls.Add(this.txtIdentityFilePath);
            this.Controls.Add(this.txtAddressFilePath);
            this.Controls.Add(this.lblProofIC);
            this.Controls.Add(this.lblProofAddress);
            this.Controls.Add(this.lblDateOfBirth);
            this.Controls.Add(this.lblAccountType);
            this.Controls.Add(this.cbxAccountType);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblMobileNumber);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblIDNumber);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.dpDateOfBirth);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtIdNumber);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Name = "CreateNewAccountPage";
            this.Text = "CreateNewAccountPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.OpenFileDialog fileAddress;
        private System.Windows.Forms.OpenFileDialog fileIdentity;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtIdNumber;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MonthCalendar dpDateOfBirth;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblIDNumber;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblMobileNumber;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.ComboBox cbxAccountType;
        private System.Windows.Forms.Label lblAccountType;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblProofAddress;
        private System.Windows.Forms.Label lblProofIC;
        private System.Windows.Forms.TextBox txtAddressFilePath;
        private System.Windows.Forms.TextBox txtIdentityFilePath;
        private System.Windows.Forms.Button btnAddressBrowse;
        private System.Windows.Forms.Button btnIdentityBrowse;
        private System.Windows.Forms.Timer backgroundClockTimer;
        private System.Windows.Forms.Label lblClock;
    }
}