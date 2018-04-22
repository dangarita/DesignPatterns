using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Bridge
{
    /// <summary>
    /// Este código del mundo real muestra el patrón Bridge 
    /// en el que una abstracción de BusinessObject está desacoplada de la 
    /// implementación en DataObject. Las implementaciones de DataObject pueden evolucionar 
    /// dinámicamente sin cambiar ningún cliente.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Create RefinedAbstraction

            Customers customers = new Customers("Chicago");

            // Set ConcreteImplementor

            customers.Data = new CustomersData();

            // Exercise the bridge

            customers.Show();
            customers.Next();
            customers.Show();
            customers.Next();
            customers.Show();
            customers.Add("Henry Velasquez");

            customers.ShowAll();

            // Wait for user

            Console.Read();
        }
    }
}
