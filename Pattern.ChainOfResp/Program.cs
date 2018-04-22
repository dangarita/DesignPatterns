using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.ChainOfResp
{
    /// <summary>
    /// Este código del mundo real demuestra el patrón de Chain of resp 
    /// en el que varios gerentes y ejecutivos vinculados pueden responder a 
    /// una solicitud de compra o entregársela a un superior. Cada posición puede 
    /// tener su propio conjunto de reglas que las órdenes pueden aprobar.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Setup Chain of Responsibility

            Approver larry = new Director();
            Approver sam = new VicePresident();
            Approver tammy = new President();

            larry.SetSuccessor(sam);
            sam.SetSuccessor(tammy);

            // Generate and process purchase requests

            Purchase p = new Purchase(2034, 350.00, "Assets");
            larry.ProcessRequest(p);

            p = new Purchase(2035, 32590.10, "Project X");
            larry.ProcessRequest(p);

            p = new Purchase(2036, 122100.00, "Project Y");
            larry.ProcessRequest(p);

            // Wait for user

            Console.ReadKey();
        }
    }
}
