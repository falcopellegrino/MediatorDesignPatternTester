using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPatternTester.RealWorldCode
{
    /// <summary>
    /// The 'Mediator' abstract class
    /// </summary>
    abstract class AbstractChatroom
    {
        public abstract void Register(Partecipant partecipant);
        public abstract void Send(string from, string to, string message);

        public abstract void SendToAll(string from, string message);
    }
}
