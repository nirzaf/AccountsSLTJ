using AccountsSLTJ.BAL;
using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsSLTJ.DAL
{
    class DataCon
    {
        public static List<VoucherDAL> GetAllVouchers()
        {
            using (IDbConnection Con = new SQLiteConnection(LoadConnectionString()))
            {
                var Voucher = Con.Query<VoucherDAL>("SELECT * FROM tbl_Vouchers", new DynamicParameters());
                return Voucher.ToList();
            }
        }

        public void SaveVoucher(VoucherBAL Voucher)
        {
            using (IDbConnection Con = new SQLiteConnection(LoadConnectionString()))
            { 
                Con.Execute(@"INSERT INTO tbl_Vouchers (Voucher_Type, Voucher_Number, Voucher_Date,Account_ID,
                              O_Account_ID,Debit_Amount,Credit_Amount,
                              Description,Entry_Date,Entered_By,Category) VALUES ('" + Voucher.VoucherType + "'," +
                                "'" + Voucher.VoucherNumber + "','" + Voucher.VoucherDate + "'," +
                                "'" + Voucher.AccountID + "','" + Voucher.OppositeAccountID + "','" + Voucher.DebitAmount + "'," +
                                "'" + Voucher.CreditAmount + "','" + Voucher.Description + "','" + Voucher.EntryDate + "'," +
                                "'" + Voucher.EnteredBy + "','" + Voucher.Category + "') ", Voucher);
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
