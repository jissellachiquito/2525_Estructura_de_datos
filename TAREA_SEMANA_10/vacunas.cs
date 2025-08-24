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

    //se procesa los datos
    public void ProcesarDatos()
    {
        //no vacunados
        var noVacunados = new System.Collections.Generic.HashSet<string>(ciudadanos);//se crea conjunto de no vacunados 
        noVacunados.ExceptWith(pfizer);//se elimina del conjunto los que fueron vacunados con pfizer
        noVacunados.ExceptWith(astrazeneca);//se elimina tambien los vacunados con aztrazeneca

        //ambas dosis 
        var ambasDosis = new System.Collections.Generic.HashSet<string>(pfizer);
        ambasDosis.IntersectWith(astrazeneca);//aplicamos la interseccion entre ambas vacunas

        //solo pfizer
        var soloPfizer = new System.Collections.Generic.HashSet<string>(pfizer);
        soloPfizer.ExceptWith(astrazeneca); //elimina y solo se queda con los de pfizer

        //solo astrazeneca
        var soloAstra = new System.Collections.Generic.HashSet<string>(astrazeneca);
        soloAstra.ExceptWith(pfizer);//elimina y solo se queda con los de astrazeneca

        //mostrar resultados
        ImprimirGrupo("1. NO VACUNADOS", noVacunados);
        ImprimirGrupo("2. CON AMBAS DOSIS", ambasDosis);
        ImprimirGrupo("3. SOLO PFIZER", soloPfizer);
        ImprimirGrupo("4. SOLO ASTRAZENECA", soloAstra);
    }

    
}

