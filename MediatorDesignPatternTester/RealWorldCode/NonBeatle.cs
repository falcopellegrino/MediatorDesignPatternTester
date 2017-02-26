using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPatternTester.RealWorldCode
{
    /// <summary>
    /// A 'ConcreteCollegue' class
    /// </summary>  
    class NonBeatle : Partecipant
    {
        // Constructor
        public NonBeatle(string name)
            : base(name)
        {
        }

        public override void Receive(string from, string message)
        {
            Console.WriteLine("To a NonBeatle: ");
            base.Receive(from, message);
        }
    }
}
