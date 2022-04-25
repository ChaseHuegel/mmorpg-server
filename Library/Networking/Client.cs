using System;
using System.Net;

namespace Swordfish.Library.Networking
{
    public class Client : NetController
    {
        public Client(Host host) : base(host)
        {
            this.AddSession(host.EndPoint);

            Console.WriteLine($"Client started on {this.Session.EndPoint}");

            this.PacketSent += OnPacketSent;
            this.PacketReceived += OnPacketReceived;
            this.PacketAccepted += OnPacketAccepted;
            this.PacketRejected += OnPacketRejected;
        }

        public void OnPacketSent(object sender, NetEventArgs e)
        {
            Console.WriteLine($"client->sent {e.PacketID} to {e.EndPoint}");
        }

        public void OnPacketReceived(object sender, NetEventArgs e)
        {
            Console.WriteLine($"client->recieve {e.PacketID} from {sender}");
        }

        public void OnPacketAccepted(object sender, NetEventArgs e)
        {
            Console.WriteLine($"client->accept {e.PacketID} from {sender}");
        }

        public void OnPacketRejected(object sender, NetEventArgs e)
        {
            Console.WriteLine($"client->reject {e.PacketID} from {sender}");
        }
    }
}
