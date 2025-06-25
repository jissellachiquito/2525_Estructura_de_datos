//creacion de la clase y sus atributos
public class agenda_telefonica
{
    public string Nombres { get; set; }
    public string Telefono { get; set; }
    public int Edad { get; set; }
    public string Correo { get; set; }
    public string Direccion { get; set; }

    //metodo constructor
    public agenda_telefonica(string nombres, string telefono, int edad, string correo, string direccion)
    {
        Nombres = nombres;
        Telefono = telefono;
        Edad = edad;
        Correo = correo;
        Direccion = direccion;
    }
    //metodo para mostrar los datos del contacto
    public void MostrarContacto()
    {
        System.Console.WriteLine("Nombre: " + Nombres);
        System.Console.WriteLine("Telefono: " + Telefono);
        System.Console.WriteLine("Edad: " + Edad);
        System.Console.WriteLine("Correo: " + Correo);
        System.Console.WriteLine("Direccion: " + Direccion);
        System.Console.WriteLine("--------------------------");
    }


}