public class Vacunas
{
    private System.Collections.Generic.HashSet<string> ciudadanos;
    private System.Collections.Generic.HashSet<string> pfizer;
    private System.Collections.Generic.HashSet<string> astrazeneca;

    public Vacunas()
    {
        //se inicializa colecciones para almacenar ciudadanos vacunados sin duplicados
        ciudadanos = new System.Collections.Generic.HashSet<string>();
        pfizer = new System.Collections.Generic.HashSet<string>();
        astrazeneca = new System.Collections.Generic.HashSet<string>();


    }
}

