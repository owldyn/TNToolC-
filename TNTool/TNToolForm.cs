using System;
using System.Windows.Forms;
using static TNTool.SingleToRangeClass;
using static TNTool.RangeToSingleClass;
using static TNTool.SharedFunctions;
using System.Collections.Generic;

namespace TNTool {
	public partial class TNToolForm : Form {

		public TNToolForm() {
			InitializeComponent();
		}

		private void Form1_Resize(object sender, EventArgs e) {

		}
		private void Form1_Load(object sender, EventArgs e) {

		}
		//START SORTING
		private List<HistoryClass> sortHistory = new List<HistoryClass>();

		private void sortSingle_Click(object sender, EventArgs e) {
			string input = inputBox.Text;
			if (!(input == "")) {
				try {
					if (portoutFormatCheckBox.Checked) {
						try {
							input = portoutSingles(input);
						}
						catch (Exception except) {
							outputBox.Text = except.Message;
							return;
						}
					}
					input = input.Replace("|", "\r\n");
					string outputText = toSingle(input);
					outputText = sortNumbers(outputText);
					outputBox.Text = outputText;
					outputBox.SelectionStart = 0;
					outputBox.SelectionLength = 0;
					string count = countLines(outputText).ToString();
					labelCount.Text = "Count: " + count;
					newSortHistory(inputBox.Text, outputBox.Text, int.Parse(labelCount.Text.Replace("Count: ", "")), 0);
				}
				catch (Exception except) {
					outputBox.Text = except.Message;
				}
			}
		}

		private void sortRange_Click(object sender, EventArgs e) {
			if (inputBox.Text != "") {
				try {
					inputBox.Text = sortNumbers(inputBox.Text);
					string input = inputBox.Text;
					string outputText = toRange(input);

					if (portoutFormatCheckBox.Checked == true) {
						outputBox.Text = portoutFormat(outputText);
						outputBox.SelectionStart = 0;
						outputBox.SelectionLength = 0;
						string count = countLines(input).ToString();
						labelCount.Text = "Count: " + count;
					}
					else {
						outputBox.Text = outputText;
						outputBox.SelectionStart = 0;
						outputBox.SelectionLength = 0;
						string count = countLines(input).ToString();
						labelCount.Text = "Count: " + count;
					}
					newSortHistory(inputBox.Text, outputBox.Text, int.Parse(labelCount.Text.Replace("Count: ", "")), 1);
				}
				catch (Exception except) {
					outputBox.Text = except.Message;
				}
			}
		}

		private void newSortHistory(string i, string o, int c, int type) {
			string typeStr = "";
			if (type == 0) {
				typeStr = "Range to Single";
			}
			else if (type == 1) {
				typeStr = "Single to Range";
			}

			string date = DateTime.Now.ToString();
			string historyString = date + " " + typeStr;
			Boolean exists = false;
			foreach (string item in sortHistoryList.Items) {
				if (item.ToString().Equals(historyString)) {
					exists = true;
					break;
				}
			}
			if (!exists) {
				sortHistory.Add(new HistoryClass(i, o, c));
				sortHistoryList.Items.Add(historyString);
				sortHistoryList.SelectedItem = (historyString);
			}

		}

		private void sortHistoryList_SelectedIndexChanged(object sender, EventArgs e) {
			int index = sortHistoryList.SelectedIndex;
			List<Object> hist = sortHistory[index].get();
			inputBox.Text = hist[0].ToString();
			outputBox.Text = hist[1].ToString();
			labelCount.Text = "Count: " + hist[2].ToString();
		}

		private void sortClear_Click(object sender, EventArgs e) {
			inputBox.Text = "";
			outputBox.Text = "";
			labelCount.Text = "Count: ";
			portoutFormatCheckBox.Checked = false;
		}

		//STOP SORTING

		//START COMPARE
		private List<HistoryClass> compareHistory = new List<HistoryClass>();
		private void compareButton_Click(object sender, EventArgs e) {
			try {
				List<string> compared = CompareClass.compareLists(compareInput1.Text, compareInput2.Text);
				compareOutput1.Text = compared[0];
				compareOutput2.Text = compared[1];
				compareOutputAllMatch.Text = compared[2];
				compareOutputNoMatch.Text = compared[3];
				newCompareHistory(compareInput1.Text, compareInput2.Text, compareOutput1.Text, compareOutput2.Text, compareOutputAllMatch.Text, compareOutputNoMatch.Text);
			}
			catch (Exception except) {
				compareOutput1.Text = except.Message;
				compareOutput2.Text = except.Message;
			}


		}
		private void newCompareHistory(string i1, string i2, string o1, string o2, string oa, string on) {
			string date = DateTime.Now.ToString();

			string historyString = date;
			Boolean exists = false;
			foreach (string item in compareHistoryList.Items) {
				if (item.ToString().Equals(historyString)) {
					exists = true;
					break;
				}
			}
			if (!exists) {
				compareHistory.Add(new HistoryClass(i1, i2, o1, o2, oa, on));
				compareHistoryList.Items.Add(historyString);
				compareHistoryList.SelectedItem = (historyString);
			}
		}

		private void sortCompareList_SelectedIndexChanged(object sender, EventArgs e) {
			int index = compareHistoryList.SelectedIndex;
			List<Object> hist = compareHistory[index].get();
			compareInput1.Text = hist[0].ToString();
			compareInput2.Text = hist[1].ToString();
			compareOutput1.Text = hist[2].ToString();
			compareOutput2.Text = hist[3].ToString();
			compareOutputAllMatch.Text = hist[4].ToString();
			compareOutputNoMatch.Text = hist[5].ToString();
		}

		private void compareClear_Click(object sender, EventArgs e) {
			compareInput1.Text = "";
			compareInput2.Text = "";
			compareOutput1.Text = "";
			compareOutput2.Text = "";
			compareOutputAllMatch.Text = "";
			compareOutputNoMatch.Text = "";
		}
		//STOP COMPARE

		//START SPLIT
		private List<HistoryClass> splitHistory = new List<HistoryClass>();
		private void splitAmountBox_TextChanged(object sender, EventArgs e) {

		}


		private int splitCount = -1;
		private List<SplitClass> splitArray = new List<SplitClass>();
		private void splitSplit_Click(object sender, EventArgs e) {
			if (int.TryParse(splitAmountBox.Text, out int splitAmount)) {
				try {
					splitCount++;
					splitSplitList.Items.Clear();
					splitOutput.Text = "";
					splitArray.Insert(splitCount, new SplitClass(splitInput.Text, splitAmount));
					for (int i = 0; i < splitArray[splitCount].size(); i++) {
						splitSplitList.Items.Add((i + 1).ToString());
					}
					splitSplitList.SelectedIndex = 0;
					//splitOutput.Text = (splitArray[splitCount].get(0));
					newSplitHistory(splitInput.Text, splitOutput.Text, splitAmount, splitSplitList.Items.Count);
				}
				catch (Exception ex) {
					splitOutput.Text = ex.Message;
				}
			}
			else {
				splitOutput.Text = "Please insert only numbers in the numbers per split text box.";
			}

		}

		private void splitSplitList_SelectedIndexChanged(object sender, EventArgs e) {
			if (splitSplitList.SelectedIndex >= 0) {
				splitOutput.Text = (splitArray[splitCount].get(splitSplitList.SelectedIndex));
			}
		}

		private void splitClear_Click(object sender, EventArgs e) {
			splitInput.Text = "";
			splitOutput.Text = "";
			splitSplitList.Items.Clear();
			splitAmountBox.Text = "";
		}
		private void newSplitHistory(string input, string output, int perSplit, int numberOfSplits) {
			string date = DateTime.Now.ToString();
			string historyString = date;
			Boolean exists = false;
			foreach (string item in splitHistoryList.Items) {
				if (item.ToString().Equals(historyString)) {
					exists = true;
					break;
				}
			}
			if (!exists) {
				splitHistory.Add(new HistoryClass(input, output, perSplit, numberOfSplits));
				splitHistoryList.Items.Add(historyString);
				splitHistoryList.SelectedItem = (historyString);
			}
		}

		private void splitHistoryList_SelectedIndexChanged(object sender, EventArgs e) {
			splitSplitList.Items.Clear();
			int index = splitHistoryList.SelectedIndex;
			List<Object> hist = splitHistory[index].get();
			splitInput.Text = hist[0].ToString();
			splitOutput.Text = hist[1].ToString();
			splitAmountBox.Text = hist[2].ToString();
			for (int i = 0;  i < (int)hist[3]; i++) {
				splitSplitList.Items.Add((i + 1).ToString());
			}
			//splitSplitList.SelectedIndex = 0;
		}


		//STOP SPLIT


		//START TELCOVE
		private List<HistoryClass> telcoveHistory = new List<HistoryClass>();
		private void telcoveButton_Click(object sender, EventArgs e) {
			try
			{
				telcoveSwitchOutput.Text = ("");
				telcoveRemedyOutput.Text = ("");
				if (!telcoveInput.Text.Equals(""))
				{
					TelcoveToolClass Remedy = new TelcoveToolClass(telcoveInput.Text, 250, "\" OR 'TELEPHONE NUMBER (DN)' = \"", false);
					TelcoveToolClass Switch = new TelcoveToolClass(telcoveInput.Text, 7, "|", true);
					string tmpRemedy = Remedy.get().Replace("\r\n", "\"\r\n'TELEPHONE NUMBER (DN)' = \"");
					telcoveRemedyOutput.Text = ("'TELEPHONE NUMBER (DN)' = \"" + tmpRemedy + "\"");
					telcoveSwitchOutput.Text = Switch.get();
					newTelcoveHistory(telcoveInput.Text, telcoveSwitchOutput.Text, telcoveRemedyOutput.Text);
				}
				else
				{
					telcoveSwitchOutput.Text = "Please input TNs into input box";
				}
			}catch (Exception ex){
				telcoveSwitchOutput.Text = ex.Message;
			}
		}
		private void newTelcoveHistory(string input, string switchOutput, string remedyOutput) {
			string date = DateTime.Now.ToString();
			string historyString = date;
			Boolean exists = false;
			foreach (string item in telcoveHistoryBox.Items) {
				if (item.ToString().Equals(historyString)) {
					exists = true;
					break;
				}
			}
			if (!exists) {
				telcoveHistory.Add(new HistoryClass(input, switchOutput, remedyOutput));
				telcoveHistoryBox.Items.Add(historyString);
				telcoveHistoryBox.SelectedItem = (historyString);
			}
		}
		private void telcoveHistoryBox_SelectedIndexChanged(object sender, EventArgs e) {
			int index = telcoveHistoryBox.SelectedIndex;
			List<Object> hist = telcoveHistory[index].get();
			telcoveInput.Text = hist[0].ToString();
			telcoveSwitchOutput.Text = hist[1].ToString();
			telcoveRemedyOutput.Text = hist[2].ToString();
		}

		//STOP TELCOVE

		//START 5eTools
		private void essPSetTriggers_CheckedChanged(object sender, EventArgs e) {
			essLockBABoxes();
			essSetBABoxes("FORM=1v6&CHG,TN=", ",NONCONDTRIG=Y,CHG!");
		}

		private void essPSuspend_CheckedChanged(object sender, EventArgs e) {
			essLockBABoxes();
			essSetBABoxes("FORM=1v6&CHG,TN=", ",LCC=SUS,SUST=Y,CHG!");
		}

		private void essPDelete_CheckedChanged(object sender, EventArgs e) {
			essLockBABoxes();
			essSetBABoxes("FORM=1v6&OUT,TN=", ",OUT!");
		}

		private void essLockBABoxes() {
			essBeforeBox.ReadOnly = true;
			essAfterBox.ReadOnly = true;
		}

		private void essSetBABoxes(string before, string after) {
			essBeforeBox.Text = before;
			essAfterBox.Text = after;
		}

		private void essCustom_CheckedChanged(object sender, EventArgs e) {
			essBeforeBox.ReadOnly = false;
			essAfterBox.ReadOnly = false;
			essSetBABoxes("", "");
		}

		private void essConvert_Click(object sender, EventArgs e) {
			try {
				string converted = _5essClass.addBeforeAndAfter(essBeforeBox.Text, essAfterBox.Text, essInput.Text);
				essOutput.Text = converted;
				int selected = -1;
				if (essPSetTriggers.Checked) {
					selected = 0;
				} else if (essPSuspend.Checked) {
					selected = 1;
				} else if (essPDelete.Checked) {
					selected = 2;
				} else if (essCustom.Checked) {
					selected = 3;
				}
				newEssHistory(essInput.Text, essOutput.Text, essBeforeBox.Text, essAfterBox.Text, selected);
			} catch (Exception except) {
				outputBox.Text = except.Message;
			}
		}

		private List<HistoryClass> essHistory = new List<HistoryClass>();
		private void newEssHistory(string input, string output, string before, string after, int selectedOption) {
			string date = DateTime.Now.ToString();
			string historyString = date;
			Boolean exists = false;
			foreach (string item in essHistoryBox.Items) {
				if (item.ToString().Equals(historyString)) {
					exists = true;
					break;
				}
			}
			if (!exists) {
				essHistory.Add(new HistoryClass(input, output, before, after, selectedOption));
				essHistoryBox.Items.Add(historyString);
				essHistoryBox.SelectedItem = (historyString);
			}
		}

		private void essHistoryBox_SelectedIndexChanged(object sender, EventArgs e) {
			int index = essHistoryBox.SelectedIndex;
			List<Object> hist = essHistory[index].get();
			essInput.Text = hist[0].ToString();
			essOutput.Text = hist[1].ToString();
			switch (hist[4]) {// We have to set the selection first incase custom is selected so it doesn't overwrite what we set
				case 0:
					essPSetTriggers.Checked = true;
					break;
				case 1:
					essPSuspend.Checked = true;
					break;
				case 2:
					essPDelete.Checked = true;
					break;
				case 3:
					essCustom.Checked = true;
					break;
			}
			essBeforeBox.Text = hist[2].ToString();
			essAfterBox.Text = hist[3].ToString();
		}
		//STOP 5ess tools
	}
}

