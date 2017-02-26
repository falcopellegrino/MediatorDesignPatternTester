using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPatternTester.MyCode
{
    class Messaggio
    {
        private string _testo;
        private Utente _utenteFrom;
        private Utente _utenteTo;

        public Messaggio(string testo, Utente utenteFrom, Utente utenteTo)
        {
            _testo = testo;
            _utenteFrom = utenteFrom;
            _utenteTo = utenteTo;
        }

        public Utente UtenteFrom
        {
            get { return _utenteFrom; }
        }
        public Utente UtenteTo
        {
            get { return _utenteTo; }
        }
        
        public void PrintMessaggio()
        {
            Console.WriteLine(_testo + "\n");
        }

    }
}
