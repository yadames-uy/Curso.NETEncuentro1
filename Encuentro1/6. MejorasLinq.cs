namespace Encuentro1;

public class MaxMin
{
    public record MaxMinRecord(int Prioridad, string Name);

    public void Ejemplo1() // Max-Min y MaxBy-MinBy
    {
        List<MaxMinRecord> maxMinRecords = new()
            {
                new(3, "prioridad 3"),
                new(2, "prioridad 2"),
                new(10, "prioridad 10"),
                new(8, "prioridad 8")
            };

        int max = maxMinRecords.Max(x => x.Prioridad);                  // Devuelve la propiedad

        MaxMinRecord? record = maxMinRecords.MaxBy(x => x.Prioridad);   // Devuelve el objeto
    }

    public void Ejemplo2() // Chunk()
    {
        // Listado de 100 elementos
        IEnumerable<int> listInts = Enumerable.Range(0, 100);

        int chunkSize = 10;
        foreach (var chunk in listInts.Chunk(chunkSize))
        {
            // Chunk(), devuelve porciones de la lista con el tamaño
            //          que se le indique por parámetro en este caso,
            //          10 listas de 10 elementos cada una.
        }
    }

    public void Ejemplo3() // Take()
    {
        // Listado de 100 elementos
        IEnumerable<int> listInts = Enumerable.Range(0, 100);

        /**
         *  Para obtener 15 elementos a partir de la posición 10
         */
        var oldSolution = listInts.Skip(10).Take(15);

        var newSolution = listInts.Take(10..25);
    }
}