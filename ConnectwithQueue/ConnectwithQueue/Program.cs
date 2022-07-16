using Azure.Storage.Queues;
using System;

namespace ConnectwithQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            InsertMessage("Order with ORD1234 is proccessed");
        }

        public static void InsertMessage(string message)
        {
            string connectionstring = "DefaultEndpointsProtocol=https;AccountName=cyberking;AccountKey=ot4kqyZ9COIClLZagdma608JQAPvegJxNV+VXDBkpkZWH/FcTJ6QJYZhvmSQOV98l9POi0O1HBfe+AStnHWrcw==;EndpointSuffix=core.windows.net";
            QueueClient queueClient = new QueueClient(connectionstring, "myqueue");
            queueClient.CreateIfNotExists();
            if (queueClient.Exists())
            {
                queueClient.SendMessage(message);
            }
            Console.WriteLine("Message is inserted");
        }
    }
}