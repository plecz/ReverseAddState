using System;

namespace ReverseAddState
{
    public class RAState
    {
        public RAState(int input)
            : this(input, 1)
        {

        }

        private RAState(int input, int stepCount = 1)
        {
            Input = input;
            StepCount = stepCount;
            Reversed = Reverse(input);
            Sum = Input + Reversed;
        }

        public int Input { get; private set; }
        public int StepCount { get; private set; }
        public int Reversed { get; private set; }
        public int Sum { get; private set; }

        public bool IsFinalState
        {
            get
            {
                return Sum == Reverse(Sum);
            }
        }

        public RAState Next()
        {
            return new RAState(Sum, StepCount + 1);
        }

        private int Reverse(int n)
        {
            int r = 0;
            while (n > 0)
            {
                int digit = n % 10;
                r = r * 10 + digit;
                n = n / 10;
            }

            return r;
        }

        public override string ToString()
        {
            return string.Format("{0}. {1} + {2} = {3}", StepCount, Input, Reversed, Sum);
        }
    }
}
