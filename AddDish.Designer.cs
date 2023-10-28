namespace assignment2
{
    partial class AddDish
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
            this.label8 = new System.Windows.Forms.Label();
            this.AdditionalInfoBox = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.AllergenTxtBox = new System.Windows.Forms.MaskedTextBox();
            this.CalorieTxtBox = new System.Windows.Forms.MaskedTextBox();
            this.PriceTxtBox = new System.Windows.Forms.MaskedTextBox();
            this.DishTxtBox = new System.Windows.Forms.MaskedTextBox();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DishType = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(190, 364);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 20);
            this.label8.TabIndex = 46;
            this.label8.Text = "Dish Type";
            // 
            // AdditionalInfoBox
            // 
            this.AdditionalInfoBox.Location = new System.Drawing.Point(388, 485);
            this.AdditionalInfoBox.Name = "AdditionalInfoBox";
            this.AdditionalInfoBox.Size = new System.Drawing.Size(319, 22);
            this.AdditionalInfoBox.TabIndex = 45;
            this.AdditionalInfoBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.AdditionalInfoBox_MaskInputRejected);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(190, 487);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 20);
            this.label7.TabIndex = 44;
            this.label7.Text = "Additional Info:";
            // 
            // AllergenTxtBox
            // 
            this.AllergenTxtBox.Location = new System.Drawing.Point(388, 430);
            this.AllergenTxtBox.Name = "AllergenTxtBox";
            this.AllergenTxtBox.Size = new System.Drawing.Size(319, 22);
            this.AllergenTxtBox.TabIndex = 43;
            this.AllergenTxtBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.AllergenTxtBox_MaskInputRejected);
            // 
            // CalorieTxtBox
            // 
            this.CalorieTxtBox.Location = new System.Drawing.Point(388, 304);
            this.CalorieTxtBox.Name = "CalorieTxtBox";
            this.CalorieTxtBox.Size = new System.Drawing.Size(319, 22);
            this.CalorieTxtBox.TabIndex = 42;
            // 
            // PriceTxtBox
            // 
            this.PriceTxtBox.Location = new System.Drawing.Point(388, 245);
            this.PriceTxtBox.Name = "PriceTxtBox";
            this.PriceTxtBox.Size = new System.Drawing.Size(319, 22);
            this.PriceTxtBox.TabIndex = 41;
            this.PriceTxtBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.PriceTxtBox_MaskInputRejected);
            // 
            // DishTxtBox
            // 
            this.DishTxtBox.Location = new System.Drawing.Point(388, 180);
            this.DishTxtBox.Name = "DishTxtBox";
            this.DishTxtBox.Size = new System.Drawing.Size(319, 22);
            this.DishTxtBox.TabIndex = 40;
            this.DishTxtBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.DishTxtBox_MaskInputRejected);
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Location = new System.Drawing.Point(457, 502);
            this.SubmitBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(100, 28);
            this.SubmitBtn.TabIndex = 39;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click_1);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(238, 502);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(100, 28);
            this.CancelBtn.TabIndex = 38;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(190, 432);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "Allergens:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(190, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Calorie Count (kJ):";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(190, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(190, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Dish Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 29);
            this.label1.TabIndex = 31;
            this.label1.Text = "Add Dish";
            // 
            // DishType
            // 
            this.DishType.FormattingEnabled = true;
            this.DishType.Items.AddRange(new object[] {
            "Entree",
            "Main",
            "Dessert",
            "Drinks"});
            this.DishType.Location = new System.Drawing.Point(388, 364);
            this.DishType.Name = "DishType";
            this.DishType.Size = new System.Drawing.Size(319, 24);
            this.DishType.TabIndex = 47;
            this.DishType.SelectedIndexChanged += new System.EventHandler(this.DishType_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SubmitBtn);
            this.groupBox1.Controls.Add(this.CancelBtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(150, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(660, 580);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Dish";
            // 
            // AddDish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 782);
            this.Controls.Add(this.DishType);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.AdditionalInfoBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AllergenTxtBox);
            this.Controls.Add(this.CalorieTxtBox);
            this.Controls.Add(this.PriceTxtBox);
            this.Controls.Add(this.DishTxtBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddDish";
            this.Text = "Add New Dish";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox AdditionalInfoBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox AllergenTxtBox;
        private System.Windows.Forms.MaskedTextBox CalorieTxtBox;
        private System.Windows.Forms.MaskedTextBox PriceTxtBox;
        private System.Windows.Forms.MaskedTextBox DishTxtBox;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox DishType;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}