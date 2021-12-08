using Phoneshop.Business;
using Phoneshop.Domain.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phoneshop.WinForms
{
    public partial class AddPhone : Form
    {
        private readonly static PhoneService phoneService = new();
        public bool ApplyBtnClicked { get; set; }

        public AddPhone()
        {
            InitializeComponent();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (txtbxBrand.Text == string.Empty)
            {
                MessageBox.Show("Wrong input at Brand. This field is required");
                return;
            }
            if (txtbxType.Text == string.Empty)
            {
                MessageBox.Show("Wrong input at Type. This field is required");
                return;
            }
            if (!double.TryParse(txtbxPrice.Text, out double price))
            {
                MessageBox.Show("Wrong input at Price. This field is required");
                return;
            }
            if (!int.TryParse(txtbxStock.Text, out int stock))
            {
                MessageBox.Show("Wrong iput at Stock. This field is required");
                return;
            }
            if (txtbxDescription.Text == string.Empty)
            {
                MessageBox.Show("Wrong input at Description. This field is required");
                return;
            }

            var newPhone = new Phone();
            newPhone.Brand = txtbxBrand.Text.ToString();
            newPhone.Type = txtbxType.Text.ToString();
            newPhone.PriceWithTax = price;
            newPhone.Stock = stock;
            newPhone.Description = txtbxDescription.Text.ToString();

            phoneService.Create(newPhone);
            ApplyBtnClicked = true;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ApplyBtnClicked = false;
            Close();
        }
    }
}
