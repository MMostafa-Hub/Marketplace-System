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
        ServerSocket serverSocket = new ServerSocket((TcpClient)argument);
        try
        {

            dynamic recieved_obj, transmit_obj;
            while (true)
            {
                recieved_obj = serverSocket.read();
                switch (recieved_obj.type)
                {
                    /* TODO: Choose the spcific operation based on the object type */
                    /* transmit_obj = operation() */
                }
                //serverSocket.write(transmit_obj);
            }

            /* Closing the Connection */
            serverSocket.close();
        }
        catch (ServerSocket.ReadTimeoutException e)
        {
            /**/
        }
        catch (ServerSocket.WriteException e)
        {
            /**/
        }

    }

    public static void Main()
    {
        TcpListener? listener = null;
        try
        {
            /* Checks if the Machine is Connected to a Network or not */
            if (!System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                Console.WriteLine("No Network Available");
            }
            var ippaddress = Dns.GetHostEntry(Dns.GetHostName()).AddressList.FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork);


            /* Creating a port */
            listener = new TcpListener(ippaddress, 8080);
            listener.Start();

            Console.WriteLine("IP Address: {0}\nPort Number: {1}", ippaddress.ToString(), 8080);
            Console.WriteLine("Multithreaded Server started...");

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