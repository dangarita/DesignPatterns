using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Este código del mundo real demuestra el uso de un banco de datos 
/// químico heredado. Los objetos compuestos químicos acceden al banco de 
/// datos a través de una interfaz de adaptador.
/// </summary>
namespace Pattern.Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Non-adapted chemical compound

            Compound unknown = new Compound("Unknown");
            unknown.Display();

            // Adapted chemical compounds

            Compound water = new RichCompound("Water");
            water.Display();

            Compound benzene = new RichCompound("Benzene");
            benzene.Display();

            Compound ethanol = new RichCompound("Ethanol");
            ethanol.Display();

            // Wait for user

            Console.Read();
        }
    }
}
