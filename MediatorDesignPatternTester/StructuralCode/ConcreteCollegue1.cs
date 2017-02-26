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
    class ConcreteCollegue1 : Collegue
    {
        // Constructor
        public ConcreteCollegue1(Mediator mediator)
            : base(mediator)
        {
        }

        public void Send(string message)
        {
            mediator.Send(message, this);
        }
        public void Notify(string message)
        {
            Console.WriteLine("Collegue1 gets message: " + message);
        }
    }
}
