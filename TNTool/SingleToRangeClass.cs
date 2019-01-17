using System;
using System.Collections.Generic;
using System.Text;
using static TNTool.SharedFunctions;

namespace TNTool {
	class SingleToRangeClass {
		public static String toRange(String input) {
			if (input.Contains("(") || input.Contains(")")) {
				throw new Exception("Error: Please remove any parenthesis. Input should be just TNs separated by : or -. Example: 8005551234:8005552345");
			}
			StringBuilder outputText = new StringBuilder();
			//int lines = countLines(input);
			input = sortNumbers(input);
			List<long> inputArray = stringToArray(input);
			int lines = inputArray.Count;

			long tmpRangeStart = inputArray[0];
			long tmpRangeEnd;

			for (int i = 1; i < lines; i++) {
				if (inputArray[i - 1] != inputArray[i] - 1) {

					tmpRangeEnd = inputArray[i - 1];
					if (tmpRangeEnd == tmpRangeStart) {
						outputText.Append(tmpRangeStart);
						outputText.Append("\r\n");
					}
					else {
						outputText.Append(tmpRangeStart);
						outputText.Append(" - ");
						outputText.Append(tmpRangeEnd);
						outputText.Append("\r\n");
					}
					tmpRangeStart = inputArray[i];
				}
			}
			tmpRangeEnd = inputArray[lines - 1];
			if (tmpRangeEnd == tmpRangeStart) {
				outputText.Append(tmpRangeStart);
				outputText.Append("\r\n");
			}
			else {
				outputText.Append(tmpRangeStart);
				outputText.Append(" - ");
				outputText.Append(tmpRangeEnd);
				outputText.Append("\r\n");
			}

			return outputText.ToString();
		}
	}
}
