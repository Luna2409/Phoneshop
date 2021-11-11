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
    public partial class PhoneOverview : Form
    {
        private readonly static PhoneService phoneService = new();

        public PhoneOverview()
        {
            InitializeComponent();
        }

        private void phoneList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var list = phoneService.GetList();
            phoneList.
        }
    }
}
