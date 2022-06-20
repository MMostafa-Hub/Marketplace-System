using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;
using System.Threading;
using System.Text;
using Server_App.Classes;
public class Server
{
    private static void ProcessClientRequests(object argument)
    {
        serverSocket socket = new serverSocket((TcpClient)argument);
        try
        {
            dynamic recieved_obj, response_obj;
            while (true)
            {
                /* Listen on the socket */
                recieved_obj = socket.read();
                switch(recieved_obj)
                {
                    /* Switches for the specific reponse */
                }
                //socket.write(response_obj);
            }

            /* Closing the Connection */
            socket.close();
        }
        catch (serverSocket.ReadTimeoutException e)
        {
            /**/
        }
        catch (serverSocket.WriteException e)
        {
            /**/
        }

    }

    public static void Main()
    {
        TcpListener? listener = null;
        try
        {
            IPAddress ip = IPAddress.Any;

            /* Creating a port */
            listener = new TcpListener(ip, 8080);
            listener.Start();

            Console.WriteLine("MultiIPEchoServer started...");

            /* The Main Thread is Waiting for a new Client connetction */
            while (true)
            {
                /* Blocks the loop until a connection is established */
                TcpClient client = listener.AcceptTcpClient();

                Console.WriteLine("Accepted new client connection...");

                /* Creating a new Thread for the new client */
                Thread client_thread = new Thread(ProcessClientRequests);
                client_thread.Start(client);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        finally
        {
            if (listener != null) listener.Stop();
        }
    }
}