using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPatternTester.MyCode
{
    /// <summary>
    /// The 'ConcreteMediator' class
    /// </summary>
    class CentraleMessaggi : AbstractCentraleMessaggi
    {
        private Dictionary<string, Utente> _utenti = new Dictionary<string, Utente>();

        private List<Messaggio> _messaggi = new List<Messaggio>();

        public override void Register(Utente utente)
        {
            if (!_utenti.ContainsValue(utente)) {
                _utenti[utente.Name] = utente;
            }
            utente.CentraleMessaggi = this;
        }

        public override void Send(string from, string to, string message)
        {
            Utente utenteFrom = _utenti[from];
            Utente utenteTo = _utenti[to];
            if (utenteTo != null && utenteFrom != null && utenteFrom.GetType() == typeof(UtenteReadAndWrite))
            {
                _messaggi.Add(new Messaggio(message, utenteFrom, utenteTo));
            }
        }

        public override void Receive(string from, string to)
        {
            List<Messaggio> m = _messaggi.FindAll(msg => msg.UtenteFrom == _utenti[from] && msg.UtenteTo == _utenti[to]);
            foreach (Messaggio item in m)
            {
                item.PrintMessaggio();
                _messaggi.Remove(item);
            }
        }
    }
}
