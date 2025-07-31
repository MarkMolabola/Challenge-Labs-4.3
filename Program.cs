using System.Text;

namespace Challenge_Labs_4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Word: ");
            string input = Console.ReadLine();
            ReverseString(input);
            Console.WriteLine($"Reversed: {ReverseString(input)}");


        }
        static string ReverseString(string input)
        {
            char[] word = input.ToCharArray();

            for (int i = 0, j = input.Length - 1; i < j; i++, j--)
            {
                
                char temp = word[i];
                word[i] = word[j];
                word[j] = temp;

            }
            return new string (word);
        }


            
        
    }
}
