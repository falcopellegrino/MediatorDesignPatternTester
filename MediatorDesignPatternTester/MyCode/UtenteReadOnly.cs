using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPatternTester.MyCode
{
    /// <summary>
    /// A 'ConcretePartecipant' class
    /// </summary>  
    class UtenteReadOnly : Utente
    {
        // Constructor
        public UtenteReadOnly(string name)
            : base(name)
        {
        }

        public new void Send(string to, string message)
        {
            return;
        }
    }
}
