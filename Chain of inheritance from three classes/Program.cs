using System;

namespace Chain_of_inheritance_from_three_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter integer field value: ");
            int numericValue = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter character field value: ");
            char characterValue = Convert.ToChar(Console.ReadLine());
            Console.Write("Enter text field value: ");
            string textValue = Console.ReadLine();

            ThirdClass thirdClass = new ThirdClass(numericValue, characterValue, textValue);

            FirstClass firstClass = new FirstClass(numericValue);
            Console.WriteLine(firstClass.ToString());
            SecondClass secondClass = new SecondClass(numericValue, characterValue);
            secondClass.SetValue(numericValue, 'R');
            Console.WriteLine(secondClass.ToString());
            Console.WriteLine(thirdClass.ToString());

            Console.ReadKey();
        }

        class FirstClass
        {
            public int number = 0;

            public void SetValue(int _number)
            {
                number = _number;
            }

            public override string ToString()
            {
                string summaryText = "Class FIRSTCLASS and its fields: " + number;
                return summaryText;
            }

            public FirstClass(int number)
            {
                this.number = number;
            }
        }

        class SecondClass : FirstClass
        {
            public char symbol = ' ';

            public void SetValue(int _number,char _symbol)
            {
                number = _number;
                symbol = _symbol;
            }

            public override string ToString()
            {
                string summaryText = "Class SECONDCLASS and its fields: " + number + symbol;
                return summaryText;
            }

            public SecondClass(int number,char symbol) : base(number)
            {
                this.symbol = symbol;
            }
        }

        class ThirdClass : SecondClass
        {
            public string text = " ";

            public void SetValue(int _number,char _symbol, string _text)
            {
                number = _number;
                symbol = _symbol;
                text = _text;
            }

            public override string ToString()
            {
                string summaryText = "Class THIRDCLASS and its fields: " + number + symbol + text;
                return summaryText;
            }

            public ThirdClass(int number, char symbol, string text) : base(number, symbol)
            {
                this.text = text;
            }
        }
    }
}
