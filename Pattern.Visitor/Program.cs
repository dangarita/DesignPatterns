using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Visitor
{
    /// <summary>
    /// ste código del mundo real muestra el patrón Visitor en el que dos objetos 
    /// atraviesan una lista de Empleados y realiza la misma operación en cada Empleado.
    /// Los dos objetos de visitante
    /// definen diferentes operaciones: una ajusta los días de vacaciones y los otros ingresos.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Setup employee collection

            Employees e = new Employees();
            e.Attach(new Clerk());
            e.Attach(new Director());
            e.Attach(new President());

            // Employees are 'visited'

            e.Accept(new IncomeVisitor());
            e.Accept(new VacationVisitor());

            // Wait for user

            Console.ReadKey();
        }
    }
}
