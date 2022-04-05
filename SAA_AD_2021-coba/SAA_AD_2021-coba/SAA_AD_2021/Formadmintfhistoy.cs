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
    public partial class Formadmintfhistoy : Form
    {
        public Formadmintfhistoy()
        {
            InitializeComponent();
        }
       
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string sqlQuery;
        public Formadmin fLogin;
        public void init(FormadminDashboard f)
        {
            fLogin = f.fLogin;
        }
        public static string invoice_noadmin = "";
        private void Formadmintfhistoy_Load(object sender, EventArgs e)
        {
            cbJenisLaporan.SelectedIndex = 0;
            DataTable dtPlayer = new DataTable();
           
            sqlQuery = "select TSEWA_NO as `Transaction Number`,USER_FULLNAME AS `Nama`,TSEWA_VA as `Virtual Account`, TSEWA_DATENOW as `Transaction Date`,TSEWA_STARTDATE as `Start Rent`,PSEWA_NAME as `Category`,TSEWA_TIME as `Time Period`,TSEWA_PRICE as `Price`,TSEWA_UNITNO as `Unit No.`,if(TSEWA_STATUS=1,'Paid','Unpaid') as `Payment Status` from transaksi_sewa t, pengguna p, kategori_sewa k where PWAREHOUSE_NIK='" + Formadmin.id_admin + "' and p.USER_ID=t.USER_ID and k.PSEWA_NO=t.PSEWA_NO";
            sqlCommand = new MySqlCommand(sqlQuery, fLogin.conn);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtPlayer);
            dgvtampilanPH.DataSource = dtPlayer;
            lblrows.Text = Convert.ToString(dtPlayer.Rows.Count) + " row(s)";
         }

        private void dgvtampilanPH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cbJenisLaporan.SelectedIndex== 1)
            {
                invoice_noadmin = dgvtampilanPH.Rows[e.RowIndex].Cells[0].Value.ToString();

                Formadminstatus f2 = new Formadminstatus();
                f2.init(this);
                f2.ShowDialog();
                if (Formadminstatus.update2 == false)
                {
                    cbJenisLaporan.SelectedIndex = 1;
                    DataTable dtPlayer = new DataTable();
                    
                    sqlQuery = "select TSEWA_NO as `Transaction Number`,USER_FULLNAME AS `Nama`,TSEWA_VA as `Virtual Account`, TSEWA_DATENOW as `Transaction Date`,TSEWA_STARTDATE as `Start Rent`,PSEWA_NAME as `Category`,TSEWA_TIME as `Time Period`,TSEWA_PRICE as `Price`,TSEWA_UNITNO as `Unit No.`,if(TSEWA_STATUS=1,'Paid','Unpaid') as `Payment Status` from transaksi_sewa t, pengguna p, kategori_sewa k where PWAREHOUSE_NIK='" + Formadmin.id_admin + "' and p.USER_ID=t.USER_ID and k.PSEWA_NO=t.PSEWA_NO and TSEWA_DELETE=0";
                    sqlCommand = new MySqlCommand(sqlQuery, fLogin.conn);
                    sqlAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlAdapter.Fill(dtPlayer);
                    dgvtampilanPH.DataSource = dtPlayer;
                    lblrows.Text = Convert.ToString(dtPlayer.Rows.Count) + " row(s)";
                }
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
            /*this.Hide();
            FormadminDashboard f2 = new FormadminDashboard();
            f2.ShowDialog();*/
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnaddunit_Click(object sender, EventArgs e)
        {
            
           // FormCanceled check = new FormCanceled();
            //check.ShowDialog();
        }
        private void isiDgvLaporan(int pilihan)
        {
            try
            {
                string query = "";
                if (pilihan == 0)
                {
                    query = "select TSEWA_NO as `Transaction Number`,USER_FULLNAME AS `Nama`,TSEWA_VA as `Virtual Account`, TSEWA_DATENOW as `Transaction Date`,TSEWA_STARTDATE as `Start Rent`,PSEWA_NAME as `Category`,TSEWA_TIME as `Time Period`,TSEWA_PRICE as `Price`,TSEWA_UNITNO as `Unit No.`,if(TSEWA_STATUS=1,'Paid','Unpaid') as `Payment Status` from transaksi_sewa t, pengguna p, kategori_sewa k where PWAREHOUSE_NIK='" + Formadmin.id_admin + "' and p.USER_ID=t.USER_ID and k.PSEWA_NO=t.PSEWA_NO";
                }
                else  if (pilihan == 1)
                {
                    query = "select TSEWA_NO as `Transaction Number`,USER_FULLNAME AS `Nama`,TSEWA_VA as `Virtual Account`, TSEWA_DATENOW as `Transaction Date`,TSEWA_STARTDATE as `Start Rent`,PSEWA_NAME as `Category`,TSEWA_TIME as `Time Period`,TSEWA_PRICE as `Price`,TSEWA_UNITNO as `Unit No.`,if(TSEWA_STATUS=1,'Paid','Unpaid') as `Payment Status` from transaksi_sewa t, pengguna p, kategori_sewa k where PWAREHOUSE_NIK='" + Formadmin.id_admin + "' and p.USER_ID=t.USER_ID and k.PSEWA_NO=t.PSEWA_NO and TSEWA_DELETE=0";
                }
                else if (pilihan == 2)
                {
                    query = "select tsewa_no as `Transaction No`, user_fullname as `Name`, TSEWA_VA as `Virtual Account`, PSEWA_NAME as `Warehouse Name`, TSEWA_TIME as `Time Period`, TSEWA_PRICE AS `Price`,TSEWA_UNITNO as `Unit Number`,if(TSEWA_STATUS=1,'Paid','Unpaid') as `Payment Status` from transaksi_sewa t, pengguna p, kategori_sewa k where t.USER_ID=p.USER_ID and k.PSEWA_NO=t.PSEWA_NO and TSEWA_DELETE=1";
                }


                
                sqlCommand = new MySqlCommand(query, fLogin.conn);
                MySqlDataAdapter daLaporan = new MySqlDataAdapter(query, fLogin.conn);
                DataSet dsLaporan = new DataSet();
                daLaporan.Fill(dsLaporan);
                dgvtampilanPH.DataSource = dsLaporan.Tables[0];
                dgvtampilanPH.Refresh();

                DataTable dtPlayer = new DataTable();
               
               
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtPlayer);         
                lblrows.Text = Convert.ToString(dtPlayer.Rows.Count) + " row(s)";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void cbJenisLaporan_SelectedIndexChanged(object sender, EventArgs e)
        {
            isiDgvLaporan(cbJenisLaporan.SelectedIndex);
        }
    }
}
