using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPatternTester.MyCode
{
    /// <summary>
    /// The 'Partecipant' base class
    /// </summary>  
    class Utente
    {
        private CentraleMessaggi _centraleMessaggi;
        private string _name;

        // Constructor
        public Utente(string name)
        {
            this._name = name;
        }

        // Gets partecipant name
        public string Name
        {
            get { return _name; }
        }
        // Gets chatroom
        public CentraleMessaggi CentraleMessaggi
        {
            get { return _centraleMessaggi; }
            set { _centraleMessaggi = value; }
        }
        
        // Sends message to given partecipant
        public void Send(string to, string message)
        {
            _centraleMessaggi.Send(_name, to, message);
        }
        // Receives message from given partecipant
        public virtual void Receive(string from)
        {
            _centraleMessaggi.Receive(from, _name);
        }

    }
}
