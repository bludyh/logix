using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix {
    class Predicate : Proposition {

        public char Letter { get; set; }
        public List<Variable> ObjectVariables { get; set; }
        
        public Predicate(char letter, List<Variable> objectVariables) {
            Letter = letter;
            ObjectVariables = objectVariables;
        }

        public override string ToString() {
            return String.Format("{0}({1})", Letter.ToString(), String.Join(",", ObjectVariables));
        }

        public override string CreateGraph(ref int index, int preIndex = 0) {
            string graph = String.Format(Environment.NewLine + "node{0} [ label = \"{1}\" ]", index, ToString());

            if (preIndex != 0) {
                graph += String.Format(Environment.NewLine + "node{0} -- node{1}", preIndex, index);
            }

            index++;

            return graph;
        }

    }
}
