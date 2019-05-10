using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TNTool {
	class HistoryClass {
		public List<Object> outputArray = new List<Object>();
		//Start Sort History
		public HistoryClass(string i, string o, int c) { 
			outputArray.Add(i);
			outputArray.Add(o);
			outputArray.Add(c.ToString());
		}
		public void set(string i, string o, int c) {
			outputArray.Clear();
			outputArray.Add(i);
			outputArray.Add(o);
			outputArray.Add(c.ToString());
		}
		//Stop Sort History

		//Start Compare History
		public HistoryClass(string i1, string i2, string o1, string o2, string oa, string on) {
			outputArray.Add(i1);
			outputArray.Add(i2);
			outputArray.Add(o1);
			outputArray.Add(o2);
			outputArray.Add(oa);
			outputArray.Add(on);
		}
		public void set(string i1, string i2, string o1, string o2, string oa, string on) {
			outputArray.Clear();
			outputArray.Add(i1);
			outputArray.Add(i2);
			outputArray.Add(o1);
			outputArray.Add(o2);
			outputArray.Add(oa);
			outputArray.Add(on);
		}
		//Stop Compare History

		//Start Split History
		public HistoryClass(string input, string output, int perSplit, int numberOfSplits) {
			outputArray.Add(input);
			outputArray.Add(output);
			outputArray.Add(perSplit);
			outputArray.Add(numberOfSplits);
		}
		public void set(string input, string output, int perSplit, int numberOfSplits) {
			outputArray.Clear();
			outputArray.Add(input);
			outputArray.Add(output);
			outputArray.Add(perSplit);
			outputArray.Add(numberOfSplits);
		}
		//Stop Split History

		//start Telcove History
		public HistoryClass(string input, string switchOutput, string remedyOutput) {
			outputArray.Add(input);
			outputArray.Add(switchOutput);
			outputArray.Add(remedyOutput);
		}
		public void set(string input, string switchOutput, string remedyOutput) {
			outputArray.Clear();
			outputArray.Add(input);
			outputArray.Add(switchOutput);
			outputArray.Add(remedyOutput);
		}
		//stop Telcove History

		//start 5ess History
		public HistoryClass(string input, string output, string before, string after, int selectedOption) {
			outputArray.Add(input);
			outputArray.Add(output);
			outputArray.Add(before);
			outputArray.Add(after);
			outputArray.Add(selectedOption);
		}
		public void set(string input, string output, string before, string after, int selectedOption) {
			outputArray.Clear();
			outputArray.Add(input);
			outputArray.Add(output);
			outputArray.Add(before);
			outputArray.Add(after);
			outputArray.Add(selectedOption);
		}
		//stop 5ess history
		public List<Object> get() {
			return outputArray;
		}
	}
}
