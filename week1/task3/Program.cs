//3 Math/Array
int[] arr = new[] { 271, -3, 1, 14, -100, 13, 2, 1, -8, -59, -1852, 41, 5, 0 };
int[] result = GetResult(arr); //TODO: Implement GetResult

int[] GetResult(int[] arr)
{
    int negativeSum = 0;
    int positiveProduct = 0;
    foreach (int num in arr)
    {
        switch (num)
        {
            case < 0:
                negativeSum = negativeSum + num;
                break;
            case > 0:
                if (positiveProduct == 0)
                    positiveProduct = num;
                else
                    positiveProduct = positiveProduct * num;
                break;
        }
    }
    return new int[] { negativeSum, positiveProduct };
}

Console.WriteLine($"Sum of negative numbers: {result[0]}. Multiplication of positive numbers: {result[1]}");

