using AccountsSLTJ.BAL;
using System;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SQLite;
using System.Windows.Forms;

namespace AccountsSLTJ.DAL
{

    class LoginDAL
    {
       

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        public bool Authentication(LoginBAL Obj)
        {
            SQLiteConnection Con = new SQLiteConnection(LoadConnectionString());
            try
            {
                if (ConnectionState.Closed == Con.State)
                {
                    Con.Open();
                }
                string Query = "SELECT * FROM tbl_Users Where Username ='" + Obj.Username + "'  AND Password ='" + Obj.Password + "'";
                SQLiteCommand cmd = new SQLiteCommand(Query, Con);
                SQLiteDataReader Reader = cmd.ExecuteReader();

                if (Reader.HasRows)
                {
                    Con.Close();
                    return true;
                }
                else
                {
                    Con.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}
