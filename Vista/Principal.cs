using Entidades;

namespace Vista
{
    public partial class Principal : Form
    {
        Cliente clienteS;
        public Principal()
        {
            InitializeComponent();
            btnDesconectar.Enabled = false;
            btnConsultar.Enabled = false;
            btnComprar.Enabled = false;
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Equals(string.Empty))
            {
                MessageBox.Show("Debe ingresar el ID del cliente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (ClienteTCP.Conectar(txtID.Text))
                {
                    this.clienteS = ClienteTCP.ObtenerCliente(txtID.Text);
                    labelUsuario.Text = this.clienteS.nombre + " " + this.clienteS.primApell;
                    txtID.ReadOnly = true;
                    btnConectar.Enabled = false;
                    btnDesconectar.Enabled = true;
                    btnConsultar.Enabled = true;
                    btnComprar.Enabled = true;

                }
                else
                {
                    MessageBox.Show("Es posible que el ID no esté registrado o el servidor se encuentra desconectado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            ClienteTCP.Desconectar(txtID.Text);
            txtID.ReadOnly = false;
            btnConectar.Enabled = true;
            btnDesconectar.Enabled = false;
            btnConsultar.Enabled = false;
            btnComprar.Enabled = false;
            labelUsuario.Text = "Usuario";
        }


        private void btnComprar_Click(object sender, EventArgs e)
        {
            ComBoleto fr = new ComBoleto(clienteS);
            fr.ShowDialog();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ConsultaBoleto fr = new ConsultaBoleto(clienteS);
            fr.ShowDialog();
        }
    }
}