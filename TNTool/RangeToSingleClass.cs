using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static TNTool.SharedFunctions;

namespace TNTool {
	class RangeToSingleClass {
		public static string toSingle(string input) {

			StringBuilder outputBuilder = new StringBuilder();

			//input = sortNumbers(input);
			List<string> inputArray = stringToStringArray(input);
			int lines = inputArray.Count();
			int rangeInd;	//Will be assigned to where the colon or dash separating the range
			int length;		//Will be assigned to the length of the range string to determine the end index of the end number in the string
			long start;		//Will be the first number in the range
			long end;		//Will be the last number in the range
			long print;     //Will be the temporary variable that is the current number in the loop, to be added to StringBuilder output

			string tmp;
			for (int i = 0; i < lines; i++) {
				tmp = inputArray[i];
				if (tmp.Contains("(") || tmp.Contains(")")) {
					throw new Exception("Error: Please remove any parenthesis. Input should be just TNs separated by : or -. Example: 8005551234:8005552345");
				} else if (!tmp.Contains(":") && !tmp.Contains("-")) {
					outputBuilder.Append(tmp); //If it doesn't have a range indicator, assume input is just one number, so output that into the string without changing anything
					outputBuilder.Append("\n");
				} else if (hasMultipleDashes(tmp)) {
					throw new Exception("Error: Too many dashes. Input should be just TNs separated by : or -. Example: 8005551234:8005552345");
				} else {
					if (tmp.Contains(" ")) {
						tmp = removeSpaces(tmp);
					}
					if (tmp.Contains(":")) {
						rangeInd = tmp.IndexOf(":");
					}
					else {
						rangeInd = tmp.IndexOf("-");
					}
					length = tmp.Count();
					start = long.Parse(tmp.Substring(0, rangeInd));
					end = long.Parse(tmp.Substring(rangeInd + 1, length - (rangeInd + 1)));
					print = start;
					if (start > end) {
						throw new Exception("Error: Start of range cannot be lower than end of range.");
					}
					else {
						outputBuilder.Append(print.ToString());
						outputBuilder.Append("\n");
						while (print != end) {
							print++;
							outputBuilder.Append(print.ToString());
							outputBuilder.Append("\n");
						}
					}
				}
			}
			return outputBuilder.ToString();
		}
		private static Boolean hasMultipleDashes(string input) {
			if (input.Contains("-")) {
				int startLen = input.Count();
				input = input.ReplaceFirst("-", "");
				int endLen = input.Count();

				return (endLen < startLen - 1);
			}
			else {
				return false;
			}
		}
	}
}
