using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix {
    abstract class Quantifier : Proposition {

        public Proposition Predicate { get; private set; }
        public List<Variable> BoundVariables { get; private set; }

        protected Quantifier(Proposition predicate, List<Variable> boundVariables) {
            Predicate = predicate;
            BoundVariables = boundVariables;
        }

    }
}
