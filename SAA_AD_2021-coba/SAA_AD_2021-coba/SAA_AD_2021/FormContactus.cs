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
    public partial class FormContactus : Form
    {
        public FormContactus()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDashboard d = new FormDashboard();
            d.ShowDialog();
        }
    }
}
