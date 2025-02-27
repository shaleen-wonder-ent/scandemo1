using System;
using System.Data.SqlClient;

namespace AzureConsoleApp.AzureSQL
{
    public class AzureSQLService
    {
        private string _connectionString;

        public AzureSQLService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Connect()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Connected to Azure SQL Database successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred while connecting to Azure SQL Database: {ex.Message}");
                }
            }
        }
    }
}