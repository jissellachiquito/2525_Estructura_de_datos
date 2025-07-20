class Programa_principal
{
    static void Main()
    {
        //se crea una instancia del sistema con 30 asientos disponibles
        Parque_Diversiones parque = new Parque_Diversiones(30);
        int opcion;

        do
        {
            //menu principal del sistema
            System.Console.WriteLine("\n------ PARQUE DE DIVERSIONES ------");
            System.Console.WriteLine("1. Registrar persona en la fila");
            System.Console.WriteLine("2. Mostrar asientos ocupados");
            System.Console.WriteLine("3. Consultar asientos disponibles");
            System.Console.WriteLine("4. Salir");
            System.Console.Write("Seleccione una opcion: ");
            string entrada = System.Console.ReadLine();

            if (!int.TryParse(entrada, out opcion))
            {
                System.Console.WriteLine("Entrada no valida. Intente nuevamente....");
                continue;
            }

            switch (opcion) //sirve para ejecutar la opcion seleccionada 
            {
                case 1: //opcion para registrar una nueva persona
                    if (parque.Esta_Lleno())
                    {
                        System.Console.WriteLine("Todos los asientos estan ocupados....");
                    }
                    else
                    {
                        System.Console.Write("Ingrese el nombre de la persona: ");
                        string nombre = System.Console.ReadLine();
                        bool asignado = parque.Asignar_Asiento(nombre);   //intenta asignar un asiento

                        if (asignado)    //muestra mensaje segun sea el resultado
                        {
                            System.Console.WriteLine("Asiento asignado correctamente.");//cuando hay asientos
                        }
                        else
                        {
                            System.Console.WriteLine("No fue posible asignar el asiento.");//cuando no hay asientos
                        }
                    }
                    break;

                case 2:   //opcion para mostrar asientos ocupados
                    parque.Mostrar_Asientos();
                    break;

                case 3:   //opcion para consultar cuantos asientos quedan libres
                    int disponibles = parque.Espacios_Disponibles();
                    System.Console.WriteLine("Asientos disponibles: {0}", disponibles);
                    break;

                case 4:   //opcion para salir del sistema con mensaje final
                    System.Console.WriteLine("Gracias por preferirnos. ¡Hasta pronto!.....");
                    break;

                default:  //cuando la opcion sea invalida
                    System.Console.WriteLine("Opcion invalida. Intente nuevamente.");
                    break;
            }

        } while (opcion != 4); //el bucle se repite hasta que el usuario elija salir
    }
}




































// //SEMANA 7
// class Programa_principal
// {
//     static void Main()
//     {
//         //ingreso de la expresion por consola 
//         System.Console.WriteLine("INGRESE UNA EXPRESION MATEMATICA:");
//         string expresion = System.Console.ReadLine();

//         //verificacion de parentesis
//         string resultado = Verificador.Verificar(expresion);
//         System.Console.WriteLine("RESULTADO DE VERIFICACION : " + resultado);
//         System.Console.WriteLine();

//         //muestra como resolver las Torres de Hanoi paso a paso
//         System.Console.WriteLine("RESOLUCION DE TORRES DE HANOI:  ");
//         Hanoi.Ejecutar();


//     }
// }




//SEMNA 6

// class Programa_principal
// {
//     static void Main(string[] args)

//     {
//         //EJERCICIO 1:
//         ListaEnlazada lista = new ListaEnlazada();

//         //agregar algunos datos
//         lista.AgregarAlFinal(15);
//         lista.AgregarAlFinal(28);
//         lista.AgregarAlFinal(33);
//         lista.AgregarAlFinal(49);
//         lista.AgregarAlFinal(55);
//         lista.AgregarAlFinal(100);

//         Console.WriteLine("LISTA ORIGINAL:");
//         lista.Mostrar();

//         //invertir la lista
//         lista.Invertir();

//         Console.WriteLine("LISTA INVERTIDA:");
//         lista.Mostrar();
    
    
        
//         // EJERCICIO 2:  
        
//         Console.WriteLine("\n\nEJERCICIO 2: Lista aleatoria con 50 numeros (1 a 999)");

//         // Crear una nueva lista para este ejercicio
//         ListaEnlazada listaAleatoria = new ListaEnlazada();
//         listaAleatoria.GenerarAleatorios();

//         Console.WriteLine("LISTA GENERADA:");
//         listaAleatoria.Mostrar();

//         Console.Write("Ingrese el valor minimo del rango: ");//solicitar al usuario que ingrese el valor minimo del rango
//         int minimo = int.Parse(Console.ReadLine());

//         Console.Write("Ingrese el valor maximo del rango: ");//solicitar al usuario que ingrese el valor maximo del rango
//         int maximo = int.Parse(Console.ReadLine());

//         listaAleatoria.EliminarFueraDeRango(minimo, maximo);//eliminar de la lista todos los elementos que esten fuera del rango 

//         Console.WriteLine("LISTA DESPUES DE ELIMINAR ELEMENTOS FUERA DEL RANGO:");
//         listaAleatoria.Mostrar();
//     }    
      
// }

//SEMANA 5

//clase para imprimir el programa de los ejercicios/(tarea 5) 
// class Programa 
// {
//     private static void Main()
//     {
//         System.Console.WriteLine("      LISTA DE ASIGNATURAS     ");
//         System.Console.WriteLine("===============================");

//         Curso curso = new Curso();
//         curso.Mostrar_Asignaturas();       //Ejercicio 1
//         curso.Mostrar_Frase_Estudio();    //Ejercicio 2
//         curso.Pedir_Notas_Y_Mostrar_Resultados();    //Ejercicio 3
//         curso.Mostrar_Asignaturas_Reprobadas();  //Ejercicio 5

//         Loteria ganadores = new Loteria();   // Ejercicio 4
//         ganadores.Ejecutar();     
        


//     }
// }




// class Programa_principal
// {
//     static void Main(string[] args)
//     {
//         agenda_telefonica[] contactos = new agenda_telefonica[100];//declaracion de array para guardar 100 contactos
//         int cantidad = 0; //cuenta cuantos contactos hay guardados

//         //Menu principal
//         int opcion;

//         do
//         {
//             //se imprime el menú de opciones
//             System.Console.WriteLine("====== AGENDA TELEFONICA ======");
//             System.Console.WriteLine("1. Agregar contacto");
//             System.Console.WriteLine("2. Mostrar contactos");
//             System.Console.WriteLine("3. Buscar contacto");
//             System.Console.WriteLine("4. Salir");
//             System.Console.Write("Elige una opcion: ");
            
//             opcion = System.Int32.Parse(Console.ReadLine());

//             switch (opcion)
//             {
//                 case 1:
//                     //agregar contacto
//                     System.Console.Write("Ingrese el nombre: ");
//                     string nombre = System.Console.ReadLine()!;

//                     System.Console.Write("Ingrese el teléfono: ");
//                     string telefono = System.Console.ReadLine()!;

//                     System.Console.Write("Ingrese la edad: ");
//                     int edad = System.Int32.Parse(System.Console.ReadLine()!);

//                     System.Console.Write("Ingrese el correo: ");
//                     string correo = System.Console.ReadLine()!;

//                     System.Console.Write("Ingrese la dirección: ");
//                     string direccion = System.Console.ReadLine()!;

//                     // Crear y guardar el nuevo contacto
//                     contactos[cantidad] = new agenda_telefonica(nombre, telefono, edad, correo, direccion);
//                     cantidad++; // Aumentar el contador

//                     System.Console.WriteLine("Contacto agregado exitosamente...");
//                     break;
//                 case 2:
//                     //mostrar contactos
//                     if (cantidad == 0)
//                     {
//                         System.Console.WriteLine("No hay contactos registrados.");
//                     }
//                     else
//                     {
//                         System.Console.WriteLine("=== LISTA DE CONTACTOS ===");

//                         for (int i = 0; i < cantidad; i++)
//                         {
//                             contactos[i].MostrarContacto(); //llama al metodo de la clase para mostrar datos
//                         }

//                     }
//                     break;
//                 case 3:
//                     //buscar un contacto por nombre
//                     System.Console.Write("Ingrese el nombre a buscar: ");
//                     string nombreBuscado = System.Console.ReadLine()!;
                    
//                     bool encontrado = false; //operacion booleana para saber si se encontro el contacto

//                     for (int i = 0; i < cantidad; i++)
//                     {
//                         if (contactos[i].Nombres.ToLower() == nombreBuscado.ToLower())
//                         {
//                             System.Console.WriteLine("Contacto encontrado:");
//                             contactos[i].MostrarContacto();
//                             encontrado = true;
//                             break; //sale del bucle si lo encuentra
//                         }
//                     }

//                     if (!encontrado)

//                     {
//                         System.Console.WriteLine(" Contacto no encontrado.");
//                     }
                    
//                     break;
//                 case 4:
//                     //muestra un mensaje de salida
//                     System.Console.WriteLine("Saliendo del programa...");
//                     break;
//                 default:
//                     System.Console.WriteLine("Opción no valida.");
//                     break;
//                 }

//                     System.Console.WriteLine(); // Espacio entre repeticiones
//                 }
//         while (opcion != 4);
//     }
// }
