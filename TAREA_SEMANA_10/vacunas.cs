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

        //75 vacunados con pfizer
        GenerarVacunados(pfizer, 75);

        //75 vacunados con astrazeneca
        GenerarVacunados(astrazeneca, 75);
    }

    //se genera  la cantidad ciudadanos vacunados con nombres
    private void GenerarVacunados(System.Collections.Generic.HashSet<string> conjunto, int cantidad)
    {
        System.Random random = new System.Random();
        while (conjunto.Count < cantidad)
        {
            int id = random.Next(1, 501); // entre 1 y 500
            conjunto.Add("Ciudadano " + id);
        }
    }


}

