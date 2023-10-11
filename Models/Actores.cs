public class Actores{
    public int IdActor{ get; set; }
    public int IdSerie{ get; set; }
    public string Nombre{ get; set; }


     public Actores()
    {
        IdActor = 0;
        IdSerie = 0;
        Nombre = " ";
    }

     public Actores(int idActor, int idSerie ,string nombre)
    {
        IdActor = idActor;
        Nombre = nombre;
        IdSerie = idSerie;
    }
}