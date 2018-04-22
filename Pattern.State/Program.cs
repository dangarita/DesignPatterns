using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.State
{
    /// <summary>
    /// Este código del mundo real demuestra el patrón State
    /// que permite que una cuenta se comporte de manera diferente
    /// según su saldo. La diferencia de comportamiento
    /// se delega en objetos estatales llamados RedState, SilverState y GoldState.
    /// Estos estados representan cuentas sobregiradas, cuentas iniciales y cuentas en buen estado.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Open a new account

            Account account = new Account("Jim Johnson");

            // Apply financial transactions

            account.Deposit(500.0);
            account.Deposit(300.0);
            account.Deposit(550.0);
            account.PayInterest();
            account.Withdraw(2000.00);
            account.Withdraw(1100.00);

            // Wait for user

            Console.ReadKey();
        }
    }
}
