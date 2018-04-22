using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.FactoryMethod
{
    /// <summary>
    /// Este código del mundo real demuestra que el factoryMethod
    /// ofrece flexibilidad para crear documentos diferentes.
    /// Las clases de documentos derivados Informe y Reanudar instancian versiones extendidas de la clase Documento. 
    /// Aquí, se llama al factoryMethod en el constructor de la clase base del documento.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Document[] documents = new Document[2];

            documents[0] = new Resume();
            documents[1] = new Report();

            // Display document pages

            foreach (Document document in documents)
            {
                Console.WriteLine("\n" + document.GetType().Name + "--");
                foreach (Page page in document.Pages)
                {
                    Console.WriteLine(" " + page.GetType().Name);
                }
            }

            // Wait for user

            Console.Read();
        }
    }
}
