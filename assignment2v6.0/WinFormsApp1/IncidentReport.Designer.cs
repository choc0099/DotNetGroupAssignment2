namespace assignment2
{
    partial class IncidentReport
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
            submitButton = new Button();
            label1 = new Label();
            label2 = new Label();
            issueDesc = new TextBox();
            label3 = new Label();
            roomNo = new TextBox();
            SuspendLayout();
            // 
            // submitButton
            // 
            submitButton.Location = new Point(282, 430);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(94, 29);
            submitButton.TabIndex = 0;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(212, 24);
            label1.Name = "label1";
            label1.Size = new Size(243, 37);
            label1.TabIndex = 1;
            label1.Text = "Report an incident";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(21, 88);
            label2.Name = "label2";
            label2.Size = new Size(684, 40);
            label2.TabIndex = 2;
            label2.Text = "Sorry to hear that you were faced with issues. Please let us know of the issue so we can solve it for you \r\nas soon as possible\r\n";
            label2.Click += label2_Click;
            // 
            // issueDesc
            // 
            issueDesc.Location = new Point(21, 190);
            issueDesc.Multiline = true;
            issueDesc.Name = "issueDesc";
            issueDesc.Size = new Size(619, 211);
            issueDesc.TabIndex = 3;
            issueDesc.TextChanged += issueDesc_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(21, 150);
            label3.Name = "label3";
            label3.Size = new Size(149, 20);
            label3.TabIndex = 4;
            label3.Text = "Enter room number:";
            label3.Click += label3_Click;
            // 
            // roomNo
            // 
            roomNo.BorderStyle = BorderStyle.None;
            roomNo.Location = new Point(176, 150);
            roomNo.Name = "roomNo";
            roomNo.Size = new Size(67, 20);
            roomNo.TabIndex = 5;
            roomNo.TextChanged += roomNo_TextChanged;
            // 
            // IncidentReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 493);
            Controls.Add(roomNo);
            Controls.Add(label3);
            Controls.Add(issueDesc);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(submitButton);
            Name = "IncidentReport";
            Text = "Incident Report";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button submitButton;
        private Label label1;
        private Label label2;
        private TextBox issueDesc;
        private Label label3;
        private TextBox roomNo;
    }
}