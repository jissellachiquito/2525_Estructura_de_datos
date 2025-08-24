public class Vacunas
{
    private System.Collections.Generic.HashSet<string> ciudadanos;
    private System.Collections.Generic.HashSet<string> pfizer;
    private System.Collections.Generic.HashSet<string> astrazeneca;

    public Vacunas()
    {
        //se inicializa colecciones para almacenar ciudadanos vacunados sin duplicados
        ciudadanos = new System.Collections.Generic.HashSet<string>(); // todos los ciudadanos vacunados 
        pfizer = new System.Collections.Generic.HashSet<string>(); //vacunados con pfizer
        astrazeneca = new System.Collections.Generic.HashSet<string>(); //vacunados con astrazeneca


        //se declara los 500 ciudadanos 
        for (int i = 1; i <= 500; i++)
        {
            ciudadanos.Add("Ciudadano " + i);
        }


    }
}

