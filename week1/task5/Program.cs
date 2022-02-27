//5. Arrays

int[] input = new[] { 1, 2, 5, 7, 2, 3, 5, 7 };

// In this variable we will store the lenght off the input array divided by 2
int halfLenght = 0;
if (input != null & input.Length % 2 == 0)
{
    halfLenght = input.Length / 2;

    int[][] splitArray = Split(input);
    int[] result = AddArray(splitArray);
    WriteResult(result);

}
else
{
    Console.WriteLine("Array must be even!");
}

// Step 1: Split
int[][] Split(int[] input)
{
    // create and array with tge first half of orinal arrray
    int[] first = new int[halfLenght];
    Array.ConstrainedCopy(input, 0, first, 0, halfLenght);

    //create second array with the second half of original array
    int[] second = new int[halfLenght];
    Array.ConstrainedCopy(input, halfLenght, second, 0, halfLenght);

    // create the 2 dimentional array to be returned
    int[][] arr = new int[][] { first, second };
    return arr;
}

// Step 2: Add arrays
int[] AddArray(int[][] input)
{
    int[] result = new int[halfLenght];

    for (int i = 0; i < halfLenght; i++)
    {   //we store the result of the of the two arrays in the newly created result array
        result[i] = input[0][i] + input[1][i];
    }
    return result;
}

// Step 3: Console log result array
void WriteResult(int[] result)
{
    Array.ForEach(result, Console.WriteLine);
}