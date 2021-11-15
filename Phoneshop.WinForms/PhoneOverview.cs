using Phoneshop.Business;
using Phoneshop.Domain.Objects;
using System;
using System.Windows.Forms;

namespace Phoneshop.WinForms
{
    public partial class PhoneOverview : Form
    {
        private readonly static PhoneService phoneService = new();
        bool listChanged;

        public PhoneOverview()
        {
            InitializeComponent();

            var list = phoneService.GetList();
            listBoxPhone.DisplayMember = nameof(Phone.FullName);

            foreach (var item in list)
            {
                listBoxPhone.Items.Add(item);
            }
        }

        private void ListBoxPhone_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxPhone.SelectedItem is Phone phone)
            {
                lblBrand.Text = phone.Brand;
                lblType.Text = phone.Type;
                lblPrice.Text = phone.PriceWithTax.ToString();
                lblStock.Text = phone.Stock.ToString();
                lblDescription.Text = phone.Description;
            }
        }

        private void TxtboxSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtboxSearch.Text.Length <= 3)
            {
                if (listChanged)
                {
                    listChanged = false;
                    listBoxPhone.Items.Clear();

                    var list = phoneService.GetList();
                    foreach (var item in list)
                    {
                        listBoxPhone.Items.Add(item);
                    }
                }
                
                return;
            }

            listBoxPhone.Items.Clear();

            var found = phoneService.Search(txtboxSearch.Text);

            foreach (var item in found)
            {
                listBoxPhone.Items.Add(item);
            }

            listChanged = true;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
