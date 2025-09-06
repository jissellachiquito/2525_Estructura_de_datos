//clase que gestiona un sistema de premiacion de los deportistas 
class PremioDeportistas
{
    //diccionario que almacena las disciplinas como claves, y para cada una, un conjunto de nombres deportistas premiados.
    Dictionary<string, HashSet<string>> disciplinas;

    //metodo constructor que inicializa el diccionario vacio
    public PremioDeportistas()
    {
        disciplinas = new Dictionary<string, HashSet<string>>();
    }

    //metodo para agregar una nueva disciplina en el sistema
    public void AgregarDisciplina(string disciplina)
    {
        //si la disciplina no existe,se la agrega al diccionario
        if (!disciplinas.ContainsKey(disciplina))
        {
            disciplinas[disciplina] = new HashSet<string>(); //crea un conjunto vacio de deportistas
            Console.WriteLine($"Disciplina {disciplina} registrada con exito......");
        }
        else
        {
            Console.WriteLine($"La disciplina {disciplina} ya existe."); //cuando la disciplina ya existe
        }
    }

    //metodo para agregar un deportista a una disciplina
    public void AgregarDeportista(string disciplina, string deportista)
    {

        if (disciplinas.ContainsKey(disciplina)) //se verifica que la disciplina exista
        {
            disciplinas[disciplina].Add(deportista); //agrega el deportista al conjunto 
            Console.WriteLine($"Deportista '{deportista}' agregado a {disciplina}.");
        }
        else
        {
            Console.WriteLine($"La disciplina '{disciplina}' no existe.");//en caso de que la disciplina no exista,muestra al ususario
        }
    }

    //metodo que muestra todos los premiados en todas las disciplinas
    public void MostrarPremiados()
    {
        foreach (var par in disciplinas) //recorre todas las disciplinas registradas
        {
            Console.WriteLine($"\nDisciplina: {par.Key}"); //imprime el nombre de la disciplina

            if (par.Value.Count == 0) //cuando no hay deportistas registrados en esa disciplina
            {
                Console.WriteLine("  (Sin deportistas registrados)");//muestra que no hay ningun registro
            }
            else
            {
                foreach (var deportista in par.Value) //muestra cada deportista dentro de la disciplina
                {
                    Console.WriteLine($"  - {deportista}");
                }
            }
        }
    }

    //metodo para consultar los deportistas de una disciplina en especifico
    public void ConsultarPorDisciplina(string disciplina)
    {
        if (disciplinas.ContainsKey(disciplina)) //verifica si la disciplina existe
        {
            Console.WriteLine($"\nPremiados en {disciplina}:");

            foreach (var d in disciplinas[disciplina]) //recorre y muestra todos los deportistas de esa disciplina
            {
                Console.WriteLine($"  - {d}");
            }

            if (disciplinas[disciplina].Count == 0)//en caso de que no tenga deportistas registrados
            {
                Console.WriteLine("  (Sin deportistas registrados)");
            }
        }
        else
        {
            Console.WriteLine($"La disciplina '{disciplina}' no existe.");//si no existe la disciplina consultada
        }
    }
}

