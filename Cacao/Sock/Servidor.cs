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

        int request = 0;

        public Jugador[] jugadores;
        public int contador =0;

        public int cantidadJugadores;

        public Servidor(string ip, int port, int cantJugadores)
        {
            this.cantidadJugadores = cantJugadores;
            jugadores = new Jugador[cantidadJugadores];
            try
            {
                host = Dns.GetHostEntry(ip);
                ipAddr = host.AddressList[0];
                endPoint = new IPEndPoint(ipAddr, port);
                //MessageBox.Show(host.AddressList[0].ToString());
                // Create a TCP/IP socket.  
                s_Server = new Socket(ipAddr.AddressFamily,
                SocketType.Stream, ProtocolType.Tcp);
            }
            catch( Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }

        public void Start()
        {
            // Data buffer for incoming data.  
            //byte[] bytes;
            //data = null;
            //s_Server.Shutdown(SocketShutdown.Both);

            
            try
            {
                s_Server.Bind(endPoint);
                //numero de clientes permitidos
                s_Server.Listen(10);
                
                // Start listening for connections.  
                while (true){

                    //bytes = new byte[1024];
                    //MessageBox.Show("Esperando una conexión...");
                    //El programa espera acá, mientras le llega una solicitud de conexión
                    MessageBox.Show("Esperando conexion");
                    s_Client = s_Server.Accept();
                    MessageBox.Show("Conectado");

                    data = null;
                    while (true)
                    {


                        //validaciones, qué sucede si hay conexion? qué pregunta, envia o recibe el server? todo aquí.
                        //s_Client.Receive(bytes);
                        try {
                            //jugadores[contador] = new Jugador();
                            //jugadores[contador] = new Jugador();

                            if (request == 0) {
                                clientReceive();
                                Send(this.cantidadJugadores.ToString());
                                request++;
                                break;
                            }
                            if (request == 1) {
                                jugadores[contador] = new Jugador();
                                jugadores[contador] = RecibirJugador();
                                Singlenton.Instance.lblUsuarios.Text += "\n" + contador.ToString() + "-) " + jugadores[contador].Nombre;
                                Singlenton.Instance.lblUsuarios.Refresh();
                                contador = 0;
                                //s_Client.Send(BinSerial.Serializar(nombre));
                                //Singlenton.Instance.lblUsuarios.Text = "";
                                break;
                            }
                            
                        }
                        catch (Exception e) {
                            
                        }
                        


                        //Loseta l = recibirLoseta(s_Client);
                        //if (l.IsOculta) {
                        //    //Loseta l = new Loseta("Loseta 1", 3);
                        //    //MessageBox.Show(datos);
                        //    l.Nombre = "Loseta recibida";
                        //    s_Client.Send(BinSerial.Serializar(l));
                        //    continue;
                        //}
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

        

        

        public bool IniciarPartida() {
            if (jugadores.Length == this.cantidadJugadores)
            {
                asignarPosicionJugador();
                return true;
            }
            else {
                return false;
            }

        }

        private void asignarPosicionJugador()
        {
            
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
        public Jugador RecibirJugador()
        {
            string recibido = "";
            Jugador l;
            byte[] buffer = new byte[1024];
            s_Client.Receive(buffer);
            l = (Jugador)BinSerial.Deserializar(buffer);
            //MessageBox.Show(l.Nombre + "||" + l.Nombre);
            return l;
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
        
