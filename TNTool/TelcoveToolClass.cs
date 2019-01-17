using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TNTool.SharedFunctions;

namespace TNTool {
	class TelcoveToolClass {
		private List<string> inputArray;
		private int sectionCount;
		private string betweenInput;
		private Boolean hasRange;


		public TelcoveToolClass(string input, int sectionSize, string between, Boolean usesRange) {
			inputArray = stringToStringArray(sortNumbers(input));
			sectionCount = sectionSize;
			betweenInput = between;
			hasRange = usesRange;
		}

		public string get() {
			return addBetween(inputArray, betweenInput, sectionCount, hasRange);
		}
	}
}
