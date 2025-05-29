using System;
using Microsoft.Data.SqlClient;
using System.Text.RegularExpressions;

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
                    Console.WriteLine($"An error occurred while connecting to Azure SQL Database: {MaskSensitiveInfo(ex.Message)}");
                }
            }
        }

        private static string MaskSensitiveInfo(string message)
        {
            if (string.IsNullOrEmpty(message))
                return message;

            // Mask password patterns in connection strings
            var maskedMessage = Regex.Replace(message, @"(password|pwd)\s*=\s*[^;]+", "$1=***", RegexOptions.IgnoreCase);
            
            // Mask user ID patterns
            maskedMessage = Regex.Replace(maskedMessage, @"(user\s*id|uid)\s*=\s*[^;]+", "$1=***", RegexOptions.IgnoreCase);
            
            // Mask authentication credentials
            maskedMessage = Regex.Replace(maskedMessage, @"(authentication)\s*=\s*[^;]+", "$1=***", RegexOptions.IgnoreCase);
            
            return maskedMessage;
        }
    }
}