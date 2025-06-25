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

}