namespace assignment2
{
    partial class Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            label7 = new Label();
            label6 = new Label();
            reportButton = new Button();
            roomServiceButton = new Button();
            bookDiningButton = new Button();
            exitButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(25, 27);
            label1.Name = "label1";
            label1.Size = new Size(109, 23);
            label1.TabIndex = 0;
            label1.Text = "Guest Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(25, 63);
            label2.Name = "label2";
            label2.Size = new Size(88, 23);
            label2.TabIndex = 0;
            label2.Text = "Room No:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(25, 101);
            label3.Name = "label3";
            label3.Size = new Size(74, 23);
            label3.TabIndex = 0;
            label3.Text = "Contact:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(25, 139);
            label4.Name = "label4";
            label4.Size = new Size(55, 23);
            label4.TabIndex = 0;
            label4.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(25, 178);
            label5.Name = "label5";
            label5.Size = new Size(126, 23);
            label5.TabIndex = 0;
            label5.Text = "Booking Detail:";
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(reportButton);
            panel1.Controls.Add(roomServiceButton);
            panel1.Controls.Add(bookDiningButton);
            panel1.Location = new Point(483, -6);
            panel1.Name = "panel1";
            panel1.Size = new Size(319, 479);
            panel1.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 9.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(17, 290);
            label7.Name = "label7";
            label7.Size = new Size(276, 42);
            label7.TabIndex = 1;
            label7.Text = "Facing issues or would like to report \r\nan incident?";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(17, 59);
            label6.Name = "label6";
            label6.Size = new Size(271, 23);
            label6.TabIndex = 1;
            label6.Text = "Check out our restaurant services:\r\n";
            // 
            // reportButton
            // 
            reportButton.BackColor = SystemColors.ControlLight;
            reportButton.Cursor = Cursors.Hand;
            reportButton.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            reportButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            reportButton.ForeColor = SystemColors.ActiveCaptionText;
            reportButton.Location = new Point(67, 355);
            reportButton.Name = "reportButton";
            reportButton.Size = new Size(176, 38);
            reportButton.TabIndex = 0;
            reportButton.Text = "Report Incident";
            reportButton.UseVisualStyleBackColor = false;
            reportButton.Click += reportButton_Click;
            // 
            // roomServiceButton
            // 
            roomServiceButton.BackColor = SystemColors.ControlLight;
            roomServiceButton.Cursor = Cursors.Hand;
            roomServiceButton.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            roomServiceButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            roomServiceButton.ForeColor = SystemColors.ActiveCaptionText;
            roomServiceButton.Location = new Point(67, 174);
            roomServiceButton.Name = "roomServiceButton";
            roomServiceButton.Size = new Size(176, 42);
            roomServiceButton.TabIndex = 0;
            roomServiceButton.Text = "Room Service";
            roomServiceButton.UseVisualStyleBackColor = false;
            // 
            // bookDiningButton
            // 
            bookDiningButton.BackColor = SystemColors.ControlLight;
            bookDiningButton.Cursor = Cursors.Hand;
            bookDiningButton.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            bookDiningButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            bookDiningButton.ForeColor = SystemColors.ActiveCaptionText;
            bookDiningButton.Location = new Point(67, 116);
            bookDiningButton.Name = "bookDiningButton";
            bookDiningButton.Size = new Size(176, 42);
            bookDiningButton.TabIndex = 0;
            bookDiningButton.Text = "Book Dining";
            bookDiningButton.UseVisualStyleBackColor = false;
            // 
            // exitButton
            // 
            exitButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            exitButton.Location = new Point(25, 400);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(74, 29);
            exitButton.TabIndex = 2;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(exitButton);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Customer";
            Text = "Customer";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Panel panel1;
        private Button bookDiningButton;
        private Label label6;
        private Button roomServiceButton;
        private Label label7;
        private Button reportButton;
        private Button exitButton;
    }
}