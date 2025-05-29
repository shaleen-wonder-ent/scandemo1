using Azure.Storage.Blobs;
using System;
using System.Text.RegularExpressions;

namespace AzureConsoleApp.AzureStorage
{
    public class AzureStorageService
    {
        private string _connectionString;

        public AzureStorageService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Connect()
        {
            try
            {
                // Placeholder for Azure Storage connection logic
                BlobServiceClient blobServiceClient = new BlobServiceClient(_connectionString);
                // Additional logic for interacting with Azure Storage can be added here
                Console.WriteLine("Connected to Azure Storage successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while connecting to Azure Storage: {MaskSensitiveInfo(ex.Message)}");
            }
        }

        private static string MaskSensitiveInfo(string message)
        {
            if (string.IsNullOrEmpty(message))
                return message;

            // Mask account key patterns in Azure Storage connection strings
            var maskedMessage = Regex.Replace(message, @"(AccountKey)\s*=\s*[^;]+", "$1=***", RegexOptions.IgnoreCase);
            
            // Mask SAS tokens
            maskedMessage = Regex.Replace(maskedMessage, @"(SharedAccessSignature|sas)\s*=\s*[^;]+", "$1=***", RegexOptions.IgnoreCase);
            
            // Mask any other sensitive key patterns
            maskedMessage = Regex.Replace(maskedMessage, @"([Kk]ey)\s*=\s*[^;]+", "$1=***", RegexOptions.IgnoreCase);
            
            return maskedMessage;
        }
    }
}