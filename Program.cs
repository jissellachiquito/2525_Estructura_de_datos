
class Programa_principal
{
    static void Main(string[] args)
    {
        agenda_telefonica[] contactos = new agenda_telefonica[100];//declaracion de array para guardar 100 contactos

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
                    break;
                case 2:
                    //mostrar contactos
                    break;
                case 3:
                    //buscar un contacto por nombre
                    break;
                case 4:
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
