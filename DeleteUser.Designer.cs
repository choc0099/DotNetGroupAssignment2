namespace assignment2
{
    partial class DeleteUser
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
            button1 = new Button();
            deleteUsernameTxtBox = new TextBox();
            label7 = new Label();
            label1 = new Label();
            button2 = new Button();
            deletePasswordTxtBox = new TextBox();
            label2 = new Label();
            deleteNameBox = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(362, 293);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(75, 29);
            button1.TabIndex = 70;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // deleteUsernameTxtBox
            // 
            deleteUsernameTxtBox.Location = new Point(181, 196);
            deleteUsernameTxtBox.Margin = new Padding(3, 4, 3, 4);
            deleteUsernameTxtBox.Name = "deleteUsernameTxtBox";
            deleteUsernameTxtBox.Size = new Size(486, 27);
            deleteUsernameTxtBox.TabIndex = 67;
            deleteUsernameTxtBox.TextChanged += textBox1_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(279, 92);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(233, 31);
            label7.TabIndex = 66;
            label7.Text = "Delete Customer";
            label7.Click += label7_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(102, 200);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 65;
            label1.Text = "Username:";
            label1.Click += label1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(673, 233);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(75, 29);
            button2.TabIndex = 69;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // deletePasswordTxtBox
            // 
            deletePasswordTxtBox.Location = new Point(181, 233);
            deletePasswordTxtBox.Margin = new Padding(3, 4, 3, 4);
            deletePasswordTxtBox.Name = "deletePasswordTxtBox";
            deletePasswordTxtBox.Size = new Size(486, 27);
            deletePasswordTxtBox.TabIndex = 68;
            deletePasswordTxtBox.TextChanged += deletePasswordTxtBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(102, 236);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 71;
            label2.Text = "Password:";
            // 
            // deleteNameBox
            // 
            deleteNameBox.Location = new Point(181, 162);
            deleteNameBox.Margin = new Padding(3, 4, 3, 4);
            deleteNameBox.Name = "deleteNameBox";
            deleteNameBox.Size = new Size(486, 27);
            deleteNameBox.TabIndex = 66;
            deleteNameBox.TextChanged += textBox1_TextChanged_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(96, 162);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 73;
            label3.Text = "Full Name:";
            // 
            // DeleteUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 349);
            Controls.Add(deleteNameBox);
            Controls.Add(label3);
            Controls.Add(deletePasswordTxtBox);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(deleteUsernameTxtBox);
            Controls.Add(label7);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DeleteUser";
            Text = "DeleteUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox deleteUsernameTxtBox;
        private Label label7;
        private Label label1;
        private Button button2;
        private TextBox deletePasswordTxtBox;
        private Label label2;
        private TextBox deleteNameBox;
        private Label label3;
    }
}