//ejercicios de listas enlazadas 
//EJERCICIO 1:INVERTIR UNA LISTA ENLAZADA

//nodo de la lista
public class Nodo
{
    public int dato;
    public Nodo siguiente;

    public Nodo(int dato)
    {
        this.dato = dato;
        this.siguiente = null;
    }
}

//lista enlazada 
public class ListaEnlazada
{
    private Nodo cabeza; //primer nodo de la lista

    public ListaEnlazada()
    {
        cabeza = null;
    }

    //metodo para agregarlos datos al final 
    public void AgregarAlFinal(int dato)
    {
        Nodo nuevo = new Nodo(dato);
        if (cabeza == null)
        {
            cabeza = nuevo;
        }
        else
        {
            Nodo actual = cabeza;
            while (actual.siguiente != null)
            {
                actual = actual.siguiente;
            }
            actual.siguiente = nuevo;
        }
    }

    //metodo para imprimir la lista
    public void Mostrar()
    {
        Nodo actual = cabeza;
        while (actual != null)
        {
            Console.Write(actual.dato + " -> ");
            actual = actual.siguiente;
        }
        Console.WriteLine("null");
    }

    //metodo para invertir la lista
    public void Invertir()
    {
        Nodo anterior = null;
        Nodo actual = cabeza;
        Nodo siguiente = null;

        while (actual != null)
        {
            siguiente = actual.siguiente;  //guardar el siguiente nodo
            actual.siguiente = anterior;   //invertir el puntero
            anterior = actual;             //avanzar el anterior
            actual = siguiente;            //avanzar el actual
        }

        cabeza = anterior;  //cambiar la cabeza al ultimo nodo
    }


   
    // EJERCICIO 2:GENERAR 50 NUMEROS ALEATORIOS ENTRE 1 Y 999
    public void GenerarAleatorios()
    {
        Random rand = new Random();
        for (int i = 0; i < 50; i++)
        {
            int numero = rand.Next(1, 1000); //genera numero entre 1 y 999
            AgregarAlFinal(numero);
        }
    }
    
    //elimina los nodos que esten fuera del rango (minimo, maximo)
    public void EliminarFueraDeRango(int minimo, int maximo)
    {
        




    
}
