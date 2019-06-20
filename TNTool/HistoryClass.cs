using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TNTool {
	class HistoryClass {
		public List<Object> outputArray = new List<Object>();
		public HistoryClass(params Object[] inputList) {
			foreach(object obj in inputList) {
				outputArray.Add(obj);
			}
		}
		public void set(params Object[] inputList) {
			foreach (object obj in inputList) {
				outputArray.Add(obj);
			}
		}
		public List<Object> get() {
			return outputArray;
		}
	}
}
