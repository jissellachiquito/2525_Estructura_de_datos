//Creacion de clase pila que representa una torre con discos 
class Pila
{
    private int[] discos; //arreglo para representar los discos
    private int tope;     //indice del tope de la pila
    public string Nombre; //nombre de la torre 

    //constructor que define el nombre y capacidad de la torre
    public Pila(string nombre, int capacidad)
    {
        Nombre = nombre;
        discos = new int[capacidad];
        tope = -1;
    }

    //metodo push que coloca un disco sobre la torre
    public void Push(int disco)
    {
        if (tope < discos.Length - 1)
            discos[++tope] = disco;
    }

    //metodo pop para retirar el disco superior de la torre
    public int Pop()
    {
        if (tope >= 0)
            return discos[tope--];
        return -1;
    }

    //mover un disco de esta torre a otra torre
    public void MoverDisco(Pila destino)
    {
        int disco = Pop();
        destino.Push(disco);
        System.Console.WriteLine("Mover disco " + disco + " de " + Nombre + " a " + destino.Nombre);
    }
}


//Creacion de clase Hanoi para resolver el problema
class Hanoi
{
    //metodo para resolver Hanoi
    public static void Resolver(int n, Pila origen, Pila auxiliar, Pila destino)
    {
        if (n == 1)
        {
            //mover un solo disco directamente
            origen.MoverDisco(destino);
        }
        else
        {
            //paso 1: mover n-1 discos a la torre auxiliar
            Resolver(n - 1, origen, destino, auxiliar);

            //paso 2: mover el disco más grande al destino
            origen.MoverDisco(destino);

            //paso 3: mover los n-1 discos desde auxiliar a destino
            Resolver(n - 1, auxiliar, origen, destino);
        }
    }


    //metodo para inicializar las torres y comenzar el proceso
    public static void Ejecutar()
    {
       
    }


    
}


