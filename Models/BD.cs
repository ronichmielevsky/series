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
     public static List<Actores> ObtenerActores(int IdSerie)
        {
            using (SqlConnection db = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM Actores where IdSerie = @pidSerie";
                return db.Query<Actores>(sql, new {pidserie = IdSerie }).ToList();
            }
        }

        public static Series GetSeries(int IdSerie)
        {
            Series Actualserie = null;
            using (SqlConnection db = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM Series WHERE IdSerie = @pidSerie";
                Actualserie = db.QueryFirstOrDefault<Series>(sql,new {pidSerie = IdSerie});
            }
            return Actualserie;
        }
        public static List<Temporadas> ObtenerTemporadas(int IdSerie)
        {
           using (SqlConnection db = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM Temporadas where IdSerie = @pidSerie";
                return db.Query<Temporadas>(sql, new {pidSerie = IdSerie }).ToList();
            }
        }
}


