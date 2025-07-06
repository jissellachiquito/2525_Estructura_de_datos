//ejercicios de listas enlazadas 
//EJERCICIO 1

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

    
}
