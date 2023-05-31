namespace WinFormsApp5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CBDataProduct = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TBPrice = new System.Windows.Forms.TextBox();
            this.BtnAddChosen = new System.Windows.Forms.Button();
            this.BtnAddDataBase = new System.Windows.Forms.Button();
            this.LBChosenProd = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TBTotalPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CBDataProduct
            // 
            this.CBDataProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBDataProduct.FormattingEnabled = true;
            this.CBDataProduct.Location = new System.Drawing.Point(27, 45);
            this.CBDataProduct.Name = "CBDataProduct";
            this.CBDataProduct.Size = new System.Drawing.Size(198, 23);
            this.CBDataProduct.Sorted = true;
            this.CBDataProduct.TabIndex = 0;
            this.CBDataProduct.SelectedIndexChanged += new System.EventHandler(this.CBDataProduct_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Price";
            // 
            // TBPrice
            // 
            this.TBPrice.Location = new System.Drawing.Point(78, 89);
            this.TBPrice.Name = "TBPrice";
            this.TBPrice.ReadOnly = true;
            this.TBPrice.Size = new System.Drawing.Size(100, 23);
            this.TBPrice.TabIndex = 2;
            // 
            // BtnAddChosen
            // 
            this.BtnAddChosen.Location = new System.Drawing.Point(27, 130);
            this.BtnAddChosen.Name = "BtnAddChosen";
            this.BtnAddChosen.Size = new System.Drawing.Size(198, 23);
            this.BtnAddChosen.TabIndex = 4;
            this.BtnAddChosen.Text = "Add Product To Choosen";
            this.BtnAddChosen.UseVisualStyleBackColor = true;
            this.BtnAddChosen.Click += new System.EventHandler(this.BtnAddChosen_Click);
            // 
            // BtnAddDataBase
            // 
            this.BtnAddDataBase.Location = new System.Drawing.Point(27, 159);
            this.BtnAddDataBase.Name = "BtnAddDataBase";
            this.BtnAddDataBase.Size = new System.Drawing.Size(198, 23);
            this.BtnAddDataBase.TabIndex = 5;
            this.BtnAddDataBase.Text = "Add Product To Data Base";
            this.BtnAddDataBase.UseVisualStyleBackColor = true;
            this.BtnAddDataBase.Click += new System.EventHandler(this.BtnAddDataBase_Click);
            // 
            // LBChosenProd
            // 
            this.LBChosenProd.FormattingEnabled = true;
            this.LBChosenProd.ItemHeight = 15;
            this.LBChosenProd.Location = new System.Drawing.Point(271, 45);
            this.LBChosenProd.Name = "LBChosenProd";
            this.LBChosenProd.Size = new System.Drawing.Size(209, 109);
            this.LBChosenProd.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Chosen Products";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total Price:";
            // 
            // TBTotalPrice
            // 
            this.TBTotalPrice.Location = new System.Drawing.Point(341, 164);
            this.TBTotalPrice.Name = "TBTotalPrice";
            this.TBTotalPrice.ReadOnly = true;
            this.TBTotalPrice.Size = new System.Drawing.Size(139, 23);
            this.TBTotalPrice.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 214);
            this.Controls.Add(this.TBTotalPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LBChosenProd);
            this.Controls.Add(this.BtnAddDataBase);
            this.Controls.Add(this.BtnAddChosen);
            this.Controls.Add(this.TBPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBDataProduct);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox CBDataProduct;
        private Label label1;
        private TextBox TBPrice;
        private Button BtnAddChosen;
        private Button BtnAddDataBase;
        private ListBox LBChosenProd;
        private Label label3;
        private Label label4;
        private TextBox TBTotalPrice;
    }
}