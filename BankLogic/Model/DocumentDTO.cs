using System;
using System.Collections.Generic;
using System.Text;

namespace BankLogic.Model
{
    public class DocumentDTO
    {
        public int DocumentId { get; set; }
        public string HexString { get; set; }
        public bool IsDeleted { get; set; }
    }
}
