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
    class UtenteReadAndWrite : Utente
    {
        // Constructor
        public UtenteReadAndWrite(string name)
            : base(name)
        {
        }

    }
}
