namespace assignment2
{
    partial class viewIncidents
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
            closeButton = new Button();
            label1 = new Label();
            viewButton = new Button();
            comboBoxRoomNumbers = new ComboBox();
            reportRichTextBox = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // closeButton
            // 
            closeButton.Location = new Point(72, 391);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(94, 29);
            closeButton.TabIndex = 0;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 19.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(205, 28);
            label1.Name = "label1";
            label1.Size = new Size(260, 45);
            label1.TabIndex = 1;
            label1.Text = "Incident Reports\r\n";
            label1.Click += label1_Click;
            // 
            // viewButton
            // 
            viewButton.Location = new Point(505, 118);
            viewButton.Name = "viewButton";
            viewButton.Size = new Size(94, 29);
            viewButton.TabIndex = 3;
            viewButton.Text = "View";
            viewButton.UseVisualStyleBackColor = true;
            viewButton.Click += viewButton_Click;
            // 
            // comboBoxRoomNumbers
            // 
            comboBoxRoomNumbers.FormattingEnabled = true;
            comboBoxRoomNumbers.Location = new Point(127, 118);
            comboBoxRoomNumbers.Name = "comboBoxRoomNumbers";
            comboBoxRoomNumbers.Size = new Size(151, 28);
            comboBoxRoomNumbers.TabIndex = 4;
            comboBoxRoomNumbers.UseWaitCursor = true;
            // 
            // reportRichTextBox
            // 
            reportRichTextBox.Location = new Point(72, 153);
            reportRichTextBox.Multiline = true;
            reportRichTextBox.Name = "reportRichTextBox";
            reportRichTextBox.Size = new Size(527, 213);
            reportRichTextBox.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(72, 121);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 6;
            label2.Text = "Room";
            // 
            // viewIncidents
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(673, 450);
            Controls.Add(label2);
            Controls.Add(reportRichTextBox);
            Controls.Add(comboBoxRoomNumbers);
            Controls.Add(viewButton);
            Controls.Add(label1);
            Controls.Add(closeButton);
            Name = "viewIncidents";
            Text = "View Incidents";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button closeButton;
        private Label label1;
        private Button viewButton;
        private ComboBox comboBoxRoomNumbers;
        private TextBox reportRichTextBox;
        private Label label2;
    }
}