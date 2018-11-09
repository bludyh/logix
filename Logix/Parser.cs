using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix {
    static class Parser {

        private static readonly char[] ignoreChars;
        private static readonly Stack<Proposition> stack;
        private static bool isPredicate;

        public static List<Variable> Variables { get; private set; }
        public static List<Variable> BoundVariables { get; private set; }

        static Parser() {
            ignoreChars = new char[] { ' ', '(', ')', ',', '.' };
            stack = new Stack<Proposition>();
        }

        public static Proposition Parse(string input) {
            Proposition operand;
            Proposition leftOperand;
            Proposition rightOperand;
            Variables = new List<Variable>();
            BoundVariables = new List<Variable>();
            isPredicate = false;

            for (int i = input.Length - 1; i >= 0; i--) {
                char token = input[i];
                if (!ignoreChars.Contains(token)) {
                    switch (token) {
                        case '~':
                            operand = stack.Pop();
                            stack.Push(new Negation(operand));
                            break;
                        case '&':
                            leftOperand = stack.Pop();
                            rightOperand = stack.Pop();
                            stack.Push(new Conjunction(leftOperand, rightOperand));
                            break;
                        case '|':
                            leftOperand = stack.Pop();
                            rightOperand = stack.Pop();
                            stack.Push(new Disjunction(leftOperand, rightOperand));
                            break;
                        case '>':
                            leftOperand = stack.Pop();
                            rightOperand = stack.Pop();
                            stack.Push(new Implication(leftOperand, rightOperand));
                            break;
                        case '=':
                            leftOperand = stack.Pop();
                            rightOperand = stack.Pop();
                            stack.Push(new BiImplication(leftOperand, rightOperand));
                            break;
                        case '%':
                            leftOperand = stack.Pop();
                            rightOperand = stack.Pop();
                            stack.Push(new NotAnd(leftOperand, rightOperand));
                            break;
                        case '1':
                            stack.Push(new True());
                            break;
                        case '0':
                            stack.Push(new False());
                            break;
                        case char letter when (letter >= 'A' && letter <= 'Z'):
                            if (isPredicate) {
                                var objectVariables = new List<Variable>();
                                while (stack.Count > 0 && stack.Peek() is Variable v) {
                                    stack.Pop();
                                    objectVariables.Add(v);
                                }
                                stack.Push(new Predicate(letter, objectVariables));
                            }
                            else {
                                var variable = GetVariable(letter);
                                if (variable == null) {
                                    variable = new Variable(letter);
                                    Variables.Add(variable);
                                }
                                stack.Push(variable);
                            }
                            break;
                        case char letter when (letter >= 'a' && letter <= 'z'):
                            isPredicate = true;
                            var objectVariable = GetVariable(letter);
                            if (objectVariable == null) {
                                objectVariable = new Variable(letter);
                                Variables.Add(objectVariable);
                            }
                            stack.Push(objectVariable);
                            break;
                        case '@':
                        case '!':
                            var boundVariables = new List<Variable>();
                            while (stack.Count > 0 && stack.Peek() is Variable v) {
                                stack.Pop();
                                boundVariables.Add(v);
                            }
                            operand = stack.Pop();
                            if (token == '@') {
                                stack.Push(new Universal(operand, boundVariables));
                            }
                            else {
                                stack.Push(new Existential(operand, boundVariables));
                            }
                            BoundVariables = BoundVariables.Union(boundVariables).ToList();
                            break;
                        default:
                            throw new InvalidLogicalNotationException("The provided logical notation is invalid.");
                    }
                }
            }
            if (stack.Count > 0) {
                var proposition = stack.Pop();
                proposition.Variables = Variables;
                proposition.IsPredicate = isPredicate;
                return proposition;
            }
            return null;
        }

        private static Variable GetVariable(char letter) {
            foreach (var variable in Variables) {
                if (variable.Letter == letter) {
                    return variable;
                }
            }
            return null;
        }


    }
}
