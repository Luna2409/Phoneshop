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
            FillListBox();
        }

        private void FillListBox()
        {
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

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            var selectedItem = listBoxPhone.SelectedItem as Phone;
            if (selectedItem == null)
            {
                MessageBox.Show("Selected Item does not exist");
                return;
            }
            var selectedID = selectedItem.Id;

            var result = MessageBox.Show("Are you sure you want to delete this phone?", "DELETE", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                phoneService.Delete(selectedID);

                listBoxPhone.Items.Clear();
                lblBrand.Text = "";
                lblType.Text = "";
                lblPrice.Text = "";
                lblStock.Text = "";
                lblDescription.Text = "";
                FillListBox();
            }
        }

        private void ListBoxPhone_SelectedValueChanged(object sender, EventArgs e)
        {
            BtnMinus.Enabled = true;
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            using (AddPhone newPhone = new())
            {
                newPhone.ShowDialog(this);
                if (newPhone.ApplyBtnClicked)
                {
                    listBoxPhone.Items.Clear();
                    FillListBox();
                }
            }
        }
    }
}
