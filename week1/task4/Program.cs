//4. Classical task
int n = 6;
// I have used an unsigned long integer so we can store long integer values.
ulong nthNumber = Fibonacci(n); //TODO: Implement Fibonacci

ulong Fibonacci(int n)
{
    if (n == 0) return 0;

    ulong current = 1;
    ulong prev = 0;
    for (int i = 1; i < n; i++)
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
