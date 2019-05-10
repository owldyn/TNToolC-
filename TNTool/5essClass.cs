using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TNTool.SharedFunctions;

namespace TNTool {
	class _5essClass {
		public static string addBeforeAndAfter(string before, string after, string TNList) {
			StringBuilder outputBuilder = new StringBuilder();
			List<String> inputList = stringToStringArray(TNList);

			foreach (string number in inputList) {
				outputBuilder.Append(before);
				outputBuilder.Append(number);
				outputBuilder.Append(after);
				outputBuilder.Append("\r\n");
			}
			return outputBuilder.ToString();
		}
	}
}
