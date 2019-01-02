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
    public partial class Main : Form
    {
        VoucherDAL d = new VoucherDAL();
        CategoryDAL c = new CategoryDAL();
        DataCon v = new DataCon();
        List<VoucherDAL> Voucher = new List<VoucherDAL>();
        List<CategoryDAL> Account = new List<CategoryDAL>();

        public Main()
        {
            InitializeComponent();
        }

        private void LoadVoucher()
        {
            Voucher = DataCon.GetAllVouchers();
        }

        private void tbl_CategoriesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_CategoriesBindingSource.EndEdit();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            FormLoad();
        }

        public void FormLoad()
        {
            LoadAccountIDComboBox();
            LoadDGvCategory();
        }

        public void LoadAccountIDComboBox()
        {
            DataTable dt = c.GetCategory(); 
            CmbAccountID.ValueMember= "Category_ID"; 
            CmbAccountID.DisplayMember = "Category_Name"; 
            CmbAccountID.DataSource = dt; 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void LoadDGvCategory()
        {
            DGVCategory.DataSource = c.GetCategory(); 
        }

        private void PBoxAddRecordButton_Click(object sender, EventArgs e)
        {
            VoucherBAL VObject = new VoucherBAL();

            if (CmbVoucherType.DisplayMember == "Expense")
            {
                VObject.VoucherType = 1;
            }
            else if (CmbVoucherType.DisplayMember == "Income")
            {
                VObject.VoucherType = 2;
            }

            VObject.VoucherNumber = TxtVoucherNumber.Text.Trim();
            VObject.VoucherDate = DTPVoucherDate.Value;
            VObject.AccountID = Convert.ToInt32(CmbAccountID.ValueMember);
            VObject.OppositeAccountID = Convert.ToInt32(CmbOppositeAccountID.ValueMember);
            VObject.DebitAmount = Convert.ToDecimal(TxtDebitAmount.Text.Trim());
            VObject.CreditAmount = Convert.ToDecimal(TxtCreditAmount.Text.Trim());
            VObject.Description = TextDescription.Text.Trim();
            VObject.EntryDate = DTPEntryDate.Value;
            VObject.EnteredBy = TxtEnteredBy.Text.Trim();
            VObject.Category = Convert.ToInt32(CmbCategory.ValueMember);
            v.SaveVoucher(VObject);
        }

        private void CmbAccountID_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblVM.Text = CmbAccountID.ValueMember.ToString();
        }

        private void PBoxAddCategory_Click(object sender, EventArgs e)
        {
            CategoryBAL cat = new CategoryBAL
            {
                Category_Name = TxtAccountName.Text.Trim(),
                Description = TxtDescription.Text.Trim()
            };

            bool Result = c.InsertAccount(cat);
            if (Result == true)
            {
                LblMessage.Visible = true;
                LblMessage.Text = "Category Added";
                LoadDGvCategory();
                LoadAccountIDComboBox();
            }
            else
            {
                MessageBox.Show("Something Went Wrong");
            }
        }

        private void TLabelMessage_Tick(object sender, EventArgs e)
        {
            LblMessage.Visible = false;
        }

        private void DGVCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGVCategory.SelectedRows.Count > 0)
            {

            }
        }
    }
}
