// See https://aka.ms/new-console-template for more information
using Microsoft.Data.SqlClient;

Console.WriteLine("Hello, World!");


SqlConnection connectionTest = new SqlConnection("""
    
    Server=localhost;Database=TestDB;
    User Id=sa;Password=amin5123;
    TrustServerCertificate=True;
    
    """);

SqlCommand alterTable_NationalCode = new SqlCommand("""
    
    ALTER TABLE Person
    ADD NationalCode char(10) NULL
    
    """, connectionTest);

SqlCommand removeUserCommand = new SqlCommand("""
    
    DELETE FROM Person WHERE Name = 'Rebecca' AND LastName = 'DeWinter'
    
    """, connectionTest);

SqlCommand insertCommand = new SqlCommand("""
    
    INSERT INTO Person (Name,LastName, Age ,NationalCode)
    VALUES ('Rebecca','DeWinter', 23,'0150553196')
    
    """, connectionTest);

SqlCommand selectCommand = new SqlCommand("""
    
    SELECT * FROM Person
    
    """, connectionTest);

connectionTest.Open();
Console.WriteLine(insertCommand.ExecuteNonQuery());



connectionTest.Close();

Console.ReadKey();