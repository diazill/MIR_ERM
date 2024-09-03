namespace MIR_ERM
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            String nama = txtusername.Text;
            String pass = txtpass.Text;
            MessageBox.Show(nama);
        }
    }
}
