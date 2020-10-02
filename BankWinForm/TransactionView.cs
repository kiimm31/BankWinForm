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
    public partial class TransactionView : Form
    {
        private readonly int _bankAccountId;
        private readonly IBankAccountFunctions _bankAccountFunctions;
        private BindingSource _bindingSource = new BindingSource();
        private ObservableCollection<BankTransactionDTO> _bankTransactionDTOs = new ObservableCollection<BankTransactionDTO>();
        private readonly BankAccountDTO _details;

        private double _accountBalance = 0;

        public TransactionView(int bankAccountId, IBankAccountFunctions bankAccountFunctions)
        {
            InitializeComponent();
            _bankAccountId = bankAccountId;
            _bankAccountFunctions = bankAccountFunctions;
            _details = _bankAccountFunctions.ViewAccountDetails(_bankAccountId);
        }

        private void LoadMe()
        {
            _bankTransactionDTOs = new ObservableCollection<BankTransactionDTO>(_bankAccountFunctions.ViewTransactions(_bankAccountId));
            _bindingSource.DataSource = _bankTransactionDTOs;
            dataGridTransactionList.DataSource = _bindingSource;

            lblFullName.Text = $"{_details.FirstName} {_details.LastName}";

            if (_bankTransactionDTOs?.Any() ?? false)
            {
                foreach (BankTransactionDTO transaction in _bankTransactionDTOs)
                {
                    switch (transaction.TransactionType)
                    {
                        case PublicEnum.TransactionType.Deposit:
                            _accountBalance += transaction.TransactionAmount;
                            break;
                        case PublicEnum.TransactionType.Withdraw:
                            _accountBalance -= transaction.TransactionAmount;
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        private void TransactionView_Load(object sender, EventArgs e)
        {
            LoadMe();
        }

        private void btnExit_Click(object sender, EventArgs e)
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

        private double GetValueFromUI()
        {
            return (double)numAmount.Value;
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (!WithdrawAmountIsValid())
            {
                MessageBox.Show($"Invalid Amount");
            }
            else
            {
                _bankAccountFunctions.WithdrawFromAccount(_bankAccountId, GetValueFromUI());
                LoadMe();
            }
        }

        private bool WithdrawAmountIsValid()
        {
            double overdraft = PublicEnum.BankOverDraftLimit[_details.BankAccountType];

            bool h = GetValueFromUI() < overdraft;

            return GetValueFromUI() < overdraft && _accountBalance >= GetValueFromUI();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            _bankAccountFunctions.DepositIntoAccount(_bankAccountId, GetValueFromUI());
            LoadMe();
        }

        private void backgroundClockTimer_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("hh:mm:ss.ff tt");
        }
    }
}
