namespace assignment2
{
    partial class Admin
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
            LogoutBtn = new Button();
            AdminTitle = new Label();
            SearchRoomBtn = new Button();
            DeleteCustomerBtn = new Button();
            label2 = new Label();
            AllCustomerBtn = new Button();
            SearchCustomerBtn = new Button();
            label3 = new Label();
            AllRoomsBtn = new Button();
            label4 = new Label();
            AllDishesBtn = new Button();
            SearchDishBtn = new Button();
            AddDishBtn = new Button();
            button2 = new Button();
            groupBox1 = new GroupBox();
            AddEmployeeButton = new Button();
            button4 = new Button();
            button3 = new Button();
            viewComplaints = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // LogoutBtn
            // 
            LogoutBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LogoutBtn.Location = new Point(7, 646);
            LogoutBtn.Margin = new Padding(4, 5, 4, 5);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(100, 35);
            LogoutBtn.TabIndex = 33;
            LogoutBtn.Text = "Logout";
            LogoutBtn.UseVisualStyleBackColor = true;
            LogoutBtn.Click += LogoutBtn_Click;
            // 
            // AdminTitle
            // 
            AdminTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AdminTitle.AutoSize = true;
            AdminTitle.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            AdminTitle.Location = new Point(222, 106);
            AdminTitle.Margin = new Padding(4, 0, 4, 0);
            AdminTitle.Name = "AdminTitle";
            AdminTitle.Size = new Size(174, 31);
            AdminTitle.TabIndex = 32;
            AdminTitle.Text = "Admin Menu";
            AdminTitle.Click += label1_Click;
            // 
            // SearchRoomBtn
            // 
            SearchRoomBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SearchRoomBtn.Location = new Point(361, 381);
            SearchRoomBtn.Margin = new Padding(4, 5, 4, 5);
            SearchRoomBtn.Name = "SearchRoomBtn";
            SearchRoomBtn.Size = new Size(140, 38);
            SearchRoomBtn.TabIndex = 39;
            SearchRoomBtn.Text = "Search Room";
            SearchRoomBtn.UseVisualStyleBackColor = true;
            SearchRoomBtn.Click += button5_Click;
            // 
            // DeleteCustomerBtn
            // 
            DeleteCustomerBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DeleteCustomerBtn.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteCustomerBtn.Location = new Point(219, 224);
            DeleteCustomerBtn.Margin = new Padding(4, 5, 4, 5);
            DeleteCustomerBtn.Name = "DeleteCustomerBtn";
            DeleteCustomerBtn.Size = new Size(140, 38);
            DeleteCustomerBtn.TabIndex = 38;
            DeleteCustomerBtn.Text = "Delete Customer Account";
            DeleteCustomerBtn.UseVisualStyleBackColor = true;
            DeleteCustomerBtn.Click += button6_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(73, 182);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(131, 29);
            label2.TabIndex = 44;
            label2.Text = "Customer";
            label2.Click += label2_Click;
            // 
            // AllCustomerBtn
            // 
            AllCustomerBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AllCustomerBtn.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Regular, GraphicsUnit.Point);
            AllCustomerBtn.Location = new Point(78, 224);
            AllCustomerBtn.Margin = new Padding(4, 5, 4, 5);
            AllCustomerBtn.Name = "AllCustomerBtn";
            AllCustomerBtn.Size = new Size(140, 38);
            AllCustomerBtn.TabIndex = 45;
            AllCustomerBtn.Text = "All Customer Accounts";
            AllCustomerBtn.UseVisualStyleBackColor = true;
            AllCustomerBtn.Click += AllCustomerBtn_Click;
            // 
            // SearchCustomerBtn
            // 
            SearchCustomerBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SearchCustomerBtn.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Regular, GraphicsUnit.Point);
            SearchCustomerBtn.Location = new Point(361, 224);
            SearchCustomerBtn.Margin = new Padding(4, 5, 4, 5);
            SearchCustomerBtn.Name = "SearchCustomerBtn";
            SearchCustomerBtn.Size = new Size(140, 38);
            SearchCustomerBtn.TabIndex = 46;
            SearchCustomerBtn.Text = "Search Customer Account";
            SearchCustomerBtn.UseVisualStyleBackColor = true;
            SearchCustomerBtn.Click += button10_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(73, 340);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(85, 29);
            label3.TabIndex = 48;
            label3.Text = "Room";
            label3.Click += label3_Click_1;
            // 
            // AllRoomsBtn
            // 
            AllRoomsBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AllRoomsBtn.Location = new Point(219, 381);
            AllRoomsBtn.Margin = new Padding(4, 5, 4, 5);
            AllRoomsBtn.Name = "AllRoomsBtn";
            AllRoomsBtn.Size = new Size(140, 38);
            AllRoomsBtn.TabIndex = 49;
            AllRoomsBtn.Text = "All Rooms";
            AllRoomsBtn.UseVisualStyleBackColor = true;
            AllRoomsBtn.Click += button7_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(76, 475);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(142, 29);
            label4.TabIndex = 51;
            label4.Text = "Hospitality";
            label4.Click += label4_Click;
            // 
            // AllDishesBtn
            // 
            AllDishesBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AllDishesBtn.Location = new Point(219, 516);
            AllDishesBtn.Margin = new Padding(4, 5, 4, 5);
            AllDishesBtn.Name = "AllDishesBtn";
            AllDishesBtn.Size = new Size(140, 38);
            AllDishesBtn.TabIndex = 52;
            AllDishesBtn.Text = "All Dishes";
            AllDishesBtn.UseVisualStyleBackColor = true;
            AllDishesBtn.Click += button13_Click;
            // 
            // SearchDishBtn
            // 
            SearchDishBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SearchDishBtn.Location = new Point(361, 516);
            SearchDishBtn.Margin = new Padding(4, 5, 4, 5);
            SearchDishBtn.Name = "SearchDishBtn";
            SearchDishBtn.Size = new Size(140, 38);
            SearchDishBtn.TabIndex = 53;
            SearchDishBtn.Text = "Search Dish";
            SearchDishBtn.UseVisualStyleBackColor = true;
            SearchDishBtn.Click += button14_Click;
            // 
            // AddDishBtn
            // 
            AddDishBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AddDishBtn.Location = new Point(78, 516);
            AddDishBtn.Margin = new Padding(4, 5, 4, 5);
            AddDishBtn.Name = "AddDishBtn";
            AddDishBtn.Size = new Size(140, 38);
            AddDishBtn.TabIndex = 54;
            AddDishBtn.Text = "Add Dish";
            AddDishBtn.UseVisualStyleBackColor = true;
            AddDishBtn.Click += button15_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button2.Location = new Point(78, 381);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(140, 38);
            button2.TabIndex = 57;
            button2.Text = "Add Room";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(AddEmployeeButton);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(viewComplaints);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(LogoutBtn);
            groupBox1.Controls.Add(AllCustomerBtn);
            groupBox1.Controls.Add(SearchCustomerBtn);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(AllRoomsBtn);
            groupBox1.Controls.Add(AddDishBtn);
            groupBox1.Controls.Add(AllDishesBtn);
            groupBox1.Controls.Add(DeleteCustomerBtn);
            groupBox1.Controls.Add(SearchRoomBtn);
            groupBox1.Controls.Add(SearchDishBtn);
            groupBox1.Location = new Point(13, 21);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(585, 690);
            groupBox1.TabIndex = 58;
            groupBox1.TabStop = false;
            groupBox1.Text = "Admin Menu";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // AddEmployeeButton
            // 
            AddEmployeeButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AddEmployeeButton.Location = new Point(438, 643);
            AddEmployeeButton.Margin = new Padding(4, 5, 4, 5);
            AddEmployeeButton.Name = "AddEmployeeButton";
            AddEmployeeButton.Size = new Size(140, 38);
            AddEmployeeButton.TabIndex = 62;
            AddEmployeeButton.Text = "Add Receptionist";
            AddEmployeeButton.UseVisualStyleBackColor = true;
            AddEmployeeButton.Click += AddEmployeeButton_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button4.Location = new Point(444, 643);
            button4.Margin = new Padding(4, 5, 4, 5);
            button4.Name = "button4";
            button4.Size = new Size(0, 38);
            button4.TabIndex = 61;
            button4.Text = "Add Room";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button3.Location = new Point(222, 326);
            button3.Margin = new Padding(4, 5, 4, 5);
            button3.Name = "button3";
            button3.Size = new Size(0, 38);
            button3.TabIndex = 60;
            button3.Text = "Add Room";
            button3.UseVisualStyleBackColor = true;
            // 
            // viewComplaints
            // 
            viewComplaints.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            viewComplaints.Location = new Point(219, 270);
            viewComplaints.Name = "viewComplaints";
            viewComplaints.Size = new Size(140, 37);
            viewComplaints.TabIndex = 59;
            viewComplaints.Text = "View Complaints";
            viewComplaints.UseVisualStyleBackColor = true;
            viewComplaints.Click += viewComplaints_Click;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 726);
            Controls.Add(AdminTitle);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Admin";
            Text = "Admin";
            Load += Admin_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button LogoutBtn;
        private Label AdminTitle;
        private Button SearchRoomBtn;
        private Button DeleteCustomerBtn;
        private Label label2;
        private Button AllCustomerBtn;
        private Button SearchCustomerBtn;
        private Label label3;
        private Button AllRoomsBtn;
        private Label label4;
        private Button AllDishesBtn;
        private Button SearchDishBtn;
        private Button AddDishBtn;
        private Button button2;
        private GroupBox groupBox1;
        private Button viewComplaints;
        private Button button3;
        private Button AddEmployeeButton;
        private Button button4;
    }
}