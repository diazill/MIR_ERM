using System.Configuration;
using System.Data.SqlClient;

namespace MIR_ERM
{
    public partial class LoginForm : Form
    {
        private string connectionString;
        private string Query = "";

        public LoginForm()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            String nama = txtusername.Text;
            String pass = txtpass.Text;

            Query = "SELECT @@SERVERNAME as 'namaserver';";

            String hasil = "";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(Query,connection))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read()) {
                            hasil = reader["namaserver"] != DBNull.Value ? reader["namaserver"].ToString() : string.Empty;
                        }
                    }
                } catch (Exception ex) {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }



            MessageBox.Show(hasil);

            
        }
    }
}
