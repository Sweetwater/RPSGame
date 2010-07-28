using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPS
{
    class TextSelector
    {
        public string Caption { get; set; }
        public IList<string> Items { get; set; }

        public string SelectedText { get; private set; }
        public int SelectedNumber { get; private set; }

        public TextSelector()
        {
            Items = new List<string>();
        }

        public void Select()
        {
            Console.WriteLine(this.Caption);

            var index = 0;
            foreach (string item in this.Items)
            {
                Console.WriteLine("{0} : {1}", (index+1), item);
                index++;
            }

            while (true)
            {
                var input = Console.ReadLine();
                var selected = 0;
                var parseResult = int.TryParse(input, out selected);

                if (parseResult == false)
                {
                    Console.WriteLine("input number parse failed");
                    continue;
                }

                selected -= 1;
                if (selected < 0 || selected > this.Items.Count - 1)
                {
                    Console.WriteLine("input number is out of range");
                    continue;
                }

                this.SelectedNumber = selected;
                this.SelectedText = Items[selected];
                return;
            }
        }
    }
}
