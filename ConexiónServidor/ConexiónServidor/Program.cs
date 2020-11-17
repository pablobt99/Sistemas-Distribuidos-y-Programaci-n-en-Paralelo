using System;
using System.Net;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;

namespace ConexiónServidor
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IPAddress ip = IPAddress.Parse("127.0.0.1");
                TcpListener tcplistener = new TcpListener(ip,80);
                tcplistener.Start();
                Console.WriteLine("Listener activado");
                Socket soket = tcplistener.AcceptSocket();
                Console.WriteLine("conexión establecida!");
                byte[] bit = new byte[100];
                int i = soket.Receive(bit);
                Console.WriteLine("Recibido: ");
                for(int a = 0; a < i; a++)
                {
                    Console.Write(Convert.ToChar(bit[a]));
                }
                ASCIIEncoding ascii = new ASCIIEncoding();
                soket.Send(ascii.GetBytes("El mensaje fue recibiddo correctamente!"));
                soket.Close();
                tcplistener.Stop();
                Console.WriteLine("La aplicación se cerrará");
                Thread.Sleep(1000);
            }
            catch (Exception)
            {

            }
        }
    }
}
