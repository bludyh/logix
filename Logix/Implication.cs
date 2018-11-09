using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix {
    class Implication : Proposition {

        public Proposition LeftOperand { get; private set; }
        public Proposition RightOperand { get; private set; }
        public override int TruthValue {
            get {
                if (LeftOperand.TruthValue == 1 && RightOperand.TruthValue == 0) return 0;
                return 1;
            }
        }

        public Implication(Proposition left, Proposition right) {
            LeftOperand = left;
            RightOperand = right;
        }

        public override string ToString() {
            return String.Format("({0} \u21d2 {1})", LeftOperand.ToString(), RightOperand.ToString());
        }

        public override string CreateGraph(ref int index, int preIndex) {
            string graph = String.Format(Environment.NewLine + "node{0} [ label = \"\u21d2\" ]", index);
            int pre = index;

            if (preIndex != 0) {
                graph += String.Format(Environment.NewLine + "node{0} -- node{1}", preIndex, index);
            }

            index++;
            graph += LeftOperand.CreateGraph(ref index, pre);
            graph += RightOperand.CreateGraph(ref index, pre);

            return graph;
        }

    }
}
