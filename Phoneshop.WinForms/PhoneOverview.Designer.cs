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
            this.lblStrock = new System.Windows.Forms.Label();
            this.Brand = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.Label();
            this.txtboxList = new System.Windows.Forms.TextBox();
            this.Description = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.Stock = new System.Windows.Forms.Label();
            this.phoneList = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1495, 698);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(176, 52);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // txtboxSearch
            // 
            this.txtboxSearch.Location = new System.Drawing.Point(12, 12);
            this.txtboxSearch.Name = "txtboxSearch";
            this.txtboxSearch.PlaceholderText = "Search";
            this.txtboxSearch.Size = new System.Drawing.Size(515, 43);
            this.txtboxSearch.TabIndex = 1;
            // 
            // lblPrice
            // 
            this.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrice.Location = new System.Drawing.Point(1016, 12);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(112, 43);
            this.lblPrice.TabIndex = 7;
            // 
            // lblStrock
            // 
            this.lblStrock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStrock.Location = new System.Drawing.Point(1016, 74);
            this.lblStrock.Name = "lblStrock";
            this.lblStrock.Size = new System.Drawing.Size(112, 39);
            this.lblStrock.TabIndex = 8;
            // 
            // Brand
            // 
            this.Brand.AutoSize = true;
            this.Brand.Location = new System.Drawing.Point(553, 10);
            this.Brand.Name = "Brand";
            this.Brand.Size = new System.Drawing.Size(92, 37);
            this.Brand.TabIndex = 9;
            this.Brand.Text = "Brand:";
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Location = new System.Drawing.Point(553, 74);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(79, 37);
            this.Type.TabIndex = 10;
            this.Type.Text = "Type:";
            // 
            // txtboxList
            // 
            this.txtboxList.BackColor = System.Drawing.SystemColors.Window;
            this.txtboxList.Location = new System.Drawing.Point(39, 736);
            this.txtboxList.Multiline = true;
            this.txtboxList.Name = "txtboxList";
            this.txtboxList.Size = new System.Drawing.Size(515, 613);
            this.txtboxList.TabIndex = 11;
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
            this.lblDescription.Size = new System.Drawing.Size(1117, 486);
            this.lblDescription.TabIndex = 14;
            // 
            // lblType
            // 
            this.lblType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblType.Location = new System.Drawing.Point(727, 74);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(125, 39);
            this.lblType.TabIndex = 15;
            // 
            // lblBrand
            // 
            this.lblBrand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBrand.Location = new System.Drawing.Point(727, 10);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(125, 41);
            this.lblBrand.TabIndex = 16;
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(881, 12);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(80, 37);
            this.Price.TabIndex = 17;
            this.Price.Text = "Price:";
            // 
            // Stock
            // 
            this.Stock.AutoSize = true;
            this.Stock.Location = new System.Drawing.Point(881, 76);
            this.Stock.Name = "Stock";
            this.Stock.Size = new System.Drawing.Size(86, 37);
            this.Stock.TabIndex = 18;
            this.Stock.Text = "Stock:";
            // 
            // phoneList
            // 
            this.phoneList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.phoneList.HideSelection = false;
            this.phoneList.Location = new System.Drawing.Point(12, 74);
            this.phoneList.Name = "phoneList";
            this.phoneList.Size = new System.Drawing.Size(515, 608);
            this.phoneList.TabIndex = 20;
            this.phoneList.UseCompatibleStateImageBehavior = false;
            this.phoneList.SelectedIndexChanged += new System.EventHandler(this.phoneList_SelectedIndexChanged);
            // 
            // PhoneOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1683, 1392);
            this.Controls.Add(this.phoneList);
            this.Controls.Add(this.Stock);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.txtboxList);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.Brand);
            this.Controls.Add(this.lblStrock);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtboxSearch);
            this.Controls.Add(this.btnExit);
            this.Name = "PhoneOverview";
            this.Text = "Phoneshop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtboxSearch;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblStrock;
        private System.Windows.Forms.Label Brand;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.TextBox txtboxList;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label Stock;
        private System.Windows.Forms.ListView phoneList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}
