namespace TNTool
{
    partial class TNToolForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TNToolForm));
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.sortPage = new System.Windows.Forms.TabPage();
			this.label15 = new System.Windows.Forms.Label();
			this.sortClear = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.labelCount = new System.Windows.Forms.Label();
			this.sortHistoryList = new System.Windows.Forms.ComboBox();
			this.portoutFormatCheckBox = new System.Windows.Forms.CheckBox();
			this.sortRange = new System.Windows.Forms.Button();
			this.outputBox = new System.Windows.Forms.TextBox();
			this.sortSingle = new System.Windows.Forms.Button();
			this.inputBox = new System.Windows.Forms.TextBox();
			this.comparePage = new System.Windows.Forms.TabPage();
			this.compareCheckForMatch = new System.Windows.Forms.Button();
			this.label16 = new System.Windows.Forms.Label();
			this.compareClear = new System.Windows.Forms.Button();
			this.compareHistoryList = new System.Windows.Forms.ComboBox();
			this.compareButton = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.compareOutputNoMatch = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.compareOutputAllMatch = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.compareOutput2 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.compareOutput1 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.compareInput2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.compareInput1 = new System.Windows.Forms.TextBox();
			this.splitPage = new System.Windows.Forms.TabPage();
			this.label17 = new System.Windows.Forms.Label();
			this.splitAmountBox = new System.Windows.Forms.TextBox();
			this.splitClear = new System.Windows.Forms.Button();
			this.splitSplit = new System.Windows.Forms.Button();
			this.label11 = new System.Windows.Forms.Label();
			this.splitSplitList = new System.Windows.Forms.ComboBox();
			this.splitHistoryList = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.splitOutput = new System.Windows.Forms.TextBox();
			this.splitInput = new System.Windows.Forms.TextBox();
			this.telcoveToolsPage = new System.Windows.Forms.TabPage();
			this.label18 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.telcoveRemedyOutput = new System.Windows.Forms.TextBox();
			this.telcoveHistoryBox = new System.Windows.Forms.ComboBox();
			this.label13 = new System.Windows.Forms.Label();
			this.telcoveSwitchOutput = new System.Windows.Forms.TextBox();
			this.telcoveButton = new System.Windows.Forms.Button();
			this.label12 = new System.Windows.Forms.Label();
			this.telcoveInput = new System.Windows.Forms.TextBox();
			this.essTools = new System.Windows.Forms.TabPage();
			this.essPDelete = new System.Windows.Forms.RadioButton();
			this.label23 = new System.Windows.Forms.Label();
			this.essHistoryBox = new System.Windows.Forms.ComboBox();
			this.label22 = new System.Windows.Forms.Label();
			this.essOutput = new System.Windows.Forms.TextBox();
			this.essCustom = new System.Windows.Forms.RadioButton();
			this.essPSetTriggers = new System.Windows.Forms.RadioButton();
			this.essPSuspend = new System.Windows.Forms.RadioButton();
			this.label21 = new System.Windows.Forms.Label();
			this.essAfterBox = new System.Windows.Forms.TextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.essBeforeBox = new System.Windows.Forms.TextBox();
			this.essConvert = new System.Windows.Forms.Button();
			this.label19 = new System.Windows.Forms.Label();
			this.essInput = new System.Windows.Forms.TextBox();
			this.tabControl1.SuspendLayout();
			this.sortPage.SuspendLayout();
			this.comparePage.SuspendLayout();
			this.splitPage.SuspendLayout();
			this.telcoveToolsPage.SuspendLayout();
			this.essTools.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.sortPage);
			this.tabControl1.Controls.Add(this.comparePage);
			this.tabControl1.Controls.Add(this.splitPage);
			this.tabControl1.Controls.Add(this.telcoveToolsPage);
			this.tabControl1.Controls.Add(this.essTools);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(494, 455);
			this.tabControl1.TabIndex = 0;
			// 
			// sortPage
			// 
			this.sortPage.BackColor = System.Drawing.SystemColors.ControlLight;
			this.sortPage.Controls.Add(this.label15);
			this.sortPage.Controls.Add(this.sortClear);
			this.sortPage.Controls.Add(this.label3);
			this.sortPage.Controls.Add(this.label2);
			this.sortPage.Controls.Add(this.labelCount);
			this.sortPage.Controls.Add(this.sortHistoryList);
			this.sortPage.Controls.Add(this.portoutFormatCheckBox);
			this.sortPage.Controls.Add(this.sortRange);
			this.sortPage.Controls.Add(this.outputBox);
			this.sortPage.Controls.Add(this.sortSingle);
			this.sortPage.Controls.Add(this.inputBox);
			this.sortPage.Location = new System.Drawing.Point(4, 22);
			this.sortPage.Name = "sortPage";
			this.sortPage.Padding = new System.Windows.Forms.Padding(3);
			this.sortPage.Size = new System.Drawing.Size(486, 429);
			this.sortPage.TabIndex = 0;
			this.sortPage.Text = "Sort";
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(0, 387);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(483, 15);
			this.label15.TabIndex = 10;
			this.label15.Text = "History";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// sortClear
			// 
			this.sortClear.Location = new System.Drawing.Point(394, 185);
			this.sortClear.Name = "sortClear";
			this.sortClear.Size = new System.Drawing.Size(84, 75);
			this.sortClear.TabIndex = 9;
			this.sortClear.Text = "Clear";
			this.sortClear.UseVisualStyleBackColor = true;
			this.sortClear.Click += new System.EventHandler(this.sortClear_Click);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(202, 5);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(188, 15);
			this.label3.TabIndex = 8;
			this.label3.Text = "Output";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 5);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(188, 15);
			this.label2.TabIndex = 7;
			this.label2.Text = "Input";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelCount
			// 
			this.labelCount.Location = new System.Drawing.Point(394, 263);
			this.labelCount.Name = "labelCount";
			this.labelCount.Size = new System.Drawing.Size(84, 53);
			this.labelCount.TabIndex = 6;
			this.labelCount.Text = "Count:";
			// 
			// sortHistoryList
			// 
			this.sortHistoryList.Cursor = System.Windows.Forms.Cursors.Default;
			this.sortHistoryList.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.sortHistoryList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.sortHistoryList.FormattingEnabled = true;
			this.sortHistoryList.Location = new System.Drawing.Point(3, 405);
			this.sortHistoryList.Name = "sortHistoryList";
			this.sortHistoryList.Size = new System.Drawing.Size(480, 21);
			this.sortHistoryList.TabIndex = 5;
			this.sortHistoryList.SelectedIndexChanged += new System.EventHandler(this.sortHistoryList_SelectedIndexChanged);
			// 
			// portoutFormatCheckBox
			// 
			this.portoutFormatCheckBox.Location = new System.Drawing.Point(397, 345);
			this.portoutFormatCheckBox.Name = "portoutFormatCheckBox";
			this.portoutFormatCheckBox.Size = new System.Drawing.Size(81, 40);
			this.portoutFormatCheckBox.TabIndex = 4;
			this.portoutFormatCheckBox.Text = "Portout Format";
			this.portoutFormatCheckBox.UseVisualStyleBackColor = true;
			// 
			// sortRange
			// 
			this.sortRange.Location = new System.Drawing.Point(394, 104);
			this.sortRange.Name = "sortRange";
			this.sortRange.Size = new System.Drawing.Size(84, 75);
			this.sortRange.TabIndex = 3;
			this.sortRange.Text = "Convert to Ranges";
			this.sortRange.UseVisualStyleBackColor = true;
			this.sortRange.Click += new System.EventHandler(this.sortRange_Click);
			// 
			// outputBox
			// 
			this.outputBox.Location = new System.Drawing.Point(202, 23);
			this.outputBox.MaxLength = 0;
			this.outputBox.Multiline = true;
			this.outputBox.Name = "outputBox";
			this.outputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.outputBox.Size = new System.Drawing.Size(188, 362);
			this.outputBox.TabIndex = 2;
			// 
			// sortSingle
			// 
			this.sortSingle.Location = new System.Drawing.Point(394, 23);
			this.sortSingle.Name = "sortSingle";
			this.sortSingle.Size = new System.Drawing.Size(84, 75);
			this.sortSingle.TabIndex = 1;
			this.sortSingle.Text = "Sort/Convert to Single";
			this.sortSingle.UseVisualStyleBackColor = true;
			this.sortSingle.Click += new System.EventHandler(this.sortSingle_Click);
			// 
			// inputBox
			// 
			this.inputBox.Location = new System.Drawing.Point(8, 23);
			this.inputBox.MaxLength = 0;
			this.inputBox.Multiline = true;
			this.inputBox.Name = "inputBox";
			this.inputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.inputBox.Size = new System.Drawing.Size(188, 362);
			this.inputBox.TabIndex = 0;
			// 
			// comparePage
			// 
			this.comparePage.BackColor = System.Drawing.SystemColors.ControlLight;
			this.comparePage.Controls.Add(this.compareCheckForMatch);
			this.comparePage.Controls.Add(this.label16);
			this.comparePage.Controls.Add(this.compareClear);
			this.comparePage.Controls.Add(this.compareHistoryList);
			this.comparePage.Controls.Add(this.compareButton);
			this.comparePage.Controls.Add(this.label7);
			this.comparePage.Controls.Add(this.compareOutputNoMatch);
			this.comparePage.Controls.Add(this.label8);
			this.comparePage.Controls.Add(this.compareOutputAllMatch);
			this.comparePage.Controls.Add(this.label5);
			this.comparePage.Controls.Add(this.compareOutput2);
			this.comparePage.Controls.Add(this.label6);
			this.comparePage.Controls.Add(this.compareOutput1);
			this.comparePage.Controls.Add(this.label4);
			this.comparePage.Controls.Add(this.compareInput2);
			this.comparePage.Controls.Add(this.label1);
			this.comparePage.Controls.Add(this.compareInput1);
			this.comparePage.Location = new System.Drawing.Point(4, 22);
			this.comparePage.Name = "comparePage";
			this.comparePage.Padding = new System.Windows.Forms.Padding(3);
			this.comparePage.Size = new System.Drawing.Size(486, 429);
			this.comparePage.TabIndex = 1;
			this.comparePage.Text = "Compare";
			// 
			// compareCheckForMatch
			// 
			this.compareCheckForMatch.Location = new System.Drawing.Point(8, 405);
			this.compareCheckForMatch.Name = "compareCheckForMatch";
			this.compareCheckForMatch.Size = new System.Drawing.Size(225, 21);
			this.compareCheckForMatch.TabIndex = 17;
			this.compareCheckForMatch.Text = "Only check for matches";
			this.compareCheckForMatch.UseVisualStyleBackColor = true;
			this.compareCheckForMatch.Click += new System.EventHandler(this.compareCheckForMatch_Click);
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(250, 386);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(57, 15);
			this.label16.TabIndex = 16;
			this.label16.Text = "History";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// compareClear
			// 
			this.compareClear.Location = new System.Drawing.Point(248, 405);
			this.compareClear.Name = "compareClear";
			this.compareClear.Size = new System.Drawing.Size(230, 21);
			this.compareClear.TabIndex = 15;
			this.compareClear.Text = "Clear";
			this.compareClear.UseVisualStyleBackColor = true;
			this.compareClear.Click += new System.EventHandler(this.compareClear_Click);
			// 
			// compareHistoryList
			// 
			this.compareHistoryList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.compareHistoryList.FormattingEnabled = true;
			this.compareHistoryList.Location = new System.Drawing.Point(311, 383);
			this.compareHistoryList.Name = "compareHistoryList";
			this.compareHistoryList.Size = new System.Drawing.Size(167, 21);
			this.compareHistoryList.TabIndex = 14;
			this.compareHistoryList.SelectedIndexChanged += new System.EventHandler(this.sortCompareList_SelectedIndexChanged);
			// 
			// compareButton
			// 
			this.compareButton.Location = new System.Drawing.Point(8, 383);
			this.compareButton.Name = "compareButton";
			this.compareButton.Size = new System.Drawing.Size(225, 21);
			this.compareButton.TabIndex = 13;
			this.compareButton.Text = "Compare";
			this.compareButton.UseVisualStyleBackColor = true;
			this.compareButton.Click += new System.EventHandler(this.compareButton_Click);
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(248, 254);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(230, 18);
			this.label7.TabIndex = 12;
			this.label7.Text = "Everything that does not match";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// compareOutputNoMatch
			// 
			this.compareOutputNoMatch.Location = new System.Drawing.Point(248, 275);
			this.compareOutputNoMatch.MaxLength = 0;
			this.compareOutputNoMatch.Multiline = true;
			this.compareOutputNoMatch.Name = "compareOutputNoMatch";
			this.compareOutputNoMatch.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.compareOutputNoMatch.Size = new System.Drawing.Size(230, 102);
			this.compareOutputNoMatch.TabIndex = 11;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(1, 254);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(230, 18);
			this.label8.TabIndex = 10;
			this.label8.Text = "Everything that matches";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// compareOutputAllMatch
			// 
			this.compareOutputAllMatch.Location = new System.Drawing.Point(6, 275);
			this.compareOutputAllMatch.MaxLength = 0;
			this.compareOutputAllMatch.Multiline = true;
			this.compareOutputAllMatch.Name = "compareOutputAllMatch";
			this.compareOutputAllMatch.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.compareOutputAllMatch.Size = new System.Drawing.Size(230, 102);
			this.compareOutputAllMatch.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(250, 129);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(230, 18);
			this.label5.TabIndex = 8;
			this.label5.Text = "What isn\'t in input 2";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// compareOutput2
			// 
			this.compareOutput2.Location = new System.Drawing.Point(248, 150);
			this.compareOutput2.MaxLength = 0;
			this.compareOutput2.Multiline = true;
			this.compareOutput2.Name = "compareOutput2";
			this.compareOutput2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.compareOutput2.Size = new System.Drawing.Size(230, 102);
			this.compareOutput2.TabIndex = 7;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(3, 129);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(230, 18);
			this.label6.TabIndex = 6;
			this.label6.Text = "What isn\'t in input 1";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// compareOutput1
			// 
			this.compareOutput1.Location = new System.Drawing.Point(6, 150);
			this.compareOutput1.MaxLength = 0;
			this.compareOutput1.Multiline = true;
			this.compareOutput1.Name = "compareOutput1";
			this.compareOutput1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.compareOutput1.Size = new System.Drawing.Size(230, 102);
			this.compareOutput1.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(250, 3);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(230, 18);
			this.label4.TabIndex = 4;
			this.label4.Text = "Input 2";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// compareInput2
			// 
			this.compareInput2.Location = new System.Drawing.Point(248, 24);
			this.compareInput2.MaxLength = 0;
			this.compareInput2.Multiline = true;
			this.compareInput2.Name = "compareInput2";
			this.compareInput2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.compareInput2.Size = new System.Drawing.Size(230, 102);
			this.compareInput2.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(3, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(230, 18);
			this.label1.TabIndex = 2;
			this.label1.Text = "Input 1";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// compareInput1
			// 
			this.compareInput1.Location = new System.Drawing.Point(6, 24);
			this.compareInput1.MaxLength = 0;
			this.compareInput1.Multiline = true;
			this.compareInput1.Name = "compareInput1";
			this.compareInput1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.compareInput1.Size = new System.Drawing.Size(230, 102);
			this.compareInput1.TabIndex = 1;
			// 
			// splitPage
			// 
			this.splitPage.BackColor = System.Drawing.SystemColors.ControlLight;
			this.splitPage.Controls.Add(this.label17);
			this.splitPage.Controls.Add(this.splitAmountBox);
			this.splitPage.Controls.Add(this.splitClear);
			this.splitPage.Controls.Add(this.splitSplit);
			this.splitPage.Controls.Add(this.label11);
			this.splitPage.Controls.Add(this.splitSplitList);
			this.splitPage.Controls.Add(this.splitHistoryList);
			this.splitPage.Controls.Add(this.label9);
			this.splitPage.Controls.Add(this.label10);
			this.splitPage.Controls.Add(this.splitOutput);
			this.splitPage.Controls.Add(this.splitInput);
			this.splitPage.Location = new System.Drawing.Point(4, 22);
			this.splitPage.Name = "splitPage";
			this.splitPage.Size = new System.Drawing.Size(486, 429);
			this.splitPage.TabIndex = 2;
			this.splitPage.Text = "Split";
			// 
			// label17
			// 
			this.label17.Location = new System.Drawing.Point(3, 390);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(483, 15);
			this.label17.TabIndex = 20;
			this.label17.Text = "History";
			this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// splitAmountBox
			// 
			this.splitAmountBox.Location = new System.Drawing.Point(396, 54);
			this.splitAmountBox.MaxLength = 9;
			this.splitAmountBox.Name = "splitAmountBox";
			this.splitAmountBox.Size = new System.Drawing.Size(82, 20);
			this.splitAmountBox.TabIndex = 19;
			// 
			// splitClear
			// 
			this.splitClear.Location = new System.Drawing.Point(396, 308);
			this.splitClear.Name = "splitClear";
			this.splitClear.Size = new System.Drawing.Size(82, 75);
			this.splitClear.TabIndex = 18;
			this.splitClear.Text = "Clear";
			this.splitClear.UseVisualStyleBackColor = true;
			this.splitClear.Click += new System.EventHandler(this.splitClear_Click);
			// 
			// splitSplit
			// 
			this.splitSplit.Location = new System.Drawing.Point(396, 80);
			this.splitSplit.Name = "splitSplit";
			this.splitSplit.Size = new System.Drawing.Size(82, 75);
			this.splitSplit.TabIndex = 17;
			this.splitSplit.Text = "Split";
			this.splitSplit.UseVisualStyleBackColor = true;
			this.splitSplit.Click += new System.EventHandler(this.splitSplit_Click);
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(396, 22);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(82, 29);
			this.label11.TabIndex = 16;
			this.label11.Text = "Numbers per split";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// splitSplitList
			// 
			this.splitSplitList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.splitSplitList.FormattingEnabled = true;
			this.splitSplitList.Location = new System.Drawing.Point(202, 362);
			this.splitSplitList.Name = "splitSplitList";
			this.splitSplitList.Size = new System.Drawing.Size(188, 21);
			this.splitSplitList.TabIndex = 15;
			this.splitSplitList.SelectedIndexChanged += new System.EventHandler(this.splitSplitList_SelectedIndexChanged);
			// 
			// splitHistoryList
			// 
			this.splitHistoryList.Cursor = System.Windows.Forms.Cursors.Default;
			this.splitHistoryList.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.splitHistoryList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.splitHistoryList.FormattingEnabled = true;
			this.splitHistoryList.Location = new System.Drawing.Point(0, 408);
			this.splitHistoryList.Name = "splitHistoryList";
			this.splitHistoryList.Size = new System.Drawing.Size(486, 21);
			this.splitHistoryList.TabIndex = 13;
			this.splitHistoryList.SelectedIndexChanged += new System.EventHandler(this.splitHistoryList_SelectedIndexChanged);
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(202, 4);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(188, 15);
			this.label9.TabIndex = 12;
			this.label9.Text = "Output";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(8, 4);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(188, 15);
			this.label10.TabIndex = 11;
			this.label10.Text = "Input";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// splitOutput
			// 
			this.splitOutput.Location = new System.Drawing.Point(202, 22);
			this.splitOutput.MaxLength = 0;
			this.splitOutput.Multiline = true;
			this.splitOutput.Name = "splitOutput";
			this.splitOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.splitOutput.Size = new System.Drawing.Size(188, 334);
			this.splitOutput.TabIndex = 10;
			// 
			// splitInput
			// 
			this.splitInput.Location = new System.Drawing.Point(8, 22);
			this.splitInput.MaxLength = 0;
			this.splitInput.Multiline = true;
			this.splitInput.Name = "splitInput";
			this.splitInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.splitInput.Size = new System.Drawing.Size(188, 361);
			this.splitInput.TabIndex = 9;
			// 
			// telcoveToolsPage
			// 
			this.telcoveToolsPage.BackColor = System.Drawing.SystemColors.ControlLight;
			this.telcoveToolsPage.Controls.Add(this.label18);
			this.telcoveToolsPage.Controls.Add(this.label14);
			this.telcoveToolsPage.Controls.Add(this.telcoveRemedyOutput);
			this.telcoveToolsPage.Controls.Add(this.telcoveHistoryBox);
			this.telcoveToolsPage.Controls.Add(this.label13);
			this.telcoveToolsPage.Controls.Add(this.telcoveSwitchOutput);
			this.telcoveToolsPage.Controls.Add(this.telcoveButton);
			this.telcoveToolsPage.Controls.Add(this.label12);
			this.telcoveToolsPage.Controls.Add(this.telcoveInput);
			this.telcoveToolsPage.Location = new System.Drawing.Point(4, 22);
			this.telcoveToolsPage.Name = "telcoveToolsPage";
			this.telcoveToolsPage.Size = new System.Drawing.Size(486, 429);
			this.telcoveToolsPage.TabIndex = 3;
			this.telcoveToolsPage.Text = "TelcoveTools";
			// 
			// label18
			// 
			this.label18.Location = new System.Drawing.Point(253, 379);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(225, 15);
			this.label18.TabIndex = 19;
			this.label18.Text = "History";
			this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(256, 194);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(222, 15);
			this.label14.TabIndex = 18;
			this.label14.Text = "Remedy HY Search Output";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// telcoveRemedyOutput
			// 
			this.telcoveRemedyOutput.Location = new System.Drawing.Point(253, 212);
			this.telcoveRemedyOutput.MaxLength = 0;
			this.telcoveRemedyOutput.Multiline = true;
			this.telcoveRemedyOutput.Name = "telcoveRemedyOutput";
			this.telcoveRemedyOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.telcoveRemedyOutput.Size = new System.Drawing.Size(225, 162);
			this.telcoveRemedyOutput.TabIndex = 17;
			this.telcoveRemedyOutput.WordWrap = false;
			// 
			// telcoveHistoryBox
			// 
			this.telcoveHistoryBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.telcoveHistoryBox.FormattingEnabled = true;
			this.telcoveHistoryBox.Location = new System.Drawing.Point(253, 400);
			this.telcoveHistoryBox.Name = "telcoveHistoryBox";
			this.telcoveHistoryBox.Size = new System.Drawing.Size(225, 21);
			this.telcoveHistoryBox.TabIndex = 16;
			this.telcoveHistoryBox.SelectedIndexChanged += new System.EventHandler(this.telcoveHistoryBox_SelectedIndexChanged);
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(253, 9);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(225, 15);
			this.label13.TabIndex = 12;
			this.label13.Text = "Switch Output";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// telcoveSwitchOutput
			// 
			this.telcoveSwitchOutput.Location = new System.Drawing.Point(253, 27);
			this.telcoveSwitchOutput.MaxLength = 0;
			this.telcoveSwitchOutput.Multiline = true;
			this.telcoveSwitchOutput.Name = "telcoveSwitchOutput";
			this.telcoveSwitchOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.telcoveSwitchOutput.Size = new System.Drawing.Size(225, 162);
			this.telcoveSwitchOutput.TabIndex = 11;
			this.telcoveSwitchOutput.WordWrap = false;
			// 
			// telcoveButton
			// 
			this.telcoveButton.Location = new System.Drawing.Point(8, 400);
			this.telcoveButton.Name = "telcoveButton";
			this.telcoveButton.Size = new System.Drawing.Size(225, 21);
			this.telcoveButton.TabIndex = 10;
			this.telcoveButton.Text = "Convert";
			this.telcoveButton.UseVisualStyleBackColor = true;
			this.telcoveButton.Click += new System.EventHandler(this.telcoveButton_Click);
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(8, 9);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(225, 15);
			this.label12.TabIndex = 9;
			this.label12.Text = "Input";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// telcoveInput
			// 
			this.telcoveInput.Location = new System.Drawing.Point(8, 27);
			this.telcoveInput.MaxLength = 0;
			this.telcoveInput.Multiline = true;
			this.telcoveInput.Name = "telcoveInput";
			this.telcoveInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.telcoveInput.Size = new System.Drawing.Size(225, 367);
			this.telcoveInput.TabIndex = 8;
			// 
			// essTools
			// 
			this.essTools.BackColor = System.Drawing.SystemColors.ControlLight;
			this.essTools.Controls.Add(this.essPDelete);
			this.essTools.Controls.Add(this.label23);
			this.essTools.Controls.Add(this.essHistoryBox);
			this.essTools.Controls.Add(this.label22);
			this.essTools.Controls.Add(this.essOutput);
			this.essTools.Controls.Add(this.essCustom);
			this.essTools.Controls.Add(this.essPSetTriggers);
			this.essTools.Controls.Add(this.essPSuspend);
			this.essTools.Controls.Add(this.label21);
			this.essTools.Controls.Add(this.essAfterBox);
			this.essTools.Controls.Add(this.label20);
			this.essTools.Controls.Add(this.essBeforeBox);
			this.essTools.Controls.Add(this.essConvert);
			this.essTools.Controls.Add(this.label19);
			this.essTools.Controls.Add(this.essInput);
			this.essTools.Location = new System.Drawing.Point(4, 22);
			this.essTools.Name = "essTools";
			this.essTools.Padding = new System.Windows.Forms.Padding(3);
			this.essTools.Size = new System.Drawing.Size(486, 429);
			this.essTools.TabIndex = 4;
			this.essTools.Text = "5e Tools";
			// 
			// essPDelete
			// 
			this.essPDelete.AutoSize = true;
			this.essPDelete.Location = new System.Drawing.Point(237, 69);
			this.essPDelete.Name = "essPDelete";
			this.essPDelete.Size = new System.Drawing.Size(88, 17);
			this.essPDelete.TabIndex = 25;
			this.essPDelete.Text = "POTS Delete";
			this.essPDelete.UseVisualStyleBackColor = true;
			this.essPDelete.CheckedChanged += new System.EventHandler(this.essPDelete_CheckedChanged);
			// 
			// label23
			// 
			this.label23.Location = new System.Drawing.Point(6, 384);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(225, 18);
			this.label23.TabIndex = 24;
			this.label23.Text = "History";
			this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// essHistoryBox
			// 
			this.essHistoryBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.essHistoryBox.FormattingEnabled = true;
			this.essHistoryBox.Location = new System.Drawing.Point(6, 405);
			this.essHistoryBox.Name = "essHistoryBox";
			this.essHistoryBox.Size = new System.Drawing.Size(225, 21);
			this.essHistoryBox.TabIndex = 23;
			this.essHistoryBox.SelectedIndexChanged += new System.EventHandler(this.essHistoryBox_SelectedIndexChanged);
			// 
			// label22
			// 
			this.label22.Location = new System.Drawing.Point(237, 174);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(241, 15);
			this.label22.TabIndex = 22;
			this.label22.Text = "Output";
			this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// essOutput
			// 
			this.essOutput.Location = new System.Drawing.Point(239, 192);
			this.essOutput.MaxLength = 0;
			this.essOutput.Multiline = true;
			this.essOutput.Name = "essOutput";
			this.essOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.essOutput.Size = new System.Drawing.Size(241, 229);
			this.essOutput.TabIndex = 21;
			// 
			// essCustom
			// 
			this.essCustom.AutoSize = true;
			this.essCustom.Location = new System.Drawing.Point(357, 24);
			this.essCustom.Name = "essCustom";
			this.essCustom.Size = new System.Drawing.Size(60, 17);
			this.essCustom.TabIndex = 20;
			this.essCustom.Text = "Custom";
			this.essCustom.UseVisualStyleBackColor = true;
			this.essCustom.CheckedChanged += new System.EventHandler(this.essCustom_CheckedChanged);
			// 
			// essPSetTriggers
			// 
			this.essPSetTriggers.AutoSize = true;
			this.essPSetTriggers.Checked = true;
			this.essPSetTriggers.Location = new System.Drawing.Point(237, 24);
			this.essPSetTriggers.Name = "essPSetTriggers";
			this.essPSetTriggers.Size = new System.Drawing.Size(114, 17);
			this.essPSetTriggers.TabIndex = 19;
			this.essPSetTriggers.TabStop = true;
			this.essPSetTriggers.Text = "POTS Set Triggers";
			this.essPSetTriggers.UseVisualStyleBackColor = true;
			this.essPSetTriggers.CheckedChanged += new System.EventHandler(this.essPSetTriggers_CheckedChanged);
			// 
			// essPSuspend
			// 
			this.essPSuspend.AutoSize = true;
			this.essPSuspend.Location = new System.Drawing.Point(237, 47);
			this.essPSuspend.Name = "essPSuspend";
			this.essPSuspend.Size = new System.Drawing.Size(99, 17);
			this.essPSuspend.TabIndex = 18;
			this.essPSuspend.Text = "POTS Suspend";
			this.essPSuspend.UseVisualStyleBackColor = true;
			this.essPSuspend.CheckedChanged += new System.EventHandler(this.essPSuspend_CheckedChanged);
			// 
			// label21
			// 
			this.label21.Location = new System.Drawing.Point(234, 128);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(246, 15);
			this.label21.TabIndex = 17;
			this.label21.Text = "After TN";
			this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// essAfterBox
			// 
			this.essAfterBox.Location = new System.Drawing.Point(237, 146);
			this.essAfterBox.Name = "essAfterBox";
			this.essAfterBox.ReadOnly = true;
			this.essAfterBox.Size = new System.Drawing.Size(243, 20);
			this.essAfterBox.TabIndex = 16;
			this.essAfterBox.Text = ",NONCONDTRIG=Y,CHG,abortform!";
			// 
			// label20
			// 
			this.label20.Location = new System.Drawing.Point(234, 89);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(246, 15);
			this.label20.TabIndex = 15;
			this.label20.Text = "Before TN";
			this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// essBeforeBox
			// 
			this.essBeforeBox.Location = new System.Drawing.Point(237, 107);
			this.essBeforeBox.Name = "essBeforeBox";
			this.essBeforeBox.ReadOnly = true;
			this.essBeforeBox.Size = new System.Drawing.Size(243, 20);
			this.essBeforeBox.TabIndex = 14;
			this.essBeforeBox.Text = "FORM=1v6&CHG,TN=";
			// 
			// essConvert
			// 
			this.essConvert.Location = new System.Drawing.Point(356, 47);
			this.essConvert.Name = "essConvert";
			this.essConvert.Size = new System.Drawing.Size(127, 39);
			this.essConvert.TabIndex = 13;
			this.essConvert.Text = "Convert";
			this.essConvert.UseVisualStyleBackColor = true;
			this.essConvert.Click += new System.EventHandler(this.essConvert_Click);
			// 
			// label19
			// 
			this.label19.Location = new System.Drawing.Point(6, 5);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(225, 15);
			this.label19.TabIndex = 11;
			this.label19.Text = "Input";
			this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// essInput
			// 
			this.essInput.Location = new System.Drawing.Point(6, 23);
			this.essInput.MaxLength = 0;
			this.essInput.Multiline = true;
			this.essInput.Name = "essInput";
			this.essInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.essInput.Size = new System.Drawing.Size(225, 358);
			this.essInput.TabIndex = 10;
			// 
			// TNToolForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
			this.ClientSize = new System.Drawing.Size(494, 455);
			this.Controls.Add(this.tabControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "TNToolForm";
			this.Text = "TNTool";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Resize += new System.EventHandler(this.Form1_Resize);
			this.tabControl1.ResumeLayout(false);
			this.sortPage.ResumeLayout(false);
			this.sortPage.PerformLayout();
			this.comparePage.ResumeLayout(false);
			this.comparePage.PerformLayout();
			this.splitPage.ResumeLayout(false);
			this.splitPage.PerformLayout();
			this.telcoveToolsPage.ResumeLayout(false);
			this.telcoveToolsPage.PerformLayout();
			this.essTools.ResumeLayout(false);
			this.essTools.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage sortPage;
        private System.Windows.Forms.TabPage comparePage;
        private System.Windows.Forms.TabPage splitPage;
        private System.Windows.Forms.TabPage telcoveToolsPage;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.Button sortSingle;
		private System.Windows.Forms.Button sortRange;
		private System.Windows.Forms.Label labelCount;
		private System.Windows.Forms.ComboBox sortHistoryList;
		private System.Windows.Forms.CheckBox portoutFormatCheckBox;
		private System.Windows.Forms.Button sortClear;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox compareInput1;
		private System.Windows.Forms.ComboBox compareHistoryList;
		private System.Windows.Forms.Button compareButton;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox compareOutputNoMatch;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox compareOutputAllMatch;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox compareOutput2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox compareOutput1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox compareInput2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button compareClear;
		private System.Windows.Forms.Button splitClear;
		private System.Windows.Forms.Button splitSplit;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.ComboBox splitSplitList;
		private System.Windows.Forms.ComboBox splitHistoryList;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox splitOutput;
		private System.Windows.Forms.TextBox splitInput;
		private System.Windows.Forms.TextBox splitAmountBox;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox telcoveRemedyOutput;
		private System.Windows.Forms.ComboBox telcoveHistoryBox;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox telcoveSwitchOutput;
		private System.Windows.Forms.Button telcoveButton;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox telcoveInput;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.TabPage essTools;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.TextBox essAfterBox;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.TextBox essBeforeBox;
		private System.Windows.Forms.Button essConvert;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.TextBox essInput;
		private System.Windows.Forms.RadioButton essCustom;
		private System.Windows.Forms.RadioButton essPSetTriggers;
		private System.Windows.Forms.RadioButton essPSuspend;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.TextBox essOutput;
		private System.Windows.Forms.RadioButton essPDelete;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.ComboBox essHistoryBox;
		private System.Windows.Forms.Button compareCheckForMatch;
	}
}

