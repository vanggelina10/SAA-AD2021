using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAA_AD_2021
{
    public partial class FormPaymentMethod : Form
    {
        public FormPaymentMethod()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormInvoice invoice = new FormInvoice();
            invoice.ShowDialog();
        }
    }
}
