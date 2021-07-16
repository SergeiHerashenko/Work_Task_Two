using System;

namespace Task_Two
{
    class Program
    {
        //Змінні для запам’‎ятовування індексу
        public static int min = 0;
        public static int max = 0;

        public static int CalculatorMinValue(int[] Value_Copy)
        {
            int MinValue = Value_Copy[0];

            //Знаходження мінімального значення
            for (int i = 0; i < Value_Copy.Length; i++)
            {
                if (MinValue > Value_Copy[i])
                {
                    MinValue = Value_Copy[i];
                    min = i;
                }
            }

            return min;
        }

        public static int CalculatorMaxValue(int[] Value_Copy)
        {
            int MaxValue = Value_Copy[min];

            //Знаходняя максимального значення(стартуючи від індексу мінімального значення)
            for (int j = min; j < Value_Copy.Length; j++)
            {
                if (MaxValue < Value_Copy[j])
                {
                    MaxValue = Value_Copy[j];
                    max = j;
                }
            }

            return max;
        }
        static void Main(string[] args)
        {
            //Введення значень користувачем(заповненя строкового масиву)
            string[] Value = Console.ReadLine().Split(' ');

            //Створюемо масив цілих чисел
            int[] Value_Copy = new int[Value.Length];

            for(int i = 0; i < Value.Length; i++)
            {
                Value_Copy[i] = Convert.ToInt32(Value[i]);
            }

            CalculatorMinValue(Value_Copy);
            CalculatorMaxValue(Value_Copy);

            //Вивід на консоль результату
            Console.WriteLine(Value_Copy[max] - Value_Copy[min]);
        }
    }
}
