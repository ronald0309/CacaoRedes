using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Net;            //   Paso 1
using System.Net.Sockets;    //   Paso 1
using System.Windows.Forms;

namespace Cacao.Sock
{
    class Cliente
    {
        public Cliente()
        {

        }
        public void Conect()
        {
            Conectar(); 
        }
        public static void Conectar()
        {
            Socket miPrimerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            // paso 2 - creamos el socket
            IPEndPoint miDireccion = new IPEndPoint(IPAddress.Parse("192.168.8.103"), 1234);
            //paso 3 - Acá debemos poner la Ip del servidor, y el puerto de escucha del servidor
            //Yo puse esa porque corrí las dos aplicaciones en la misma pc
            try
            {
                miPrimerSocket.Connect(miDireccion); // Conectamos                
                Console.WriteLine("Conectado con exito");
                MessageBox.Show("Conectado");
                miPrimerSocket.Close();
            }
            catch (Exception error)
            {
                Console.WriteLine("Error: {0}", error.ToString());
            }
            Console.WriteLine("Presione cualquier tecla para terminar");
            Console.ReadLine();
        }
    }
}