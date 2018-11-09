using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix {
    class Existential : Quantifier {

        public Existential(Proposition predicate, List<Variable> boundVariables) : base(predicate, boundVariables) { }

        public override string ToString() {
            return String.Format("\u2203{0}.{1}", String.Join(",", BoundVariables), Predicate.ToString());
        }

        public override string CreateGraph(ref int index, int preIndex = 0) {
            string graph = String.Format(Environment.NewLine + "node{0} [ label = \"\u2203{1}\" ]", index, String.Join(",", BoundVariables));
            int pre = index;

            if (preIndex != 0) {
                graph += String.Format(Environment.NewLine + "node{0} -- node{1}", preIndex, index);
            }

            index++;
            graph += Predicate.CreateGraph(ref index, pre);

            return graph;
        }

    }
}
