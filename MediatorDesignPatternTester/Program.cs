using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Structural = MediatorDesignPatternTester.StructuralCode;
using Real = MediatorDesignPatternTester.RealWorldCode;
using My = MediatorDesignPatternTester.MyCode;

namespace MediatorDesignPatternTester
{
    // Mediator

    // Definition
    // Define an object that encapsulates how a set of objects interact.
    // Mediator promotes loose coupling by keeping objects from referring to each other explicitly,
    // and it lets you vary their interaction independently. 

    // Participants
    // The classes and objects participating in this pattern are:
    //  - Mediator (IChatroom)
    //      defines an interface for communicating with Colleague objects
    //  - ConcreteMediator (Chatroom)
    //       - implements cooperative behavior by coordinating Colleague objects
    //       - knows and maintains its colleagues
    //  - Colleague classes  (Participant)
    //       - each Colleague class knows its Mediator object
    //       - each colleague communicates with its mediator whenever it would have otherwise communicated with another colleague

    /// <summary>
    /// MainApp startup class for Structural 
    /// Mediator Design Pattern.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Entry point into console application
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            #region Structural code in C#
            // Structural code in C#
            // This structural code demonstrates the Mediator pattern facilitating loosely coupled communication
            // between different objects and object types. The mediator is a central hub through which all interaction must take place. 
            Structural.ConcreteMediator m = new Structural.ConcreteMediator();

            Structural.ConcreteCollegue1 c1 = new Structural.ConcreteCollegue1(m);
            Structural.ConcreteCollegue2 c2 = new Structural.ConcreteCollegue2(m);

            m.Collegue1 = c1;
            m.Collegue2 = c2;

            c1.Send("How are you?");
            c2.Send("Fine Thenks");

            // Wait for user
            Console.ReadKey();
            #endregion

            #region Real World code in C#
            // Real-world code in C#
            // This real-world code demonstrates the Mediator pattern
            // facilitating loosely coupled communication between different Participants registering with a Chatroom. 
            // The Chatroom is the central hub through which all communication takes place.
            // At this point only one-to-one communication is implemented in the Chatroom, but would be trivial to change to one-to-many. 

            // Create chatroom
            Real.Chatroom chatroom = new Real.Chatroom();

            // Create partecipants and register them
            Real.Partecipant George = new Real.Beatle("George");
            Real.Partecipant Paul = new Real.Beatle("Paul");
            Real.Partecipant Ringo = new Real.Beatle("Ringo");
            Real.Partecipant John = new Real.Beatle("John");
            Real.Partecipant Yoko = new Real.NonBeatle("Yoko");

            chatroom.Register(George);
            chatroom.Register(Paul);
            chatroom.Register(Ringo);
            chatroom.Register(John);
            chatroom.Register(Yoko);

            // Chatting partecipants
            Yoko.Send("John", "Hi John");
            Paul.Send("Ringo", "All you need is love");
            Ringo.Send("George", "My sweet Lord");
            Paul.Send("John", "Can't buy my love");
            John.Send("Yoko", "My sweet lord");

            // *** My TRIVIAL send to all
            Yoko.SendToAll("Ciao a tutti!");
            
            // Wait for user
            Console.ReadKey();
            #endregion

            #region My code in C#
            // Creazione Centrale Messaggi
            My.CentraleMessaggi cm = new My.CentraleMessaggi();

            // Creazione utenti
            My.UtenteReadAndWrite Marco = new My.UtenteReadAndWrite("Marco");
            My.UtenteReadAndWrite Andrea = new My.UtenteReadAndWrite("Andrea");
            My.UtenteReadOnly Mario = new My.UtenteReadOnly("Mario");

            // Registrazione utenti alla centrale messaggi
            cm.Register(Marco);
            cm.Register(Andrea);
            cm.Register(Mario);

            // Invio Messaggi alla centrale
            Marco.Send("Andrea", "DA MARCO PER ANDREA");
            Marco.Send("Mario", "DA MARCO PER MARIO");

            Mario.Send("Marco", "DA MARIO PER MARCO"); // Non viene mandato perchè Mario è UtenteReadOnly

            // Ricezione Messaggi dalla centrale
            Marco.Receive("Mario");
            Marco.Receive("Andrea");

            Andrea.Receive("Marco");
            Andrea.Receive("Andrea");

            Mario.Receive("Marco");
            Mario.Receive("Andrea");
            // Wait for user
            Console.ReadKey();

            #endregion
        }
    }
}
