namespace Lesson4_Week1.Tasks
{
    using Homework.Helpers;

    public static class Lesson4Tasks
    {
        public static void PrintMatrix()
        {
            int[,] numbers =
            {
                {1, 2, 3},
                {4, 5, 6}
            };

            if (SharedUtils.IsNull(numbers) || SharedUtils.IsEmpty(numbers))
            {
                return;
            }

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.Write($"{numbers[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        public static void CalculateMatrixSum()
        {
            int[,] numbers =
            {
                {10, 20},
                {30, 40}
            };

            if (SharedUtils.IsNull(numbers) || SharedUtils.IsEmpty(numbers))
            {
                return;
            }

            int total = 0;

            foreach (int num in numbers)
            {
                total += num;
            }

            Console.WriteLine($"ჯამი: {total}");
        }

        public static void FindMaxElement()
        {
            int[,] numbers =
            {
                {15, 7, 20},
                {40, 12, 8}
            };

            if (SharedUtils.IsNull(numbers) || SharedUtils.IsEmpty(numbers))
            {
                return;
            }

            int maxNum = numbers[0, 0];

            foreach (int num in numbers)
            {
                if (num > maxNum)
                {
                    maxNum = num;
                }
            }

            Console.WriteLine($"მაქსიმალური ელემენტია: {maxNum}");
        }

        public static void CountEvenNumbers()
        {
            int[,] numbers =
            {
                {2, 5, 8},
                {7, 10, 3}
            };

            if (SharedUtils.IsNull(numbers) || SharedUtils.IsEmpty(numbers))
            {
                return;
            }

            int evenCount = 0;

            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    evenCount++;
                }
            }

            Console.WriteLine($"ლუწი რიცხვების რაოდენობა: {evenCount}");
        }
    }
}