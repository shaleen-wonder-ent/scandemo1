# Azure Console Application

This is a C# console application that demonstrates how to connect to Azure Storage and Azure SQL Database.

## Project Structure

```
AzureConsoleApp
├── Program.cs
├── AzureStorage
│   └── AzureStorageService.cs
├── AzureSQL
│   └── AzureSQLService.cs
├── appsettings.json
├── AzureConsoleApp.csproj
└── README.md
```

## Prerequisites

- .NET SDK installed on your machine.
- An Azure account with access to Azure Storage and Azure SQL Database.

## Setup Instructions

1. Clone the repository or download the project files.
2. Open the project in your preferred IDE or editor.
3. Update the `appsettings.json` file with your Azure Storage and Azure SQL Database connection strings.

   Example:
   ```json
   {
       "AzureStorage": {
           "ConnectionString": "Your_Azure_Storage_Connection_String"
       },
       "AzureSQL": {
           "ConnectionString": "Your_Azure_SQL_Connection_String"
       }
   }
   ```

4. Build the project using the command:
   ```
   dotnet build
   ```

5. Run the application using the command:
   ```
   dotnet run
   ```

## Usage

The application will initialize and attempt to connect to Azure Storage and Azure SQL Database using the provided connection strings. Ensure that your connection strings are correct to avoid connection errors.

## Contributing

Feel free to submit issues or pull requests for improvements or bug fixes.