namespace Logix {
    partial class Logix {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.input = new System.Windows.Forms.TextBox();
            this.labelInput = new System.Windows.Forms.Label();
            this.buttonRead = new System.Windows.Forms.Button();
            this.buttonVisualize = new System.Windows.Forms.Button();
            this.labelInfix = new System.Windows.Forms.Label();
            this.labelVariables = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.truthTable = new System.Windows.Forms.DataGridView();
            this.labelTruthTable = new System.Windows.Forms.Label();
            this.labelHexCode = new System.Windows.Forms.Label();
            this.simplifiedTruthTable = new System.Windows.Forms.DataGridView();
            this.labelSimplifiedTruthTable = new System.Windows.Forms.Label();
            this.labelDisjuncSimple = new System.Windows.Forms.Label();
            this.labelDisjuncNormal = new System.Windows.Forms.Label();
            this.listBoxDisjuncNormal = new System.Windows.Forms.ListBox();
            this.listBoxDisjuncSimple = new System.Windows.Forms.ListBox();
            this.textBoxInfix = new System.Windows.Forms.TextBox();
            this.textBoxVariables = new System.Windows.Forms.TextBox();
            this.textBoxHexCode = new System.Windows.Forms.TextBox();
            this.listBoxNand = new System.Windows.Forms.ListBox();
            this.labelNand = new System.Windows.Forms.Label();
            this.groupBoxPropositions = new System.Windows.Forms.GroupBox();
            this.groupBoxPredicates = new System.Windows.Forms.GroupBox();
            this.textBoxReplaceVariable = new System.Windows.Forms.TextBox();
            this.listBoxUnboundVariables = new System.Windows.Forms.ListBox();
            this.listBoxBoundVariables = new System.Windows.Forms.ListBox();
            this.buttonReplaceVariable = new System.Windows.Forms.Button();
            this.labelUnboundVariables = new System.Windows.Forms.Label();
            this.labelBoundVariables = new System.Windows.Forms.Label();
            this.buttonSTableaux = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.truthTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simplifiedTruthTable)).BeginInit();
            this.groupBoxPropositions.SuspendLayout();
            this.groupBoxPredicates.SuspendLayout();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input.Location = new System.Drawing.Point(181, 13);
            this.input.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(415, 30);
            this.input.TabIndex = 0;
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInput.Location = new System.Drawing.Point(12, 16);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(136, 25);
            this.labelInput.TabIndex = 1;
            this.labelInput.Text = "Prefix formula:";
            // 
            // buttonRead
            // 
            this.buttonRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRead.Location = new System.Drawing.Point(602, 11);
            this.buttonRead.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(150, 34);
            this.buttonRead.TabIndex = 2;
            this.buttonRead.Text = "Read";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.ButtonRead_Click);
            // 
            // buttonVisualize
            // 
            this.buttonVisualize.Enabled = false;
            this.buttonVisualize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVisualize.Location = new System.Drawing.Point(758, 11);
            this.buttonVisualize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonVisualize.Name = "buttonVisualize";
            this.buttonVisualize.Size = new System.Drawing.Size(150, 34);
            this.buttonVisualize.TabIndex = 3;
            this.buttonVisualize.Text = "Visualize";
            this.buttonVisualize.UseMnemonic = false;
            this.buttonVisualize.UseVisualStyleBackColor = true;
            this.buttonVisualize.Click += new System.EventHandler(this.ButtonVisualize_Click);
            // 
            // labelInfix
            // 
            this.labelInfix.AutoSize = true;
            this.labelInfix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfix.Location = new System.Drawing.Point(12, 66);
            this.labelInfix.Name = "labelInfix";
            this.labelInfix.Size = new System.Drawing.Size(122, 25);
            this.labelInfix.TabIndex = 4;
            this.labelInfix.Text = "Infix formula:";
            // 
            // labelVariables
            // 
            this.labelVariables.AutoSize = true;
            this.labelVariables.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVariables.Location = new System.Drawing.Point(12, 116);
            this.labelVariables.Name = "labelVariables";
            this.labelVariables.Size = new System.Drawing.Size(100, 25);
            this.labelVariables.TabIndex = 6;
            this.labelVariables.Text = "Variables:";
            // 
            // buttonClear
            // 
            this.buttonClear.Enabled = false;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(1070, 11);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(100, 34);
            this.buttonClear.TabIndex = 8;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // truthTable
            // 
            this.truthTable.AllowUserToAddRows = false;
            this.truthTable.AllowUserToDeleteRows = false;
            this.truthTable.AllowUserToResizeColumns = false;
            this.truthTable.AllowUserToResizeRows = false;
            this.truthTable.BackgroundColor = System.Drawing.SystemColors.Window;
            this.truthTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.truthTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.truthTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.truthTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.truthTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.truthTable.GridColor = System.Drawing.SystemColors.Control;
            this.truthTable.Location = new System.Drawing.Point(14, 352);
            this.truthTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.truthTable.MultiSelect = false;
            this.truthTable.Name = "truthTable";
            this.truthTable.ReadOnly = true;
            this.truthTable.RowHeadersVisible = false;
            this.truthTable.RowTemplate.Height = 24;
            this.truthTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.truthTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.truthTable.Size = new System.Drawing.Size(400, 272);
            this.truthTable.TabIndex = 9;
            this.truthTable.SelectionChanged += new System.EventHandler(this.DataGridView1_SelectionChanged);
            // 
            // labelTruthTable
            // 
            this.labelTruthTable.AutoSize = true;
            this.labelTruthTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTruthTable.Location = new System.Drawing.Point(9, 325);
            this.labelTruthTable.Name = "labelTruthTable";
            this.labelTruthTable.Size = new System.Drawing.Size(111, 25);
            this.labelTruthTable.TabIndex = 10;
            this.labelTruthTable.Text = "Truth table:";
            // 
            // labelHexCode
            // 
            this.labelHexCode.AutoSize = true;
            this.labelHexCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHexCode.Location = new System.Drawing.Point(9, 275);
            this.labelHexCode.Name = "labelHexCode";
            this.labelHexCode.Size = new System.Drawing.Size(101, 25);
            this.labelHexCode.TabIndex = 11;
            this.labelHexCode.Text = "Hex code:";
            // 
            // simplifiedTruthTable
            // 
            this.simplifiedTruthTable.AllowUserToAddRows = false;
            this.simplifiedTruthTable.AllowUserToDeleteRows = false;
            this.simplifiedTruthTable.AllowUserToResizeColumns = false;
            this.simplifiedTruthTable.AllowUserToResizeRows = false;
            this.simplifiedTruthTable.BackgroundColor = System.Drawing.SystemColors.Window;
            this.simplifiedTruthTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.simplifiedTruthTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.simplifiedTruthTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.simplifiedTruthTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.simplifiedTruthTable.DefaultCellStyle = dataGridViewCellStyle4;
            this.simplifiedTruthTable.GridColor = System.Drawing.SystemColors.Control;
            this.simplifiedTruthTable.Location = new System.Drawing.Point(420, 352);
            this.simplifiedTruthTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simplifiedTruthTable.MultiSelect = false;
            this.simplifiedTruthTable.Name = "simplifiedTruthTable";
            this.simplifiedTruthTable.ReadOnly = true;
            this.simplifiedTruthTable.RowHeadersVisible = false;
            this.simplifiedTruthTable.RowTemplate.Height = 24;
            this.simplifiedTruthTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.simplifiedTruthTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.simplifiedTruthTable.Size = new System.Drawing.Size(400, 272);
            this.simplifiedTruthTable.TabIndex = 13;
            this.simplifiedTruthTable.SelectionChanged += new System.EventHandler(this.DataGridView2_SelectionChanged);
            // 
            // labelSimplifiedTruthTable
            // 
            this.labelSimplifiedTruthTable.AutoSize = true;
            this.labelSimplifiedTruthTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSimplifiedTruthTable.Location = new System.Drawing.Point(415, 325);
            this.labelSimplifiedTruthTable.Name = "labelSimplifiedTruthTable";
            this.labelSimplifiedTruthTable.Size = new System.Drawing.Size(192, 25);
            this.labelSimplifiedTruthTable.TabIndex = 14;
            this.labelSimplifiedTruthTable.Text = "Simplified truth table:";
            // 
            // labelDisjuncSimple
            // 
            this.labelDisjuncSimple.AutoSize = true;
            this.labelDisjuncSimple.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDisjuncSimple.Location = new System.Drawing.Point(9, 125);
            this.labelDisjuncSimple.Name = "labelDisjuncSimple";
            this.labelDisjuncSimple.Size = new System.Drawing.Size(143, 25);
            this.labelDisjuncSimple.TabIndex = 18;
            this.labelDisjuncSimple.Text = "Disjunc simple:";
            // 
            // labelDisjuncNormal
            // 
            this.labelDisjuncNormal.AutoSize = true;
            this.labelDisjuncNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDisjuncNormal.Location = new System.Drawing.Point(9, 50);
            this.labelDisjuncNormal.Name = "labelDisjuncNormal";
            this.labelDisjuncNormal.Size = new System.Drawing.Size(146, 25);
            this.labelDisjuncNormal.TabIndex = 16;
            this.labelDisjuncNormal.Text = "Disjunc normal:";
            // 
            // listBoxDisjuncNormal
            // 
            this.listBoxDisjuncNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxDisjuncNormal.FormattingEnabled = true;
            this.listBoxDisjuncNormal.HorizontalScrollbar = true;
            this.listBoxDisjuncNormal.ItemHeight = 25;
            this.listBoxDisjuncNormal.Location = new System.Drawing.Point(178, 50);
            this.listBoxDisjuncNormal.Name = "listBoxDisjuncNormal";
            this.listBoxDisjuncNormal.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxDisjuncNormal.Size = new System.Drawing.Size(642, 54);
            this.listBoxDisjuncNormal.TabIndex = 21;
            // 
            // listBoxDisjuncSimple
            // 
            this.listBoxDisjuncSimple.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxDisjuncSimple.FormattingEnabled = true;
            this.listBoxDisjuncSimple.HorizontalScrollbar = true;
            this.listBoxDisjuncSimple.ItemHeight = 25;
            this.listBoxDisjuncSimple.Location = new System.Drawing.Point(178, 125);
            this.listBoxDisjuncSimple.Name = "listBoxDisjuncSimple";
            this.listBoxDisjuncSimple.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxDisjuncSimple.Size = new System.Drawing.Size(642, 54);
            this.listBoxDisjuncSimple.TabIndex = 22;
            // 
            // textBoxInfix
            // 
            this.textBoxInfix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInfix.Location = new System.Drawing.Point(181, 63);
            this.textBoxInfix.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxInfix.Name = "textBoxInfix";
            this.textBoxInfix.Size = new System.Drawing.Size(989, 30);
            this.textBoxInfix.TabIndex = 23;
            // 
            // textBoxVariables
            // 
            this.textBoxVariables.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVariables.Location = new System.Drawing.Point(181, 113);
            this.textBoxVariables.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxVariables.Name = "textBoxVariables";
            this.textBoxVariables.Size = new System.Drawing.Size(989, 30);
            this.textBoxVariables.TabIndex = 24;
            // 
            // textBoxHexCode
            // 
            this.textBoxHexCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHexCode.Location = new System.Drawing.Point(178, 272);
            this.textBoxHexCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxHexCode.Name = "textBoxHexCode";
            this.textBoxHexCode.Size = new System.Drawing.Size(642, 30);
            this.textBoxHexCode.TabIndex = 25;
            // 
            // listBoxNand
            // 
            this.listBoxNand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxNand.FormattingEnabled = true;
            this.listBoxNand.HorizontalScrollbar = true;
            this.listBoxNand.ItemHeight = 25;
            this.listBoxNand.Location = new System.Drawing.Point(178, 200);
            this.listBoxNand.Name = "listBoxNand";
            this.listBoxNand.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxNand.Size = new System.Drawing.Size(642, 54);
            this.listBoxNand.TabIndex = 27;
            // 
            // labelNand
            // 
            this.labelNand.AutoSize = true;
            this.labelNand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNand.Location = new System.Drawing.Point(9, 200);
            this.labelNand.Name = "labelNand";
            this.labelNand.Size = new System.Drawing.Size(74, 25);
            this.labelNand.TabIndex = 26;
            this.labelNand.Text = "NAND:";
            // 
            // groupBoxPropositions
            // 
            this.groupBoxPropositions.Controls.Add(this.listBoxNand);
            this.groupBoxPropositions.Controls.Add(this.truthTable);
            this.groupBoxPropositions.Controls.Add(this.labelNand);
            this.groupBoxPropositions.Controls.Add(this.labelTruthTable);
            this.groupBoxPropositions.Controls.Add(this.textBoxHexCode);
            this.groupBoxPropositions.Controls.Add(this.labelHexCode);
            this.groupBoxPropositions.Controls.Add(this.simplifiedTruthTable);
            this.groupBoxPropositions.Controls.Add(this.labelSimplifiedTruthTable);
            this.groupBoxPropositions.Controls.Add(this.listBoxDisjuncSimple);
            this.groupBoxPropositions.Controls.Add(this.labelDisjuncNormal);
            this.groupBoxPropositions.Controls.Add(this.listBoxDisjuncNormal);
            this.groupBoxPropositions.Controls.Add(this.labelDisjuncSimple);
            this.groupBoxPropositions.Enabled = false;
            this.groupBoxPropositions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPropositions.Location = new System.Drawing.Point(17, 166);
            this.groupBoxPropositions.Name = "groupBoxPropositions";
            this.groupBoxPropositions.Size = new System.Drawing.Size(836, 650);
            this.groupBoxPropositions.TabIndex = 28;
            this.groupBoxPropositions.TabStop = false;
            this.groupBoxPropositions.Text = "Propositions";
            // 
            // groupBoxPredicates
            // 
            this.groupBoxPredicates.Controls.Add(this.textBoxReplaceVariable);
            this.groupBoxPredicates.Controls.Add(this.listBoxUnboundVariables);
            this.groupBoxPredicates.Controls.Add(this.listBoxBoundVariables);
            this.groupBoxPredicates.Controls.Add(this.buttonReplaceVariable);
            this.groupBoxPredicates.Controls.Add(this.labelUnboundVariables);
            this.groupBoxPredicates.Controls.Add(this.labelBoundVariables);
            this.groupBoxPredicates.Enabled = false;
            this.groupBoxPredicates.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPredicates.Location = new System.Drawing.Point(860, 166);
            this.groupBoxPredicates.Name = "groupBoxPredicates";
            this.groupBoxPredicates.Size = new System.Drawing.Size(310, 650);
            this.groupBoxPredicates.TabIndex = 29;
            this.groupBoxPredicates.TabStop = false;
            this.groupBoxPredicates.Text = "Predicates && Quantifiers";
            // 
            // textBoxReplaceVariable
            // 
            this.textBoxReplaceVariable.Location = new System.Drawing.Point(20, 352);
            this.textBoxReplaceVariable.Name = "textBoxReplaceVariable";
            this.textBoxReplaceVariable.Size = new System.Drawing.Size(144, 30);
            this.textBoxReplaceVariable.TabIndex = 36;
            // 
            // listBoxUnboundVariables
            // 
            this.listBoxUnboundVariables.FormattingEnabled = true;
            this.listBoxUnboundVariables.ItemHeight = 25;
            this.listBoxUnboundVariables.Location = new System.Drawing.Point(20, 229);
            this.listBoxUnboundVariables.Name = "listBoxUnboundVariables";
            this.listBoxUnboundVariables.Size = new System.Drawing.Size(270, 104);
            this.listBoxUnboundVariables.TabIndex = 34;
            // 
            // listBoxBoundVariables
            // 
            this.listBoxBoundVariables.FormattingEnabled = true;
            this.listBoxBoundVariables.ItemHeight = 25;
            this.listBoxBoundVariables.Location = new System.Drawing.Point(20, 79);
            this.listBoxBoundVariables.Name = "listBoxBoundVariables";
            this.listBoxBoundVariables.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxBoundVariables.Size = new System.Drawing.Size(270, 104);
            this.listBoxBoundVariables.TabIndex = 33;
            // 
            // buttonReplaceVariable
            // 
            this.buttonReplaceVariable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReplaceVariable.Location = new System.Drawing.Point(170, 350);
            this.buttonReplaceVariable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonReplaceVariable.Name = "buttonReplaceVariable";
            this.buttonReplaceVariable.Size = new System.Drawing.Size(120, 34);
            this.buttonReplaceVariable.TabIndex = 32;
            this.buttonReplaceVariable.Text = "Replace";
            this.buttonReplaceVariable.UseVisualStyleBackColor = true;
            this.buttonReplaceVariable.Click += new System.EventHandler(this.ButtonReplaceVariable_Click);
            // 
            // labelUnboundVariables
            // 
            this.labelUnboundVariables.AutoSize = true;
            this.labelUnboundVariables.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUnboundVariables.Location = new System.Drawing.Point(15, 200);
            this.labelUnboundVariables.Name = "labelUnboundVariables";
            this.labelUnboundVariables.Size = new System.Drawing.Size(181, 25);
            this.labelUnboundVariables.TabIndex = 29;
            this.labelUnboundVariables.Text = "Unbound variables:";
            // 
            // labelBoundVariables
            // 
            this.labelBoundVariables.AutoSize = true;
            this.labelBoundVariables.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBoundVariables.Location = new System.Drawing.Point(15, 50);
            this.labelBoundVariables.Name = "labelBoundVariables";
            this.labelBoundVariables.Size = new System.Drawing.Size(158, 25);
            this.labelBoundVariables.TabIndex = 28;
            this.labelBoundVariables.Text = "Bound variables:";
            // 
            // buttonSTableaux
            // 
            this.buttonSTableaux.Enabled = false;
            this.buttonSTableaux.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSTableaux.Location = new System.Drawing.Point(914, 11);
            this.buttonSTableaux.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSTableaux.Name = "buttonSTableaux";
            this.buttonSTableaux.Size = new System.Drawing.Size(150, 34);
            this.buttonSTableaux.TabIndex = 30;
            this.buttonSTableaux.Text = "S.Tableaux";
            this.buttonSTableaux.UseMnemonic = false;
            this.buttonSTableaux.UseVisualStyleBackColor = true;
            this.buttonSTableaux.Click += new System.EventHandler(this.ButtonSTableaux_Click);
            // 
            // Logix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 853);
            this.Controls.Add(this.buttonSTableaux);
            this.Controls.Add(this.groupBoxPredicates);
            this.Controls.Add(this.textBoxVariables);
            this.Controls.Add(this.textBoxInfix);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.labelVariables);
            this.Controls.Add(this.labelInfix);
            this.Controls.Add(this.buttonVisualize);
            this.Controls.Add(this.buttonRead);
            this.Controls.Add(this.labelInput);
            this.Controls.Add(this.input);
            this.Controls.Add(this.groupBoxPropositions);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Logix";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.truthTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simplifiedTruthTable)).EndInit();
            this.groupBoxPropositions.ResumeLayout(false);
            this.groupBoxPropositions.PerformLayout();
            this.groupBoxPredicates.ResumeLayout(false);
            this.groupBoxPredicates.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.Button buttonVisualize;
        private System.Windows.Forms.Label labelInfix;
        private System.Windows.Forms.Label labelVariables;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.DataGridView truthTable;
        private System.Windows.Forms.Label labelTruthTable;
        private System.Windows.Forms.Label labelHexCode;
        private System.Windows.Forms.DataGridView simplifiedTruthTable;
        private System.Windows.Forms.Label labelSimplifiedTruthTable;
        private System.Windows.Forms.Label labelDisjuncSimple;
        private System.Windows.Forms.Label labelDisjuncNormal;
        private System.Windows.Forms.ListBox listBoxDisjuncNormal;
        private System.Windows.Forms.ListBox listBoxDisjuncSimple;
        private System.Windows.Forms.TextBox textBoxInfix;
        private System.Windows.Forms.TextBox textBoxVariables;
        private System.Windows.Forms.TextBox textBoxHexCode;
        private System.Windows.Forms.ListBox listBoxNand;
        private System.Windows.Forms.Label labelNand;
        private System.Windows.Forms.GroupBox groupBoxPropositions;
        private System.Windows.Forms.GroupBox groupBoxPredicates;
        private System.Windows.Forms.Button buttonSTableaux;
        private System.Windows.Forms.Label labelBoundVariables;
        private System.Windows.Forms.Button buttonReplaceVariable;
        private System.Windows.Forms.Label labelUnboundVariables;
        private System.Windows.Forms.TextBox textBoxReplaceVariable;
        private System.Windows.Forms.ListBox listBoxUnboundVariables;
        private System.Windows.Forms.ListBox listBoxBoundVariables;
    }
}

