using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var p = new Program();
            //p.Swap2NumbersWithoutTempVariable();
            //p.ReversofGivenNumber();
            p.factorialvalue();
        }

        public void factorialvalue()
        {
            Console.WriteLine("Enter factorial value : ");
            var factorialvalue = Console.ReadLine();
            var tempfactvalue = 1;
            bool isnumber = double.TryParse(factorialvalue, out double n);

            if (isnumber && double.Parse(factorialvalue)>0)
            {
                for (int i = 0; i < double.Parse(factorialvalue); i++)
                {
                    tempfactvalue += (tempfactvalue * i);
                }
                Console.WriteLine("factorial value :" + tempfactvalue);
            }
            else { Console.WriteLine("non numeric / negative value"); }            
            Console.ReadLine();
        }
        public void ReversofGivenNumber()
        {
            Console.WriteLine("Enter Sequence of on number");
            string seqnumber = Console.ReadLine().ToString();
            string reverseseqnumber = "";
            if (seqnumber.Length == 0) { Console.WriteLine("no input is provided"); }
            if (seqnumber.Length > 0)
            {
                //
                //for (int i = 0; i < seqnumber.Length; i++)
                //{
                //    reverseseqnumber += seqnumber[(seqnumber.Length - 1) - i];
                //}

                for(int i=seqnumber.Length;i>0;i--)
                {
                    reverseseqnumber += seqnumber[i-1];
                }
                Console.WriteLine("original value : " + seqnumber + " reverse value :" + reverseseqnumber);
            }
            else
            {
                Console.WriteLine("Print input in reverse order : " + seqnumber);
            }
            Console.ReadLine();
        }

        public void Swap2NumbersWithoutTempVariable()
        {
            int input1, input2;

            Console.WriteLine("Enter 1st value for swap:");
            input1=int.Parse(Console.ReadLine().ToString());
            Console.WriteLine("Enter 2nd value for swap");
            input2 = int.Parse(Console.ReadLine().ToString());

            //Swaping numbers
            input1 = input1 + input2;
            input2 = input1 - input2;
            input1 = input1 - input2;

            Console.WriteLine("first swapped value : " + input1.ToString());
            Console.WriteLine("2nd swapped value  : " + input2.ToString());
            Console.ReadLine();
        }
    }
}
