public class Temporadas{
    public int IdTemporada{ get; set; }
    public int IdSerie{ get; set; }
    public int NumeroTemporada{ get; set; }
    public string TituloTemporada{ get; set; }

     public Temporadas()
    {
        IdTemporada = 0;
        IdSerie = 0;
        NumeroTemporada = 0;
        TituloTemporada = "";
    }

     public Temporadas(int idTemporada , int idSerie, int numeroTemporada, string tituloTemporada)
    {
        IdTemporada = idTemporada;
        IdSerie = idSerie;
        NumeroTemporada = numeroTemporada;
        TituloTemporada = tituloTemporada;
    }
}