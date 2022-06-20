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
        public dynamic read(int timeout = System.Threading.Timeout.Infinite)
        {
            this.stream.ReadTimeout = timeout;
            string recieved_json;
            dynamic recieved_obj = new object();
            try
            {
                recieved_json = this.reader.ReadLine();
                var request = JsonConvert.DeserializeObject<Request>(recieved_json);
                switch (request.type)
                {
                    /* TODO: Cast the request to its aprobriate type */
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