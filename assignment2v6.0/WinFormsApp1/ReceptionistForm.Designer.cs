namespace assignment2
{
    partial class ReceptionistForm
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
            btnAddCustomer = new Button();
            menuStrip1 = new MenuStrip();
            manageToolStripMenuItem = new ToolStripMenuItem();
            bookHotelRoomToolStripMenuItem = new ToolStripMenuItem();
            viewAllCustomersToolStripMenuItem = new ToolStripMenuItem();
            reportIncidentToolStripMenuItem = new ToolStripMenuItem();
            foodToolStripMenuItem = new ToolStripMenuItem();
            viewMenuToolStripMenuItem = new ToolStripMenuItem();
            btnBook = new Button();
            lbCustomers = new ListBox();
            lbRooms = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnLogOut = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Location = new Point(55, 498);
            btnAddCustomer.Margin = new Padding(5);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(232, 46);
            btnAddCustomer.TabIndex = 0;
            btnAddCustomer.Text = "Add Customer";
            btnAddCustomer.UseVisualStyleBackColor = true;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { manageToolStripMenuItem, foodToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(10, 3, 0, 3);
            menuStrip1.Size = new Size(1300, 42);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // manageToolStripMenuItem
            // 
            manageToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bookHotelRoomToolStripMenuItem, viewAllCustomersToolStripMenuItem, reportIncidentToolStripMenuItem });
            manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            manageToolStripMenuItem.Size = new Size(121, 36);
            manageToolStripMenuItem.Text = "Manage";
            // 
            // bookHotelRoomToolStripMenuItem
            // 
            bookHotelRoomToolStripMenuItem.Name = "bookHotelRoomToolStripMenuItem";
            bookHotelRoomToolStripMenuItem.Size = new Size(352, 44);
            bookHotelRoomToolStripMenuItem.Text = "Book Hotel Room";
            // 
            // viewAllCustomersToolStripMenuItem
            // 
            viewAllCustomersToolStripMenuItem.Name = "viewAllCustomersToolStripMenuItem";
            viewAllCustomersToolStripMenuItem.Size = new Size(352, 44);
            viewAllCustomersToolStripMenuItem.Text = "View All Customers";
            // 
            // reportIncidentToolStripMenuItem
            // 
            reportIncidentToolStripMenuItem.Name = "reportIncidentToolStripMenuItem";
            reportIncidentToolStripMenuItem.Size = new Size(352, 44);
            reportIncidentToolStripMenuItem.Text = "Report Incident";
            reportIncidentToolStripMenuItem.Click += reportIncidentToolStripMenuItem_Click;
            // 
            // foodToolStripMenuItem
            // 
            foodToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewMenuToolStripMenuItem });
            foodToolStripMenuItem.Name = "foodToolStripMenuItem";
            foodToolStripMenuItem.Size = new Size(88, 36);
            foodToolStripMenuItem.Text = "Food";
            // 
            // viewMenuToolStripMenuItem
            // 
            viewMenuToolStripMenuItem.Name = "viewMenuToolStripMenuItem";
            viewMenuToolStripMenuItem.Size = new Size(268, 44);
            viewMenuToolStripMenuItem.Text = "View Menu";
            // 
            // btnBook
            // 
            btnBook.Location = new Point(855, 626);
            btnBook.Margin = new Padding(5);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(213, 46);
            btnBook.TabIndex = 2;
            btnBook.Text = "Book a Room";
            btnBook.UseVisualStyleBackColor = true;
            btnBook.Click += btnBook_Click;
            // 
            // lbCustomers
            // 
            lbCustomers.FormattingEnabled = true;
            lbCustomers.ItemHeight = 32;
            lbCustomers.Location = new Point(414, 259);
            lbCustomers.Margin = new Padding(5);
            lbCustomers.Name = "lbCustomers";
            lbCustomers.Size = new Size(344, 324);
            lbCustomers.TabIndex = 3;
            lbCustomers.SelectedIndexChanged += lbCustomers_SelectedIndexChanged;
            // 
            // lbRooms
            // 
            lbRooms.FormattingEnabled = true;
            lbRooms.ItemHeight = 32;
            lbRooms.Location = new Point(855, 259);
            lbRooms.Margin = new Padding(5);
            lbRooms.Name = "lbRooms";
            lbRooms.Size = new Size(339, 324);
            lbRooms.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 99);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 5;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(414, 66);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(207, 32);
            label2.TabIndex = 6;
            label2.Text = "Select a Customer";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(855, 82);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(166, 32);
            label3.TabIndex = 7;
            label3.Text = "Select a Room";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnLogOut
            // 
            btnLogOut.Location = new Point(55, 626);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(150, 46);
            btnLogOut.TabIndex = 8;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // ReceptionistForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 720);
            Controls.Add(btnLogOut);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbRooms);
            Controls.Add(lbCustomers);
            Controls.Add(btnBook);
            Controls.Add(btnAddCustomer);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(5);
            Name = "ReceptionistForm";
            Text = "ReceptionistForm";
            Load += ReceptionistForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddCustomer;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem manageToolStripMenuItem;
        private ToolStripMenuItem bookHotelRoomToolStripMenuItem;
        private ToolStripMenuItem viewAllCustomersToolStripMenuItem;
        private ToolStripMenuItem foodToolStripMenuItem;
        private ToolStripMenuItem viewMenuToolStripMenuItem;
        private ToolStripMenuItem reportIncidentToolStripMenuItem;
        private Button btnBook;
        private ListBox lbCustomers;
        private ListBox lbRooms;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnLogOut;
    }
}