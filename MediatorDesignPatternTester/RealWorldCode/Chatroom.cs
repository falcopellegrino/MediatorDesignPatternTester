using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPatternTester.RealWorldCode
{
    /// <summary>
    /// The 'ConcreteMediator' class
    /// </summary>
    class Chatroom : AbstractChatroom
    {
        private Dictionary<string, Partecipant> _partecipants = new Dictionary<string, Partecipant>();

        public override void Register(Partecipant partecipant)
        {
            if (!_partecipants.ContainsValue(partecipant)) {
                _partecipants[partecipant.Name] = partecipant;
            }
            partecipant.Chatroom = this;
        }

        public override void Send(string from, string to, string message)
        {
            Partecipant partecipant = _partecipants[to];
            if(partecipant != null)
            {
                partecipant.Receive(from, message);
            }
        }

        public override void SendToAll(string from, string message)
        {
            foreach (KeyValuePair<string, Partecipant> p in _partecipants)
            {
                p.Value.Receive(from, message);
            }
        }
    }
}
