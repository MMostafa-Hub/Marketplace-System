using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;
using System.Threading;
using System.Text;
using Server_App.Classes;
using Server_App.Functions;
public class Server
{
    private static void ProcessClientRequests(object argument)
    {
        ServerSocket serverSocket = new ServerSocket((TcpClient)argument);
        try
        {

            dynamic recieved_obj;
            bool logout_flag = false;
            while (!logout_flag)
            {
                recieved_obj = serverSocket.read();
                switch (recieved_obj.type)
                {
                    /* Choose the spcific operation based on the object type */
                    case "userLogin":
                        serverSocket.write(Login.loginUser(recieved_obj));
                        break;
                    case "adminLogin":
                        serverSocket.write(Login.loginAdmin(recieved_obj));
                        break;
                    case "logout":
                        Logout.LogoutHandler();
                        logout_flag = true;
                        break;
                    case "createAccount":
                        serverSocket.write(CreateAccount.createAccountHandler(recieved_obj));
                        break;
                    case "deposit":
                        Deposit.depositBalance(recieved_obj);
                        break;
                    case "profile":
                        serverSocket.write(Profile.profile(recieved_obj));
                        break;
                    case "addToCart":
                        Add_Cart.addToCart(recieved_obj);
                        break;
                    case "CategoryRequest":
                        serverSocket.write(Search.categorySearch());
                        break;
                    case "removeFromCart":
                        Cart_remove.removefromCart(recieved_obj);
                        break;
                    case "SearchRequest":
                        serverSocket.write(Search.search(recieved_obj));
                        break;
                    case "dashboard":
                        serverSocket.write(AdminReports.dashboard());
                        break;
                    case "productsReport":
                        serverSocket.write(AdminReports.productReport());
                        break;
                    case "ordersReport":
                        serverSocket.write(AdminReports.orderReport());
                        break;
                    case "updateCart":
                        Cart_update.updateCart(recieved_obj);
                        break;
                    case "checkOut":
                        serverSocket.write(Checkout.checkOut(recieved_obj));
                        break;
                }
            }

        }
        catch (ServerSocket.ReadTimeoutException e)
        {
            /**/
        }
        catch (ServerSocket.WriteException e)
        {
            /**/
        }
        finally
        {
            Console.WriteLine("Connection Ended");

            /* Closing the Connection */
            serverSocket.close();
            Logout.LogoutHandler();
            

            // Killing the thread with cold blood
            Thread.CurrentThread.Interrupt();
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

            int portNumber = 49152;
            /* Creating a port */
            listener = new TcpListener(ippaddress, portNumber);
            listener.Start();

            Console.WriteLine("IP Address: {0}\nPort Number: {1}", ippaddress.ToString(), portNumber);
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