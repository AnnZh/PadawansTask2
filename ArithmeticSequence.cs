using System;

namespace PadawansTask2
{
    public static class ArithmeticSequence
    {
        public static int Calculate(int number, int add, int count)
        {
            // put your code here
            //throw new NotImplementedException();

            if (number > int.MaxValue || add > int.MaxValue || count > int.MaxValue)
                throw new ArgumentException();
            if (number <= 0 || add <= 0 || count <= 0)
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
