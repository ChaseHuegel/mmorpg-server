using System;

namespace Demo
{
    public class Commands
    {
        public void Read()
        {
            string input = Console.ReadLine();
            string[] arguments = input.Split(' ');

            switch (arguments[0].ToLower())
            {
                case "stop":
                    Application.Exit();
                    break;
                case "list":
                case "players":
                case "sessions":
                case "connected":
                    Console.WriteLine("Server: " + string.Join(", ", Demo.Instance.Server.GetSessions()));
                    Console.WriteLine("Client: " + string.Join(", ", Demo.Instance.Client.GetSessions()));
                    break;
            }
        }
    }
}