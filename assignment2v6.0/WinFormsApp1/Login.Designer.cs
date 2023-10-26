namespace assignment2
{
    partial class LoginForm
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
            this.LoginTitle = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Button();
            this.NewUser = new System.Windows.Forms.Button();
            this.PassTxtbox = new System.Windows.Forms.TextBox();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.UsernameLbl = new System.Windows.Forms.Label();
            this.userTxtBx = new System.Windows.Forms.TextBox();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginTitle
            // 
            this.LoginTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginTitle.AutoSize = true;
            this.LoginTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginTitle.Location = new System.Drawing.Point(232, 71);
            this.LoginTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LoginTitle.Name = "LoginTitle";
            this.LoginTitle.Size = new System.Drawing.Size(201, 39);
            this.LoginTitle.TabIndex = 8;
            this.LoginTitle.Text = "Hotel Login";
            this.LoginTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // Login
            // 
            this.Login.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Login.Location = new System.Drawing.Point(437, 235);
            this.Login.Margin = new System.Windows.Forms.Padding(4);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(100, 28);
            this.Login.TabIndex = 14;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // NewUser
            // 
            this.NewUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NewUser.Location = new System.Drawing.Point(329, 235);
            this.NewUser.Margin = new System.Windows.Forms.Padding(4);
            this.NewUser.Name = "NewUser";
            this.NewUser.Size = new System.Drawing.Size(100, 28);
            this.NewUser.TabIndex = 13;
            this.NewUser.Text = "New User";
            this.NewUser.UseVisualStyleBackColor = true;
            this.NewUser.Click += new System.EventHandler(this.NewUserBtn_Click);
            // 
            // PassTxtbox
            // 
            this.PassTxtbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PassTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassTxtbox.Location = new System.Drawing.Point(239, 197);
            this.PassTxtbox.Margin = new System.Windows.Forms.Padding(4);
            this.PassTxtbox.Name = "PassTxtbox";
            this.PassTxtbox.PasswordChar = '*';
            this.PassTxtbox.Size = new System.Drawing.Size(309, 30);
            this.PassTxtbox.TabIndex = 12;
            this.PassTxtbox.TextChanged += new System.EventHandler(this.PassTxtbox_TextChanged);
            // 
            // passwordLbl
            // 
            this.passwordLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLbl.Location = new System.Drawing.Point(67, 195);
            this.passwordLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(149, 31);
            this.passwordLbl.TabIndex = 11;
            this.passwordLbl.Text = "Password: ";
            this.passwordLbl.Click += new System.EventHandler(this.passwordLbl_Click);
            // 
            // UsernameLbl
            // 
            this.UsernameLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsernameLbl.AutoSize = true;
            this.UsernameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLbl.Location = new System.Drawing.Point(67, 146);
            this.UsernameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UsernameLbl.Name = "UsernameLbl";
            this.UsernameLbl.Size = new System.Drawing.Size(154, 31);
            this.UsernameLbl.TabIndex = 10;
            this.UsernameLbl.Text = "Username: ";
            this.UsernameLbl.Click += new System.EventHandler(this.UsernameLbl_Click);
            // 
            // userTxtBx
            // 
            this.userTxtBx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTxtBx.Location = new System.Drawing.Point(239, 148);
            this.userTxtBx.Margin = new System.Windows.Forms.Padding(4);
            this.userTxtBx.Name = "userTxtBx";
            this.userTxtBx.Size = new System.Drawing.Size(309, 30);
            this.userTxtBx.TabIndex = 9;
            this.userTxtBx.TextChanged += new System.EventHandler(this.userTxtBx_TextChanged);
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.Location = new System.Drawing.Point(600, 358);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(101, 28);
            this.Exit.TabIndex = 17;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 398);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.NewUser);
            this.Controls.Add(this.PassTxtbox);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.UsernameLbl);
            this.Controls.Add(this.userTxtBx);
            this.Controls.Add(this.LoginTitle);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoginTitle;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button NewUser;
        private System.Windows.Forms.TextBox PassTxtbox;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.Label UsernameLbl;
        private System.Windows.Forms.TextBox userTxtBx;
        private System.Windows.Forms.Button Exit;
    }
}

