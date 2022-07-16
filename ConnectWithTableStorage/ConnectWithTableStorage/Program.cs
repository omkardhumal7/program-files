using Azure;
using Azure.Data.Tables;
using System;

namespace ConnectWithTableStorage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var client = new TableClient(new Uri("https://cyberking.table.core.windows.net"), "MyTable", new TableSharedKeyCredential("cyberking", "ot4kqyZ9COIClLZagdma608JQAPvegJxNV+VXDBkpkZWH/FcTJ6QJYZhvmSQOV98l9POi0O1HBfe+AStnHWrcw=="));
            Pageable<TableEntity> queryableTable = client.Query<TableEntity>();
            foreach (TableEntity item in queryableTable)
            {
                Console.WriteLine(item.GetString("Name"));
            }
        }
    }
}