using BankLogic.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankLogic
{
    public class DocumentFunctions : IDocumentFunctions
    {
        private readonly IDatabaseFunctions _databaseFunctions;

        public DocumentFunctions(IDatabaseFunctions databaseFunctions)
        {
            _databaseFunctions = databaseFunctions;
        }

        public int UploadDocument(string filePath)
        {
            DocumentDTO documentDTO = new DocumentDTO()
            {
                HexString = filePath
            };

            return _databaseFunctions.AddNewDocument(documentDTO);
        }
    }
}
