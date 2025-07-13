// Clase que implementa una pila de caracteres
class StackChar
{
    private char[] elementos; //arreglo para almacenar elementos 
    private int tope;         //indice del tope de la pila

    //constructor que inicializa la pila con un tamaño dado
    public StackChar(int tamaño)
    {
        elementos = new char[tamaño];
        tope = -1;
    }

    //metodo push para agregar un caracter a la pila  
    public void Push(char valor)
    {
        if (tope < elementos.Length - 1)
            elementos[++tope] = valor;
    }


}



