// 1. String manipulation
string input = "world";
string reversed = ReverseString(input); //TODO: Implement ReverseString

string ReverseString(string input)
{
    if (input == null) return null;
    char[] arr = input.ToCharArray();
    Array.Reverse(arr);
    return new String(arr);
}
Console.WriteLine($"Reversed input value: {reversed}");
