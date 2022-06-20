using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Sockets;


namespace Client_App.Classes
{
    internal class ClientSocket
    {
        public class PortIsNotOpen : Exception
        {
            public PortIsNotOpen() : base() { }
        }
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

        public ClientSocket(string hostname = "127.0.0.1", int port_number = 8080)
        {
            try
            {
                this.port = new TcpClient(hostname, port_number);
            }
            catch (SocketException ex)
            {
                throw new PortIsNotOpen();
            }
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
                    /* TODO: According to the type it converts the recieved msg into the specific type */
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
