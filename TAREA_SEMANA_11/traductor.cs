//se inicializa la clase tradusctor
class Traductor

{
    //diccionario que almacena clave: español y valor: ingles 
    Dictionary<string, string> diccionario;

    //constructor de la clase traductor que crea el diccionario
    public Traductor()
    {
        diccionario = new Dictionary<string, string>();
        Inicializar();
    }

    //inicializa el diccionario con 10 palabras
    private void Inicializar()
    {
        diccionario.Add("tiempo", "time");
        diccionario.Add("persona", "person");
        diccionario.Add("año", "year");
        diccionario.Add("camino", "way");
        diccionario.Add("dia", "day");
        diccionario.Add("cosa", "thing");
        diccionario.Add("mujer", "woman");
        diccionario.Add("mundo", "world");
        diccionario.Add("vida", "life");
        diccionario.Add("ojo", "eye");
    }

    //traduce una frase usando el diccionario
    public string Traducir(string frase)
    {
        string[] palabras = frase.Split(' ');  //divide la frase en palabras usando el espacio como separador
        for (int i = 0; i < palabras.Length; i++) //recorre cada palabra de la frase
        {
            string palabra = palabras[i];
            //quita signos de puntuacion simples
            string limpia = palabra.Trim(',', '.');
            //si la palabra existe en el diccionario, la reemplaza
            if (diccionario.ContainsKey(limpia))
            {
                palabras[i] = palabras[i].Replace(limpia, diccionario[limpia]);
            }
        }
        return string.Join(" ", palabras); //une las palabras ya traducidas en una frase y la devuelve
    }

    //permite agregar nuevas palabras al diccionario
    public void AgregarPalabra(string espanol, string ingles)
    {
        if (!diccionario.ContainsKey(espanol.ToLower()))//verifica si la palabra en español no existe aun en el diccionario
        {
            diccionario.Add(espanol.ToLower(), ingles.ToLower());//agrega la palabra en español como clave y la traduccion en ingles como valor
            System.Console.WriteLine("Palabra agregada correctamente.....");//muestra que la palabra se agrego correctamente
        }
        else
        {
            System.Console.WriteLine("La palabra ya existe en el diccionario.....");//si la palabra ya existe, muestra que no se puede agregar 
        }
    }
}




