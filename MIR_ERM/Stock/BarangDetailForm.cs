using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace MIR_ERM.Stock
{
    public partial class BarangDetailForm : Form
    {
        public string barangid;
        private string connectionString = GlobalConfig.ConnectionString;
        private string Query = "";
        private string mode = "";


        public BarangDetailForm(string brid, string mode)
        {
            InitializeComponent();
            barangid = brid;
            mode = mode;

            if (mode == "view")
            {
                ModeView();
            }
        }

        private void ModeView()
        {
            txtbarangid.ReadOnly = true;
            txtbarangid.Enabled = false;
            txtnamabarang.ReadOnly = true;
            txtnamabarang.Enabled = false;
            txtharga.ReadOnly = true;
            txtharga.Enabled = false;
            txtstock.ReadOnly = true;
            txtstock.Enabled = false;
            txtsatuan.ReadOnly = true;
            txtsatuan.Enabled = false;
            txtsuplier.ReadOnly = true;
            txtsuplier.Enabled = false;
            btn_save.Visible = false;
            btn_cancel.Visible = false;
            btn_edit.Enabled = true;
        }

        private void ModeEdit()
        {
            txtbarangid.ReadOnly = false;
            txtbarangid.Enabled = true;
            txtnamabarang.ReadOnly = false;
            txtnamabarang.Enabled = true;
            txtharga.ReadOnly = false;
            txtharga.Enabled = true;
            txtstock.ReadOnly = false;
            txtstock.Enabled = true;
            txtsatuan.ReadOnly = false;
            txtsatuan.Enabled = true;
            txtsuplier.ReadOnly = false;
            txtsuplier.Enabled = true;
            btn_save.Visible = true;
            btn_edit.Enabled = false;
            btn_cancel.Visible = true;
        }

        private void BarangDetailForm_Load(object sender, EventArgs e)
        {
            //txtbarangid.Text = barangid;
            loaddata();
        }

        private void loaddata()
        {
            Query = "select * from tbl_barang where kode_barang = @kode_barang";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(Query, connection))
                    {
                        cmd.Parameters.AddWithValue("@kode_barang", barangid);
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            txtbarangid.Text = barangid;
                            txtnamabarang.Text = reader["nama_barang"].ToString();
                            txtharga.Text = reader["harga"].ToString();
                            txtstock.Text = reader["stok"].ToString();
                            txtsatuan.Text = reader["satuan_barang"].ToString();
                            txtsuplier.Text = reader["supplier_barang"].ToString();

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            ModeEdit();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            ModeView();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string namabarang = txtnamabarang.Text;
            long kodebarang = Convert.ToInt64(txtbarangid.Text);
            decimal harga = Convert.ToDecimal(txtharga.Text);
            int stock = Convert.ToInt32(txtstock.Text);
            string satuan = txtsatuan.Text;
            string suplier = txtsuplier.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                Query = "UPDATE tbl_barang set nama_barang = @nama_barang, harga = @harga , stok = @stok, satuan_barang = @satuan_barang, supplier_barang = @supplier_barang, CreatedBy = @CreatedBy, CreatedDate = @CreatedDate where  kode_barang = @kodebarang ";

                connection.Open();
                try {
                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        command.Parameters.AddWithValue("kodebarang", kodebarang);
                        command.Parameters.AddWithValue("nama_barang", namabarang);
                        command.Parameters.AddWithValue("harga", harga);
                        command.Parameters.AddWithValue("stok", stock);
                        command.Parameters.AddWithValue("satuan_barang", satuan);
                        command.Parameters.AddWithValue("supplier_barang", suplier);
                        command.Parameters.AddWithValue("CreatedBy", "Admin");
                        command.Parameters.AddWithValue("CreatedDate", DateTime.Now);

                        command.ExecuteNonQuery();

                        MessageBox.Show("Data berhasil di input", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                } catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                connection.Close();
            }

            ModeView();
        }
    }
}
