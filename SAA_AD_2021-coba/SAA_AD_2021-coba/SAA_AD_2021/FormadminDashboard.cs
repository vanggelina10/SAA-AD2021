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
    public partial class FormadminDashboard : Form
    {
        public FormadminDashboard()
        {
            InitializeComponent();
        }
       
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string sqlQuery;
        public Formadmin fLogin;

        public void init(Formadmin f)
        {
            fLogin = f;
        }
        public string psewa = "";
        public static string user_id2 = "";
        int a = 0, b = 0, c = 0, d = 0;
        string coba1 = "";
        string coba2 = "";
        string coba3 = "";
      string time = "";
        string total = "";
        private void btntransferhitory_Click(object sender, EventArgs e)
        {
            //this.Hide();

            Formadmintfhistoy check = new Formadmintfhistoy();
            check.init(this);
            check.ShowDialog();
        }

        private void btncanceltf_Click(object sender, EventArgs e)
        {
            
        }

        private void btninfounit_Click(object sender, EventArgs e)
        {
            

        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure to Logout Your Account?", "Notification", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Formadmin d = new Formadmin();
                d.ShowDialog();
            }
        }

        private void btnunit_Click(object sender, EventArgs e)
        {
          
            Formunit f2 = new Formunit();
            f2.init(this);
            f2.ShowDialog();
        }
        private void isiDgvLaporan(int pilihan)
        {
            try
            {
                string query = "";
                if (pilihan == 0)
                {
                    query = "SELECT * FROM KMMI4.jumlah_kategori;";
                }
                else if (pilihan == 1)
                {
                    query = "SELECT * FROM KMMI4.Jumlah_Tersewa_Detail;";
                }
                else if (pilihan == 2)
                {
                    query = "SELECT * FROM KMMI4.jumlah_transaksi_user;";
                }
                
                sqlCommand = new MySqlCommand(query, fLogin.conn);
                MySqlDataAdapter daLaporan = new MySqlDataAdapter(query, fLogin.conn);
                DataSet dsLaporan = new DataSet();
                daLaporan.Fill(dsLaporan);
                dgvreport.DataSource = dsLaporan.Tables[0];
                dgvreport.Refresh();

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

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(textBox1.Text== "ID Warehouse...")
            {
                textBox1.Clear();
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (textBox2.Text == "ID User...")
            {

                textBox2.Clear();
                textBox2.ForeColor = Color.Black;
            }
        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("please fill with warehouse id!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else if (textBox1.Text == "X0000" || textBox1.Text == "N0000" || textBox1.Text == "T0000" || textBox1.Text == "N0000")
                {
                    DataTable dtPlayer = new DataTable();
                   sqlQuery = "call KMMI4.pCariUnitWarehouseTersedia('" + textBox1.Text + "');";
                    sqlCommand = new MySqlCommand(sqlQuery, fLogin.conn);
                    sqlAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlAdapter.Fill(dtPlayer);
                    dgvreport.DataSource = dtPlayer;
                }
                else
                {
                    MessageBox.Show("Wrong warehouse id!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {

            try
            {
               
                string userid = textBox2.Text;
                DataTable dtlogin = new DataTable();
                sqlQuery = "SELECT * FROM `pengguna` WHERE `user_id`=@userid ";
                sqlCommand = new MySqlCommand(sqlQuery, fLogin.conn);
                sqlCommand.Parameters.Add("@userid", MySqlDbType.VarChar).Value = userid;
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.SelectCommand = sqlCommand;
                sqlAdapter.Fill(dtlogin);
                //menyimpan id

                //Mengecek user ada apa tidak
                if (dtlogin.Rows.Count != 0)
                {

                    DataTable dtPlayer = new DataTable();
                  
                    sqlQuery = "call KMMI4.pDetailTransaksiUser('" + textBox2.Text + "');";
                    sqlCommand = new MySqlCommand(sqlQuery, fLogin.conn);
                    sqlAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlAdapter.Fill(dtPlayer);
                    dgvreport.DataSource = dtPlayer;

                }
                else
                {
                    MessageBox.Show("wrong UserID input!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void dgvreport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cbJenisLaporan.SelectedIndex == 2)
            {
               user_id2 = dgvreport.Rows[e.RowIndex].Cells[0].Value.ToString();

              Formdeleteuser f2 = new Formdeleteuser();
                f2.init(this);
                f2.ShowDialog();
                if (Formdeleteuser.update3 == false)
                {
                    cbJenisLaporan.SelectedIndex = 2;
                    DataTable dtPlayer = new DataTable();
                   
                    sqlQuery = "SELECT * FROM KMMI4.jumlah_transaksi_user;";
                    sqlCommand = new MySqlCommand(sqlQuery, fLogin.conn);
                    sqlAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlAdapter.Fill(dtPlayer);
                    dgvreport.DataSource = dtPlayer;
                   
                }
            }
        }

        private void FormadminDashboard_Load(object sender, EventArgs e)
        {
            gbunit.Visible = false;
            gbPenjualan.Visible = false;
            IsiAdd();
            isiDataUser();
            txtIDINV.Text = "";
            isiwarehouse();
        }
        //aku
        private void autoinvoice()
        {
            try
            {
            
                    MySqlCommand cmdinvoice = new MySqlCommand();
                    cmdinvoice.Connection = fLogin.conn;
                    cmdinvoice.CommandText = "select KMMI4.AutoID_Transaksi('" + cbuser_id.Text + "');";
                    txtIDINV.Text = cmdinvoice.ExecuteScalar().ToString();
                

               
                /*

                MySqlCommand cmdINV = new MySqlCommand();
                cmdINV.Connection = fLogin.conn;
                cmdINV.CommandType = CommandType.StoredProcedure;
                cmdINV.CommandText = "AutoID_Transaksi";

                */
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void isiDataUser()
        {
            try
            {
               
                string query = "SELECT USER_ID FROM pengguna";
                MySqlDataAdapter daUser = new MySqlDataAdapter(query, fLogin.conn);
                DataSet dsUser = new DataSet();
                daUser.Fill(dsUser);
                cbuser_id.Items.Clear();
                cbuser_id.DataSource = dsUser.Tables[0];
                cbuser_id.ValueMember = "USER_ID";
                cbuser_id.DisplayMember = "USER_ID";
                cbuser_id.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void isiwarehouse()
        {
            try
            {

                    string query = "SELECT * FROM kategori_sewa";
                    MySqlDataAdapter dawarehouse = new MySqlDataAdapter(query, fLogin.conn);
                    DataTable dsWarehouse = new DataTable();
                    dawarehouse.Fill(dsWarehouse);

                    cbcategory.DataSource = dsWarehouse;
                    cbcategory.ValueMember = "PSEWA_NAME";
                    cbcategory.DisplayMember = "PSEWA_NAME";
                    //  cbcategory.SelectedIndex = -1;
                
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void IsiAdd()
        {
            cboxcategori.SelectedIndex = -1;
            string query = "SELECT * FROM kategori_sewa";
            MySqlDataAdapter dawarehouse = new MySqlDataAdapter(query, fLogin.conn);
            DataTable dsWarehouse = new DataTable();
            dawarehouse.Fill(dsWarehouse);

            cboxcategori.DataSource = dsWarehouse;
            cboxcategori.ValueMember = "PSEWA_NAME";
            cboxcategori.DisplayMember = "PSEWA_NAME";
         
                DataTable dtPlayer = new DataTable();
            if (cboxcategori.Text == "TINY WAREHOUSE")
            {
                sqlQuery = "select concat('T',concat(IF(count(unit_no)<10, '000', '00')),ifnull(substr(max(unit_no),2,5),0)+1 ) as `ID` , k.PSEWA_NO as `No` from unit u, kategori_sewa k where u.psewa_no=k.psewa_no and k.psewa_name ='" + cboxcategori.Text + "'";
            }
            else if (cboxcategori.Text == "NORMAL WAREHOUSE")
            {
                sqlQuery = "select concat('N',concat(IF(count(unit_no)<10, '000', '00')),ifnull(substr(max(unit_no),2,5),0)+1 ) as `ID`, k.PSEWA_NO as `No`  from unit u, kategori_sewa k where u.psewa_no=k.psewa_no and k.psewa_name ='" + cboxcategori.Text + "'";
            }
            else if (cboxcategori.Text == "LARGE WAREHOUSE")
            {
                sqlQuery = "select concat('L',concat(IF(count(unit_no)<10, '000', '00')),ifnull(substr(max(unit_no),2,5),0)+1 ) as `ID` , k.PSEWA_NO as `No` from unit u, kategori_sewa k where u.psewa_no=k.psewa_no and k.psewa_name ='" + cboxcategori.Text + "'";

            }
            else
            {
                sqlQuery = "select concat('X',concat(IF(count(unit_no)<10, '000', '00')),ifnull(substr(max(unit_no),2,5),0)+1 ) as `ID`, k.PSEWA_NO as `No` from unit u, kategori_sewa k where u.psewa_no=k.psewa_no and k.psewa_name ='" + cboxcategori.Text + "'";

            }
            sqlCommand = new MySqlCommand(sqlQuery, fLogin.conn);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtPlayer);
                tboxunitadd.Text = dtPlayer.Rows[0]["ID"].ToString();
                psewa= dtPlayer.Rows[0]["No"].ToString();

            DataTable dtPlayer2 = new DataTable();

            sqlQuery = "select UNIT_NO as `Unit ID`, PSEWA_NAME as `Warehoouse Name`, if(unit_status=0,'Available','Rented') as `Status Unit` from unit u, kategori_sewa k where u.PSEWA_NO=k.PSEWA_NO";
            sqlCommand = new MySqlCommand(sqlQuery, fLogin.conn);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtPlayer2);
            Dgvadd.DataSource = dtPlayer2;


        }

        private void cbuser_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            autoinvoice();
        }
        public int k = 0;
        private void cboxweek_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cboxweek.Text != "")
            {
                coba1 = cboxweek.Text + " Minggu";
                a = Convert.ToInt32(cboxweek.Text);
                if (cbcategory.Text == "Tiny Warehouse")
                {
                    a = a * 1500000;

                }
                else if (cbcategory.Text == "Normal Warehouse")
                {
                    a = a * 2500000;
                }
                else if (cbcategory.Text == "Large Warehouse")
                {
                    a = a * 3000000;
                }
                else
                {
                    a = a * 4500000;
                }
                d = a + b + c;
                lblTotal.Text = d.ToString();
                tboxtime.Text = coba3 + coba2 + coba1;
                total = lblTotal.Text;
                time = tboxtime.Text;
            }
            else
            {
                coba1 = cboxweek.Text + "";
                a = 0;
                d = a + b + c;
                lblTotal.Text = d.ToString();
                tboxtime.Text = coba3 + " " + coba2 + " " + coba1;
                total = lblTotal.Text;
                time = tboxtime.Text;
            }

        }

        private void cboxmonth_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cboxmonth.Text != "")
            {
                coba2 = cboxmonth.Text + " Bulan";
                b = Convert.ToInt32(cboxmonth.Text);
                if (cbcategory.Text == "Tiny Warehouse")
                {
                    b = b * 5000000;
                }
                else if (cbcategory.Text == "Normal Warehouse")
                {
                    b = b * 8000000;
                }
                else if (cbcategory.Text == "Large Warehouse")
                {
                    b = b * 10000000;
                }
                else
                {
                    b = b * 15000000;
                }
                d = a + b + c;
                lblTotal.Text = d.ToString();
                tboxtime.Text = coba3 + " " + coba2 + " " + coba1;
                total = lblTotal.Text;
                time = tboxtime.Text;
            }
            else
            {
                coba2 = cboxmonth.Text + "";
                b = 0;
                d = a + b + c;
                lblTotal.Text = d.ToString();
                tboxtime.Text = coba3 + " " + coba2 + " " + coba1;
                total = lblTotal.Text;
                time = tboxtime.Text;
            }
        }

        private void cboxyear_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cboxyear.Text != "")
            {
                coba3 = cboxyear.Text + " Tahun";
                c = Convert.ToInt32(cboxyear.Text);
                if (cbcategory.Text == "Tiny Warehouse")
                {
                    c = c * 70000000;
                }
                else if (cbcategory.Text == "Normal Warehouse")
                {
                    c = c * 90000000;
                }
                else if (cbcategory.Text == "Large Warehouse")
                {
                    c = c * 110000000;
                }
                else
                {
                    c = c * 150000000;
                }
                d = a + b + c;
                lblTotal.Text = d.ToString();
                tboxtime.Text = coba3 + " " + coba2 + " " + coba1;
                total = lblTotal.Text;
                time = tboxtime.Text;
            }
            else
            {
                coba3 = cboxyear.Text + "";
                c = 0;
                d = a + b + c;
                lblTotal.Text = d.ToString();
                tboxtime.Text = coba3 + " " + coba2 + " " + coba1;
                total = lblTotal.Text;
                time = tboxtime.Text;
            }
        }


        private void cbcategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                
                if (string.IsNullOrEmpty(cbcategory.Text))
                {

                }
                else
                {

                 DataTable dtPlayer = new DataTable();
                sqlQuery = "select * from unit u, kategori_sewa k where u.PSEWA_NO=k.PSEWA_NO and unit_status=0 and k.PSEWA_NAME='"+cbcategory.Text+"' LIMIT 1  ";
                sqlCommand = new MySqlCommand(sqlQuery, fLogin.conn);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtPlayer);
                tboxunit.Text = dtPlayer.Rows[0]["UNIT_NO"].ToString();/*
               cboxPemain.DataSource = null;
                DataTable PemainT = new DataTable();
                sqlConnect = new MySqlConnection(connectString);
                sqlQuery = "SELECT player_name, player_id FROM player p, team t WHERE p.team_id = t.team_id AND team_name = '" + cboxTeam.Text + "'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(PemainT);
                cboxPemain.DataSource = PemainT;
                cboxPemain.DisplayMember = "player_name";
                cboxPemain.ValueMember = "player_id";
                cboxPemain.SelectedIndex = -1;

                    if (cbcategory.Text == "Tiny Warehouse")
                    {

                        k = 1500000;
                        d = a + b + c + k;
                    }
                    else if (cbcategory.Text == "Normal Warehouse")
                    {

                        k = 2500000;
                        d = a + b + c + k;
                    }
                    else if (cbcategory.Text == "Large Warehouse")
                    {
                        k = 3000000;
                        d = a + b + c + k;
                    }
                    else
                    {

                        k = 4500000;
                        d = a + b + c + k;
                    }
                    
                    lblTotal.Text = d.ToString(); */
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnreport_Click(object sender, EventArgs e)
        {
            gbunit.Visible = false;
            gbLaporan.Visible = true;
        }

        private void btnsales_Click(object sender, EventArgs e)
        {
            gbunit.Visible = true;
        }

        private void cboxcategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtPlayer = new DataTable();
            if (cboxcategori.Text == "TINY WAREHOUSE")
            {
                sqlQuery = "select concat('T',concat(IF(count(unit_no)<10, '000', '00')),ifnull(substr(max(unit_no),2,5),0)+1 ) as `ID` , k.PSEWA_NO as `No`  from unit u, kategori_sewa k where u.psewa_no=k.psewa_no and k.psewa_name ='" + cboxcategori.Text + "'";
            }
            else if (cboxcategori.Text == "NORMAL WAREHOUSE")
            {
                sqlQuery = "select concat('N',concat(IF(count(unit_no)<10, '000', '00')),ifnull(substr(max(unit_no),2,5),0)+1 ) as `ID`, k.PSEWA_NO as `No`   from unit u, kategori_sewa k where u.psewa_no=k.psewa_no and k.psewa_name ='" + cboxcategori.Text + "'";
            }
            else if(cboxcategori.Text == "LARGE WAREHOUSE")
            {
                sqlQuery = "select concat('L',concat(IF(count(unit_no)<10, '000', '00')),ifnull(substr(max(unit_no),2,5),0)+1 ) as `ID` ,k.PSEWA_NO as `No`  from unit u, kategori_sewa k where u.psewa_no=k.psewa_no and k.psewa_name ='" + cboxcategori.Text + "'";

            }
            else
            {
                sqlQuery = "select concat('X',concat(IF(count(unit_no)<10, '000', '00')),ifnull(substr(max(unit_no),2,5),0)+1 ) as `ID`, k.PSEWA_NO as `No`  from unit u, kategori_sewa k where u.psewa_no=k.psewa_no and k.psewa_name ='" + cboxcategori.Text + "'";

            }
            sqlCommand = new MySqlCommand(sqlQuery, fLogin.conn);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtPlayer);
            tboxunitadd.Text = dtPlayer.Rows[0]["ID"].ToString();
            psewa = dtPlayer.Rows[0]["NO"].ToString();
        }

        private void Btnadd2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure to Added?", "Notification", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                sqlQuery = "INSERT INTO `unit` (`UNIT_NO`, `PSEWA_NO`, `UNIT_STATUS`, `UNIT_DELETE`) VALUES ('"+tboxunitadd.Text+"', '"+psewa+"', '0', '0'); ";
                sqlCommand = new MySqlCommand(sqlQuery, fLogin.conn);

                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Input Succed");
                DataTable dtPlayer2 = new DataTable();

                sqlQuery = "select UNIT_NO as `Unit ID`, PSEWA_NAME as `Warehoouse Name`, if(unit_status=0,'Available','Rented') as `Status Unit` from unit u, kategori_sewa k where u.PSEWA_NO=k.PSEWA_NO";
                sqlCommand = new MySqlCommand(sqlQuery, fLogin.conn);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtPlayer2);
                Dgvadd.DataSource = dtPlayer2;
                tboxunitadd.Text = "";
                IsiAdd();
            }
        }

        private void btnaddd_Click(object sender, EventArgs e)
        {
           gbunit.Visible = true;
        }

        private void cboxday_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void cboxmonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void cboxyear_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}
