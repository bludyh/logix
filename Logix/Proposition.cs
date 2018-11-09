using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix {
    abstract class Proposition {

        public List<Variable> Variables { get; set; }
        public bool IsPredicate { get; set; }
        public virtual int TruthValue { get; private set; }

        public abstract override string ToString();
        public abstract string CreateGraph(ref int index, int preIndex = 0);

        public TruthTable CreateTruthTable() {
            var data = new List<string[]>();
            for (int i = 0; i < (int)Math.Pow(2, Variables.Count); i++) {
                var values = Convert.ToString(i, 2).PadLeft(Variables.Count, '0').ToCharArray();
                var row = new string[Variables.Count + 1];
                for (int j = 0; j < Variables.Count; j++) {
                    Variables[j].TruthValue = ((int)Char.GetNumericValue(values[j]));
                    row[j] = Variables[j].TruthValue.ToString();
                }
                row[Variables.Count] = TruthValue.ToString();
                data.Add(row);
            }
            return new TruthTable(Variables, data);
        }

        public Proposition Nandify() {
            Proposition nand;
            if (this is Negation n) {
                nand = new NotAnd(n.Operand.Nandify(), n.Operand.Nandify());
            }
            else if (this is Conjunction c) {
                nand = new NotAnd(new NotAnd(c.LeftOperand.Nandify(), c.RightOperand.Nandify()), new NotAnd(c.LeftOperand.Nandify(), c.RightOperand.Nandify()));
            }
            else if (this is Disjunction d) {
                nand = new NotAnd(new NotAnd(d.LeftOperand.Nandify(), d.LeftOperand.Nandify()), new NotAnd(d.RightOperand.Nandify(), d.RightOperand.Nandify()));
            }
            else if (this is Implication i) {
                nand = new NotAnd(i.LeftOperand.Nandify(), new NotAnd(i.RightOperand.Nandify(), i.RightOperand.Nandify()));
            }
            else if (this is BiImplication bi) {
                nand = new NotAnd(new NotAnd(new NotAnd(bi.LeftOperand.Nandify(), bi.LeftOperand.Nandify()), new NotAnd(bi.RightOperand.Nandify(), bi.RightOperand.Nandify())), new NotAnd(bi.LeftOperand.Nandify(), bi.RightOperand.Nandify()));
            }
            else {
                nand = this;
            }
            return nand;
        }

    }
}
