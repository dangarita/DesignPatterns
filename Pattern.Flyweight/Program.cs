using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Flyweight
{
    /// <summary>
    /// Este código del mundo real demuestra el patrón Flyweight
    /// en el que un número relativamente pequeño de objetos
    /// Character se comparte muchas veces con un documento que 
    /// potencialmente tiene muchos caracteres.
    /// existen clases para cada caracter ej: // ... C, D, E, etc
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Build a document with text

            string document = "AAZZBBZB";
            char[] chars = document.ToCharArray();

            CharacterFactory factory = new CharacterFactory();

            // extrinsic state

            int pointSize = 10;

            // For each character use a flyweight object

            foreach (char c in chars)
            {
                pointSize++;
                Character character = factory.GetCharacter(c);
                character.Display(pointSize);
            }

            // Wait for user

            Console.ReadKey();
        }
    }
}
