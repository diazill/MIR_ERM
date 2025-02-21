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

namespace MIR_ERM.Stock
{
    public partial class ListStock : Form
    {
        private string connectionString = GlobalConfig.ConnectionString;
        private string Query = "";
        string[] judulHeader = { "No", "Kode Barang", "Nama Barang" };
        string[] nameHeader = { "No", "KodeBarang", "NamaBarang" };

        public ListStock()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListStock_Load(object sender, EventArgs e)
        {
            dgvlistbarang.ColumnCount = judulHeader.Length;

            // Loop untuk menetapkan judul header dan nama kolom
            for (int i = 0; i < judulHeader.Length; i++)
            {
                // Mengatur judul header (yang tampil di datagrid)
                dgvlistbarang.Columns[i].HeaderText = judulHeader[i];

                // Mengatur nama kolom (untuk akses secara kode)
                dgvlistbarang.Columns[i].Name = nameHeader[i];
            }

            // Mengatur lebar kolom "No" agar sesuai dengan panjang isinya
            dgvlistbarang.AutoResizeColumn(dgvlistbarang.Columns["No"].Index, DataGridViewAutoSizeColumnMode.DisplayedCells);

            // Mengatur kolom lainnya untuk mengisi sisa ruang
            for (int j = 1; j < dgvlistbarang.Columns.Count; j++)
            {
                dgvlistbarang.Columns[j].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            loaddata();
        }

        private void loaddata()
        {
            Query = "select * from tbl_barang ";

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
                            dgvlistbarang.Rows.Add();
                            dgvlistbarang.Rows[i].Cells["No"].Value = i + 1;
                            dgvlistbarang.Rows[i].Cells["KodeBarang"].Value = reader["kode_barang"].ToString();
                            dgvlistbarang.Rows[i].Cells["NamaBarang"].Value = reader["nama_barang"].ToString();

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

        private void dgvlistbarang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string brid = dgvlistbarang.Rows[e.RowIndex].Cells[1].Value.ToString();

            string mode = "view";
            
            BarangDetailForm f = new BarangDetailForm(brid,mode);
            f.Show();
        }
    }
}
