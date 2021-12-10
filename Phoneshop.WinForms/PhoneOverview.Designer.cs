namespace Phoneshop.WinForms
{
    partial class PhoneOverview
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
            this.btnExit = new System.Windows.Forms.Button();
            this.txtboxSearch = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.Brand = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.Stock = new System.Windows.Forms.Label();
            this.listBoxPhone = new System.Windows.Forms.ListBox();
            this.BtnMinus = new System.Windows.Forms.Button();
            this.BtnPlus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1610, 708);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(176, 52);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // txtboxSearch
            // 
            this.txtboxSearch.Location = new System.Drawing.Point(12, 12);
            this.txtboxSearch.Name = "txtboxSearch";
            this.txtboxSearch.PlaceholderText = "Search";
            this.txtboxSearch.Size = new System.Drawing.Size(515, 43);
            this.txtboxSearch.TabIndex = 1;
            this.txtboxSearch.TextChanged += new System.EventHandler(this.TxtboxSearch_TextChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrice.Location = new System.Drawing.Point(1139, 16);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(101, 43);
            this.lblPrice.TabIndex = 7;
            // 
            // lblStock
            // 
            this.lblStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStock.Location = new System.Drawing.Point(1139, 79);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(101, 39);
            this.lblStock.TabIndex = 8;
            // 
            // Brand
            // 
            this.Brand.AutoSize = true;
            this.Brand.Location = new System.Drawing.Point(554, 12);
            this.Brand.Name = "Brand";
            this.Brand.Size = new System.Drawing.Size(92, 37);
            this.Brand.TabIndex = 9;
            this.Brand.Text = "Brand:";
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Location = new System.Drawing.Point(554, 76);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(79, 37);
            this.Type.TabIndex = 10;
            this.Type.Text = "Type:";
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(553, 142);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(158, 37);
            this.Description.TabIndex = 13;
            this.Description.Text = "Description:";
            // 
            // lblDescription
            // 
            this.lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDescription.Location = new System.Drawing.Point(554, 196);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(1232, 499);
            this.lblDescription.TabIndex = 14;
            // 
            // lblType
            // 
            this.lblType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblType.Location = new System.Drawing.Point(649, 78);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(364, 39);
            this.lblType.TabIndex = 15;
            // 
            // lblBrand
            // 
            this.lblBrand.AccessibleDescription = "";
            this.lblBrand.AccessibleName = "";
            this.lblBrand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBrand.Location = new System.Drawing.Point(649, 15);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(364, 41);
            this.lblBrand.TabIndex = 16;
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(1047, 15);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(80, 37);
            this.Price.TabIndex = 17;
            this.Price.Text = "Price:";
            // 
            // Stock
            // 
            this.Stock.AutoSize = true;
            this.Stock.Location = new System.Drawing.Point(1047, 79);
            this.Stock.Name = "Stock";
            this.Stock.Size = new System.Drawing.Size(86, 37);
            this.Stock.TabIndex = 18;
            this.Stock.Text = "Stock:";
            // 
            // listBoxPhone
            // 
            this.listBoxPhone.FormattingEnabled = true;
            this.listBoxPhone.ItemHeight = 37;
            this.listBoxPhone.Location = new System.Drawing.Point(12, 61);
            this.listBoxPhone.Name = "listBoxPhone";
            this.listBoxPhone.Size = new System.Drawing.Size(515, 633);
            this.listBoxPhone.TabIndex = 19;
            this.listBoxPhone.SelectedIndexChanged += new System.EventHandler(this.ListBoxPhone_SelectedIndexChanged);
            // 
            // BtnMinus
            // 
            this.BtnMinus.Enabled = false;
            this.BtnMinus.Location = new System.Drawing.Point(12, 700);
            this.BtnMinus.Name = "BtnMinus";
            this.BtnMinus.Size = new System.Drawing.Size(50, 50);
            this.BtnMinus.TabIndex = 20;
            this.BtnMinus.Text = "-";
            this.BtnMinus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnMinus.UseVisualStyleBackColor = true;
            this.BtnMinus.Click += new System.EventHandler(this.BtnMinus_Click);
            // 
            // BtnPlus
            // 
            this.BtnPlus.Location = new System.Drawing.Point(68, 700);
            this.BtnPlus.Name = "BtnPlus";
            this.BtnPlus.Size = new System.Drawing.Size(50, 50);
            this.BtnPlus.TabIndex = 21;
            this.BtnPlus.Text = "+";
            this.BtnPlus.UseVisualStyleBackColor = true;
            this.BtnPlus.Click += new System.EventHandler(this.BtnPlus_Click);
            // 
            // PhoneOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1798, 772);
            this.Controls.Add(this.BtnPlus);
            this.Controls.Add(this.BtnMinus);
            this.Controls.Add(this.listBoxPhone);
            this.Controls.Add(this.Stock);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.Brand);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtboxSearch);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PhoneOverview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phoneshop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtboxSearch;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label Brand;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label Stock;
        private System.Windows.Forms.ListBox listBoxPhone;
        private System.Windows.Forms.Button BtnMinus;
        private System.Windows.Forms.Button BtnPlus;
    }
}
