using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using static BankLogic.PublicEnum;

namespace BankLogic.Model
{
    public class BankAccountDTO
    {
        private readonly DateTimeOffset _CreatedDateTime;
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IDNumber { get; set; }
        public DateTimeOffset DateOfBirth { get; set; }
        public string Address { get; set; }
        public BankType BankAccountType { get; set; }
        public int IdentificationProofDocumentId { get; set; }
        public int AddressProofDocumentId { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }
        public bool IsDeleted { get; set; }

        public BankAccountDTO()
        {
            _CreatedDateTime = new DateTimeOffset(DateTime.Now);
        }
    }
}
