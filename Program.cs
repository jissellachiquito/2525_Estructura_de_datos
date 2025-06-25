
class Programa_principal
{
    static void Main(string[] args)
    {
        agenda_telefonica[] contactos = new agenda_telefonica[100];//declaracion de array para guardar 100 contactos
        int cantidad = 0; //cuenta cuantos contactos hay guardados

        //Menu principal
        int opcion;

        do
        {
            //se imprime el menú de opciones
            System.Console.WriteLine("====== AGENDA TELEFONICA ======");
            System.Console.WriteLine("1. Agregar contacto");
            System.Console.WriteLine("2. Mostrar contactos");
            System.Console.WriteLine("3. Buscar contacto");
            System.Console.WriteLine("4. Salir");
            System.Console.Write("Elige una opcion: ");
            
            opcion = System.Int32.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    //agregar contacto
                    System.Console.Write("Ingrese el nombre: ");
                    string nombre = System.Console.ReadLine()!;

                    System.Console.Write("Ingrese el teléfono: ");
                    string telefono = System.Console.ReadLine()!;

                    System.Console.Write("Ingrese la edad: ");
                    int edad = System.Int32.Parse(System.Console.ReadLine()!);

                    System.Console.Write("Ingrese el correo: ");
                    string correo = System.Console.ReadLine()!;

                    System.Console.Write("Ingrese la dirección: ");
                    string direccion = System.Console.ReadLine()!;

                    // Crear y guardar el nuevo contacto
                    contactos[cantidad] = new agenda_telefonica(nombre, telefono, edad, correo, direccion);
                    cantidad++; // Aumentar el contador

                    System.Console.WriteLine("Contacto agregado exitosamente...");
                    break;
                case 2:
                    //mostrar contactos
                    if (cantidad == 0)
                    {
                        System.Console.WriteLine("No hay contactos registrados.");
                    }
                    else
                    {
                        System.Console.WriteLine("=== LISTA DE CONTACTOS ===");

                        for (int i = 0; i < cantidad; i++)
                        {
                            contactos[i].MostrarContacto(); // llama al método de la clase para mostrar datos
                        }

                    }
                    break;
                case 3:
                    //buscar un contacto por nombre
                    System.Console.Write("Ingrese el nombre a buscar: ");
                    string nombreBuscado = System.Console.ReadLine()!;
                    
                    bool encontrado = false; // operacion booleana para saber si se encontro el contacto

                    for (int i = 0; i < cantidad; i++)
                    {
                        if (contactos[i].Nombres.ToLower() == nombreBuscado.ToLower())
                        {
                            System.Console.WriteLine("Contacto encontrado:");
                            contactos[i].MostrarContacto();
                            encontrado = true;
                            break; //sale del bucle si lo encuentra
                        }
                    }

                    if (!encontrado)

                    {
                        System.Console.WriteLine(" Contacto no encontrado.");
                    }
                    
                    break;
                case 4:
                //muestra un mensaje de salida
                            System.Console.WriteLine("Saliendo del programa...");
                            break;
                        default:
                            System.Console.WriteLine("Opción no valida.");
                            break;
                        }

                        System.Console.WriteLine(); // Espacio entre repeticiones
                    }
        while (opcion != 4);
    }
}
