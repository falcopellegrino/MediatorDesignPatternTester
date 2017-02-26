using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPatternTester.RealWorldCode
{
    /// <summary>
    /// The 'AbstractColleague' class
    /// </summary>  
    class Partecipant
    {
        private Chatroom _chatroom;
        private string _name;

        // Constructor
        public Partecipant(string name)
        {
            this._name = name;
        }

        // Gets partecipant name
        public string Name
        {
            get { return _name; }
        }
        // Gets chatroom
        public Chatroom Chatroom
        {
            get { return _chatroom; }
            set { _chatroom = value; }
        }
        // Sends message to given partecipant
        public void Send(string to, string message)
        {
            _chatroom.Send(_name, to, message);
        }
        // Receives message from given partecipant
        public virtual void Receive(string from, string message)
        {
            Console.WriteLine("{0} to {1}: '{2}'", from, Name, message);
        }

        // *** Sends message to all partecipant
        public void SendToAll(string message)
        {
            _chatroom.SendToAll(_name, message);
        }

    }
}
