namespace assignment2
{
    partial class AddEmployee
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
            label8 = new Label();
            surnameTxtBox = new TextBox();
            label6 = new Label();
            fNameTxtBox = new TextBox();
            SubmitBtn = new Button();
            CancelBtn = new Button();
            label7 = new Label();
            dobPicker = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            phoneTxtBox = new TextBox();
            label3 = new Label();
            emailTxtBox = new TextBox();
            label2 = new Label();
            passReenterTxtBox = new TextBox();
            label1 = new Label();
            passTxtBox = new TextBox();
            userTxtBox = new TextBox();
            usernameLbl = new Label();
            stateComboBox = new ComboBox();
            label11 = new Label();
            label10 = new Label();
            cityTxtBox = new TextBox();
            label12 = new Label();
            addressTxtBox = new TextBox();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(208, 353);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(125, 20);
            label8.TabIndex = 57;
            label8.Text = "Phone Number:";
            label8.Click += label8_Click;
            // 
            // surnameTxtBox
            // 
            surnameTxtBox.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            surnameTxtBox.Location = new Point(385, 270);
            surnameTxtBox.Margin = new Padding(4, 5, 4, 5);
            surnameTxtBox.Name = "surnameTxtBox";
            surnameTxtBox.Size = new Size(309, 26);
            surnameTxtBox.TabIndex = 45;
            surnameTxtBox.TextChanged += surnameTxtBox_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(209, 313);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 56;
            label6.Text = "E-Mail:";
            label6.Click += label6_Click;
            // 
            // fNameTxtBox
            // 
            fNameTxtBox.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            fNameTxtBox.Location = new Point(385, 230);
            fNameTxtBox.Margin = new Padding(4, 5, 4, 5);
            fNameTxtBox.Name = "fNameTxtBox";
            fNameTxtBox.Size = new Size(309, 26);
            fNameTxtBox.TabIndex = 44;
            fNameTxtBox.TextChanged += fNameTxtBox_TextChanged;
            // 
            // SubmitBtn
            // 
            SubmitBtn.Location = new Point(594, 567);
            SubmitBtn.Margin = new Padding(4, 5, 4, 5);
            SubmitBtn.Name = "SubmitBtn";
            SubmitBtn.Size = new Size(100, 35);
            SubmitBtn.TabIndex = 53;
            SubmitBtn.Text = "Submit";
            SubmitBtn.UseVisualStyleBackColor = true;
            SubmitBtn.Click += SubmitBtn_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.Location = new Point(385, 567);
            CancelBtn.Margin = new Padding(4, 5, 4, 5);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(100, 35);
            CancelBtn.TabIndex = 54;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = true;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(385, 43);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(243, 31);
            label7.TabIndex = 55;
            label7.Text = "New Receptionist";
            label7.Click += label7_Click;
            // 
            // dobPicker
            // 
            dobPicker.CustomFormat = "dd-MM-yyyy";
            dobPicker.Format = DateTimePickerFormat.Custom;
            dobPicker.Location = new Point(385, 505);
            dobPicker.Margin = new Padding(4, 5, 4, 5);
            dobPicker.Name = "dobPicker";
            dobPicker.Size = new Size(309, 27);
            dobPicker.TabIndex = 52;
            dobPicker.ValueChanged += dobPicker_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(209, 510);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(110, 20);
            label5.TabIndex = 54;
            label5.Text = "Date of Birth:";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(209, 273);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(96, 20);
            label4.TabIndex = 51;
            label4.Text = "Last Name:";
            label4.Click += label4_Click;
            // 
            // phoneTxtBox
            // 
            phoneTxtBox.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            phoneTxtBox.Location = new Point(385, 350);
            phoneTxtBox.Margin = new Padding(4, 5, 4, 5);
            phoneTxtBox.Name = "phoneTxtBox";
            phoneTxtBox.Size = new Size(309, 26);
            phoneTxtBox.TabIndex = 47;
            phoneTxtBox.TextChanged += phoneTxtBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(208, 233);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 49;
            label3.Text = "First Name:";
            label3.Click += label3_Click;
            // 
            // emailTxtBox
            // 
            emailTxtBox.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            emailTxtBox.Location = new Point(385, 310);
            emailTxtBox.Margin = new Padding(4, 5, 4, 5);
            emailTxtBox.Name = "emailTxtBox";
            emailTxtBox.Size = new Size(309, 26);
            emailTxtBox.TabIndex = 46;
            emailTxtBox.TextChanged += emailTxtBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(208, 193);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(158, 20);
            label2.TabIndex = 46;
            label2.Text = "Re-enter Password:";
            label2.Click += label2_Click;
            // 
            // passReenterTxtBox
            // 
            passReenterTxtBox.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            passReenterTxtBox.Location = new Point(385, 190);
            passReenterTxtBox.Margin = new Padding(4, 5, 4, 5);
            passReenterTxtBox.Name = "passReenterTxtBox";
            passReenterTxtBox.PasswordChar = '*';
            passReenterTxtBox.Size = new Size(309, 26);
            passReenterTxtBox.TabIndex = 43;
            passReenterTxtBox.TextChanged += passReenterTxtBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(209, 153);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 42;
            label1.Text = "Password:";
            label1.Click += label1_Click;
            // 
            // passTxtBox
            // 
            passTxtBox.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            passTxtBox.Location = new Point(385, 150);
            passTxtBox.Margin = new Padding(4, 5, 4, 5);
            passTxtBox.Name = "passTxtBox";
            passTxtBox.PasswordChar = '*';
            passTxtBox.Size = new Size(309, 26);
            passTxtBox.TabIndex = 41;
            passTxtBox.TextChanged += passTxtBox_TextChanged;
            // 
            // userTxtBox
            // 
            userTxtBox.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            userTxtBox.Location = new Point(385, 110);
            userTxtBox.Margin = new Padding(4, 5, 4, 5);
            userTxtBox.Name = "userTxtBox";
            userTxtBox.Size = new Size(309, 26);
            userTxtBox.TabIndex = 40;
            userTxtBox.TextChanged += userTxtBox_TextChanged;
            // 
            // usernameLbl
            // 
            usernameLbl.AutoSize = true;
            usernameLbl.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            usernameLbl.Location = new Point(208, 113);
            usernameLbl.Margin = new Padding(4, 0, 4, 0);
            usernameLbl.Name = "usernameLbl";
            usernameLbl.Size = new Size(91, 20);
            usernameLbl.TabIndex = 39;
            usernameLbl.Text = "Username:";
            usernameLbl.Click += usernameLbl_Click;
            // 
            // stateComboBox
            // 
            stateComboBox.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            stateComboBox.FormattingEnabled = true;
            stateComboBox.Items.AddRange(new object[] { "New South Wales", "Queensland", "Victoria", "Northern Territory", "South Australia", "Tasmania", "Western Australia" });
            stateComboBox.Location = new Point(385, 470);
            stateComboBox.Margin = new Padding(3, 4, 3, 4);
            stateComboBox.Name = "stateComboBox";
            stateComboBox.Size = new Size(309, 26);
            stateComboBox.TabIndex = 50;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(209, 472);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(53, 20);
            label11.TabIndex = 65;
            label11.Text = "State:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(209, 433);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(43, 20);
            label10.TabIndex = 64;
            label10.Text = "City:";
            // 
            // cityTxtBox
            // 
            cityTxtBox.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cityTxtBox.Location = new Point(385, 430);
            cityTxtBox.Margin = new Padding(4, 5, 4, 5);
            cityTxtBox.Name = "cityTxtBox";
            cityTxtBox.Size = new Size(309, 26);
            cityTxtBox.TabIndex = 49;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(208, 393);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(76, 20);
            label12.TabIndex = 63;
            label12.Text = "Address:";
            // 
            // addressTxtBox
            // 
            addressTxtBox.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            addressTxtBox.Location = new Point(385, 390);
            addressTxtBox.Margin = new Padding(4, 5, 4, 5);
            addressTxtBox.Name = "addressTxtBox";
            addressTxtBox.Size = new Size(309, 26);
            addressTxtBox.TabIndex = 48;
            addressTxtBox.TextChanged += addressTxtBox_TextChanged;
            // 
            // AddEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 645);
            Controls.Add(stateComboBox);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(cityTxtBox);
            Controls.Add(label12);
            Controls.Add(addressTxtBox);
            Controls.Add(label8);
            Controls.Add(surnameTxtBox);
            Controls.Add(label6);
            Controls.Add(fNameTxtBox);
            Controls.Add(SubmitBtn);
            Controls.Add(CancelBtn);
            Controls.Add(label7);
            Controls.Add(dobPicker);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(phoneTxtBox);
            Controls.Add(label3);
            Controls.Add(emailTxtBox);
            Controls.Add(label2);
            Controls.Add(passReenterTxtBox);
            Controls.Add(label1);
            Controls.Add(passTxtBox);
            Controls.Add(userTxtBox);
            Controls.Add(usernameLbl);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddEmployee";
            Text = "Add Employee";
            Load += AddEmployee_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private TextBox surnameTxtBox;
        private Label label6;
        private TextBox fNameTxtBox;
        private Button SubmitBtn;
        private Button CancelBtn;
        private Label label7;
        private DateTimePicker dobPicker;
        private Label label5;
        private Label label4;
        private TextBox phoneTxtBox;
        private Label label3;
        private TextBox emailTxtBox;
        private Label label2;
        private TextBox passReenterTxtBox;
        private Label label1;
        private TextBox passTxtBox;
        private TextBox userTxtBox;
        private Label usernameLbl;
        private ComboBox stateComboBox;
        private Label label11;
        private Label label10;
        private TextBox cityTxtBox;
        private Label label12;
        private TextBox addressTxtBox;
    }
}