using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPatternTester.StructuralCode
{
    /// <summary>
    /// A 'ConcreteCollegue' class
    /// </summary>  
    class ConcreteCollegue2 : Collegue
    {
        // Constructor
        public ConcreteCollegue2(Mediator mediator)
            : base(mediator)
        {
        }

        public void Send(string message)
        {
            mediator.Send(message, this);
        }
        public void Notify(string message)
        {
            Console.WriteLine("Collegue2 gets message: " + message);
        }
    }
}
