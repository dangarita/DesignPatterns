using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Strategy
{
    /// <summary>
    /// Este código del mundo real demuestra el patrón de strategy
    /// que encapsula los algoritmos de clasificación en forma
    /// de objetos de clasificación. Esto permite a los clientes
    /// cambiar dinámicamente las estrategias
    /// de clasificación, incluidas Quicksort, Shellsort y Mergesort.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Two contexts following different strategies

            SortedList studentRecords = new SortedList();

            studentRecords.Add("Samual");
            studentRecords.Add("Jimmy");
            studentRecords.Add("Sandra");
            studentRecords.Add("Vivek");
            studentRecords.Add("Anna");

            studentRecords.SetSortStrategy(new QuickSort());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new ShellSort());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new MergeSort());
            studentRecords.Sort();

            // Wait for user

            Console.ReadKey();
        }
    }
}
