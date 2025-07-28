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
            Stack<char> mystring = new();
            foreach (char c in input)
            {
                mystring.Push(c);
            }
            string reversed = "";
            while (mystring.Count > 0)
            {
                reversed += mystring.Pop();
            }
            return reversed;
        }
    }
}
