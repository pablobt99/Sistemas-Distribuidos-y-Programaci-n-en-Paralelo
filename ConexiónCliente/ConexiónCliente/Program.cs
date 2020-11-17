using System;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace ConexiónCliente
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                TcpClient tcpclient = new TcpClient();

                Console.WriteLine("Conectando...");
                tcpclient.Connect("127.0.0.1", 80);
                Console.WriteLine("conectado");
                Console.Write("Mensage -->");
                string mensge_a_envivar = Console.ReadLine();
                Stream stream = tcpclient.GetStream();
                ASCIIEncoding ascii = new ASCIIEncoding();
                byte[] enviar = ascii.GetBytes(mensge_a_envivar);
                stream.Write(enviar, 0, enviar.Length);
                byte[] bit = new byte[100];
                int i = stream.Read(bit, 0, 100);
                for(int a = 0; a < i; a++)
                {
                    Console.Write(Convert.ToChar(bit[a]));
                }
                tcpclient.Close();
                Console.WriteLine("La aplicación se cerrará!");
                Thread.Sleep(1000);
            }
            catch(Exception)
            {

            }
        }
    }
}
