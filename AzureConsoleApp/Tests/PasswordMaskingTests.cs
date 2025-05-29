using System;
using AzureConsoleApp.AzureSQL;
using AzureConsoleApp.AzureStorage;

namespace AzureConsoleApp.Tests
{
    public class PasswordMaskingTests
    {
        public static void RunTests()
        {
            Console.WriteLine("Running password masking tests...");
            
            // Test SQL connection with invalid credentials to trigger error with masked output
            TestSQLPasswordMasking();
            
            // Test Storage connection with invalid credentials to trigger error with masked output
            TestStoragePasswordMasking();
            
            Console.WriteLine("Password masking tests completed.");
        }

        private static void TestSQLPasswordMasking()
        {
            Console.WriteLine("\n--- Testing SQL Password Masking ---");
            
            // Use a connection string with dummy credentials that will fail
            string testConnectionString = "Server=dummy.database.windows.net;Database=testdb;User Id=testuser;Password=secretpassword123;";
            
            var sqlService = new AzureSQLService(testConnectionString);
            
            Console.WriteLine("Testing SQL connection with dummy credentials (should fail and mask password):");
            sqlService.Connect();
        }

        private static void TestStoragePasswordMasking()
        {
            Console.WriteLine("\n--- Testing Storage Password Masking ---");
            
            // Use a connection string with dummy credentials that will fail
            string testConnectionString = "DefaultEndpointsProtocol=https;AccountName=testaccount;AccountKey=dummykey123456789==;EndpointSuffix=core.windows.net";
            
            var storageService = new AzureStorageService(testConnectionString);
            
            Console.WriteLine("Testing Storage connection with dummy credentials (should fail and mask account key):");
            storageService.Connect();
        }
    }
}