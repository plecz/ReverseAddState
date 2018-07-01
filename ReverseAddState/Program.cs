using System;

namespace ReverseAddState
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter the initial number: ");
                var inputString = Console.ReadLine();
                int input = int.Parse(inputString);

                var state = new RAState(input);
                Console.WriteLine(state.ToString());

                while (!state.IsFinalState)
                {
                    state = state.Next();
                    Console.WriteLine(state.ToString());
                }
                Console.WriteLine();
            }
        }
    }
}
