using BankLogic;
using BankLogic.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BankLogic.PublicEnum;

namespace BankWinForm
{
    public partial class CreateNewAccountPage : Form
    {
        private readonly IBankAccountFunctions _bankAccountFunctions;

        public CreateNewAccountPage(IBankAccountFunctions bankAccountFunctions)
        {
            InitializeComponent();
            _bankAccountFunctions = bankAccountFunctions;

            loadMe();
        }

        private void loadMe()
        {
            cbxAccountType.DataSource = Enum.GetValues(typeof(BankType));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ExitMe();
        }

        private void ExitMe()
        {
            MainPage mainPage = (MainPage)this.Tag;
            mainPage.LoadMe();
            mainPage.Show();
            Close();
        }

        private BankAccountDTO GetAccountDetailFromUI()
        {
            if (!ValidUI())
            {
                MessageBox.Show("Invalid Input");
                return null;
            }
            else
            {
                BankAccountDTO bankAccountDTO = new BankAccountDTO()
                {
                    Address = txtAddress.Text,
                    DateOfBirth = dpDateOfBirth.SelectionRange.Start,
                    Email = txtEmail.Text,
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    IDNumber = txtIdNumber.Text,
                    MobileNumber = txtMobile.Text,
                    BankAccountType = (BankType)cbxAccountType.SelectedItem,
                    AddressProofDocumentId = _bankAccountFunctions.UploadDocument(txtAddressFilePath.Text),
                    IdentificationProofDocumentId = _bankAccountFunctions.UploadDocument(txtIdentityFilePath.Text)
                };

                return bankAccountDTO;
            }
        }

        private bool ValidUI()
        {
            return !string.IsNullOrWhiteSpace(txtAddress.Text) &&
                !string.IsNullOrWhiteSpace(txtEmail.Text) &&
                !string.IsNullOrWhiteSpace(txtFirstName.Text) &&
                !string.IsNullOrWhiteSpace(txtLastName.Text) &&
                !string.IsNullOrWhiteSpace(txtIdNumber.Text) &&
                !string.IsNullOrWhiteSpace(txtMobile.Text) &&
                !string.IsNullOrWhiteSpace(txtIdentityFilePath.Text) &&
                !string.IsNullOrWhiteSpace(txtAddressFilePath.Text) &&
            dpDateOfBirth.SelectionRange.Start > DateTime.MinValue;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            BankAccountDTO bankAccountDTO = GetAccountDetailFromUI();

            if (bankAccountDTO != null)
            {
                _bankAccountFunctions.CreateNewAccount(bankAccountDTO);

                ExitMe();
            }
        }


        private void btnAddressBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                InitialDirectory = @"C:\",
                Title = "Proof Of Address",

                CheckFileExists = true,
                CheckPathExists = true,
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtAddressFilePath.Text = openFileDialog.FileName;
            }

        }

        private void btnIdentityBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                InitialDirectory = @"C:\",
                Title = "Proof Of Identity",

                CheckFileExists = true,
                CheckPathExists = true,
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtIdentityFilePath.Text = openFileDialog.FileName;
            }
        }

        private void backgroundClockTimer_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("hh:mm:ss.ff tt");
        }
    }
}
