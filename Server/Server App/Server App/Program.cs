using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;
using System.Threading;
using System.Text;
public class Server
{
    private static void ProcessClientRequests(object argument)
    {
        /* The Parameter must be of type object to pass the function to the thread */
        TcpClient client = (TcpClient)argument;

        /* Associating the thread to the client stream */
        NetworkStream client_stream = client.GetStream();

        try
        {
            StreamReader reader = new StreamReader(client_stream);
            StreamWriter writer = new StreamWriter(client_stream);

            string recieved_msg = String.Empty;
            while (true)
            {
                /* reading data sent by the client */
                recieved_msg = reader.ReadLine();

                /* Sending back Acknowledge */
                writer.WriteLine("ACK");
                writer.Flush();

                /* for Debugging */
                Console.WriteLine("From client -> " + recieved_msg);

                /* TODO: deserialize the reciveied msg */

                /* TODO: run the operation */

            }

            /* Closing the Connection */
            reader.Close();
            writer.Close();
            client.Close();

            Console.WriteLine("Client connection closed!");
        }
        catch (IOException)
        {
            Console.WriteLine("Client Crashed!!");
        }
        finally
        {
            if (client != null) client.Close();
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