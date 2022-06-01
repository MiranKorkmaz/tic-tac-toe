using System;

namespace tictactoe 
{
    internal class Program
    {
        // Create play field
        static void Main(string[] args)
        {
            SetField();
        }

        public static void SetField() {
            Console.WriteLine("     |      |      ");
            // TODO replace numbers with variables
            Console.WriteLine(" {0}   |  {1}   |  {2}", 1,2,3);
            Console.WriteLine("_____|______|______");
            Console.WriteLine("     |      |      ");
            Console.WriteLine(" {0}   |  {1}   |  {2}", 1,2,3);
            Console.WriteLine("_____|______|______");
            Console.WriteLine("     |      |      ");
            Console.WriteLine(" {0}   |  {1}   |  {2}", 1,2,3);
            Console.WriteLine("_____|______|______");
            Console.WriteLine("     |      |      ");

        }
    }
}