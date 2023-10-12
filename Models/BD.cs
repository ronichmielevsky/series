using System.Data.SqlClient;
using Dapper;
using series.Models; // Asegúrate de agregar el namespace correcto

static class BD
{
    private static string _connectionString = @"server=localhost;Database=BDSeries;Trusted_connection=True;";

    public static List<Series> ObtenerSeries()
    {
         List<Series> listaSeries = new List<Series>();    
         using (SqlConnection db = new SqlConnection(_connectionString))
        {
            string sql = "SELECT * FROM Series;";
             listaSeries= db.Query<Series>(sql).ToList();
        }
         return listaSeries;
    }
}
