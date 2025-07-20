//EJERCICIO: asignación de 30 asientos en orden de llegada, una vez que todos los asientos son vendidos
//clase para la asignacion de asientos 
public class Parque_Diversiones
{
    private string[] asientos;//array que almacena los nombres de las personas que ocuparon un asiento
    private int cantidad_Ocupada;//contador para llevar la cantidad de asientos ocupados

    //constructor que inicializa el array
    public Parque_Diversiones(int totalAsientos)
    {
        asientos = new string[totalAsientos];
        cantidad_Ocupada = 0; //no hay asientos ocupados
    }
    
    //metodo que asigna un asiento cuando si hay espacio disponible
    public bool Asignar_Asiento(string nombrePersona)
    {
        if (cantidad_Ocupada >= asientos.Length)
        {
            return false;  //retorna false cuando ya no hay asientos disponibles
        }

        asientos[cantidad_Ocupada] = nombrePersona; //se asigna el nombre 
        cantidad_Ocupada++; //incrementa el contador de asientos ocupados
        return true; //retorna true cuando ya que se asigno un asiento
    }

    //metodo para mostrar todos los asientos ocupados
    public void Mostrar_Asientos()
    {
        
    }

}
