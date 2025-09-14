
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

    //metodo recursivo que busca el titulo en el catalogo
    private bool BuscarRecursivo(string titulo, int indice)
    {
        //caso cuando si llegamos al final del arreglo y no se encontro
        if (indice >= revistas.Length)
        {
            return false; //no se encontro el titulo en el catalogo
        }

        //comparamos el titulo en la posicion actual con el titulo ingresado.

        if (revistas[indice].ToLower() == titulo.ToLower())
        {
            return true; // el titulo fue ncontrado
        }

        return BuscarRecursivo(titulo, indice + 1); //llamada recursiva al siguiente elemento
    }

    
}
