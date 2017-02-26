using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPatternTester.StructuralCode
{
    /// <summary>
    /// The 'ConcreteMediator' class
    /// </summary>
    class ConcreteMediator : Mediator
    {
        private ConcreteCollegue1 _collegue1;
        private ConcreteCollegue2 _collegue2;

        public ConcreteCollegue1 Collegue1
        {
            set { _collegue1 = value; }
        }
        public ConcreteCollegue2 Collegue2
        {
            set { _collegue2 = value; }
        }

        public override void Send(string message, Collegue collegue)
        {
            if (collegue == _collegue1){
                _collegue2.Notify(message);
            }
            else{
                _collegue1.Notify(message);
            }
        }
    }
}
