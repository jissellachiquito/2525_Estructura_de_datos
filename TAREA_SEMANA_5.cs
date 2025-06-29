//EJERCICIO 1:
//CREAR UNA LISTA DE ASIGNATURAS 

//crear clase curso
class Curso
{
    //declaracion de listas 
    private List<string> asignaturas;
    private List<double> notas;

    
    //constructor para inicializar la lista de asignaturas y la lista de notas 
    public Curso()
    {
        asignaturas = new List<string>() { "Ciencias Naturales", "Estudio Sociales", "Matematicas", "Educacion Fisica", "Lenguaje" };

        notas = new List<double>();  // inicualizar la lista de notas

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

    //EJERCICIO 3:pedir y mostrar las notas 
    public void Pedir_Notas_Y_Mostrar_Resultados()
    {
        System.Console.WriteLine("=====INGRESO DE NOTAS=====");

        if (notas == null)//verifica si la lista notas no ha sido inicializada o sino muestra un mensaje
        {
            System.Console.WriteLine("Lista notas es null.");
            return;
        }  
        notas.Clear();//limpia la lista por si se ejecuta varias veces

        //pedir nota por asignatura
        foreach (string asignatura in asignaturas)
        {
            System.Console.Write("¿Que nota has sacado en " + asignatura + "? ");
            string entrada = System.Console.ReadLine();
            double nota = double.Parse(entrada);
            notas.Add(nota);
        }

        //mostrar resultados
        System.Console.WriteLine("======RESULTADOS======");
        for (int i = 0; i < asignaturas.Count; i++)
        {
            System.Console.WriteLine("En " + asignaturas[i] +" has sacado " + notas[i]);
        }
    }

}











    









   





         





