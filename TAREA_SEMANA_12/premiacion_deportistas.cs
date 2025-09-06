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
        
    }

    
}

