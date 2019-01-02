namespace AccountsSLTJ
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tbl_CategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.CreateVoucher = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TxtEnteredBy = new System.Windows.Forms.TextBox();
            this.TxtCreditAmount = new System.Windows.Forms.TextBox();
            this.TxtDebitAmount = new System.Windows.Forms.TextBox();
            this.TxtVoucherNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TextDescription = new System.Windows.Forms.RichTextBox();
            this.DTPVoucherDate = new System.Windows.Forms.DateTimePicker();
            this.CmbVoucherType = new System.Windows.Forms.ComboBox();
            this.DTPEntryDate = new System.Windows.Forms.DateTimePicker();
            this.CmbCategory = new System.Windows.Forms.ComboBox();
            this.tblCategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PBoxAddRecordButton = new System.Windows.Forms.PictureBox();
            this.CmbAccountID = new System.Windows.Forms.ComboBox();
            this.CmbOppositeAccountID = new System.Windows.Forms.ComboBox();
            this.LblVM = new System.Windows.Forms.Label();
            this.ViewReports = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AddCategory = new System.Windows.Forms.TabPage();
            this.DGVCategory = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.PBoxAddCategory = new System.Windows.Forms.PictureBox();
            this.TxtAccountName = new System.Windows.Forms.TextBox();
            this.tblCategoriesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tblCategoriesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.LblMessage = new System.Windows.Forms.Label();
            this.TLabelMessage = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_CategoriesBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.CreateVoucher.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblCategoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxAddRecordButton)).BeginInit();
            this.ViewReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.AddCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCategory)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxAddCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCategoriesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCategoriesBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // tbl_CategoriesBindingSource
            // 
            this.tbl_CategoriesBindingSource.DataMember = "tbl_Categories";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.CreateVoucher);
            this.tabControl1.Controls.Add(this.ViewReports);
            this.tabControl1.Controls.Add(this.AddCategory);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(11, 46);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(870, 576);
            this.tabControl1.TabIndex = 0;
            // 
            // CreateVoucher
            // 
            this.CreateVoucher.Controls.Add(this.tableLayoutPanel1);
            this.CreateVoucher.Location = new System.Drawing.Point(4, 25);
            this.CreateVoucher.Name = "CreateVoucher";
            this.CreateVoucher.Padding = new System.Windows.Forms.Padding(3);
            this.CreateVoucher.Size = new System.Drawing.Size(862, 547);
            this.CreateVoucher.TabIndex = 0;
            this.CreateVoucher.Text = "Create Voucher";
            this.CreateVoucher.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.55231F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.44769F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 236F));
            this.tableLayoutPanel1.Controls.Add(this.TxtEnteredBy, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.TxtCreditAmount, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.TxtDebitAmount, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.TxtVoucherNumber, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.TextDescription, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.DTPVoucherDate, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.CmbVoucherType, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.DTPEntryDate, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.CmbCategory, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.PBoxAddRecordButton, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.CmbAccountID, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.CmbOppositeAccountID, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.LblVM, 2, 0);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(21, 38);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 12;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.72414F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.27586F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(666, 482);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // TxtEnteredBy
            // 
            this.TxtEnteredBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtEnteredBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEnteredBy.Location = new System.Drawing.Point(190, 300);
            this.TxtEnteredBy.Name = "TxtEnteredBy";
            this.TxtEnteredBy.Size = new System.Drawing.Size(236, 22);
            this.TxtEnteredBy.TabIndex = 21;
            // 
            // TxtCreditAmount
            // 
            this.TxtCreditAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCreditAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCreditAmount.Location = new System.Drawing.Point(190, 166);
            this.TxtCreditAmount.Name = "TxtCreditAmount";
            this.TxtCreditAmount.Size = new System.Drawing.Size(236, 22);
            this.TxtCreditAmount.TabIndex = 18;
            // 
            // TxtDebitAmount
            // 
            this.TxtDebitAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtDebitAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDebitAmount.Location = new System.Drawing.Point(190, 139);
            this.TxtDebitAmount.Name = "TxtDebitAmount";
            this.TxtDebitAmount.Size = new System.Drawing.Size(236, 22);
            this.TxtDebitAmount.TabIndex = 17;
            // 
            // TxtVoucherNumber
            // 
            this.TxtVoucherNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtVoucherNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtVoucherNumber.Location = new System.Drawing.Point(190, 33);
            this.TxtVoucherNumber.Name = "TxtVoucherNumber";
            this.TxtVoucherNumber.Size = new System.Drawing.Size(236, 22);
            this.TxtVoucherNumber.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Voucher Type";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Voucher Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Credit Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Voucher Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Debit Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Account ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Opposite Account ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 271);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "Entry Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 297);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "Entered By";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 325);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 16);
            this.label11.TabIndex = 11;
            this.label11.Text = "Category ";
            // 
            // TextDescription
            // 
            this.TextDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextDescription.Location = new System.Drawing.Point(190, 194);
            this.TextDescription.Name = "TextDescription";
            this.TextDescription.Size = new System.Drawing.Size(236, 74);
            this.TextDescription.TabIndex = 23;
            this.TextDescription.Text = "";
            // 
            // DTPVoucherDate
            // 
            this.DTPVoucherDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPVoucherDate.Location = new System.Drawing.Point(190, 61);
            this.DTPVoucherDate.Name = "DTPVoucherDate";
            this.DTPVoucherDate.Size = new System.Drawing.Size(236, 22);
            this.DTPVoucherDate.TabIndex = 31;
            this.DTPVoucherDate.Value = new System.DateTime(2018, 12, 27, 0, 0, 0, 0);
            // 
            // CmbVoucherType
            // 
            this.CmbVoucherType.FormattingEnabled = true;
            this.CmbVoucherType.Items.AddRange(new object[] {
            "Expense ",
            "Income"});
            this.CmbVoucherType.Location = new System.Drawing.Point(190, 3);
            this.CmbVoucherType.Name = "CmbVoucherType";
            this.CmbVoucherType.Size = new System.Drawing.Size(236, 24);
            this.CmbVoucherType.TabIndex = 33;
            // 
            // DTPEntryDate
            // 
            this.DTPEntryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPEntryDate.Location = new System.Drawing.Point(190, 274);
            this.DTPEntryDate.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.DTPEntryDate.Name = "DTPEntryDate";
            this.DTPEntryDate.Size = new System.Drawing.Size(236, 22);
            this.DTPEntryDate.TabIndex = 34;
            this.DTPEntryDate.Value = new System.DateTime(2018, 12, 27, 0, 0, 0, 0);
            // 
            // CmbCategory
            // 
            this.CmbCategory.DataSource = this.tblCategoriesBindingSource;
            this.CmbCategory.DisplayMember = "Category_Name";
            this.CmbCategory.FormattingEnabled = true;
            this.CmbCategory.Location = new System.Drawing.Point(190, 328);
            this.CmbCategory.Name = "CmbCategory";
            this.CmbCategory.Size = new System.Drawing.Size(236, 24);
            this.CmbCategory.TabIndex = 36;
            this.CmbCategory.ValueMember = "Category_ID";
            // 
            // tblCategoriesBindingSource
            // 
            this.tblCategoriesBindingSource.DataMember = "tbl_Categories";
            // 
            // PBoxAddRecordButton
            // 
            this.PBoxAddRecordButton.Image = global::AccountsSLTJ.Properties.Resources._1024px_More_Icon_C_svg;
            this.PBoxAddRecordButton.Location = new System.Drawing.Point(190, 356);
            this.PBoxAddRecordButton.Name = "PBoxAddRecordButton";
            this.PBoxAddRecordButton.Size = new System.Drawing.Size(123, 119);
            this.PBoxAddRecordButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBoxAddRecordButton.TabIndex = 10;
            this.PBoxAddRecordButton.TabStop = false;
            this.PBoxAddRecordButton.Click += new System.EventHandler(this.PBoxAddRecordButton_Click);
            // 
            // CmbAccountID
            // 
            this.CmbAccountID.FormattingEnabled = true;
            this.CmbAccountID.Location = new System.Drawing.Point(190, 86);
            this.CmbAccountID.Name = "CmbAccountID";
            this.CmbAccountID.Size = new System.Drawing.Size(236, 24);
            this.CmbAccountID.TabIndex = 39;
            this.CmbAccountID.SelectedIndexChanged += new System.EventHandler(this.CmbAccountID_SelectedIndexChanged);
            // 
            // CmbOppositeAccountID
            // 
            this.CmbOppositeAccountID.DataSource = this.tblCategoriesBindingSource;
            this.CmbOppositeAccountID.DisplayMember = "Category_Name";
            this.CmbOppositeAccountID.FormattingEnabled = true;
            this.CmbOppositeAccountID.Location = new System.Drawing.Point(190, 111);
            this.CmbOppositeAccountID.Name = "CmbOppositeAccountID";
            this.CmbOppositeAccountID.Size = new System.Drawing.Size(236, 24);
            this.CmbOppositeAccountID.TabIndex = 38;
            this.CmbOppositeAccountID.ValueMember = "Category_ID";
            // 
            // LblVM
            // 
            this.LblVM.AutoSize = true;
            this.LblVM.BackColor = System.Drawing.Color.White;
            this.LblVM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVM.Location = new System.Drawing.Point(432, 0);
            this.LblVM.Name = "LblVM";
            this.LblVM.Size = new System.Drawing.Size(108, 16);
            this.LblVM.TabIndex = 40;
            this.LblVM.Text = "Value member";
            // 
            // ViewReports
            // 
            this.ViewReports.Controls.Add(this.dataGridView1);
            this.ViewReports.Location = new System.Drawing.Point(4, 25);
            this.ViewReports.Name = "ViewReports";
            this.ViewReports.Size = new System.Drawing.Size(862, 547);
            this.ViewReports.TabIndex = 2;
            this.ViewReports.Text = "View Reports";
            this.ViewReports.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(820, 464);
            this.dataGridView1.TabIndex = 0;
            // 
            // AddCategory
            // 
            this.AddCategory.Controls.Add(this.DGVCategory);
            this.AddCategory.Controls.Add(this.tableLayoutPanel2);
            this.AddCategory.Location = new System.Drawing.Point(4, 25);
            this.AddCategory.Name = "AddCategory";
            this.AddCategory.Padding = new System.Windows.Forms.Padding(3);
            this.AddCategory.Size = new System.Drawing.Size(862, 547);
            this.AddCategory.TabIndex = 1;
            this.AddCategory.Text = "Add Accounts";
            this.AddCategory.UseVisualStyleBackColor = true;
            // 
            // DGVCategory
            // 
            this.DGVCategory.AllowUserToAddRows = false;
            this.DGVCategory.AllowUserToDeleteRows = false;
            this.DGVCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVCategory.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DGVCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCategory.Location = new System.Drawing.Point(434, 21);
            this.DGVCategory.Name = "DGVCategory";
            this.DGVCategory.ReadOnly = true;
            this.DGVCategory.Size = new System.Drawing.Size(417, 260);
            this.DGVCategory.TabIndex = 11;
            this.DGVCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCategory_CellClick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.19355F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.80645F));
            this.tableLayoutPanel2.Controls.Add(this.TxtDescription, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label12, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label14, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.PBoxAddCategory, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.TxtAccountName, 1, 0);
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(26, 21);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.72414F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.27586F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 401F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(402, 482);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // TxtDescription
            // 
            this.TxtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescription.Location = new System.Drawing.Point(140, 44);
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Size = new System.Drawing.Size(257, 22);
            this.TxtDescription.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 16);
            this.label12.TabIndex = 1;
            this.label12.Text = "Account Name";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 41);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 16);
            this.label14.TabIndex = 2;
            this.label14.Text = "Description";
            // 
            // PBoxAddCategory
            // 
            this.PBoxAddCategory.Image = global::AccountsSLTJ.Properties.Resources._1024px_More_Icon_C_svg;
            this.PBoxAddCategory.Location = new System.Drawing.Point(140, 83);
            this.PBoxAddCategory.Name = "PBoxAddCategory";
            this.PBoxAddCategory.Size = new System.Drawing.Size(123, 119);
            this.PBoxAddCategory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBoxAddCategory.TabIndex = 10;
            this.PBoxAddCategory.TabStop = false;
            this.PBoxAddCategory.Click += new System.EventHandler(this.PBoxAddCategory_Click);
            // 
            // TxtAccountName
            // 
            this.TxtAccountName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtAccountName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAccountName.Location = new System.Drawing.Point(140, 3);
            this.TxtAccountName.Name = "TxtAccountName";
            this.TxtAccountName.Size = new System.Drawing.Size(257, 22);
            this.TxtAccountName.TabIndex = 14;
            // 
            // tblCategoriesBindingSource1
            // 
            this.tblCategoriesBindingSource1.DataMember = "tbl_Categories";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AccountsSLTJ.Properties.Resources.close;
            this.pictureBox1.Location = new System.Drawing.Point(847, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LblMessage
            // 
            this.LblMessage.BackColor = System.Drawing.Color.LemonChiffon;
            this.LblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMessage.ForeColor = System.Drawing.Color.DarkRed;
            this.LblMessage.Location = new System.Drawing.Point(-4, 0);
            this.LblMessage.Name = "LblMessage";
            this.LblMessage.Size = new System.Drawing.Size(898, 41);
            this.LblMessage.TabIndex = 41;
            this.LblMessage.Text = "Message";
            this.LblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblMessage.Visible = false;
            // 
            // TLabelMessage
            // 
            this.TLabelMessage.Enabled = true;
            this.TLabelMessage.Interval = 10000;
            this.TLabelMessage.Tick += new System.EventHandler(this.TLabelMessage_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(891, 632);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.LblMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_CategoriesBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.CreateVoucher.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblCategoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxAddRecordButton)).EndInit();
            this.ViewReports.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.AddCategory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCategory)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxAddCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCategoriesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCategoriesBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource tbl_CategoriesBindingSource;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage CreateVoucher;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox TxtEnteredBy;
        private System.Windows.Forms.TextBox TxtCreditAmount;
        private System.Windows.Forms.TextBox TxtDebitAmount;
        private System.Windows.Forms.TextBox TxtVoucherNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox TextDescription;
        private System.Windows.Forms.TabPage ViewReports;
        private System.Windows.Forms.TabPage AddCategory;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox PBoxAddRecordButton;
        private System.Windows.Forms.DateTimePicker DTPVoucherDate;
        private System.Windows.Forms.ComboBox CmbVoucherType;
        private System.Windows.Forms.ComboBox CmbCategory;
        private System.Windows.Forms.BindingSource tblCategoriesBindingSource;
        private System.Windows.Forms.ComboBox CmbAccountID;
        private System.Windows.Forms.ComboBox CmbOppositeAccountID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker DTPEntryDate;
        private System.Windows.Forms.Label LblVM;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox TxtDescription;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox PBoxAddCategory;
        private System.Windows.Forms.TextBox TxtAccountName;
        private System.Windows.Forms.DataGridView DGVCategory;
        private System.Windows.Forms.BindingSource tblCategoriesBindingSource1;
        private System.Windows.Forms.BindingSource tblCategoriesBindingSource2;
        private System.Windows.Forms.Label LblMessage;
        private System.Windows.Forms.Timer TLabelMessage;
    }
}