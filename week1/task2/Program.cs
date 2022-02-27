// 2. String/Math
string input = "Intellectualization";
int vowelCount = GetVowelCount(input); //TODO: Implement GetVowelCount 

int GetVowelCount(string input)
{
    if (input == null) return 0;

    string i = input.ToLower();
    char[] arr = i.ToCharArray();

    string vowels = "aeiou";
    char[] vowelsArr = vowels.ToCharArray();

    int count = 0;
    foreach (char l in arr)
    {
        foreach (char v in vowelsArr)
        {
            if (l == v) count++;
        }
    }
    return count;
}
Console.WriteLine($"Number of vowels: {vowelCount}");
