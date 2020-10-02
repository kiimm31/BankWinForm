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
        private BankAccountFunctions _bankAccountFunctions;
        private IDatabaseFunctions _databaseFunctions;

        private ObservableCollection<BankAccountDTO> _bankAccountDTOs = new ObservableCollection<BankAccountDTO>();

        public MainPage()
        {
            InitializeComponent();
            _databaseFunctions = new DatabaseFunctions(Properties.Settings.Default.ConnectionString);
            _bankAccountFunctions = new BankAccountFunctions(_databaseFunctions);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _bankAccountDTOs = new ObservableCollection<BankAccountDTO>(_databaseFunctions.GetAllBankAccount());
        }

        private void btnCreateNewAccount_Click(object sender, EventArgs e)
        {
            CreateNewAccountPage createNewAccountPage = new CreateNewAccountPage();

            this.Hide();
            createNewAccountPage.Show(this);
        }

        private void btnViewTransaction_Click(object sender, EventArgs e)
        {

        }
    }
}
