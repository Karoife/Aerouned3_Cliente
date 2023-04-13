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

namespace Vista
{
    public partial class ConsultaBoleto : Form
    {
        Cliente cliente;
        public ConsultaBoleto(Cliente clienteE)
        {
            InitializeComponent();
            cliente = clienteE;
            usuario.Text = cliente.nombre;
            LlenarTabla();
            
        }
        private void LlenarTabla() 
        {
            tabla.ColumnCount = 5;
            tabla.Columns[0].Name = "Número";
            tabla.Columns[1].Name = "Vuelo";
            tabla.Columns[2].Name = "Fecha";
            tabla.Columns[3].Name = "Cliente";
            tabla.Columns[4].Name = "Asientos";
            // Revisa si puede mostrar en las filas
            List<Boleto> boletos = ClienteTCP.ObtenerBoletos(cliente);
            try
            {
                foreach (Boleto boleto in boletos)
                {
                    string[] Row = new[] { boleto.numero.ToString(), boleto.vuelo.id + "-" + boleto.vuelo.origen.ciudad + "-" + boleto.vuelo.destino.ciudad, boleto.fecha.ToString("d"), boleto.cliente.nombre + " " + boleto.cliente.primApell + " " + boleto.cliente.segApell, boleto.asientos.ToString() };
                    tabla.Rows.Add(Row);
                }
            }
            catch (Exception)
            {
                // Do Nothing
            }
        }
    }
}
