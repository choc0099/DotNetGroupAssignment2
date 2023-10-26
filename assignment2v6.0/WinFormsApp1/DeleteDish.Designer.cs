namespace assignment2
{
    partial class DeleteDish
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
            button2 = new Button();
            button1 = new Button();
            deleteDishTxtBox = new TextBox();
            label7 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(655, 194);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(75, 29);
            button2.TabIndex = 75;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(344, 254);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(75, 29);
            button1.TabIndex = 74;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // deleteDishTxtBox
            // 
            deleteDishTxtBox.Location = new Point(163, 194);
            deleteDishTxtBox.Margin = new Padding(3, 4, 3, 4);
            deleteDishTxtBox.Name = "deleteDishTxtBox";
            deleteDishTxtBox.Size = new Size(486, 27);
            deleteDishTxtBox.TabIndex = 73;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(299, 129);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(166, 31);
            label7.TabIndex = 72;
            label7.Text = "Delete Dish";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(110, 198);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 71;
            label1.Text = "Name:";
            // 
            // DeleteDish
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 326);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(deleteDishTxtBox);
            Controls.Add(label7);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DeleteDish";
            Text = "DeleteDish";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private TextBox deleteDishTxtBox;
        private Label label7;
        private Label label1;
    }
}