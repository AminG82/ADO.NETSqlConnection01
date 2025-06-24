// See https://aka.ms/new-console-template for more information
using Microsoft.Data.SqlClient;

Console.WriteLine("Hello, World!");


SqlConnection connectionTest = new SqlConnection("""
    
    Server=localhost;Database=TestDB;
    User Id=sa;Password=amin5123;
    
    """);
    

SqlCommand insertCommand = new SqlCommand("""
    
    INSERT INTO Person (Name,LastName, Age)
    VALUES ('Rebecca','DeWinter', 23)
    
    """, connectionTest);

connectionTest.Open();
Console.WriteLine(insertCommand.ExecuteNonQuery());

connectionTest.Close();

Console.ReadKey();