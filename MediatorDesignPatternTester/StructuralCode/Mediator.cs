using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPatternTester.StructuralCode
{
    /// <summary>
    /// The 'Mediator' abstract class
    /// </summary>
    abstract class Mediator
    {
        public abstract void Send(string Message, Collegue collegue);
    }
}
