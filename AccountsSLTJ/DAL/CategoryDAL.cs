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
using System.Windows.Forms;

namespace AccountsSLTJ.DAL
{
    class CategoryDAL
    {
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        public bool InsertAccount(CategoryBAL c)
        {      
            try
            {
                using (SQLiteConnection Con = new SQLiteConnection(LoadConnectionString()))
                {
                    Con.Open();
                    string Query = @"INSERT INTO tbl_Categories (Category_Name,Description) 
                                VALUES ('" + c.Category_Name + "','" + c.Description + "')";
                    SQLiteCommand cmd = new SQLiteCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }        
        }

        public DataTable GetCategory()
        {
            SQLiteConnection Con = new SQLiteConnection(LoadConnectionString());
            try
            {
                if (ConnectionState.Closed == Con.State)
                {
                    Con.Open();
                }
                string Query = "SELECT * FROM tbl_Categories";
                SQLiteDataAdapter cmd = new SQLiteDataAdapter(Query, Con);
                DataTable dt = new DataTable();
                cmd.Fill(dt);
                Con.Close();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        public DataSet FillComboBox()
        {
            SQLiteConnection Con = new SQLiteConnection(LoadConnectionString());
            try
            {
                Con.Open();
                string Query = "SELECT * FROM tbl_Categories";
                SQLiteDataAdapter cmd = new SQLiteDataAdapter(Query, Con);
                DataSet ds = new DataSet();
                cmd.Fill(ds);
                Con.Close();
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}