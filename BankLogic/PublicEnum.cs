using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace BankLogic
{
    public class PublicEnum
    {
        public enum BankType
        {
            Current = 0,
            Saving = 1
        }

        public enum TransactionType
        {
            Deposit = 0,
            Withdraw = 1
        }

        //public static Dictionary<BankType, double> BankOverDraftLimit =>

        public static ReadOnlyDictionary<BankType, double> BankOverDraftLimit
          = new ReadOnlyDictionary<BankType, double>(
          new Dictionary<BankType, double>()
          {
              {BankType.Current,1000 },
              {BankType.Saving,2000 }
          });
    }
}
