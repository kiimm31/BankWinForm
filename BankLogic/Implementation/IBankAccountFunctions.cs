using BankLogic.Model;
using System.Collections.Generic;

namespace BankLogic
{
    public interface IBankAccountFunctions
    {
        int CreateNewAccount(BankAccountDTO backAccountDTO);
        void DepositIntoAccount(int bankAccountId, double amount);
        int UploadDocument(string filePath);
        DocumentDTO ViewAccountDocument(int documentId);
        BankAccountDTO ViewAccountDetails(int bankAccountId);
        IEnumerable<BankAccountDTO> ViewAllBankAccounts();
        IEnumerable<BankTransactionDTO> ViewTransactions(int bankAccountId);
        void WithdrawFromAccount(int bankAccountId, double amount);
    }
}