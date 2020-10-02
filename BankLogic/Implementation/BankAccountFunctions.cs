using BankLogic.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankLogic
{
    public class BankAccountFunctions
    {
        private readonly IDatabaseFunctions _databaseFunctions;

        public BankAccountFunctions(IDatabaseFunctions databaseFunctions)
        {
            _databaseFunctions = databaseFunctions;
        }

        public int CreateNewAccount(BankAccountDTO backAccountDTO)
        {
            return _databaseFunctions.AddNewAccount(backAccountDTO);
        }

        public BankAccountDTO ViewAccountDetails(int bankAccountId)
        {
            return _databaseFunctions.GetBackAccountDTO(bankAccountId);
        }

        public DocumentDTO ViewAccountAddressDocument(int documentId)
        {
            return _databaseFunctions.GetDocumentDTO(documentId);
        }

        public void WithdrawFromAccount(int bankAccountId, double amount)
        {
            BankTransactionDTO bankTransactionDTO = new BankTransactionDTO()
            {
                BankAccountId = bankAccountId,
                TransactionAmount = amount,
                TransactionDateTime = new DateTimeOffset(DateTime.Now),
                TransactionType = PublicEnum.TransactionType.Withdraw
            };

            _databaseFunctions.AddNewTransaction(bankTransactionDTO);
        }

        public void DepositIntoAccount(int bankAccountId, double amount)
        {
            BankTransactionDTO bankTransactionDTO = new BankTransactionDTO()
            {
                BankAccountId = bankAccountId,
                TransactionAmount = amount,
                TransactionDateTime = new DateTimeOffset(DateTime.Now),
                TransactionType = PublicEnum.TransactionType.Deposit
            };

            _databaseFunctions.AddNewTransaction(bankTransactionDTO);
        }

        public IEnumerable<BankTransactionDTO> ViewTransactions(int bankAccountId)
        {
            return _databaseFunctions.GetBankTransactionDTOs(bankAccountId);
        }

        public bool LoginUser(UserLoginDTO userLoginDTO)
        {

        }
    }
}
