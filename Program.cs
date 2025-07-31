using System.Text;

namespace Challenge_Labs_4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "Hello World";
            char[] letters = word.ToCharArray();
            ReverseString(letters);
            Console.WriteLine("Reversed Word: ");
            for (int i = 0; i < letters.Length; i++)
            {
                Console.Write(letters[i]);
            }
        }
        static void ReverseString(char[] word)
        {
            for (int i = 0, j = word.Length - 1; i < j; i++, j--)
            {
                char temp = word[i];
                word[i] = word[j];
                word[j] = temp;
            }
        }


            
        
    }
}
