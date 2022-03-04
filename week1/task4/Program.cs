//4. Classical task
int number = 6;
// I have used an unsigned long integer so we can store long integer values.
ulong nthNumber = Fibonacci(number); //TODO: Implement Fibonacci

ulong Fibonacci(int number)
{
    if (number == 0) return 0;

    ulong current = 1;
    ulong prev = 0;
    for (int i = 1; i < number; i++)
    {
        // the variable temp will hold temporarly the  value of current
        // to later use it to update prev variable
        ulong temp = current;
        current = current + prev;
        prev = temp;

    }
    return current;
}

Console.WriteLine($"Nth fibonacci number is {nthNumber}");
