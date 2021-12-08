namespace Phoneshop.WinForms
{
    partial class AddPhone
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
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtbxBrand = new System.Windows.Forms.TextBox();
            this.txtbxType = new System.Windows.Forms.TextBox();
            this.txtbxPrice = new System.Windows.Forms.TextBox();
            this.txtbxStock = new System.Windows.Forms.TextBox();
            this.txtbxDescription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(24, 38);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(86, 37);
            this.lblBrand.TabIndex = 0;
            this.lblBrand.Text = "Brand";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(24, 91);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(73, 37);
            this.lblType.TabIndex = 3;
            this.lblType.Text = "Type";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(24, 140);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(74, 37);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(24, 189);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(80, 37);
            this.lblStock.TabIndex = 5;
            this.lblStock.Text = "Stock";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(24, 238);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(152, 37);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "Description";
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(530, 617);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(115, 52);
            this.btnApply.TabIndex = 2;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(663, 617);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(115, 52);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtbxBrand
            // 
            this.txtbxBrand.Location = new System.Drawing.Point(186, 38);
            this.txtbxBrand.Name = "txtbxBrand";
            this.txtbxBrand.Size = new System.Drawing.Size(225, 43);
            this.txtbxBrand.TabIndex = 15;
            // 
            // txtbxType
            // 
            this.txtbxType.Location = new System.Drawing.Point(186, 85);
            this.txtbxType.Name = "txtbxType";
            this.txtbxType.Size = new System.Drawing.Size(225, 43);
            this.txtbxType.TabIndex = 16;
            // 
            // txtbxPrice
            // 
            this.txtbxPrice.Location = new System.Drawing.Point(186, 134);
            this.txtbxPrice.Name = "txtbxPrice";
            this.txtbxPrice.Size = new System.Drawing.Size(225, 43);
            this.txtbxPrice.TabIndex = 17;
            // 
            // txtbxStock
            // 
            this.txtbxStock.Location = new System.Drawing.Point(186, 183);
            this.txtbxStock.Name = "txtbxStock";
            this.txtbxStock.Size = new System.Drawing.Size(225, 43);
            this.txtbxStock.TabIndex = 18;
            // 
            // txtbxDescription
            // 
            this.txtbxDescription.Location = new System.Drawing.Point(24, 278);
            this.txtbxDescription.Multiline = true;
            this.txtbxDescription.Name = "txtbxDescription";
            this.txtbxDescription.Size = new System.Drawing.Size(754, 314);
            this.txtbxDescription.TabIndex = 19;
            // 
            // AddPhone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 694);
            this.Controls.Add(this.txtbxDescription);
            this.Controls.Add(this.txtbxStock);
            this.Controls.Add(this.txtbxPrice);
            this.Controls.Add(this.txtbxType);
            this.Controls.Add(this.txtbxBrand);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.lblBrand);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddPhone";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddPhone";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtbxBrand;
        private System.Windows.Forms.TextBox txtbxType;
        private System.Windows.Forms.TextBox txtbxPrice;
        private System.Windows.Forms.TextBox txtbxStock;
        private System.Windows.Forms.TextBox txtbxDescription;
    }
}