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

    
}




