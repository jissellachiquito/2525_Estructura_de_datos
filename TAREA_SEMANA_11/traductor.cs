//se inicializa la clase tradusctor
class Traductor

{
    //diccionario que almacena calve: español y valor: ingles 
    private System.Collections.Generic.Dictionary<string, string> diccionario;

    public Traductor() // constructor de la clase traductor que crea el diccionario
    {
        diccionario = new System.Collections.Generic.Dictionary<string, string>();
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
            //quita signos de puntuación simples
            string limpia = palabra.Trim(',', '.');
            //si la palabra existe en el diccionario, la reemplaza
            if (diccionario.ContainsKey(limpia))
            {
                palabras[i] = palabras[i].Replace(limpia, diccionario[limpia]);
            }
        }
        
    }

    
}




