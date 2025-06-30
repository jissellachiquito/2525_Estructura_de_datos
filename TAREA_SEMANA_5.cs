//EJERCICIO 1:
//CREAR UNA LISTA DE ASIGNATURAS 

//crear clase curso
class Curso
{
    //declaracion de listas 
    private System.Collections.Generic.List<string> asignaturas;
    private System.Collections.Generic.List<double> notas;

    //constructor para inicializar la lista de asignaturas y la lista de notas 
    public Curso()
    {
        asignaturas = new System.Collections.Generic.List<string>() { "Ciencias Naturales", "Estudio Sociales", "Matematicas", "Educacion Fisica", "Lenguaje" };

        // inicualizar la lista de notas
        notas = new System.Collections.Generic.List<double>();

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
            System.Console.WriteLine("En " + asignaturas[i] + " has sacado " + notas[i]);
        }
    }
    
    //EJERCICIO 5: verificar las asignaturas reprobadas usando las notas ya ingresadas
    public void Mostrar_Asignaturas_Reprobadas()
    {
        System.Console.WriteLine("====== ASIGNATURAS REPROBADAS ======");

        //verifica si ya se ingresaron notas
        if (notas.Count != asignaturas.Count)
        {
            System.Console.WriteLine("Primero debes ingresar las notas");
            return;
        }

        bool hayReprobadas = false; //saber si hay alguna asignatura reprobada
        

    }          

}

//EJERCICIO 4:
//GANADORES DE LA LOTERIA 

//crear clase loteria
public class Loteria
{
     public void Ejecutar()
    {
        //usamos una lista  para almacenar los números ganadores
        System.Collections.Generic.List<int> awarded = new System.Collections.Generic.List<int>();

        //pedimos al usuario que ingrese 6 numeros validos
        while (awarded.Count < 6)
        {
            System.Console.Write("Introduce un numero ganador: ");
            string input = System.Console.ReadLine();

            //convertir la entrada a entero
            if (int.TryParse(input, out int number))
            {
                awarded.Add(number);
            }
            else
            {
                System.Console.WriteLine("Entrada invalida. Por favor introduce un numero valido.");
            }
        }

        //ordenar la lista de menor a mayor
        awarded.Sort();

        //muestra los numeros ordenados
        System.Console.WriteLine("Los números ganadores son:");
        System.Console.Write("[");

        for (int i = 0; i < awarded.Count; i++)
        {
            System.Console.Write(awarded[i]);
            if (i < awarded.Count - 1)
            {
                System.Console.Write(", ");
            }
        }

        System.Console.WriteLine("]");
    }

}











    









   





         





