using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix {
    class TruthTable {

        private static readonly Stack<Proposition> stack;

        public List<Variable> Variables { get; private set; }
        public List<string[]> Data { get; private set; }

        static TruthTable() {
            stack = new Stack<Proposition>();
        }

        public TruthTable(List<Variable> variables, List<string[]> data) {
            Variables = variables;
            Data = data;
        }

        public TruthTable Simplify() {
            var zeros = new List<string[]>();
            var ones = new List<string[]>();
            foreach (var row in Data) {
                switch (row[row.Length - 1]) {
                    case "0":
                        zeros.Add(row); break;
                    case "1":
                        ones.Add(row); break;
                }
            }
            var smpfdData = SimplifyDataRecursively(zeros).Concat(SimplifyDataRecursively(ones)).ToList();
            return new TruthTable(Variables, smpfdData);
        }

        private List<string[]> SimplifyDataRecursively(List<string[]> data, int count = 0) {
            count++;
            var smpfdData = new List<string[]>();
            for (int i = 0; i < data.Count; i++) {
                bool isSimplifiable = false;
                for (int j = 0; j < data.Count; j++) {
                    var diffIndexes = new List<int>();
                    for (int k = 0; k < data[i].Length; k++) {
                        if (data[i][k] != data[j][k]) {
                            diffIndexes.Add(k);
                        }
                    }
                    if (diffIndexes.Count == 1) {
                        var smpfdRow = (string[])data[i].Clone();
                        smpfdRow[diffIndexes[0]] = "*";
                        if (!smpfdData.Any(smpfdRow.SequenceEqual)) smpfdData.Add(smpfdRow);
                        isSimplifiable = true;
                    }
                }
                if (!isSimplifiable && !smpfdData.Any(data[i].SequenceEqual)) smpfdData.Add(data[i]);
            }
            if (count < Variables.Count) return SimplifyDataRecursively(smpfdData, count);
            return smpfdData;
        }

        public Proposition CreateDisjunctiveFormula() {
            Proposition leftOperand;
            Proposition rightOperand;
            int count = 0;
            for (int i = Data.Count - 1; i >= 0; i--) {
                if (Data[i][Data[i].Length - 1] == "1") {
                    for (int j = Data[i].Length - 2; j >= 0; j--) {
                        switch (Data[i][j]) {
                            case "0":
                                stack.Push(new Negation(Variables[j]));
                                break;
                            case "1":
                                stack.Push(Variables[j]);
                                break;
                        }
                    }
                    count++;
                    while (stack.Count > count) {
                        leftOperand = stack.Pop();
                        rightOperand = stack.Pop();
                        stack.Push(new Conjunction(leftOperand, rightOperand));
                    }
                }
            }
            while (stack.Count > 1) {
                leftOperand = stack.Pop();
                rightOperand = stack.Pop();
                stack.Push(new Disjunction(leftOperand, rightOperand));
            }
            if (stack.Count > 0) {
                var proposition = stack.Pop();
                return proposition;
            }
            return null;
        }


    }
}
