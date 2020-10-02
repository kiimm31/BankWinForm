using BankLogic.Model;
using System.Collections.Generic;

namespace BankLogic
{
    public interface IDatabaseFunctions
    {
        int AddNewAccount(BankAccountDTO backAccountDTO);
        int AddNewDocument(DocumentDTO documentDTO);
        void AddNewTransaction(BankTransactionDTO bankTransactionDTO);
        void InitialiseDatabase();

        BankAccountDTO GetBackAccountDTO(int bankAccountId);
        DocumentDTO GetDocumentDTO(int documentId);
        IEnumerable<BankTransactionDTO> GetBankTransactionDTOs(int bankAccountId);
        IEnumerable<BankAccountDTO> GetAllBankAccount();

    }
}