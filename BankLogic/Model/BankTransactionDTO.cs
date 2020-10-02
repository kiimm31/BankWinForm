using System;
using System.Collections.Generic;
using System.Text;
using static BankLogic.PublicEnum;

namespace BankLogic.Model
{
    public class BankTransactionDTO
    {
        public int ID { get; set; }
        public DateTimeOffset TransactionDateTime { get; set; }
        public int BankAccountId { get; set; }
        public double TransactionAmount { get; set; }
        public TransactionType TransactionType { get; set; }
    }
}
