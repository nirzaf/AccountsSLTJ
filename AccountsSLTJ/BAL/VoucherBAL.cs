using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsSLTJ.BAL
{
    class VoucherBAL
    {
        public int VoucherID { get; set; }
        public int VoucherType { get; set; }
        public string VoucherNumber { get; set; }
        public DateTime VoucherDate { get; set; }
        public int AccountID { get; set; }
        public int OppositeAccountID { get; set; }
        public decimal DebitAmount { get; set; }
        public decimal CreditAmount { get; set; }
        public string  Description { get; set; }
        public DateTime EntryDate { get; set; }
        public string EnteredBy { get; set; }
        public int Category { get; set; }
    }
}
