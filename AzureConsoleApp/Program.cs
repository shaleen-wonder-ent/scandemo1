using System;
using AzureConsoleApp.Tests;

namespace AzureConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Check if we should run tests
            if (args.Length > 0 && args[0] == "--test")
            {
                PasswordMaskingTests.RunTests();
                return;
            }

            // Placeholder for Azure Storage connection string
            string azureStorageConnectionString = "Your_Azure_Storage_Connection_String_Here";

            // Placeholder for Azure SQL Database connection string
            string azureSqlConnectionString = "Your_Azure_SQL_Connection_String_Here";

            // Initialize services
            var storageService = new AzureStorage.AzureStorageService(azureStorageConnectionString);
            var sqlService = new AzureSQL.AzureSQLService(azureSqlConnectionString);

            // Connect to Azure Storage
            storageService.Connect();

            // Connect to Azure SQL Database
            sqlService.Connect();

            Console.WriteLine("Connected to Azure Storage and Azure SQL Database.");
        }
    }
}