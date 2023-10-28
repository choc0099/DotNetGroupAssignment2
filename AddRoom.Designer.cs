namespace assignment2
{
    partial class AddRoom
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
            this.sightTxtBox = new System.Windows.Forms.MaskedTextBox();
            this.bedTxtBox = new System.Windows.Forms.MaskedTextBox();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sizeTxtBox = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AdditionalInformationBox = new System.Windows.Forms.TextBox();
            this.priceTxtBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.wifiCheckBox = new System.Windows.Forms.CheckBox();
            this.tvCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sightTxtBox
            // 
            this.sightTxtBox.Location = new System.Drawing.Point(360, 291);
            this.sightTxtBox.Name = "sightTxtBox";
            this.sightTxtBox.Size = new System.Drawing.Size(319, 22);
            this.sightTxtBox.TabIndex = 52;
            // 
            // bedTxtBox
            // 
            this.bedTxtBox.Location = new System.Drawing.Point(360, 230);
            this.bedTxtBox.Name = "bedTxtBox";
            this.bedTxtBox.Size = new System.Drawing.Size(319, 22);
            this.bedTxtBox.TabIndex = 51;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(220, 453);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(100, 28);
            this.CancelBtn.TabIndex = 18;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Location = new System.Drawing.Point(439, 453);
            this.SubmitBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(100, 28);
            this.SubmitBtn.TabIndex = 19;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(19, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Size:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(19, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bed Size:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(19, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sight:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 349);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Price:";
            // 
            // sizeTxtBox
            // 
            this.sizeTxtBox.Location = new System.Drawing.Point(360, 165);
            this.sizeTxtBox.Name = "sizeTxtBox";
            this.sizeTxtBox.Size = new System.Drawing.Size(319, 22);
            this.sizeTxtBox.TabIndex = 50;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tvCheckBox);
            this.groupBox1.Controls.Add(this.wifiCheckBox);
            this.groupBox1.Controls.Add(this.AdditionalInformationBox);
            this.groupBox1.Controls.Add(this.priceTxtBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CancelBtn);
            this.groupBox1.Controls.Add(this.SubmitBtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(140, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(663, 544);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Employee";
            // 
            // AdditionalInformationBox
            // 
            this.AdditionalInformationBox.Location = new System.Drawing.Point(220, 393);
            this.AdditionalInformationBox.Name = "AdditionalInformationBox";
            this.AdditionalInformationBox.Size = new System.Drawing.Size(319, 22);
            this.AdditionalInformationBox.TabIndex = 66;
            // 
            // priceTxtBox
            // 
            this.priceTxtBox.Location = new System.Drawing.Point(220, 347);
            this.priceTxtBox.Name = "priceTxtBox";
            this.priceTxtBox.Size = new System.Drawing.Size(319, 22);
            this.priceTxtBox.TabIndex = 65;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(19, 393);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(175, 20);
            this.label9.TabIndex = 63;
            this.label9.Text = "Additional Information:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Room";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(23, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Features:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // wifiCheckBox
            // 
            this.wifiCheckBox.AutoSize = true;
            this.wifiCheckBox.Location = new System.Drawing.Point(220, 295);
            this.wifiCheckBox.Name = "wifiCheckBox";
            this.wifiCheckBox.Size = new System.Drawing.Size(56, 20);
            this.wifiCheckBox.TabIndex = 67;
            this.wifiCheckBox.Text = "WiFi";
            this.wifiCheckBox.UseVisualStyleBackColor = true;
            this.wifiCheckBox.CheckedChanged += new System.EventHandler(this.wifiCheckBox_CheckedChanged);
            // 
            // tvCheckBox
            // 
            this.tvCheckBox.AutoSize = true;
            this.tvCheckBox.Location = new System.Drawing.Point(337, 295);
            this.tvCheckBox.Name = "tvCheckBox";
            this.tvCheckBox.Size = new System.Drawing.Size(47, 20);
            this.tvCheckBox.TabIndex = 68;
            this.tvCheckBox.Text = "TV";
            this.tvCheckBox.UseVisualStyleBackColor = true;
            // 
            // AddRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 852);
            this.Controls.Add(this.sightTxtBox);
            this.Controls.Add(this.bedTxtBox);
            this.Controls.Add(this.sizeTxtBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddRoom";
            this.Text = "AddRoom";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox sightTxtBox;
        private System.Windows.Forms.MaskedTextBox bedTxtBox;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox sizeTxtBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox AdditionalInformationBox;
        private System.Windows.Forms.TextBox priceTxtBox;
        private System.Windows.Forms.CheckBox tvCheckBox;
        private System.Windows.Forms.CheckBox wifiCheckBox;
        private System.Windows.Forms.Label label5;
    }
}