using System;
using System.Collections.Generic;

namespace RPS {
	class TextSelector {
		public string Caption { get; set; }
		public IList<string> Items { get; set; }

		public TextSelector() {
			Items = new List<string>();
		}

		public TextSelectResult DoSelect() {
			Console.WriteLine(this.Caption);

			var index = 0;
			foreach (string item in this.Items) {
				Console.WriteLine("{0} : {1}", (index + 1), item);
				index++;
			}

			while (true) {
				var input = Console.ReadLine();
				var selected = 0;
				var parseResult = int.TryParse(input, out selected);

				if (parseResult == false) {
					Console.WriteLine("input number parse failed");
					continue;
				}

				selected -= 1;
				if (selected < 0 || selected > this.Items.Count - 1) {
					Console.WriteLine("input number is out of range");
					continue;
				}

				return new TextSelectResult (Items[selected],  selected);
			}
		}
	}

	class TextSelectResult {
		public string Text { get; private set; }
		public int Number { get; private set; }

		public TextSelectResult(string text, int number) {
			this.Text = text;
			this.Number = number;
		}
	}
}
