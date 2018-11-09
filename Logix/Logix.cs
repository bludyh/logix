using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Logix {
    public partial class Logix : Form {

        Proposition proposition;

        public Logix() {
            InitializeComponent();
        }

        private void ButtonRead_Click(object sender, EventArgs e) {
            try {
                // Update form
                textBoxInfix.Text = "";
                textBoxVariables.Text = "";
                groupBoxPropositions.Enabled = false;
                listBoxDisjuncNormal.Items.Clear();
                listBoxDisjuncSimple.Items.Clear();
                listBoxNand.Items.Clear();
                textBoxHexCode.Text = "";
                truthTable.Columns.Clear();
                truthTable.Rows.Clear();
                simplifiedTruthTable.Columns.Clear();
                simplifiedTruthTable.Rows.Clear();
                groupBoxPredicates.Enabled = false;
                listBoxBoundVariables.Items.Clear();
                listBoxUnboundVariables.Items.Clear();
                textBoxReplaceVariable.Text = "";
                buttonVisualize.Enabled = true;
                buttonSTableaux.Enabled = true;
                buttonClear.Enabled = true;

                // Create proposition from user input
                proposition = Parser.Parse(input.Text);

                // Show infix formula
                textBoxInfix.Text = proposition.ToString();

                // Show variables
                proposition.Variables.Sort();
                foreach (var variable in proposition.Variables) {
                    textBoxVariables.Text += variable + " ";
                }

                if (!proposition.IsPredicate) {
                    // Enable propositions panel
                    groupBoxPropositions.Enabled = true;

                    // Show truth table
                    var table = proposition.CreateTruthTable();
                    foreach (var variable in table.Variables) {
                        truthTable.Columns.Add(variable.ToString(), variable.ToString());
                    }
                    truthTable.Columns.Add(proposition.ToString(), proposition.ToString());
                    foreach (var row in table.Data) {
                        truthTable.Rows.Add(row);
                    }
                    foreach (DataGridViewColumn col in truthTable.Columns) {
                        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        col.SortMode = DataGridViewColumnSortMode.NotSortable;
                    }
                    truthTable.Columns[truthTable.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                    // Show simplified truth table
                    var smpfdTable = table.Simplify();
                    foreach (var variable in smpfdTable.Variables) {
                        simplifiedTruthTable.Columns.Add(variable.ToString(), variable.ToString());
                    }
                    simplifiedTruthTable.Columns.Add(proposition.ToString(), proposition.ToString());
                    foreach (var row in smpfdTable.Data) {
                        simplifiedTruthTable.Rows.Add(row);
                    }

                    foreach (DataGridViewColumn col in simplifiedTruthTable.Columns) {
                        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        col.SortMode = DataGridViewColumnSortMode.NotSortable;
                    }
                    simplifiedTruthTable.Columns[simplifiedTruthTable.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                    // Show disjunctive normal formula
                    var disjuncNormal = table.CreateDisjunctiveFormula();
                    if (disjuncNormal != null) {
                        listBoxDisjuncNormal.Items.Add(disjuncNormal);
                    }

                    // Show disjunctive simple formula
                    var disjuncSimple = smpfdTable.CreateDisjunctiveFormula();
                    if (disjuncSimple != null) {
                        listBoxDisjuncSimple.Items.Add(disjuncSimple);
                    }

                    // Show NAND formula
                    var nand = proposition.Nandify();
                    listBoxNand.Items.Add(nand);

                    // Generate hex code
                    string result = "";
                    for (int i = table.Data.Count - 1; i >= 0; i--) {
                        result += table.Data[i][table.Data[0].Length - 1];
                    }
                    textBoxHexCode.Text = Convert.ToInt32(result, 2).ToString("X");
                }
                else {
                    // Enable predicates panel
                    groupBoxPredicates.Enabled = true;

                    // Show bound variables
                    Parser.BoundVariables.Sort();
                    foreach (var variable in Parser.BoundVariables) {
                        listBoxBoundVariables.Items.Add(variable);
                    }

                    // Show unbound variables
                    var unboundVariables = proposition.Variables.Except(Parser.BoundVariables).ToList();
                    unboundVariables.Sort();
                    foreach (var variable in unboundVariables) {
                        listBoxUnboundVariables.Items.Add(variable);
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
                ResetForm();
            }
        }

        private void ButtonVisualize_Click(object sender, EventArgs e) {
            try {
                int index = 1;
                string str = "graph logic { \r\nnode [ fontname = \"Sans serif\" ] " + proposition.CreateGraph(ref index) + "\r\n}";
                File.WriteAllText(@"visualization.dot", str);

                Process dot = new Process();
                dot.StartInfo.FileName = @"dot.exe";
                dot.StartInfo.Arguments = "-Tpng -ovisualization.png visualization.dot";
                dot.Start();
                dot.WaitForExit();

                Process.Start(@"visualization.png");
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
                ResetForm();
            }
        }
        private void ButtonSTableaux_Click(object sender, EventArgs e) {
            try {
                int index = 1;
                var tableaux = new SemanticTableau(new HashSet<Proposition> { new Negation(proposition) });
                tableaux.CreateSemanticTableaux();
                string str = "graph logic { \r\nnode [ shape=box, fontname = \"Sans serif\" ] " + tableaux.CreateGraph(ref index) + "\r\n}";
                File.WriteAllText(@"tableaux.dot", str);

                Process dot = new Process();
                dot.StartInfo.FileName = @"dot.exe";
                dot.StartInfo.Arguments = "-Tpng -otableaux.png tableaux.dot";
                dot.Start();
                dot.WaitForExit();

                Process.Start(@"tableaux.png");
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
                ResetForm();
            }
        }

        private void ButtonClear_Click(object sender, EventArgs e) {
            ResetForm();
        }

        private void ButtonReplaceVariable_Click(object sender, EventArgs e) {
            if (listBoxUnboundVariables.SelectedItem != null && !String.IsNullOrWhiteSpace(textBoxReplaceVariable.Text)) {
                var unboundVariable = (Variable)listBoxUnboundVariables.SelectedItem;
                unboundVariable.Letter = textBoxReplaceVariable.Text[0];
                // Clear old fields
                input.Text = "";
                textBoxInfix.Text = "";
                textBoxVariables.Text = "";
                listBoxBoundVariables.Items.Clear();
                listBoxUnboundVariables.Items.Clear();
                listBoxUnboundVariables.SelectedIndex = -1;
                textBoxReplaceVariable.Text = "";

                // Show new infix formula
                textBoxInfix.Text = proposition.ToString();

                // Show new variables
                proposition.Variables.Sort();
                foreach (var variable in proposition.Variables) {
                    textBoxVariables.Text += variable + " ";
                }

                // Show new bound variables
                Parser.BoundVariables.Sort();
                foreach (var variable in Parser.BoundVariables) {
                    listBoxBoundVariables.Items.Add(variable);
                }

                // Show new unbound variables
                var unboundVariables = proposition.Variables.Except(Parser.BoundVariables).ToList();
                unboundVariables.Sort();
                foreach (var variable in unboundVariables) {
                    listBoxUnboundVariables.Items.Add(variable);
                }
            }
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e) {
            truthTable.ClearSelection();
        }

        private void DataGridView2_SelectionChanged(object sender, EventArgs e) {
            simplifiedTruthTable.ClearSelection();
        }

        private void ResetForm() {
            input.Text = "";
            textBoxInfix.Text = "";
            textBoxVariables.Text = "";
            groupBoxPropositions.Enabled = false;
            listBoxDisjuncNormal.Items.Clear();
            listBoxDisjuncSimple.Items.Clear();
            listBoxNand.Items.Clear();
            textBoxHexCode.Text = "";
            truthTable.Columns.Clear();
            truthTable.Rows.Clear();
            simplifiedTruthTable.Columns.Clear();
            simplifiedTruthTable.Rows.Clear();
            groupBoxPredicates.Enabled = false;
            listBoxBoundVariables.Items.Clear();
            listBoxUnboundVariables.Items.Clear();
            textBoxReplaceVariable.Text = "";
            buttonVisualize.Enabled = false;
            buttonSTableaux.Enabled = false;
            buttonClear.Enabled = false;
            input.Focus();
        }

    }
}
