namespace assignment2
{
    partial class NewCustomerForm
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
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dobPicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.phoneTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.emailTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.passReenterTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.passTxtBox = new System.Windows.Forms.TextBox();
            this.userTxtBox = new System.Windows.Forms.TextBox();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.fNameTxtBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.surnameTxtBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.addressTxtBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cityTxtBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Location = new System.Drawing.Point(443, 525);
            this.SubmitBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(100, 28);
            this.SubmitBtn.TabIndex = 31;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(234, 525);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(100, 28);
            this.CancelBtn.TabIndex = 30;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(228, 18);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 31);
            this.label7.TabIndex = 32;
            this.label7.Text = "New User";
            // 
            // dobPicker
            // 
            this.dobPicker.CustomFormat = "dd-MM-yyyy";
            this.dobPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.dobPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dobPicker.Location = new System.Drawing.Point(234, 475);
            this.dobPicker.Margin = new System.Windows.Forms.Padding(4);
            this.dobPicker.Name = "dobPicker";
            this.dobPicker.Size = new System.Drawing.Size(309, 26);
            this.dobPicker.TabIndex = 29;
            this.dobPicker.ValueChanged += new System.EventHandler(this.dobPicker_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 477);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Date of Birth:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 238);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Last Name:";
            // 
            // phoneTxtBox
            // 
            this.phoneTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTxtBox.Location = new System.Drawing.Point(234, 315);
            this.phoneTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.phoneTxtBox.Name = "phoneTxtBox";
            this.phoneTxtBox.Size = new System.Drawing.Size(309, 26);
            this.phoneTxtBox.TabIndex = 25;
            this.phoneTxtBox.TextChanged += new System.EventHandler(this.phoneTxtBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 198);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "First Name:";
            // 
            // emailTxtBox
            // 
            this.emailTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTxtBox.Location = new System.Drawing.Point(234, 275);
            this.emailTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.emailTxtBox.Name = "emailTxtBox";
            this.emailTxtBox.Size = new System.Drawing.Size(309, 26);
            this.emailTxtBox.TabIndex = 24;
            this.emailTxtBox.TextChanged += new System.EventHandler(this.emailTxtBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 158);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Re-enter Password:";
            // 
            // passReenterTxtBox
            // 
            this.passReenterTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passReenterTxtBox.Location = new System.Drawing.Point(234, 155);
            this.passReenterTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.passReenterTxtBox.Name = "passReenterTxtBox";
            this.passReenterTxtBox.PasswordChar = '*';
            this.passReenterTxtBox.Size = new System.Drawing.Size(309, 26);
            this.passReenterTxtBox.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 118);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Password:";
            // 
            // passTxtBox
            // 
            this.passTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passTxtBox.Location = new System.Drawing.Point(234, 115);
            this.passTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.passTxtBox.Name = "passTxtBox";
            this.passTxtBox.PasswordChar = '*';
            this.passTxtBox.Size = new System.Drawing.Size(309, 26);
            this.passTxtBox.TabIndex = 20;
            this.passTxtBox.TextChanged += new System.EventHandler(this.passTxtBox_TextChanged);
            // 
            // userTxtBox
            // 
            this.userTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTxtBox.Location = new System.Drawing.Point(234, 75);
            this.userTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.userTxtBox.Name = "userTxtBox";
            this.userTxtBox.Size = new System.Drawing.Size(309, 26);
            this.userTxtBox.TabIndex = 19;
            this.userTxtBox.TextChanged += new System.EventHandler(this.userTxtBx_TextChanged);
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLbl.Location = new System.Drawing.Point(57, 78);
            this.usernameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(91, 20);
            this.usernameLbl.TabIndex = 18;
            this.usernameLbl.Text = "Username:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(57, 281);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 36;
            this.label6.Text = "E-Mail:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // fNameTxtBox
            // 
            this.fNameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fNameTxtBox.Location = new System.Drawing.Point(234, 195);
            this.fNameTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.fNameTxtBox.Name = "fNameTxtBox";
            this.fNameTxtBox.Size = new System.Drawing.Size(309, 26);
            this.fNameTxtBox.TabIndex = 22;
            this.fNameTxtBox.TextChanged += new System.EventHandler(this.fNameTxtBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(57, 318);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 20);
            this.label8.TabIndex = 38;
            this.label8.Text = "Phone Number:";
            // 
            // surnameTxtBox
            // 
            this.surnameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnameTxtBox.Location = new System.Drawing.Point(234, 235);
            this.surnameTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.surnameTxtBox.Name = "surnameTxtBox";
            this.surnameTxtBox.Size = new System.Drawing.Size(309, 26);
            this.surnameTxtBox.TabIndex = 23;
            this.surnameTxtBox.TextChanged += new System.EventHandler(this.surnameTxtBox_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.userTxtBox);
            this.groupBox1.Controls.Add(this.stateComboBox);
            this.groupBox1.Controls.Add(this.usernameLbl);
            this.groupBox1.Controls.Add(this.SubmitBtn);
            this.groupBox1.Controls.Add(this.CancelBtn);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cityTxtBox);
            this.groupBox1.Controls.Add(this.dobPicker);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.addressTxtBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.surnameTxtBox);
            this.groupBox1.Controls.Add(this.passTxtBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.phoneTxtBox);
            this.groupBox1.Controls.Add(this.fNameTxtBox);
            this.groupBox1.Controls.Add(this.passReenterTxtBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.emailTxtBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(150, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(650, 600);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add User";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(57, 358);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 20);
            this.label9.TabIndex = 40;
            this.label9.Text = "Address:";
            // 
            // addressTxtBox
            // 
            this.addressTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTxtBox.Location = new System.Drawing.Point(234, 355);
            this.addressTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.addressTxtBox.Name = "addressTxtBox";
            this.addressTxtBox.Size = new System.Drawing.Size(309, 26);
            this.addressTxtBox.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(57, 398);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 20);
            this.label10.TabIndex = 42;
            this.label10.Text = "City:";
            // 
            // cityTxtBox
            // 
            this.cityTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityTxtBox.Location = new System.Drawing.Point(234, 395);
            this.cityTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.cityTxtBox.Name = "cityTxtBox";
            this.cityTxtBox.Size = new System.Drawing.Size(309, 26);
            this.cityTxtBox.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(57, 435);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 20);
            this.label11.TabIndex = 44;
            this.label11.Text = "State:";
            // 
            // stateComboBox
            // 
            this.stateComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.Items.AddRange(new object[] {
            "New South Wales",
            "Queensland",
            "Victoria",
            "Northern Territory",
            "South Australia",
            "Tasmania",
            "Western Australia"});
            this.stateComboBox.Location = new System.Drawing.Point(234, 435);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(309, 26);
            this.stateComboBox.TabIndex = 28;
            // 
            // NewCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(932, 753);
            this.Controls.Add(this.groupBox1);
            this.Name = "NewCustomerForm";
            this.Text = "Add New User";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dobPicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox phoneTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox emailTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passReenterTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passTxtBox;
        private System.Windows.Forms.TextBox userTxtBox;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox fNameTxtBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox surnameTxtBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox cityTxtBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox addressTxtBox;
        private System.Windows.Forms.ComboBox stateComboBox;
    }
}