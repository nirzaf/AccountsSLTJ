namespace AccountsSLTJ
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.PBoxCloseButton = new System.Windows.Forms.PictureBox();
            this.PBoxLoginButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxCloseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxLoginButton)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(496, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to SLTJ HO Accounts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // TxtUsername
            // 
            this.TxtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsername.Location = new System.Drawing.Point(178, 91);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(224, 29);
            this.TxtUsername.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.Location = new System.Drawing.Point(178, 137);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(224, 29);
            this.TxtPassword.TabIndex = 4;
            this.TxtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPassword_KeyPress);
            // 
            // PBoxCloseButton
            // 
            this.PBoxCloseButton.Image = global::AccountsSLTJ.Properties.Resources.close;
            this.PBoxCloseButton.Location = new System.Drawing.Point(296, 201);
            this.PBoxCloseButton.Name = "PBoxCloseButton";
            this.PBoxCloseButton.Size = new System.Drawing.Size(106, 102);
            this.PBoxCloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBoxCloseButton.TabIndex = 6;
            this.PBoxCloseButton.TabStop = false;
            this.PBoxCloseButton.Click += new System.EventHandler(this.PBoxCloseButton_Click);
            // 
            // PBoxLoginButton
            // 
            this.PBoxLoginButton.Image = global::AccountsSLTJ.Properties.Resources.Login;
            this.PBoxLoginButton.Location = new System.Drawing.Point(178, 201);
            this.PBoxLoginButton.Name = "PBoxLoginButton";
            this.PBoxLoginButton.Size = new System.Drawing.Size(106, 102);
            this.PBoxLoginButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBoxLoginButton.TabIndex = 5;
            this.PBoxLoginButton.TabStop = false;
            this.PBoxLoginButton.Click += new System.EventHandler(this.PBoxLoginButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(561, 351);
            this.Controls.Add(this.PBoxCloseButton);
            this.Controls.Add(this.PBoxLoginButton);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to SLTJ HO Accounts ";
            ((System.ComponentModel.ISupportInitialize)(this.PBoxCloseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxLoginButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.PictureBox PBoxLoginButton;
        private System.Windows.Forms.PictureBox PBoxCloseButton;
    }
}

