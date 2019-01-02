using AccountsSLTJ.BAL;
using AccountsSLTJ.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountsSLTJ
{
    public partial class Login : Form
    {
        LoginDAL DAL = new LoginDAL();
        LoginBAL Obj = new LoginBAL();
        Main MainForm = new Main();
        public Login()
        {
            InitializeComponent();
        }

        private void PBoxLoginButton_Click(object sender, EventArgs e)
        {
            if (TxtUsername.Text != "" && TxtPassword.Text != "")
            {
                Obj.Username = TxtUsername.Text.Trim();
                Obj.Password = TxtPassword.Text.Trim();
                bool Result = DAL.Authentication(Obj);
                if (Result == true)
                {
                    MainForm.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Username or Password Invalid");
                }
            }
            else
            {
                MessageBox.Show("Username or Password Cannot be Empty");
            }
        }

        private void PBoxCloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (TxtUsername.Text != "" && TxtPassword.Text != "")
                {
                    Obj.Username = TxtUsername.Text.Trim();
                    Obj.Password = TxtPassword.Text.Trim();
                    bool Result = DAL.Authentication(Obj);
                    if (Result == true)
                    {
                        MainForm.Show();
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("Username or Password Invalid");
                    }
                }
                else
                {
                    MessageBox.Show("Username or Password Cannot be Empty");
                }
            }
        }
    }
}
