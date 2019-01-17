using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using static TNTool.SingleToRangeClass;
using static TNTool.RangeToSingleClass;


namespace TNTool {
	class SharedFunctions {
		public static string addBetween(List<string> input, string between, int sections, Boolean hasRange) {
			StringBuilder outputBuilder = new StringBuilder();
			int arrayIndex = 0;
			
			Boolean atEnd = false;
			if (!hasRange) {
				int length = input.Count;
				if (sections <= 0) {
					for (int i = 0; i < input.Count; i++) {
						outputBuilder.Append(input[i]);
						if (input.Count > i + 1) {
							outputBuilder.Append(between);
						}
					}
				} else {

					while(!atEnd) {
						int remainingLines = length - arrayIndex;
						if (remainingLines < sections) {
							sections = remainingLines;
							atEnd = true;
						}

						for (int i = 0; i < sections; i++) {
							outputBuilder.Append(input[arrayIndex]);
							if (sections > i + 1) {
								outputBuilder.Append(between);
							}
							arrayIndex++;
						}
						if (!atEnd) {
							outputBuilder.Append("\r\n");
						}
					}
				}
			} else {
				List<string> inputRange = stringToStringArray(SingleToRangeClass.toRange(arrayToString(input)));
				List<string> separatedRanges = new List<string>();
				List<string> separatedSingles = new List<string>();

				for (int i = 0; i < inputRange.Count; i++) {
					string line = inputRange[i];
					if (line.Contains("-")) {
						string range = convertIfLessThanSeven(line);
						if (range.Contains(":")) {
							separatedRanges.Add(range);
						} else {
							List<string> tmpArray = stringToStringArray(range);
							separatedSingles.AddRange(tmpArray);
						}
					} else {
						separatedSingles.Add(line);
					}
				}
				int length = separatedSingles.Count;
				if (length > 0) {
					while (!atEnd) {
						int remainingLines = length - arrayIndex;
						if (remainingLines < sections) {
							sections = remainingLines;
							atEnd = true;
						}

						for (int i = 0; i < sections; i++) {
							outputBuilder.Append(separatedSingles[arrayIndex]);
							if (sections > i + 1) {
								outputBuilder.Append(between);
							}
							arrayIndex++;
						}
						if (!atEnd) {
							outputBuilder.Append("\r\n");
						}
					}
				}
				if (separatedRanges.Count > 0) {
					if (separatedSingles.Count > 0) {
						outputBuilder.Append("\r\n");
					}
					foreach (string anSeparatedRanges in separatedRanges) {
						outputBuilder.Append(anSeparatedRanges);
						outputBuilder.Append("\r\n");
					}
				}
			}
			return outputBuilder.ToString();
		}




		private static string convertIfLessThanSeven(string input) {
			string inputSingles = RangeToSingleClass.toSingle(input);
			if (countLines(inputSingles) < 7) {
				return inputSingles;
			}
			else {
				string tmpString;
				List<string> tmpArray = stringToStringArray(inputSingles);
				tmpString = tmpArray[0] + ":" + tmpArray[tmpArray.Count - 1];
				return tmpString;
			}
		}





		public static int countLines(String str) {
			List<string> lines = str.Split(new char[] { '\n' }).ToList();
			return lines.Count;
		}




		public static String removeSpaces(String spaceless) {
			Boolean hasSpace = true;
			while (hasSpace) {
				int spaceIndex = spaceless.IndexOf(' ');
				if (spaceIndex == -1) {
					hasSpace = false;
				}
				else {
					spaceless = spaceless.Replace(" ", "");
				}
			}
			return spaceless;
		}




		public static String sortNumbers(String input) {
			StringBuilder output = new StringBuilder();
			List<long> inputArray = stringToArray(input);
			List<string> inputStringArray = stringToStringArray(input);
			List<int> leadingZerosArray = new List<int>();
			int lines = inputArray.Count;
			for (int i = 0; i < inputStringArray.Count; i++) {
				String number = inputStringArray[i];
				Boolean isZero = true;
				int leadingZeros = 0;
				while (isZero) {
					if (number.ElementAt(leadingZeros) == '0') {
						leadingZeros++;
					}
					else {
						isZero = false;
					}
				}
				leadingZerosArray.Insert(i, leadingZeros);
			}
			inputArray.Sort();

			for (int i = 0; i < lines; i++) {
				if (leadingZerosArray[i] > 0) {
					for (int j = 0; j < leadingZerosArray[i]; j++) {
						output.Append("0");
					}
				}
				output.Append(inputArray[i]);
				if (i != (lines - 1)) {
					output.Append("\r\n");
				}
			}
			return output.ToString();
		}




		public static List<long> stringToArray(string input) {
			input = input.Replace("\r", "");
			List<string> stringArray = input.Split(new char[] { '\n' }).ToList();
			int lines = countLines(input);
			List<long> unsortedArray = new List<long>();

			for (int i = 0; i < lines; i++) { 
				if (long.TryParse(stringArray[i],out long tmp)) {
					unsortedArray.Add(tmp);
				} else if(!stringArray[i].Equals("")) {
					throw new Exception(stringArray[i].ToString() + " is not a valid number."); ;
				}

				/*
				if (!stringArray[i].Equals("")) {
					unsortedArray.Add(long.Parse(stringArray[i]));
				}
				*/
				
			}
			return unsortedArray;
		}




		public static List<string> stringToStringArray(string input) {
			input = input.Replace("\r\n", "\n");
			List<string> stringArray = input.Split(new char[] { '\n' }).ToList();
			int lines = countLines(input);
			List<string> unsortedArray = new List<string>();

			for (int i = 0; i < lines; i++) {
				if (!stringArray[i].Equals("")) {
					unsortedArray.Add(stringArray[i]);
				}
			}
			return unsortedArray;
		}




		public static String arrayToString<T>(List<T> inputArray) {
			StringBuilder tmpBuilder = new StringBuilder();
			foreach (Object line in inputArray) {
				tmpBuilder.Append(line.ToString());
				tmpBuilder.Append("\r\n");
			}
			return tmpBuilder.ToString();
		}




		public static string portoutFormat(string input) {
			List<string> unformattedArray = stringToStringArray(input);
			StringBuilder formattedOutput = new StringBuilder();

			for (int i = 0; i < unformattedArray.Count; i++) {
				if ((unformattedArray[i].Length == 23 && unformattedArray[i].Contains(" - ")) ||        //If it's a 10 digit range (9185550123 - 9185550130)
					(unformattedArray[i].Length == 10 && !unformattedArray[i].Contains(" - "))) {       //Or if it's a single TN (9185550123)
																										//I know this shouldn't be an empty if body but it works								//You're good.
				}
				else {                                                                                      //Otherwise,
					throw new Exception("All numbers should be 10 digits.");                                    //Throw an exception
				}
				StringBuilder tmp = new StringBuilder();
				tmp.Append("(");
				tmp.Append(unformattedArray[i].Substring(0, 3));
				tmp.Append(")");
				tmp.Append(unformattedArray[i].Substring(3, 3));
				tmp.Append("-");
				tmp.Append(unformattedArray[i].Substring(6, 4));
				if (unformattedArray[i].Contains("-")) {
					tmp.Append(" - ");
					tmp.Append(unformattedArray[i].Substring(19, 4));
					tmp.Append(":");
				}
				else {
					tmp.Append("\t\t:");
				}
				formattedOutput.Append(tmp.ToString());
				formattedOutput.Append("\r\n");
			}
		return formattedOutput.ToString();
		}




		public static string portoutSingles(string input) {
			List<string> inputArray = stringToStringArray(input);              //Pull the string into an array to make it easier to manipulate each individual number
			StringBuilder output = new StringBuilder();


			for (int i = 0; i < inputArray.Count(); i++) {
				if (!inputArray[i].Contains("(") || !inputArray[i].Contains(")") || !inputArray[i].Contains("-")) {
					throw new Exception("Portout Format not detected.");
				}
				Boolean single = true;
				string singleTest = inputArray[i];
				if (singleTest.Replace("-", "").Length < singleTest.Length - 1) {        // if it has two dashes in it, it shouldn't be a single. ( "(202)879-6757		:" )
					single = false;                                     //Example on how this next section works:
				}                                                       //inputArray.get(i) is "	(202)879-6760 - 6761:" 	or "	(202)879-6757		:"
				string tmp = inputArray[i].Replace("(", "");			//Now it's "	202)879-6760 - 6761:"	or "	202)879-6757		:"
				tmp = tmp.Replace(")", "");								//Now it's "	202879-6760 - 6761:"	or "	202879-6757		:"
				tmp = tmp.ReplaceFirst("-", "");						//Now it's "	2028796760 - 6761:'		or "	2028796757		:"
				tmp = tmp.Replace(":", "");								//Now it's "	2028796760 - 6761'		or "	2028796757		"
				tmp = tmp.Replace(" ", "");								//Now it's "	2028796760-6761'		or "	2028796757		"
				tmp = tmp.Replace("\t", "");							//Now it's "2028796760-6761"			or "2028796757"
				if (single) {
					output.Append(tmp);                                             //If it's a single, just add the number "2028796757"
					output.Append("\r\n");                                            //Append a newline for the next number
				}
				else {
					int startOfEnd = tmp.IndexOf("-") + 1;                          //Get the index of the end of the range, (6761) using the - as the separator

					output.Append(tmp.Substring(0, startOfEnd));                        //Append the start (2028796760)
					output.Append(tmp.Substring(0, 6));                             //Get the first 6 numbers, (202879) so the end is a whole number
					output.Append(tmp.Substring(startOfEnd, 4));         //Get the last 4 numbers, (6761) to finish the end of the range
					output.Append("\r\n");                                            //Append a newline for the next number
				}

			}
			return output.ToString().Replace("-", " - ");

		}

	}



	public static class StringExtensionMethods {
		public static string ReplaceFirst(this string text, string search, string replace) {
			int pos = text.IndexOf(search);
			if (pos < 0) {
				return text;
			}
			return text.Substring(0, pos) + replace + text.Substring(pos + search.Length);
		}
	}
}

