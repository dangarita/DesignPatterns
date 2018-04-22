using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Command
{
    /// <summary>
    /// Este código del mundo real muestra el patrón Command 
    /// utilizado en una calculadora simple con un número ilimitado de deshacer y rehacer. 
    /// Tenga en cuenta que en C # la palabra 'operador' es una palabra clave. 
    /// Prefijo con '@' permite usarlo como un identificador.
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            // Create user and let her compute

            User user = new User();

            // User presses calculator buttons

            user.Compute('+', 100);
            user.Compute('-', 50);
            user.Compute('*', 10);
            user.Compute('/', 2);

            // Undo 4 commands

            user.Undo(4);

            // Redo 3 commands

            user.Redo(3);

            // Wait for user

            Console.ReadKey();
        }
    }
}
