namespace assignment2
{
    partial class Form3
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dobPicker = new DateTimePicker();
            label6 = new Label();
            SubmitBtn = new Button();
            CancelBtn = new Button();
            usernameTxtBox = new MaskedTextBox();
            passwordTxtBox = new MaskedTextBox();
            confirmPwTxtBox = new MaskedTextBox();
            fNameTxtBox = new MaskedTextBox();
            surnameTxtBox = new MaskedTextBox();
            label7 = new Label();
            label8 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            genderBox = new GroupBox();
            groupBox1 = new GroupBox();
            comboBox1 = new ComboBox();
            label9 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(215, 46);
            label1.Name = "label1";
            label1.Size = new Size(191, 29);
            label1.TabIndex = 0;
            label1.Text = "Add Employee";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(19, 136);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 1;
            label2.Text = "Username:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(19, 218);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 2;
            label3.Text = "Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(19, 294);
            label4.Name = "label4";
            label4.Size = new Size(160, 20);
            label4.TabIndex = 3;
            label4.Text = "Re-Enter Password:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(19, 454);
            label5.Name = "label5";
            label5.Size = new Size(97, 20);
            label5.TabIndex = 4;
            label5.Text = "First Name:";
            // 
            // dobPicker
            // 
            dobPicker.CustomFormat = "dd-MM-yyyy";
            dobPicker.Format = DateTimePickerFormat.Custom;
            dobPicker.Location = new Point(220, 576);
            dobPicker.Margin = new Padding(4, 5, 4, 5);
            dobPicker.Name = "dobPicker";
            dobPicker.Size = new Size(319, 27);
            dobPicker.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(19, 579);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(110, 20);
            label6.TabIndex = 13;
            label6.Text = "Date of Birth:";
            // 
            // SubmitBtn
            // 
            SubmitBtn.Location = new Point(439, 702);
            SubmitBtn.Margin = new Padding(4, 5, 4, 5);
            SubmitBtn.Name = "SubmitBtn";
            SubmitBtn.Size = new Size(100, 35);
            SubmitBtn.TabIndex = 19;
            SubmitBtn.Text = "Submit";
            SubmitBtn.UseVisualStyleBackColor = true;
            SubmitBtn.Click += SubmitBtn_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.Location = new Point(220, 702);
            CancelBtn.Margin = new Padding(4, 5, 4, 5);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(100, 35);
            CancelBtn.TabIndex = 18;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = true;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // usernameTxtBox
            // 
            usernameTxtBox.Location = new Point(426, 252);
            usernameTxtBox.Margin = new Padding(3, 4, 3, 4);
            usernameTxtBox.Name = "usernameTxtBox";
            usernameTxtBox.Size = new Size(319, 27);
            usernameTxtBox.TabIndex = 20;
            usernameTxtBox.MaskInputRejected += usernameTxtBox_MaskInputRejected;
            // 
            // passwordTxtBox
            // 
            passwordTxtBox.Location = new Point(426, 334);
            passwordTxtBox.Margin = new Padding(3, 4, 3, 4);
            passwordTxtBox.Name = "passwordTxtBox";
            passwordTxtBox.Size = new Size(319, 27);
            passwordTxtBox.TabIndex = 21;
            // 
            // confirmPwTxtBox
            // 
            confirmPwTxtBox.Location = new Point(426, 410);
            confirmPwTxtBox.Margin = new Padding(3, 4, 3, 4);
            confirmPwTxtBox.Name = "confirmPwTxtBox";
            confirmPwTxtBox.Size = new Size(319, 27);
            confirmPwTxtBox.TabIndex = 22;
            // 
            // fNameTxtBox
            // 
            fNameTxtBox.Location = new Point(426, 570);
            fNameTxtBox.Margin = new Padding(3, 4, 3, 4);
            fNameTxtBox.Name = "fNameTxtBox";
            fNameTxtBox.Size = new Size(319, 27);
            fNameTxtBox.TabIndex = 23;
            // 
            // surnameTxtBox
            // 
            surnameTxtBox.Location = new Point(426, 639);
            surnameTxtBox.Margin = new Padding(3, 4, 3, 4);
            surnameTxtBox.Name = "surnameTxtBox";
            surnameTxtBox.Size = new Size(319, 27);
            surnameTxtBox.TabIndex = 25;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(19, 522);
            label7.Name = "label7";
            label7.Size = new Size(101, 20);
            label7.TabIndex = 24;
            label7.Text = "Last Name: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(19, 370);
            label8.Name = "label8";
            label8.Size = new Size(69, 20);
            label8.TabIndex = 26;
            label8.Text = "Gender:";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(433, 489);
            radioButton1.Margin = new Padding(3, 4, 3, 4);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(63, 24);
            radioButton1.TabIndex = 27;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(545, 488);
            radioButton2.Margin = new Padding(3, 4, 3, 4);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(78, 24);
            radioButton2.TabIndex = 28;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(682, 488);
            radioButton3.Margin = new Padding(3, 4, 3, 4);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(67, 24);
            radioButton3.TabIndex = 29;
            radioButton3.TabStop = true;
            radioButton3.Text = "Other";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // genderBox
            // 
            genderBox.Location = new Point(426, 459);
            genderBox.Margin = new Padding(3, 4, 3, 4);
            genderBox.Name = "genderBox";
            genderBox.Padding = new Padding(3, 4, 3, 4);
            genderBox.Size = new Size(331, 82);
            genderBox.TabIndex = 30;
            genderBox.TabStop = false;
            genderBox.Text = "Gender";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(CancelBtn);
            groupBox1.Controls.Add(SubmitBtn);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dobPicker);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(206, 119);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(663, 764);
            groupBox1.TabIndex = 49;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Employee";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Housekeeping", "Manager", "Room Service", "Accountant", "Receptionist", "Head Chef", "Support" });
            comboBox1.Location = new Point(220, 640);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(326, 28);
            comboBox1.TabIndex = 49;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(19, 645);
            label9.Name = "label9";
            label9.Size = new Size(126, 20);
            label9.TabIndex = 48;
            label9.Text = "Employee Role:";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 1028);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(surnameTxtBox);
            Controls.Add(fNameTxtBox);
            Controls.Add(confirmPwTxtBox);
            Controls.Add(passwordTxtBox);
            Controls.Add(usernameTxtBox);
            Controls.Add(genderBox);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker dobPicker;
        private Label label6;
        private Button SubmitBtn;
        private Button CancelBtn;
        private MaskedTextBox usernameTxtBox;
        private MaskedTextBox passwordTxtBox;
        private MaskedTextBox confirmPwTxtBox;
        private MaskedTextBox fNameTxtBox;
        private MaskedTextBox surnameTxtBox;
        private Label label7;
        private Label label8;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private GroupBox genderBox;
        private GroupBox groupBox1;
        private ComboBox comboBox1;
        private Label label9;
    }
}