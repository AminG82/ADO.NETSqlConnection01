// See https://aka.ms/new-console-template for more information
using Microsoft.Data.SqlClient;

Console.WriteLine("Hello, World!");


SqlConnection connectionTest = new SqlConnection("""
    
    Server=localhost;Database=TestDB;
    User Id=sa;Password=amin5123;
    TrustServerCertificate=True;
    
    """);

SqlCommand removeUserCommand = new SqlCommand("""
    
    DELETE FROM Person WHERE Name = 'Rebecca' AND LastName = 'DeWinter'
    
    """, connectionTest);

SqlCommand insertCommand = new SqlCommand("""
    
    INSERT INTO Person (Name,LastName, Age)
    VALUES ('Rebecca','DeWinter', 23)
    
    """, connectionTest);

connectionTest.Open();
Console.WriteLine(removeUserCommand.ExecuteNonQuery());

connectionTest.Close();

Console.ReadKey();