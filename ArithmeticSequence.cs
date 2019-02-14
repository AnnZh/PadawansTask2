using System;

namespace PadawansTask2
{
    public static class ArithmeticSequence
    {
        public static int Calculate(int number, int add, int count)
        {
            if (number > int.MaxValue || add > int.MaxValue || count > int.MaxValue)
                throw new OverflowException();
            if (number < int.MinValue || add < int.MinValue || count < int.MinValue)
                throw new OverflowException();
            if (count <= 0)
                throw new ArgumentException();

            int n = number;
            

            for (int i = 0; i < count - 1; i++)
            {
                number = number + (n + (add * (i + 1)));
            }

            return number;
        }
    }
}
