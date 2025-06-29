//EJERCICIO 1:
//CREAR UNA LISTA DE ASIGNATURAS 

//crear clase
class Curso
{    private List<string> asignaturas;

    //constructor para inicializar la lista de asignaturas 

    public Curso()
    {
        asignaturas = new List<string>() { "Ciencias Naturales", "Estudio Sociales", "Matematicas", "Educacion Fisica", "Lenguaje" };
    }

//metodo que muestra las asignaturas 
    public void MostrarAsignaturas()
    {
        foreach (string asignatura in asignaturas)
        {
            System.Console.WriteLine(asignatura);//imprime cada asignatura 
        }
    }

}


