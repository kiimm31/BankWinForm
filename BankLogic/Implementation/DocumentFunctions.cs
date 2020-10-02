using BankLogic.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
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
            string hex = string.Empty;

            using (FileStream fs = File.OpenRead(filePath))
            {
                byte[] contents = new byte[fs.Length];

                fs.Read(contents, 0, Convert.ToInt32(fs.Length));
                fs.Close();

                hex = Convert.ToBase64String(contents);
            }

            DocumentDTO documentDTO = new DocumentDTO()
            {
                HexString = hex,
                Extension = Path.GetExtension(filePath)
            };

            return _databaseFunctions.AddNewDocument(documentDTO);
        }
    }
}
