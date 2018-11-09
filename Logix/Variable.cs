using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix {
    class Variable : Proposition, IComparable<Variable> {

        public char Letter { get; set; }

        public Variable(char letter) {
            Letter = letter;
        }

        public override string ToString() {
            return Letter.ToString();
        }

        public override string CreateGraph(ref int index, int preIndex) {
            string graph = String.Format(Environment.NewLine + "node{0} [ label = \"{1}\" ]", index, Letter);

            if (preIndex != 0) {
                graph += String.Format(Environment.NewLine + "node{0} -- node{1}", preIndex, index);
            }

            index++;

            return graph;
        }

        public int CompareTo(Variable other) {
            return Letter.CompareTo(other.Letter);
        }

    }
}
