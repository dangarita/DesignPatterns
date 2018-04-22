using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Mediator
{
    /// <summary>
    /// Este código del mundo real demuestra el patrón del Mediator que facilita 
    /// la comunicación débilmente acoplada entre los diferentes participantes que se 
    /// registran en una sala de chat. El Chatroom es el eje central a través del cual se 
    /// lleva a cabo toda la comunicación. En este punto, solo se implementa la comunicación 
    /// uno-a-uno en la sala de chat, pero sería trivial cambiar a uno-a-muchos.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Create chatroom

            Chatroom chatroom = new Chatroom();

            // Create participants and register them

            Participant George = new Beatle("George");
            Participant Paul = new Beatle("Paul");
            Participant Ringo = new Beatle("Ringo");
            Participant John = new Beatle("John");
            Participant Yoko = new NonBeatle("Yoko");

            chatroom.Register(George);
            chatroom.Register(Paul);
            chatroom.Register(Ringo);
            chatroom.Register(John);
            chatroom.Register(Yoko);

            // Chatting participants

            Yoko.Send("John", "Hi John!");
            Paul.Send("Ringo", "All you need is love");
            Ringo.Send("George", "My sweet Lord");
            Paul.Send("John", "Can't buy me love");
            John.Send("Yoko", "My sweet love");

            // Wait for user

            Console.ReadKey();
        }
    }
}
