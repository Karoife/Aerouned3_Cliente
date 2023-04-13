using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace Vista
{
    public partial class ComBoleto : Form
    {
        Cliente cliente;
        List<Vuelo> vuelos;
        List<Boleto> boletos;
        public ComBoleto(Cliente clienteE)
        {
            InitializeComponent();
            this.cliente = clienteE;
            vuelos = ClienteTCP.ObtenerVuelos();
            if (vuelos.Count == 0)
            {
                MessageBox.Show("No hay Vuelos Disponibles");
                Close();
            }
            boletos = ClienteTCP.ObtenerTodoBoletos();
            LlenarComboBox();
            labelUsuario.Text = cliente.nombre + " " + cliente.primApell;
            tabla.ColumnCount = 6;
            tabla.Columns[0].Name = "Número";
            tabla.Columns[1].Name = "Aerolínea";
            tabla.Columns[2].Name = "Origen";
            tabla.Columns[3].Name = "Destino";
            tabla.Columns[4].Name = "Duración";
            tabla.Columns[5].Name = "Capacidad";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void LlenarComboBox()
        {
            try
            {
                foreach (Vuelo vuelo in vuelos)
                {
                    cmbVuelo.Items.Add(vuelo.id.ToString() + "-" + vuelo.origen.nombre + "-" + vuelo.destino.nombre);
                }
            }
            catch (Exception) { }
        }

        private int ContarAsientos(Vuelo vuelin)
        {
            int totalAsientos = 0;
            foreach (Boleto boleto in boletos)
            {
                if (boleto.vuelo.id.Equals(vuelin.id))
                {
                    totalAsientos = totalAsientos + boleto.asientos;
                }
            }
            return vuelin.capacidad - totalAsientos;
        }
        // Funcion para mostrar el vuelo seleccionado
        private void MostrarVuelo(Vuelo vuelin)
        {
            tabla.Rows.Clear();
            string[] Row = new[] { vuelin.id.ToString(), vuelin.aerolinea.nombre, vuelin.origen.ciudad, vuelin.destino.ciudad, vuelin.duracion.ToString("HH:mm"), vuelin.capacidad.ToString() };
            tabla.Rows.Add(Row);
        }

        private void cmbVuelo_SelectedValueChanged(object sender, EventArgs e)
        {
            int asientos = ContarAsientos(vuelos[cmbVuelo.SelectedIndex]);
            labelAsientos.Text = asientos.ToString();
            MostrarVuelo(vuelos[cmbVuelo.SelectedIndex]);
            numAsientos.Maximum = asientos;
        }
        private void ComprarBoleto()
        {
            if (txtNumero.Text.Equals(string.Empty) || cmbVuelo.Text.Equals(string.Empty))
            {
                MessageBox.Show("Debe ingresar Datos!");
            }
            else
            {
                foreach (Boleto boleto in boletos)
                {
                    if (boleto.numero == int.Parse(txtNumero.Text))
                    {
                        MessageBox.Show("EL numero de boleto se encuentra registrado!");
                        return;
                    }
                }
                Boleto boletoS = new Boleto
                {
                    numero = int.Parse(txtNumero.Text),
                    vuelo = vuelos[cmbVuelo.SelectedIndex],
                    fecha = DateTime.Now,
                    cliente = cliente,
                    asientos = Decimal.ToInt32(numAsientos.Value)
                };
                if (ClienteTCP.GuardarBoleto(boletoS)) 
                {
                    MessageBox.Show("Guardado Correctamente!");
                    txtNumero.Clear();
                    cmbVuelo.Text = "";
                    numAsientos.Value = 1;
                    boletos = ClienteTCP.ObtenerTodoBoletos();
                    labelAsientos.Text = "0";
                    tabla.Rows.Clear();
                }
                
            }
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            ComprarBoleto();
        }
    }
}
