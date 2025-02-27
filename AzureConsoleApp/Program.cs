using System;

namespace AzureConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Placeholder for Azure Storage connection string
            string azureStorageConnectionString = "Your_Azure_Storage_Connection_String_Here";

            // Placeholder for Azure SQL Database connection string
            string azureSqlConnectionString = "Your_Azure_SQL_Connection_String_Here";

            // Initialize services
            var storageService = new AzureStorage.AzureStorageService();
            var sqlService = new AzureSQL.AzureSQLService();

            // Connect to Azure Storage
            storageService.Connect(azureStorageConnectionString);

            // Connect to Azure SQL Database
            sqlService.Connect(azureSqlConnectionString);

            Console.WriteLine("Connected to Azure Storage and Azure SQL Database.");
        }
    }
}