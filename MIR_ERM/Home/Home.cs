using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.Data.SqlClient;
using System.Data.Common;

namespace MIR_ERM.Home
{
    public partial class Home : Form
    {
        private string connectionString = GlobalConfig.ConnectionString;
        private string Query = "";
        string[] judulHeader = { "No", "Kode Barang", "Nama Barang", "Harga", "Stock" };
        string[] nameHeader = { "No", "KodeBarang", "NamaBarang", "Harga", "Stock" };


        public Home()
        {
            InitializeComponent();
        }

        private void inputBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stock.AddStock f = new Stock.AddStock();
            f.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            dgvStockHome.ColumnCount = judulHeader.Length;

            // Loop untuk menetapkan judul header dan nama kolom
            for (int i = 0; i < judulHeader.Length; i++)
            {
                // Mengatur judul header (yang tampil di datagrid)
                dgvStockHome.Columns[i].HeaderText = judulHeader[i];

                // Mengatur nama kolom (untuk akses secara kode)
                dgvStockHome.Columns[i].Name = nameHeader[i];
            }

            // Mengatur lebar kolom "No" agar sesuai dengan panjang isinya
            dgvStockHome.AutoResizeColumn(dgvStockHome.Columns["No"].Index, DataGridViewAutoSizeColumnMode.DisplayedCells);

            // Mengatur kolom lainnya untuk mengisi sisa ruang
            for (int j = 1; j < dgvStockHome.Columns.Count; j++)
            {
                dgvStockHome.Columns[j].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }


            loaddata();


        }

        private void loaddata()
        {
            string Query = "select * from tbl_barang";
            int i = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(Query, connection))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            dgvStockHome.Rows.Add();
                            dgvStockHome.Rows[i].Cells["No"].Value = i + 1;
                            dgvStockHome.Rows[i].Cells["KodeBarang"].Value = reader["kode_barang"].ToString();
                            dgvStockHome.Rows[i].Cells["NamaBarang"].Value = reader["nama_barang"].ToString();

                            // Mendapatkan nilai harga dari reader dan mencoba memparsenya ke decimal
                            if (decimal.TryParse(reader["harga"].ToString(), out decimal harga))
                            {
                                // Format harga menjadi "Rp. x.xxx" dan tampilkan di DataGridView
                                dgvStockHome.Rows[i].Cells["Harga"].Value = $"Rp. {harga:N0}";
                            }
                            else
                            {
                                // Jika parsing gagal, tampilkan nilai asli atau pesan default
                                dgvStockHome.Rows[i].Cells["Harga"].Value = "Rp. 0";
                            }

                            dgvStockHome.Rows[i].Cells["Stock"].Value = reader["stok"].ToString();

                            i++;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbljam.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void penjualanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transaksi.Penjualan.PenjualanHome f = new Transaksi.Penjualan.PenjualanHome();
            f.Show();
        }

        private void daftarBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stock.ListStock f = new Stock.ListStock();
            f.Show();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            dgvStockHome.Rows.Clear();
            loaddata();
        }
    }
}
