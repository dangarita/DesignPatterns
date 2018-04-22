using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Memento
{
    /// <summary>
    /// Este código del mundo real muestra el patrón Memento
    /// que guarda temporalmente y luego
    /// restablece el estado interno de Prospectos de venta.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            /// <summary>

            /// Entry point into console application.

            /// </summary>

            SalesProspect s = new SalesProspect();
            s.Name = "Noel van Halen";
            s.Phone = "(412) 256-0990";
            s.Budget = 25000.0;

            // Store internal state

            ProspectMemory m = new ProspectMemory();
            m.Memento = s.SaveMemento();

            // Continue changing originator

            s.Name = "Leo Welch";
            s.Phone = "(310) 209-7111";
            s.Budget = 1000000.0;

            // Restore saved state

            s.RestoreMemento(m.Memento);

            // Wait for user

            Console.ReadKey();
        }
    }
}
