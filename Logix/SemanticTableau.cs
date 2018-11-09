using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix {
    class SemanticTableau {

        private static readonly Stack<SemanticTableau> stack;
        private static char variableName;

        public HashSet<Proposition> CurrentNode { get; private set; }
        public List<SemanticTableau> ChildrenNodes { get; private set; }
        public List<Variable> ActiveVariables { get; private set; }
        public List<Proposition> PropositionsProcessedByGamma { get; private set; }

        static SemanticTableau() {
            stack = new Stack<SemanticTableau>();
        }

        public SemanticTableau(HashSet<Proposition> set, List<Variable> activeVariables = null, List<Proposition> propositionsProcessedByGamma = null) {
            CurrentNode = set;
            ChildrenNodes = new List<SemanticTableau>();
            ActiveVariables = (activeVariables != null) ? new List<Variable>(activeVariables) : new List<Variable>();
            PropositionsProcessedByGamma = (propositionsProcessedByGamma != null) ? new List<Proposition>(propositionsProcessedByGamma) : new List<Proposition>();
        }

        public override string ToString() {
            return String.Format("{{ {0} }}", String.Join(", ", CurrentNode));
        }

        public string CreateGraph(ref int index, int preIndex = 0) {
            string graph = String.Format(Environment.NewLine + "node{0} [ label = \"{1} [{2}]\" ]", index, ToString(), String.Join(", ", ActiveVariables));
            int pre = index;

            if (preIndex != 0) {
                graph += String.Format(Environment.NewLine + "node{0} -- node{1}", preIndex, index);
            }

            if (IsClosedNode()) {
                index++;
                graph += String.Format(Environment.NewLine + "node{0} [ label = \"X\" ]", index);
                graph += String.Format(Environment.NewLine + "node{0} -- node{1}", pre, index);
            }

            index++;
            foreach (var node in ChildrenNodes) {
                graph += node.CreateGraph(ref index, pre);
            }

            return graph;
        }

        public bool IsClosedNode() {
            if (ChildrenNodes.Count == 0) {
                foreach (var prop in CurrentNode) {
                    if (CurrentNode.Any(p => p.ToString() == new Negation(prop).ToString())) {
                        return true;
                    }
                }
            }
            return false;
        }

        public void CreateSemanticTableaux() {
            variableName = 'a';
            PropositionsProcessedByGamma = new List<Proposition>();
            stack.Push(this);
            while (stack.Count > 0) {
                var tableau = stack.Pop();
                if (tableau.ApplyAlphaRule() || tableau.ApplyDeltaRule() || tableau.ApplyBetaRule() || tableau.ApplyGammaRule()) {
                    continue;
                }
            }
        }

        public bool ApplyAlphaRule() {
            foreach (var prop in CurrentNode) {
                var set = new HashSet<Proposition>(CurrentNode);
                set.Remove(prop);
                if (prop is Negation n && n.Operand is Negation n1) {
                    set.Add(n1.Operand);
                    var tableau = new SemanticTableau(set, ActiveVariables, PropositionsProcessedByGamma);
                    ChildrenNodes.Add(tableau);
                    stack.Push(tableau);
                    return true;
                }
                else if (prop is Conjunction c) {
                    set.Add(c.LeftOperand);
                    set.Add(c.RightOperand);
                    var tableau = new SemanticTableau(set, ActiveVariables, PropositionsProcessedByGamma);
                    ChildrenNodes.Add(tableau);
                    stack.Push(tableau);
                    return true;
                }
                else if (prop is Negation n2 && n2.Operand is Disjunction d) {
                    set.Add(new Negation(d.LeftOperand));
                    set.Add(new Negation(d.RightOperand));
                    var tableau = new SemanticTableau(set, ActiveVariables, PropositionsProcessedByGamma);
                    ChildrenNodes.Add(tableau);
                    stack.Push(tableau);
                    return true;
                }
                else if (prop is Negation n3 && n3.Operand is Implication i) {
                    set.Add(i.LeftOperand);
                    set.Add(new Negation(i.RightOperand));
                    var tableau = new SemanticTableau(set, ActiveVariables, PropositionsProcessedByGamma);
                    ChildrenNodes.Add(tableau);
                    stack.Push(tableau);
                    return true;
                }
            }
            return false;
        }

        public bool ApplyBetaRule() {
            foreach (var prop in CurrentNode) {
                var set1 = new HashSet<Proposition>(CurrentNode);
                set1.Remove(prop);
                var set2 = new HashSet<Proposition>(CurrentNode);
                set2.Remove(prop);
                if (prop is Negation n5 && n5.Operand is Conjunction c1) {
                    set1.Add(new Negation(c1.LeftOperand));
                    var tableau1 = new SemanticTableau(set1, ActiveVariables, PropositionsProcessedByGamma);
                    ChildrenNodes.Add(tableau1);
                    stack.Push(tableau1);
                    set2.Add(new Negation(c1.RightOperand));
                    var tableau2 = new SemanticTableau(set2, ActiveVariables, PropositionsProcessedByGamma);
                    ChildrenNodes.Add(tableau2);
                    stack.Push(tableau2);
                    return true;
                }
                else if (prop is Disjunction d1) {
                    set1.Add(d1.LeftOperand);
                    var tableau1 = new SemanticTableau(set1, ActiveVariables, PropositionsProcessedByGamma);
                    ChildrenNodes.Add(tableau1);
                    stack.Push(tableau1);
                    set2.Add(d1.RightOperand);
                    var tableau2 = new SemanticTableau(set2, ActiveVariables, PropositionsProcessedByGamma);
                    ChildrenNodes.Add(tableau2);
                    stack.Push(tableau2);
                    return true;
                }
                else if (prop is Implication i1) {
                    set1.Add(new Negation(i1.LeftOperand));
                    var tableau1 = new SemanticTableau(set1, ActiveVariables, PropositionsProcessedByGamma);
                    ChildrenNodes.Add(tableau1);
                    stack.Push(tableau1);
                    set2.Add(i1.RightOperand);
                    var tableau2 = new SemanticTableau(set2, ActiveVariables, PropositionsProcessedByGamma);
                    ChildrenNodes.Add(tableau2);
                    stack.Push(tableau2);
                    return true;
                }
                else if (prop is BiImplication bi) {
                    set1.Add(bi.LeftOperand);
                    set1.Add(bi.RightOperand);
                    var tableau1 = new SemanticTableau(set1, ActiveVariables, PropositionsProcessedByGamma);
                    ChildrenNodes.Add(tableau1);
                    stack.Push(tableau1);
                    set2.Add(new Negation(bi.LeftOperand));
                    set2.Add(new Negation(bi.RightOperand));
                    var tableau2 = new SemanticTableau(set2, ActiveVariables, PropositionsProcessedByGamma);
                    ChildrenNodes.Add(tableau2);
                    stack.Push(tableau2);
                    return true;
                }
                else if (prop is Negation n6 && n6.Operand is BiImplication bi1) {
                    set1.Add(bi1.LeftOperand);
                    set1.Add(new Negation(bi1.RightOperand));
                    var tableau1 = new SemanticTableau(set1, ActiveVariables, PropositionsProcessedByGamma);
                    ChildrenNodes.Add(tableau1);
                    stack.Push(tableau1);
                    set2.Add(new Negation(bi1.LeftOperand));
                    set2.Add(bi1.RightOperand);
                    var tableau2 = new SemanticTableau(set2, ActiveVariables, PropositionsProcessedByGamma);
                    ChildrenNodes.Add(tableau2);
                    stack.Push(tableau2);
                    return true;
                }
            }
            return false;
        }

        public bool ApplyDeltaRule() {
            foreach (var prop in CurrentNode) {
                var set = new HashSet<Proposition>(CurrentNode);
                set.Remove(prop);
                if (prop is Existential x) {
                    var x1 = x.Copy();
                    set.Add(x1.Predicate);
                    var tableau = new SemanticTableau(set, ActiveVariables, PropositionsProcessedByGamma);
                    foreach (var variable in x1.BoundVariables) {
                        variable.Letter = variableName++;
                        tableau.ActiveVariables.Add(variable);
                    }
                    ChildrenNodes.Add(tableau);
                    stack.Push(tableau);
                    return true;
                }
                else if (prop is Negation n4 && n4.Operand is Universal u) {
                    var u2 = u.Copy();
                    set.Add(new Negation(u2.Predicate));
                    var tableau = new SemanticTableau(set, ActiveVariables, PropositionsProcessedByGamma);
                    foreach (var variable in u2.BoundVariables) {
                        variable.Letter = variableName++;
                        tableau.ActiveVariables.Add(variable);
                    }
                    ChildrenNodes.Add(tableau);
                    stack.Push(tableau);
                    return true;
                }
            }
            return false;
        }

        public bool ApplyGammaRule() {
            foreach (var prop in CurrentNode) {
                var set = new HashSet<Proposition>(CurrentNode);
                if (!PropositionsProcessedByGamma.Contains(prop) && prop is Universal u1) {
                    PropositionsProcessedByGamma.Add(prop);
                    var u2 = u1.Copy();
                    foreach (var variable in u2.BoundVariables) {
                        foreach (var activeVariable in ActiveVariables) {
                            variable.Letter = activeVariable.Letter;
                            var u3 = u2.Copy();
                            set.Add(u3.Predicate);
                        }
                    }
                    var tableau = new SemanticTableau(set, ActiveVariables, PropositionsProcessedByGamma);
                    ChildrenNodes.Add(tableau);
                    stack.Push(tableau);
                    return true;
                }
                else if (!PropositionsProcessedByGamma.Contains(prop) && prop is Negation n7 && n7.Operand is Existential x1) {
                    PropositionsProcessedByGamma.Add(prop);
                    var x2 = x1.Copy();
                    foreach (var variable in x2.BoundVariables) {
                        foreach (var activeVariable in ActiveVariables) {
                            variable.Letter = activeVariable.Letter;
                            var x3 = x2.Copy();
                            set.Add(new Negation(x3.Predicate));
                        }
                    }
                    var tableau = new SemanticTableau(set, ActiveVariables, PropositionsProcessedByGamma);
                    ChildrenNodes.Add(tableau);
                    stack.Push(tableau);
                    return true;
                }
            }
            return false;
        }

    }
}
