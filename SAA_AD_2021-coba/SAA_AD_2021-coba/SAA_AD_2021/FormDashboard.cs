using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SAA_AD_2021
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
        }
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string sqlQuery;
        string connectString = "server=139.255.11.84; uid=student; pwd=isbmantap; database=KMMI4;";
        private void btnBooking_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formpembelian booking = new Formpembelian();
            booking.ShowDialog();
        }

        private void btnstorage_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormStoreInfo info = new FormStoreInfo();
            info.ShowDialog();
        }

        private void btnContactus_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormContactus contact = new FormContactus();
            contact.ShowDialog();
        }

        private void btnpurchase_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPurchaseHistory purchase = new FormPurchaseHistory();
            purchase.ShowDialog();
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            
        }

        private void Btnlogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure to Logout Your Account?", "Notification", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                FormLogin d = new FormLogin();
                d.ShowDialog();
            }
        }

        private void pboxprofile_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProfile d = new FormProfile();
            d.ShowDialog();
        }
    }
}
