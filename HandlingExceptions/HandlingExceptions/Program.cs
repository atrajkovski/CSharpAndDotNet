using  static System.Console;

namespace HandlingExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Before parsing");
            Write("What is your age?");
            string? input = ReadLine(); // or use "49" in a notebook
            try
            {
                int age = int.Parse(input);
                WriteLine($"You are {age} years old. ");
            }
            catch
            {

            }
            WriteLine("After parsing");
        }
    }
}
