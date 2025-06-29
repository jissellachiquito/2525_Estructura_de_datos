//EJERCICIO 1:
//CREAR UNA LISTA DE ASIGNATURAS 

//crear clase curso
class Curso
{
    private List<string> asignaturas;

    //constructor para inicializar la lista de asignaturas 

    public Curso()
    {
        asignaturas = new List<string>() { "Ciencias Naturales", "Estudio Sociales", "Matematicas", "Educacion Fisica", "Lenguaje" };
    }

    //metodo que muestra las asignaturas 
    public void Mostrar_Asignaturas()
    {
        foreach (string asignatura in asignaturas)
        {
            System.Console.WriteLine(asignatura);//imprime cada asignatura 

        }
    }
    //EJERCICIO 2: mostrar yo estudio en cada asignatura
    public void Mostrar_Frase_Estudio()
    {
        System.Console.WriteLine("\n===== YO ESTUDIO... =====");
        foreach (string asignatura in asignaturas)
        {
            System.Console.WriteLine("Yo estudio " + asignatura);
        }
    }
    //EJERCICIO 3: pedir notas y mostrar resultados

}


         





