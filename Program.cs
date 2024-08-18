using System;
using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;
namespace ModelPratice
{
    class ModelPratice
    {
        public static void Main(String[] args)
        {
            string connectionString = "Server=localhost;Database=DotNetCourseDatabase;TrustServerCertificate=true;Trusted_Connection=false;User Id=sa;Password=SQLConnect1";
            IDbConnection dbConnection = new SqlConnection(connectionString);

            string sqlCommand = "SELECT GETDATE()";
            DateTime rigthNow = dbConnection.QuerySingle<DateTime>(sqlCommand);
            Console.WriteLine(rigthNow);

            Computer newComputer = new Computer("Intel", 8, true, false, DateTime.Parse("2002-10-23"), 23.333m, "Nvidia");

            string sqlInsertionCommand = @"INSERT INTO TutorialAppSchema.Computer(
            MotherBoard,
            CPUCores,
            HasWifi,
            HasLTE,
            ReleaseDate,
            Price,
            VideoCard
            ) VALUES('" + newComputer.MotherBoard
            + "','" + newComputer.CPUCores
            + "','" + newComputer.HasWifi
            + "','" + newComputer.HasLTE
            + "','" + newComputer.ReleaseDate
            + "','" + newComputer.Price
            + "','" + newComputer.VideoCard
            + "')";
            Console.WriteLine(sqlInsertionCommand);
            int result = dbConnection.Execute(sqlInsertionCommand); // return whole number if it works out 
            Console.WriteLine(result);

            Console.WriteLine(newComputer.ReleaseDate.ToString("dd/MM/yyyy"));
        }
    }
}

