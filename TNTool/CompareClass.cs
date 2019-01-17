using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static TNTool.SharedFunctions;

namespace TNTool {
	class CompareClass {
		public static List<String> compareLists(string input1, string input2) {
			try {
				input1 = sortNumbers(input1);
				input2 = sortNumbers(input2);
			} catch (Exception ex){
				throw ex;
			}
			List<long> inputArray1 = stringToArray(input1);
			List<long> inputArray2 = stringToArray(input2);
			List<String> output = new List<String>();     //First string in array (0) will be what isn't in input1, second (1) will be what isn't in input2, third (2) will be all numbers that match, fourth (3) will be what doesn't match.
			List<StringBuilder> builder = new List<StringBuilder>();
			for (int i = 0; i < 4; i++) {
				builder.Add(new StringBuilder());
			}

			if (inputArray1.Count == 0) {
				if (inputArray2.Count == 0) {
					throw new Exception("Please input numbers in both input 1 and input 2.");
				}
				throw new Exception("Please input numbers in input 2.");
			} else if (inputArray2.Count == 0) {
				throw new Exception("Please input numbers in input 1.");
			} else {

				for (int i = 0; i < inputArray1.Count(); i++) {
					//if (inputArray2.Contains(inputArray1[i])) {
					int indexOfNumber = inputArray2.BinarySearch(inputArray1[i]);
					if (indexOfNumber > -1) {
						builder[2].Append(inputArray1[i]);
						builder[2].Append("\r\n");
					} else {
						builder[1].Append(inputArray1[i]);
						builder[1].Append("\r\n");

						builder[3].Append(inputArray1[i]);
						builder[3].Append("\r\n");
					}
				}

				for (int i = 0; i < inputArray2.Count(); i++) {
					//if (!inputArray1.Contains(inputArray2[i])) {
					int indexOfNumber = inputArray1.BinarySearch(inputArray2[i]);
					if (indexOfNumber <= -1) {
						builder[0].Append(inputArray2[i]);
						builder[0].Append("\r\n");

						builder[3].Append(inputArray2[i]);
						builder[3].Append("\r\n");
					}
				}

				for (int i = 0; i < builder.Count(); i++) {
					output.Add(builder[i].ToString());
				}
				return output;
			}
		}
	}
}
