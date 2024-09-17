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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.Configuration;

namespace MIR_ERM
{
    public partial class RegisterForm : Form
    {
        private string connectionString;
        private string Query = "";

        public RegisterForm()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            string nama = txtnama.Text;
            string username = txtusername.Text;
            string password = txtpassword.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                Query = "INSERT INTO tbl_user (username,password,nama,CreatedBy,CreatedDate) VALUES (@username,@password, @nama,@CreatedBy,@CreatedDate)";

                connection.Open();
                try
                {
                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        command.Parameters.AddWithValue("username", username);
                        command.Parameters.AddWithValue("password", password);
                        command.Parameters.AddWithValue("nama", nama);
                        command.Parameters.AddWithValue("CreatedBy", "SYSTEM");
                        command.Parameters.AddWithValue("CreatedDate", DateTime.Now);
                        
                        command.ExecuteNonQuery();

                        MessageBox.Show("Data berhasil di input","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        
                    }
                } catch (Exception ex) {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                connection.Close();

                this.Close();





            }
        }
    }
}
