using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Este código del mundo real demuestra la creación de diferentes mundos animales
/// para un juego de computadora que utiliza diferentes Factories. 
/// Aunque los animales creados por las Factories del Continente son diferentes, 
/// las interacciones entre los animales siguen siendo las mismas.
/// </summary>
namespace Pattern.AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create and run the African animal world

            ContinentFactory africa = new AfricaFactory();
            AnimalWorld world = new AnimalWorld(africa);
            world.RunFoodChain();

            // Create and run the American animal world

            ContinentFactory america = new AmericaFactory();
            world = new AnimalWorld(america);
            world.RunFoodChain();

            // Wait for user input

            Console.Read();
        }
    }
}
