using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix {
    class False : Proposition {

        public override int TruthValue { get { return 0; } }

        public override string ToString() {
            return "False";
        }

        public override string CreateGraph(ref int index, int preIndex) {
            string graph = String.Format(Environment.NewLine + "node{0} [ label = \"False\" ]", index);

            if (preIndex != 0) {
                graph += String.Format(Environment.NewLine + "node{0} -- node{1}", preIndex, index);
            }

            index++;

            return graph;
        }

    }
}
