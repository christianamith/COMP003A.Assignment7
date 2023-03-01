/*
 * Author:  Christian Amith
 * Course:  COMP-003A-L01
 * Purpose: Code for Week 7 Assignment
 */
namespace COMP003A.Assignment7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SectionSeperator("Array - CharacterCounter Section");
            Console.WriteLine("Please enter a letter");
            char userChar = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Please enter a word");
            string userWord = Console.ReadLine();
            int charTotal = CharacterCounter(userChar, userWord);
            Console.WriteLine($"There are {charTotal} letter {userChar} in the word {userWord}");


            SectionSeperator("Array - IsPalindrome Section");
            Console.WriteLine("Please enter a word to check if it is a palindrome");
            string palCheck = Console.ReadLine();
            string palCheckLower = palCheck.ToLower();
            bool palValueBool = IsPalindrome(palCheckLower);
            string palValueString = palValueBool.ToString();
            Console.WriteLine($"Is the word {palCheck} a palindrome: {palValueString}");


            SectionSeperator("List - Add Section");
            List<string> names = new List<string>();
            char userInput = default;
            char exit = 'e';

            do
            {
                Console.WriteLine("Please enter a name");
                names.Add(Console.ReadLine());
                Console.WriteLine("Press any key to add more or (e) to exit");

                char a = Convert.ToChar(Console.ReadLine());
                userInput = a;
            }
            while (userInput != exit);


            SectionSeperator("List - Traversal Section");
            TraverseList(names);


            SectionSeperator("List - Reverse Traversal Section");
            TraverseListReverse(names);
        }


        /// <summary>
        /// Section seperator method
        /// </summary>
        /// <param name="section">String input for section name</param>
        static void SectionSeperator(string section)
        {
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine($"\t{section} Section");
            Console.WriteLine("".PadRight(50, '*'));
        }

        /// <summary>
        /// String traversal for char count
        /// </summary>
        /// <param name="characterInput"></param>
        /// <param name="word"></param>
        /// <returns></returns>
        static int CharacterCounter(char characterInput, string word)
        {
            int count = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == characterInput)
                {
                    count++;
                }
            }
            return count;
        }

        /// <summary>
        /// Palindrome Checker
        /// </summary>
        /// <param name="word">String input</param>
        /// <returns></returns>
        static bool IsPalindrome(string word)
        {
            string reverseWord = new string(word.ToCharArray().Reverse().ToArray());
            bool palindrome = reverseWord.Equals(word);
            return palindrome;
        }

        /// <summary>
        /// Writes list to Console
        /// </summary>
        /// <param name="list"></param>
        static void TraverseList(List<string> list)
        {
            list.ForEach(Console.WriteLine);
        }

        /// <summary>
        /// Revereses list and writes to Console
        /// </summary>
        /// <param name="list"></param>
        static void TraverseListReverse(List<string> list)
        {
            list.Reverse();
            list.ForEach(Console.WriteLine);
        }
    }
}