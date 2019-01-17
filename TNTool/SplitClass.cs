using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TNTool.SharedFunctions;

namespace TNTool {
	class SplitClass {
		private List<String> eachSplit = new List<string>();

		public SplitClass(string input, int size) {
			splitStrings(input, size);
		}
		private void splitStrings(String input, int size) {
			//StringBuilder tmpSplit = new StringBuilder();
			List<String> tmpArray = stringToStringArray(input);
			int numberOfSplits = (int)Math.Ceiling((double)tmpArray.Count() / (double)size);
			int arrayIndex = 0;
			for (int i = 0; i < numberOfSplits; i++) {
				StringBuilder tmpSplit = new StringBuilder();
				for (int j = 0; j < size; j++) {
					if (tmpArray.Count() < arrayIndex + 1) {
						break;
					}
					else {
						tmpSplit.Append(tmpArray[arrayIndex]);
						tmpSplit.Append("\r\n");
						arrayIndex++;
					}
				}
				eachSplit.Add(tmpSplit.ToString());
				//tmpSplit.setLength(0);
			}
		}
		public string get(int index) {
			return eachSplit[index];
		}

		public int size() {
			return eachSplit.Count();
		}
	}
}
