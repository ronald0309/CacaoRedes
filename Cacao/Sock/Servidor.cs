using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;               //   Paso 1
using System.Net.Sockets;       //   Paso 1
using System.Windows.Forms;
using Cacao.Utils;
using Cacao.Clases;

namespace Cacao.Sock
{
    class Servidor
    {
        //;)
        IPHostEntry host;
        IPAddress ipAddr;
        IPEndPoint endPoint;

        Socket s_Server;
        Socket s_Client;

        string data;
        public string info;

        public Servidor(string ip, int port)
        {
            host = Dns.GetHostEntry(Dns.GetHostName());
            ipAddr = host.AddressList[0];
            endPoint = new IPEndPoint(ipAddr, port);

            // Create a TCP/IP socket.  
            s_Server = new Socket(ipAddr.AddressFamily,
            SocketType.Stream, ProtocolType.Tcp);
        }

        public void Start()
        {
            // Data buffer for incoming data.  
            //byte[] bytes;
            //data = null;

            try
            {
                s_Server.Bind(endPoint);
                //numero de clientes permitidos
                s_Server.Listen(10);
                MessageBox.Show("Conecct");
                // Start listening for connections.  
                while (true)
                {
                    //bytes = new byte[1024];
                    Console.WriteLine("Esperando una conexión...");
                    //El programa espera acá, mientras le llega una solicitud de conexión
                    MessageBox.Show("Conecct");
                    s_Client = s_Server.Accept();
                    MessageBox.Show("Conecct");
                    data = null;
                    while (true)
                    {
                        //validaciones, qué sucede si hay conexion? qué pregunta, envia o recibe el server? todo aquí.
                        //s_Client.Receive(bytes);

                        //Loseta l = recibirLoseta(s_Client);
                        //if (l.IsOculta) {
                        //    // Loseta l = new Loseta("Loseta 1", 3);
                        //    //MessageBox.Show(datos);
                        //    l.Nombre = "Loseta recibida";

                        //    s_Client.Send(BinSerial.Serializar(l));
                        //    break;
                        //}
                        info = clientReceive();
                         

                        //break;
                    }
                    Console.WriteLine("Text received : {0}", data);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                //Console.WriteLine(e.ToString());
            }

            Console.WriteLine("\nPress ENTER to continue...");
            Console.Read();
        }

        public void Send(string msj)
        {
            try
            {
                
                s_Client.Send(stringTobyte(msj));
                Console.WriteLine("Mensaje Enviado");
                //s_Client.Close();
            }
            catch (SocketException se)
            {
                Console.WriteLine("ERROR {0}", se.Message);
            }
        }

        public byte[] stringTobyte(string msj)
        {
            msj += "<EOF>";
            byte[] byteMsj = Encoding.ASCII.GetBytes(msj);
            Console.WriteLine("Mensaje Convertido");
            return byteMsj;
        }

        public Loseta recibirLoseta(object obj) {
            string recibido = "";
            Loseta l;
            byte[] buffer = new byte[1024];
            s_Client.Receive(buffer);
            l = (Loseta)BinSerial.Deserializar(buffer);
            MessageBox.Show(l.Nombre+"||"+l.IsOculta);
            return l;

        }

        public string clientReceive()
        {
            string recibido = "";
            byte[] buffer = new byte[1024];
            int bytesRec = s_Client.Receive(buffer);
            recibido += Encoding.ASCII.GetString(buffer, 0, bytesRec);
            if (recibido.IndexOf("<EOF>") > -1)
            {
                recibido = recibido.Remove(recibido.Length - 5);
            }
            return recibido;
        }
        public string byte2string(byte[] buffer,int bytesRec)
        {
            //data = null;
            string msj="";
            //int bytesRec = s_Client.Receive(buffer);
            data += Encoding.ASCII.GetString(buffer, 0, bytesRec);
            if (data.IndexOf("<EOF>") > -1)
            {
                data = data.Remove(data.Length - 5);
                //b = true;
            }

            return msj;
        }

        
    }
}
        //;)

        /*public void Conect()
        {
            Conectar();
        }
        public static void Conectar() 
        {
            Socket miPrimerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);  
            // paso 2 - creamos el socket
            IPEndPoint miDireccion = new IPEndPoint(IPAddress.Any, 1234);
            //paso 3 -IPAddress.Any significa que va a escuchar al cliente en toda la red
            try
            {
                // paso 4
                miPrimerSocket.Bind(miDireccion); // Asociamos el socket a miDireccion
                miPrimerSocket.Listen(1); // Lo ponemos a escucha
                Console.WriteLine("Escuchando...");
                MessageBox.Show("Escuchando");
                Socket Escuchar = miPrimerSocket.Accept();
                 //creamos el nuevo socket, para comenzar a trabajar con él
                 //La aplicación queda en reposo hasta que el socket se conecte a el cliente
                 //Una vez conectado, la aplicación sigue su camino 
                Console.WriteLine("Conectado con exito");
                /*Aca ponemos todo lo que queramos hacer con el socket, osea antes de
                

                cerrarlo je
                MessageBox.Show("Conectado Servidor");
                cerrarlo je
                MessageBox.Show("Conectado");
                miPrimerSocket.Close(); //Luego lo cerramos
            }
            catch (Exception error)
            {
                Console.WriteLine("Error: {0}", error.ToString());
            }
            Console.WriteLine("Presione cualquier tecla para terminar");
            Console.ReadLine();
        }
    }*/
