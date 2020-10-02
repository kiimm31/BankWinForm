using BankLogic;
using BankLogic.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankWinForm
{
    public partial class MainPage : Form
    {
        private IBankAccountFunctions _bankAccountFunctions;
        private BindingSource _bindingSource = new BindingSource();
        private ObservableCollection<BankAccountDTO> _bankAccountDTOs = new ObservableCollection<BankAccountDTO>();

        public MainPage()
        {
            InitializeComponent();
            IDatabaseFunctions databaseFunctions = new DatabaseFunctions(Properties.Settings.Default.SqliteFilePath);
            _bankAccountFunctions = new BankAccountFunctions(databaseFunctions);
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            LoadMe();
        }

        public void LoadMe()
        {
            _bankAccountDTOs = new ObservableCollection<BankAccountDTO>(_bankAccountFunctions.ViewAllBankAccounts());
            _bindingSource.DataSource = _bankAccountDTOs;
            dataGridAccountList.DataSource = _bindingSource;
        }

        private void btnCreateNewAccount_Click(object sender, EventArgs e)
        {
            CreateNewAccountPage createNewAccountPage = new CreateNewAccountPage(_bankAccountFunctions);
            this.Hide();
            createNewAccountPage.Tag = this;
            createNewAccountPage.Show(this);
        }

        private void btnViewTransaction_Click(object sender, EventArgs e)
        {
            BankAccountDTO details = GetSelectedBankDetailFromUI();

            TransactionView transactionView = new TransactionView(details.ID, _bankAccountFunctions);
            transactionView.Tag = this;

            this.Hide();
            transactionView.Show();
        }

        private BankAccountDTO GetSelectedBankDetailFromUI()
        {
            DataGridViewSelectedRowCollection selectedBankAccount = dataGridAccountList.SelectedRows;
            int index = selectedBankAccount[0].Index;

            BankAccountDTO details = _bankAccountDTOs[index];
            return details;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchValue = txtSearchBox.Text;
            //dataGridAccountList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                bool valueResult = false;
                foreach (DataGridViewRow row in dataGridAccountList.Rows)
                {
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        if (row.Cells[i].Value != null && row.Cells[i].Value.ToString().ToUpper().Contains(searchValue.ToUpper()))
                        {
                            int rowIndex = row.Index;
                            dataGridAccountList.Rows[rowIndex].Selected = true;
                            valueResult = true;
                            break;
                        }
                    }

                }
                if (!valueResult)
                {
                    MessageBox.Show("Unable to find " + txtSearchBox.Text, "Not Found");
                    return;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.GetBaseException().Message);
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    BankAccountDTO bankAccountDTO = GetSelectedBankDetailFromUI();
                    //download address Proof

                    DocumentDTO address = _bankAccountFunctions.ViewAccountDocument(bankAccountDTO.AddressProofDocumentId);

                    string addressFP = $@"{folderBrowserDialog.SelectedPath}\{bankAccountDTO.FirstName}_{bankAccountDTO.LastName}_address_document{address.Extension}";

                    byte[] addressByte = Convert.FromBase64String(address.HexString);

                    System.IO.File.WriteAllBytes(addressFP.Replace(" ", ""), addressByte);

                    DocumentDTO identity = _bankAccountFunctions.ViewAccountDocument(bankAccountDTO.IdentificationProofDocumentId);

                    string identityFP = $@"{folderBrowserDialog.SelectedPath}\{bankAccountDTO.FirstName}_{bankAccountDTO.LastName}_identity_Document{identity.Extension}";

                    byte[] identityByte = Convert.FromBase64String(identity.HexString);

                    System.IO.File.WriteAllBytes(identityFP.Replace(" ", ""), identityByte);

                    MessageBox.Show("Download Success");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Download Failed : \n {ex.GetBaseException().Message}");
                }
                
            }
        }

        private void backgroundClockTimer_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;

            lblClock.Text = now.ToString("hh:mm:ss.ff tt");
        }
    }
}
