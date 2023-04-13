// Toma como base el cliente TCP del ejemplo Biblioteca
// Visto en clase

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Net.Sockets;
using Newtonsoft.Json;
using System.Text.Json.Serialization;


namespace Entidades
{
    public class ClienteTCP
    {
        private static IPAddress ipServidor;
        private static TcpClient cliente;
        private static IPEndPoint serverEndPoint;
        private static StreamWriter clienteStreamWriter;
        private static StreamReader clienteStreamReader;


        public static bool Conectar(string clienteId)
        {
            try 
            {
                ipServidor = IPAddress.Parse("127.0.0.1");
                cliente = new TcpClient();
                serverEndPoint = new IPEndPoint(ipServidor, 14100);
                cliente.Connect(serverEndPoint);
                MensajeSocket<string> mensajeConectar = new MensajeSocket<string> { Metodo = "Conectar", Entidad = clienteId };

                clienteStreamReader = new StreamReader(cliente.GetStream());
                clienteStreamWriter = new StreamWriter(cliente.GetStream());
                clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajeConectar));
                clienteStreamWriter.Flush();

                var mensjae = clienteStreamReader.ReadLine();
                bool salida = JsonConvert.DeserializeObject<bool>(mensjae);
                return salida;
            }
            catch (SocketException) { return false; }
            return true;
        }
        // Funcion para obtener el cliente
        public static Cliente ObtenerCliente(string clienteId) 
        {
            Cliente salida;
            MensajeSocket<string> mensajeObtenerCliente = new MensajeSocket<string> { Metodo = "ObtenerCliente", Entidad = clienteId };

            clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajeObtenerCliente));
            clienteStreamWriter.Flush();

            var mensaje = clienteStreamReader.ReadLine();
            salida = JsonConvert.DeserializeObject<Cliente>(mensaje);
            string id = salida.id;
            return salida;

        }

        public static void Desconectar(string idCliente) 
        {
            MensajeSocket<string> mensajeDesconectar = new MensajeSocket<string> { Metodo = "Desconectar", Entidad = idCliente };

            clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajeDesconectar));
            clienteStreamWriter.Flush();
            //Se cierra la conexión del cliente
            cliente.Close();
        }

        public static List<Boleto> ObtenerBoletos(Cliente cliente) 
        {
            List<Boleto> boletos = new List<Boleto>();
            try 
            {
                MensajeSocket<Cliente> mensajeObtBoletos = new MensajeSocket<Cliente> { Metodo = "ConsultarBoletos", Entidad = cliente };
                clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajeObtBoletos));
                clienteStreamWriter.Flush();

                var mensaje = clienteStreamReader.ReadLine();
                boletos = JsonConvert.DeserializeObject<List<Boleto>>(mensaje);

                return boletos;


            }
            catch (Exception)
            {
                throw;
            }
            return boletos;
        }
        public static List<Vuelo> ObtenerVuelos()
        {
            List<Vuelo> vuelos = new List<Vuelo>();
            try 
            {
                MensajeSocket<string> mensajeObtVuelos = new MensajeSocket<string> { Metodo = "ConsultarVuelos"};
                clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajeObtVuelos));
                clienteStreamWriter.Flush();

                var mensaje = clienteStreamReader.ReadLine();
                vuelos = JsonConvert.DeserializeObject<List<Vuelo>>(mensaje);
            }
            catch { throw; }
            return vuelos;
        }
        // Funcion para obtener todos los boleto
        public static List<Boleto> ObtenerTodoBoletos() 
        {
            List<Boleto> boletos = new List<Boleto>();
            try 
            {
                MensajeSocket<string> mensajeObtBoletos = new MensajeSocket<string> { Metodo = "TodosBoletos" };
                clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajeObtBoletos));
                clienteStreamWriter.Flush();

                var mensaje = clienteStreamReader.ReadLine();
                boletos = JsonConvert.DeserializeObject<List<Boleto>>(mensaje);
            }
            catch (Exception) { }

            return boletos;
        }
        // Funcion para guardar Boleto
        public static bool GuardarBoleto(Boleto boletin) 
        {
            try 
            {
                MensajeSocket<Boleto> mensajeAutor = new MensajeSocket<Boleto> { Metodo = "ComprarBoleto", Entidad = boletin };
                clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajeAutor));
                clienteStreamWriter.Flush();
                return true;
            }
            catch { return false; }
        }

    }
}
