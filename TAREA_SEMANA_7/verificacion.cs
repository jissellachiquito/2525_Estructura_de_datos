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

    //metodo pop que saca el ultimo caracter de la pila
    public char Pop()
    {
        if (tope >= 0)
            return elementos[tope--];
        return '\0';  //retorna caracter nulo si la pila esta vacia
    }

    //verifica si la pila esta vacia
    public bool EstaVacia()
    {
        return tope == -1;
    }

}

//Creamos clase verificador para verificar si los simbolos estan balanceados
class Verificador
{
    //metodo que verifica si los simbolos de la expresion matematica estan balanceados
    public static string Verificar(string expresion)
    {
        
    }
}


