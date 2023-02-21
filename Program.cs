using System.Globalization;

namespace ConsoleAppAnnex1
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayMenu();

            Console.WriteLine("Would you like to perform an operation? Please answer with yes or no. :)");
            string? choice = Console.ReadLine().ToUpper();
            string str = string.Empty;
            while(choice.Equals("YES"))
            {
                Console.WriteLine("Which operation would you like to perform?");
                Console.WriteLine("Choose a, b, c, d, e or f!");
                string? operation = Console.ReadLine().ToUpper(); 
                switch (operation)
                {
                    case "A": 
                        Console.WriteLine("You chose A!");
                        Console.Write("Please insert a string: "); str = Console.ReadLine();
                        Console.WriteLine("The result is: " + ToUpperCase(str));
                        break;
                    case "B": 
                        Console.WriteLine("You chose B!");
                        Console.Write("Please insert a string: "); str = Console.ReadLine();
                        Console.WriteLine("The result is: " + ReverseString(str));
                        break;
                    case "C": 
                        Console.WriteLine("You chose C!");
                        Console.WriteLine("Please insert a string: "); str = Console.ReadLine().ToUpper();
                        Console.WriteLine("The result is: " + CountTheVowels(str) + " vowels!");
                        break;
                    case "D": 
                        Console.WriteLine("You chose D!");
                        Console.WriteLine("Please insert a string: "); str = Console.ReadLine();
                        Console.WriteLine("The result is: " + CountTheWords(str));
                        break;
                    case "E": 
                        Console.WriteLine("You chose E!");
                        Console.WriteLine("Please insert a string: "); str = Console.ReadLine();
                        Console.WriteLine("The result is: " + ToTitleCase(str));
                        break;
                    case "F":
                        Console.WriteLine("You chose F!");
                        Console.WriteLine("Please insert a string: "); str = Console.ReadLine();
                        if(IsPalindrome(str))
                        {
                            Console.WriteLine("Your string is a palindrome!");
                        } else
                        {
                            Console.WriteLine("Your string is not a palindrome!");
                        }
                        break;
                    default: Console.WriteLine("Wrong input! Would you like to try again?"); break;
                }
                Console.WriteLine("Would you like to perform a new operation? Please answer with yes or no. :)");
                operation = Console.ReadLine().ToUpper();
                if (operation.Equals("YES")) {
                    DisplayMenu();
                    continue;
                } else {
                    break;
                }
            }
        }
        public static void DisplayMenu()
        {
            Console.WriteLine("---MENU---");
            Console.WriteLine("Options:");
            Console.WriteLine("\ta. Convert a string to uppercase");
            Console.WriteLine("\tb. Reverse a string");
            Console.WriteLine("\tc. Count the number of vowels in a string");
            Console.WriteLine("\td. Count the number of words is a string");
            Console.WriteLine("\te. Convert a string to title case");
            Console.WriteLine("\tf. Check if a string is palindrome\n");
        }
        public static string ToUpperCase(string str) 
        {
            str = str.ToUpper();
            return str;
        }
        public static string ReverseString(string str)
        {
            char[] stringArray = str.ToCharArray();
            Array.Reverse(stringArray);
            return new string (stringArray);
        }
        public static int CountTheVowels(string str)
        {
            char[] vowels = { 'A', 'E', 'I', 'O', 'U' };
            return str.Count(v => vowels.Contains(v));
        }
        public static int CountTheWords(string str)
        {
            return str.Split(" ", StringSplitOptions.RemoveEmptyEntries).Length;
        }
        public static string ToTitleCase(string str)
        {
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            return textInfo.ToTitleCase(str.ToLower());
        }
        public static bool IsPalindrome(string str)
        {

            str = str.ToLower();
            int start = 0;
            int end = str.Length - 1;

            while (start < end)
            {
                if (str[start] != str[end])
                    return false;
                start++;
                end--;
            }
            return true;
        }
    }
}