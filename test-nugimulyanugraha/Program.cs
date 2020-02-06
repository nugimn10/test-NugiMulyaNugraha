using System;
using System.Linq;

namespace test_NugiMulyaNugraha
{
    class Program
    {
        static void Main(string[] args)
        {
            //number one
            NumberOne.hello(args);
            //number two
            NumberTwo.BirthdayCount();
            //number three
            NumberThree.CountString("Hellow World!");
            NumberThree.CountString("Hellow Universe!");
            //number four

            //number five
            NumberFive.odds(args);
            NumberFive.Even(args);
            //number six
            NumberSix.Grade(args);
            //number seven
            NumberSeven.CelsiusToFahrenheit(0);
            NumberSeven.FahrenheitToCelsius(50);
            NumberSeven.CelsiusToKelvin(100);
            NumberSeven.KelvinToCelsius(375);
            NumberSeven.KelvinToFahrenheit(375);
            NumberSeven.FahrenheitToKelvin(12);
            //numer eight
            NumberEight.isLeapYear(Convert.ToInt32(2019));
            //number nine
            var jakarta = Tuple.Create("Jakarta", 7);
            var bali = Tuple.Create("Bali", 8);
            var london = Tuple.Create("London", 0);
            var cairo = Tuple.Create("Cairo", 2);
            var denver = Tuple.Create("Denver", -6);
            var chicago = Tuple.Create("Chicago", -5);
            NumberNine.TimezoneDiff(jakarta, london);
            NumberNine.TimezoneDiff(cairo, chicago);
            NumberNine.TimezoneDiff(cairo, bali);
            NumberNine.TimezoneDiff(denver, jakarta);
            //number ten
            NumberTen.Sum(4, 5);
            NumberTen.Substract(5, 4);
            NumberTen.Divide(8, 4);
            NumberTen.Multiply(5, 3);
            //number eleven
            NumberEleven.sumAllArg(1);
            //number twelve
            NumberTwelve.uppercase("HelloWorld");
            //number thirteen
            NumberThirteen.CountWords("Lorem ipsum dolor sit amet");
            //number fourtheen
            NumberFourtheen.IsPalidrome("ibu ratna antar ubi");
            //number fiftheen
            NumberFiftheen.Mirror("---vvv");
            //number sisxteen
            NumberSixteen.IndexFinder("Jeruk");
            NumberSixteen.IndexFinder("Pepaya");
            NumberSixteen.IndexFinder("Markisa");
            //number seventeen
            NumberSeventeen.CreateALoop();
            //number eighteen
            NumberEighteen.findMax(1);
            NumberEighteen.finMin(1);
            NumberEighteen.findAverage(1);
            //number nineteen
            NumberNineteen.SorterdAray();
            //number twenty

            NumberTwenty item = new NumberTwenty();
            item.name = "Indomie Goreng";
            item.price = 3500;
            item.onSale = true; 
            Console.WriteLine(item.print());











        }
    }
    class NumberOne
    {
        public static void hello(string[] args)
        {
            Console.WriteLine("input your name now");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, my name is " + name);
            Console.ReadLine();
            Console.Clear();

        }
    }
    class NumberTwo
    {
        public static void BirthdayCount()
        {
            DateTime birthday = new DateTime(1995, 12, 10);
            DateTime today = DateTime.Today;
            DateTime next = birthday.AddYears(today.Year - birthday.Year);

            if (next < today)
            {
                if (!DateTime.IsLeapYear(next.Year + 1))
                    next = next.AddYears(1);
                else
                    next = new DateTime(next.Year + 1, birthday.Month, birthday.Day);
            }

            int numDays = (next - today).Days;
            Console.WriteLine($"{numDays} days remaining to my next birthday.");
            Console.ReadLine();
            Console.Clear();
        }



    }

    class NumberThree
    {
        public static void CountString(string input)
        {

            int length = input.Length;

            Console.WriteLine($"Hello World have {length} characthers");

            return;
        }

    }

    class NumberFour
    {
        public static void cencored(string[] cencored, string paragraph)
        {
            for (int i = 0; 1 < cencored.Length; i++) 
            {
                
            }
        }
    }
    class NumberFive
    {
        public static void Even(string[] args)
        {
            int i;
            Console.Write("isEven : ");
            i = int.Parse(Console.ReadLine());
            if (i % 2 != 0)
            {
                Console.WriteLine("False");

            }
            else
            {
                Console.WriteLine("True");

            }


        }
        public static void odds(string[] args)
        {
            int i;
            Console.Write("isOdd : ");
            i = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.WriteLine("False");

            }
            else
            {
                Console.WriteLine("True");

            }


        }
    }
    class NumberSix
    {
        public static void Grade(string[] args)
        {
            int grade;
            Console.WriteLine("Input Grade Here :");
            grade = int.Parse(Console.ReadLine());
            Console.Write("Your Grade Is ");
            if (grade >= 90) Console.WriteLine("A");
            if (grade >= 80 && grade <= 89) Console.WriteLine("B");
            if (grade >= 70 && grade <= 79) Console.WriteLine("C");
            if (grade >= 60 && grade <= 69) Console.WriteLine("D");
            if (grade <= 59) Console.WriteLine("E");
        }
    }

    class NumberSeven
    {
        public static void CelsiusToFahrenheit(int celsius)
        {
            var result = ((celsius * 9) / 5) + 32;
            Console.WriteLine(result);
        }
        public static void FahrenheitToCelsius(int fahrenheit)
        {
            var result = ((fahrenheit - 32) * 5) / 9;
            Console.WriteLine(result);
        }
        public static void CelsiusToKelvin(int celsius)
        {
            var result = celsius + 273.15;
            Console.WriteLine(result);
        }
        public static void KelvinToCelsius(int kelvin)
        {
            var result = kelvin - 273.15;
            Console.WriteLine(result);
        }
        public static void KelvinToFahrenheit(int kelvin)
        {
            var result = (((kelvin - 273.15) * 9) / 5) + 32;
            Console.WriteLine(result);
        }
        public static void FahrenheitToKelvin(int fahrenheit)
        {
            var result = (((fahrenheit + 459.67) * 5) / 9);
            Console.WriteLine(result);
        }
    }
    class NumberEight
    {
        public static void isLeapYear(int year)
        {
            Console.WriteLine("Input Year : ");
            year = int.Parse(Console.ReadLine());
            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine("True");
            }

            else
            {
                Console.WriteLine("False.");
            }
        }

    }
    class NumberNine
    {
        public static void TimezoneDiff(Tuple<string, int> regionA, Tuple<string, int> regionB)
        {
            if (regionA.Item2 > regionB.Item2)
            {
                var differences = regionA.Item2 - regionB.Item2;
                Console.WriteLine($"{regionA.Item1} {differences} hours ahead of {regionB.Item1}");
            }
            else if (regionA.Item2 < regionB.Item2)
            {
                var differences = regionB.Item2 - regionA.Item2;
                Console.WriteLine($"{regionA.Item1} {differences} hours behind of {regionB.Item1}");
            }
        }
    }

    class NumberTen
    {
        public static void Sum(int x, int y)
        {
            Console.WriteLine("Hasil tambah ");
            int j = x + y;
            Console.WriteLine(j);
        }
        public static void Substract(int x, int y)
        {
            Console.WriteLine("Hasil kurang ");
            int j = x - y;
            Console.WriteLine(j);
        }
        public static void Multiply(int x, int y)
        {
            Console.WriteLine("Hasil kali ", x, "*", y);
            int j = x * y;
            Console.WriteLine(j);
        }
        public static void Divide(int x, int y)
        {
            Console.WriteLine("Hasil bagi ");
            int j = x / y;
            Console.WriteLine(j);
        }

    }
    class NumberEleven
    {
        public static void sumAllArg(int temp)
        {
            int[] y = { 1, 5, 8, 3 };
            int l = y.Length;
            for (int i = 0; i < l; i++)
            {
                temp = y[i];
            }

            Console.WriteLine(temp);
        }

    }
    class NumberTwelve
    {
        public static void uppercase(string str1)
        {

            string upperstr1 = str1.ToUpper();

            Console.WriteLine(upperstr1);
        }
    }
    class NumberThirteen
    {
        public static void CountWords(string text)
        {
            int wordCount = 0, index = 0;

            // skip whitespace until first word
            while (index < text.Length && char.IsWhiteSpace(text[index]))
                index++;

            while (index < text.Length)
            {
                // check if current char is part of a word
                while (index < text.Length && !char.IsWhiteSpace(text[index]))
                    index++;

                wordCount++;

                // skip whitespace until next word
                while (index < text.Length && char.IsWhiteSpace(text[index]))
                    index++;
            }
            Console.WriteLine(wordCount);
            Console.ReadLine();
            Console.Clear();
        }
    }
    class NumberFourtheen
    {
        public static bool IsPalidrome(string words)
        {
            string first = words.Substring(0, words.Length / 2);
            char[] arr = words.ToCharArray();

            Array.Reverse(arr);

            string temp = new string(arr);
            string second = temp.Substring(0, temp.Length / 2);

            Console.WriteLine(first.Equals(second));
            return first.Equals(second);
        }
    }
    class NumberFiftheen
    {
        public static void Mirror(string text)
        {

            char[] reversedArray = text.ToCharArray();
            Array.Reverse(reversedArray);
            text = text + new string(reversedArray);

            Console.WriteLine(text);
            Console.ReadLine();
            Console.Clear();
        }
    }
    class NumberSixteen
    {
        public static void IndexFinder(string y)
        {
            string[] fruits = {
                "Jeruk",
                "Apel",
                "Anggur",
                "Pepaya",
                "Pisang",
                "Kiwi",
                "Markisa",
            };

            int i = Array.IndexOf(fruits, y);
            Console.WriteLine(i);
            Console.Clear();


        }
    }
    class NumberSeventeen
    {
        public static void CreateALoop()
        {
            int n = 1000;
            for (int i = 0; i < n; i++)
            {
                if ((i % 5) == 0) Console.WriteLine($"{i}. Foo");

                if ((i % 20) == 0) Console.WriteLine($"{i}. Bar");

                if ((i % 100) == 0) Console.WriteLine($"{i}. Bar");

            }
        }
    }
    class NumberEighteen
    {
        public static void findMax(int number)
        {
            int[] numbers = { 2, 4, 54, 12, -65, 19, 40, 92, 88, 330, -4, 54 };

            Console.WriteLine(numbers.Max());

        }
        public static void finMin(int number)
        {
            int[] numbers = { 2, 4, 54, 12, -65, 19, 40, 92, 88, 330, -4, 54 };

            Console.WriteLine(numbers.Min());

        }
        public static void findAverage(int number)
        {
            int[] numbers = { 2, 4, 54, 12, -65, 19, 40, 92, 88, 330, -4, 54 };

            Console.WriteLine(numbers.Average());

        }
    }
    class NumberNineteen
    {
        public static void SorterdAray()
        {
            int[] points = { 2, 4, 54, 12, -65, 19, 40, 92, 88, 330, -4, 45 };
            Array.Sort(points);
            int l = points.Length;
            for (int i = 0; i < l; i++)
                Console.Write((points[i]) + ", ");
        }
    }
    class NumberTwenty
    {
        public string name;
        public int price;
        public bool onSale;
        public string Name   // property
        {
            get { return name; }   // get method
            set { name = value; }  // set method
        }

        public int Price   // property
        {
            get { return Price; }   // get method
            set { Price = value; }  // set method
        }

        public bool OnSale 
        {
            get { return onSale; }   // get method
            set { onSale = value; }
        }


        public string print()
        {
            if (onSale == true)
            {
                double sale = 0.2 * price;
                double np = price - sale;
                return ($"{name} ({np})");

            }
            else
            {
                return ($"{name} ({price})");
            }
           

        }
    }


}
