// Clase pila que representa una torre con discos 
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

   
}


