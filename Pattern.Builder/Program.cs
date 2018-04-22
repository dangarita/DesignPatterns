using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Este código del mundo real demuestra el patrón Builder
/// en el que se ensamblan diferentes vehículos paso a paso.
/// The Shop usa VehicleBuilders para construir una variedad de vehículos 
/// en una serie de pasos secuenciales.
/// </summary>
namespace Pattern.Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleBuilder builder;

            // Create shop with vehicle builders

            Shop shop = new Shop();

            // Construct and display vehicles

            builder = new ScooterBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            builder = new CarBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            builder = new MotorCycleBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            // Wait for user

            Console.Read();
        }
    }
}
