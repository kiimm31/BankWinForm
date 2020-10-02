namespace BankWinForm
{
    partial class MainPage
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
            this.btnCreateNewAccount = new System.Windows.Forms.Button();
            this.btnViewTransaction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateNewAccount
            // 
            this.btnCreateNewAccount.Location = new System.Drawing.Point(12, 415);
            this.btnCreateNewAccount.Name = "btnCreateNewAccount";
            this.btnCreateNewAccount.Size = new System.Drawing.Size(126, 23);
            this.btnCreateNewAccount.TabIndex = 5;
            this.btnCreateNewAccount.Text = "Create New Account";
            this.btnCreateNewAccount.UseVisualStyleBackColor = true;
            this.btnCreateNewAccount.Click += new System.EventHandler(this.btnCreateNewAccount_Click);
            // 
            // btnViewTransaction
            // 
            this.btnViewTransaction.Location = new System.Drawing.Point(713, 415);
            this.btnViewTransaction.Name = "btnViewTransaction";
            this.btnViewTransaction.Size = new System.Drawing.Size(75, 23);
            this.btnViewTransaction.TabIndex = 6;
            this.btnViewTransaction.Text = "View Transactions";
            this.btnViewTransaction.UseVisualStyleBackColor = true;
            this.btnViewTransaction.Click += new System.EventHandler(this.btnViewTransaction_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnViewTransaction);
            this.Controls.Add(this.btnCreateNewAccount);
            this.Name = "MainPage";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCreateNewAccount;
        private System.Windows.Forms.Button btnViewTransaction;
    }
}

