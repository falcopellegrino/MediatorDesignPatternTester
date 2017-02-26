using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPatternTester.StructuralCode
{
    /// <summary>
    /// The 'Collegue' abstract class
    /// </summary>  
    class Collegue
    {
        protected Mediator mediator;

        // Constructor
        public Collegue(Mediator mediator)
        {
            this.mediator = mediator;
        }
    }
}
