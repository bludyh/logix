using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix {
    class Negation : Proposition {

        public Proposition Operand { get; private set; }
        public override int TruthValue {
            get {
                if (Operand.TruthValue == 0) return 1;
                return 0;
            }
        }

        public Negation(Proposition operand) {
            Operand = operand;
        }

        public override string ToString() {
            return String.Format("\u00ac{0}", Operand.ToString());
        }

        public override string CreateGraph(ref int index, int preIndex) {
            string graph = String.Format(Environment.NewLine + "node{0} [ label = \"\u00ac\" ]", index);
            int pre = index;

            if (preIndex != 0) {
                graph += String.Format(Environment.NewLine + "node{0} -- node{1}", preIndex, index);
            }

            index++;
            graph += Operand.CreateGraph(ref index, pre);

            return graph;
        }

    }
}
