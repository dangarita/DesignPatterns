using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Facade
{
    /// <summary>
    /// Este código del mundo real muestra el patrón Facade 
    /// como un objeto MortgageApplication que proporciona una interfaz
    /// simplificada para un gran subsistema de clases que mide la 
    /// solvencia de un solicitante.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Facade

            Mortgage mortgage = new Mortgage();

            // Evaluate mortgage eligibility for customer

            Customer customer = new Customer("Ann McKinsey");
            bool eligible = mortgage.IsEligible(customer, 125000);

            Console.WriteLine("\n" + customer.Name +
                " has been " + (eligible ? "Approved" : "Rejected"));

            // Wait for user

            Console.ReadKey();
        }
    }
}
