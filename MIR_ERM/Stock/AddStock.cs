using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.QrCode;
using ZXing.Windows.Compatibility;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data.SqlClient;

namespace MIR_ERM.Stock
{
    public partial class AddStock : Form
    {
        private string connectionString = GlobalConfig.ConnectionString;
        private string Query = "";

        public AddStock()
        {
            InitializeComponent();
        }

        FilterInfoCollection FilterInfoCollection;
        VideoCaptureDevice VideoCaptureDevice;

        private void AddStock_Load(object sender, EventArgs e)
        {
            FilterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach (FilterInfo device in FilterInfoCollection)
            cmbCAM.Items.Add(device.Name);
            cmbCAM.SelectedIndex = 0;
        }

        private void btnscan_Click(object sender, EventArgs e)
        {
            VideoCaptureDevice = new VideoCaptureDevice(FilterInfoCollection[cmbCAM.SelectedIndex].MonikerString);
            VideoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            VideoCaptureDevice.Start();
        }

        private void VideoCaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            BarcodeReader reader = new BarcodeReader();
            var result = reader.Decode(bitmap);

            if (result != null)
            {
                if (txtkodebarang.IsHandleCreated && !txtkodebarang.IsDisposed)
                {
                    txtkodebarang.Invoke(new MethodInvoker(delegate ()
                    {
                        txtkodebarang.Text = result.ToString();
                    }));
                }
                else
                {
                    txtkodebarang.HandleCreated += (s, e) =>
                    {
                        if (!txtkodebarang.IsDisposed)
                        {
                            txtkodebarang.Invoke(new MethodInvoker(delegate ()
                            {
                                txtkodebarang.Text = result.ToString();
                            }));
                        }
                    };
                }
            }

            if (pboxbarcode.IsHandleCreated && !pboxbarcode.IsDisposed)
            {
                if (pboxbarcode.IsDisposed) {
                    return;
                }
                else
                {
                    if (pboxbarcode != null && pboxbarcode.IsHandleCreated && !pboxbarcode.IsDisposed)
                    {
                        if (this != null && !this.IsDisposed && this.IsHandleCreated)
                        {
                            if (pboxbarcode != null && !pboxbarcode.IsDisposed && pboxbarcode.IsHandleCreated)
                            {
                                pboxbarcode.BeginInvoke(new MethodInvoker(delegate ()
                                {
                                    if (!pboxbarcode.IsDisposed) // Additional check inside BeginInvoke
                                    {
                                        pboxbarcode.Image = bitmap;
                                    }
                                }));
                            }
                        }
                    }
                }
            }
        }


        private void btnclose_Click(object sender, EventArgs e)
        {
            fclose();
            this.Close();
        }

        private void fclose()
        {
            if (VideoCaptureDevice != null)
            {
                if (VideoCaptureDevice.IsRunning)
                {
                    //VideoCaptureDevice.Stop();
                    VideoCaptureDevice.SignalToStop(); // Melepaskan kamera
                    VideoCaptureDevice.WaitForStop();
                }
            }
        }

        private void AddStock_FormClosing(object sender, FormClosingEventArgs e)
        {
            fclose();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {


            string namabarang = txtnamabarang.Text;
            long kodebarang = Convert.ToInt64(txtkodebarang.Text);

            if (kodebarang == 0 || txtkodebarang.Text == "")
            {
                MessageBox.Show("Kode Barang Harus diisi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                Query = "INSERT INTO tbl_barang (kode_barang,nama_barang) VALUES (@kode_barang,@nama_barang)";

                connection.Open();
                try
                {
                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        command.Parameters.AddWithValue("kode_barang", kodebarang);
                        command.Parameters.AddWithValue("nama_barang", namabarang);

                        command.ExecuteNonQuery();

                        MessageBox.Show("Data berhasil di input", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                connection.Close();

                txtkodebarang.Text = "";
                txtnamabarang.Text = "";
            }
        }
    }
}
