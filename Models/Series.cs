public class Series{
    public int IdSerie{ get; set; }
    public string Nombre{ get; set; }
    public int AñoInicio{ get; set; }
    public string Sinopsis{ get; set; }
    public string ImagenSerie{ get; set; }

     public Series()
    {
        IdActor = 0;
        Nombre = "";
        AñoInicio = 0;
        Sinopsis = "";
        ImagenSerie = "";
    }

     public Series(int idSerie , string nombre, int añoInicio, string sinopsis, string imagenSerie)
    {
        IdSerie = idSerie;
        Nombre = nombre;
        AñoInicio = añoInicio;
        Sinopsis = sinopsis;
        ImagenSerie = imagenSerie;
    }
}