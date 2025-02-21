using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIR_ERM.Transaksi.Penjualan
{
    public partial class PenjualanHome : Form
    {
        private string connectionString = GlobalConfig.ConnectionString;
        private string Query = "";
        string[] judulHeader = { "No", "Kode Barang", "Nama Barang", "Harga", "Stock" };
        string[] nameHeader = { "No", "KodeBarang", "NamaBarang", "Harga", "Stock" };

        public PenjualanHome()
        {
            InitializeComponent();
        }

        private void PenjualanHome_Load(object sender, EventArgs e)
        {
            dgvDaftarBarang.ColumnCount = judulHeader.Length;

            // Loop untuk menetapkan judul header dan nama kolom
            for (int i = 0; i < judulHeader.Length; i++)
            {
                // Mengatur judul header (yang tampil di datagrid)
                dgvDaftarBarang.Columns[i].HeaderText = judulHeader[i];

                // Mengatur nama kolom (untuk akses secara kode)
                dgvDaftarBarang.Columns[i].Name = nameHeader[i];
            }

            // Mengatur lebar kolom "No" agar sesuai dengan panjang isinya
            dgvDaftarBarang.AutoResizeColumn(dgvDaftarBarang.Columns["No"].Index, DataGridViewAutoSizeColumnMode.DisplayedCells);

            // Mengatur kolom lainnya untuk mengisi sisa ruang
            for (int j = 1; j < dgvDaftarBarang.Columns.Count; j++)
            {
                dgvDaftarBarang.Columns[j].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void txtkodebarang_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("TEst");
        }
    }
}
