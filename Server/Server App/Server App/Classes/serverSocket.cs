using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;
using System.Net.Sockets;

namespace Server_App.Classes
{
    public class ServerSocket
    {
        public class ReadTimeoutException : Exception
        {
            public ReadTimeoutException() : base() { }
        }
        public class WriteException : Exception
        {
            public WriteException() : base() { }
        }

        private TcpClient port;
        private NetworkStream stream;
        private StreamReader reader;
        private StreamWriter writer;
        public ServerSocket(TcpClient client_port)
        {
            this.port = client_port;
            this.stream = this.port.GetStream();

            this.reader = new StreamReader(this.stream);
            this.writer = new StreamWriter(this.stream);
        }
        public dynamic read()
        {   
            /* Setting the timeout to be 1 minute */
            this.stream.ReadTimeout = 60000;
            string recieved_json;
            dynamic recieved_obj = new object();
            try
            {
                recieved_json = this.reader.ReadLine();
                var request = JsonConvert.DeserializeObject<Request>(recieved_json);
                switch (request.type)
                {
                    /* Cast the request to its aprobriate type */
                    case "userLogin":
                        recieved_obj = JsonConvert.DeserializeObject<UserLoginRequest>(recieved_json);
                        break;
                    case "adminLogin":
                        recieved_obj = JsonConvert.DeserializeObject<AdminLoginRequest>(recieved_json);
                        break;
                    case "logout":
                        recieved_obj = request;
                        break;
                    case "createAccount":
                        recieved_obj = JsonConvert.DeserializeObject<CreateAccountRequest>(recieved_json);
                        break;
                    case "deposit":
                        recieved_obj = JsonConvert.DeserializeObject<DepositRequest>(recieved_json);
                        break;
                    //case "profile":
                    //    recieved_obj = JsonConvert.DeserializeObject<ProfileRequest>(recieved_json);
                    //    break;
                    case "addToCart":
                        recieved_obj = JsonConvert.DeserializeObject<addToCartRequest>(recieved_json);
                        break;
                    case "CategoryRequest":
                        recieved_obj = request;
                        break;
                    case "removeFromCart":
                        recieved_obj = JsonConvert.DeserializeObject<removeFromCartRequest>(recieved_json);
                        break;
                    case "SearchRequest":
                        recieved_obj = JsonConvert.DeserializeObject<SearchRequest>(recieved_json);
                        break;
                    //case "dashboard":
                    //    recieved_obj = JsonConvert.DeserializeObject<DashboardRequest>(recieved_json);
                    //    break;
                    //case "productsReport":
                    //    recieved_obj = JsonConvert.DeserializeObject<ProductsReportRequest>(recieved_json);
                    //    break;
                    //case "ordersReport":
                    //    recieved_obj = JsonConvert.DeserializeObject<OrdersReportRequest>(recieved_json);
                    //    break;
                    case "updateCart":
                        recieved_obj = JsonConvert.DeserializeObject<updateCartRequest>(recieved_json);
                        break;
                    case "checkOut":
                        recieved_obj = JsonConvert.DeserializeObject<checkOutRequest>(recieved_json);
                        break;

                }
            }
            catch (Exception ex)
            {
                throw new ReadTimeoutException();
            }
            return recieved_obj;
        }
        public void write(dynamic obj)
        {
            try
            {
                this.writer.WriteLine(JsonConvert.SerializeObject(obj));
                this.writer.Flush();
            }
            catch (Exception ex)
            {
                throw new WriteException();
            }
        }

        public void close()
        {
            this.reader.Close();
            this.writer.Close();
            this.port.Close();
        }
    }
}