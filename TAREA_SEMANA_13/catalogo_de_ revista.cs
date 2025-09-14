
//clase que gestiona el catalogo de revistas
class Catalogo
{
    //declaracion de un arreglo para las revistas 
    private string[] revistas;

    //metodo constructor que inicializa el catalogo 
    public Catalogo()
    {
        revistas = new string[]
        {
           "Innovacion Global",
            "Ecomundo Verde",
            "Codigos & Algoritmos",
            "Viajeros del Tiempo",
            "NeuroTech Hoy",
            "Arquitectura Futurista",
            "Sabores del Planeta",
            "Cine & Realidades",
            "Exploradores Cosmicos",
            "Misterios Ancestrales",
            "Arte Digital ",
            "Energia y Sostenibilidad"            
        };
    }

    //metodo para iniciar la busqueda recursiva
    public bool BuscarRevista(string titulo)
    {
        return BuscarRecursivo(titulo, 0);
    }

   
}
