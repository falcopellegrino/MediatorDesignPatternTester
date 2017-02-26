using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPatternTester.MyCode
{
    /// <summary>
    /// The 'Mediator' abstract class
    /// </summary>
    abstract class AbstractCentraleMessaggi
    {
        public abstract void Register(Utente utente);

        public abstract void Send(string from, string to, string message);
        public abstract void Receive(string to, string from);
    }
}
