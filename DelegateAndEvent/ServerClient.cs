using System;

namespace CSharp.DelegateAndEvent
{
    public class ServerClient{
        public class ServerEventArgs: EventArgs 
        {
            public ServerEventArgs(string message) : base()
            {
                this.Message = message;
            }

            public string Message { get; set; }
        }

        public class Server 
        {
            public delegate void ServerEvent(object sender, ServerEventArgs e);
            public event ServerEvent ServerChange;

            public Server() {}

            public void Connect(Client client)
            {
                this.ServerChange += client.ServerMessageHandler;
                OnServerChange(string.Format("User <{0}> connected", client.Name));
            }

            public void Disconnect(Client client)
            {
                OnServerChange(string.Format("User <{0}> disconnected", client.Name));
                this.ServerChange -= client.ServerMessageHandler;
            }

            protected void OnServerChange(string message)
            {
                if(ServerChange != null)
                {
                    ServerChange(this, new ServerEventArgs(message));
                }
            }
        }

        public class Client
        {
            public Client(string name)
            {
                Name = name;
            }
            public string Name { get; set; }

            public void ServerMessageHandler(object sender, ServerEventArgs e)
            {
                System.Console.WriteLine("{0} get a message: {1}", this.Name, e.Message);
            }
        }

        static void Main(string[] args)
        {
            Server server = new Server();

            Client c1 = new Client("Joseph");   
            Client c2 = new Client("Peter");   
            Client c3 = new Client("Tomas");

            server.Connect(c1);   
            server.Connect(c2);   
            server.Disconnect(c1);   
            server.Connect(c3);
        }
    }
}