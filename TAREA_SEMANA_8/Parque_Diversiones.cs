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

    
}
