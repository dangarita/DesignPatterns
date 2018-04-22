using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.TemplateMethod
{
    /// <summary>
    /// Este código del mundo real muestra un Template Method 
    /// llamado Run () que proporciona una secuencia esquemática de métodos de invocación.
    /// La implementación de estos pasos se difiere a la subclase CustomerDataObject
    /// que implementa los métodos Connect, Select, Process y Disconnect.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            DataAccessObject daoCategories = new Categories();
            daoCategories.Run();

            DataAccessObject daoProducts = new Products();
            daoProducts.Run();

            // Wait for user

            Console.ReadKey();
        }
    }
}
