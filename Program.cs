using System;

namespace whole_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] whole_numbers = {54, 56};
            Console.WriteLine(SumWholeNumbers(whole_numbers[0], whole_numbers[1]));
        }
        static int SumWholeNumbers(int num1, int num2){
            int sum = 0;
            for(int i = num1; i <= num2; i++){
                sum += i;
            }
            return sum;
        }
    }
}
