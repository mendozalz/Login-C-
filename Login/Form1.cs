namespace Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = "mendozalz";
            string passwd = "123";

            if (txtUsuario.Text == usuario && txtPasswd.Text == passwd)
            {
                //essageBox.Show("Haz ingresado correctamente");
                Form2 ventana = new Form2();
                ventana.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("usuario o contraseña incorrecto");
                txtPasswd.Text = "";
                txtUsuario.Text = "";
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
