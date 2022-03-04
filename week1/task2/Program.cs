// 2. String/Math
string input = "Intellectualization";
int vowelCount = GetVowelCount(input); //TODO: Implement GetVowelCount 

int GetVowelCount(string input)
{
    if (input == null) return 0;

    string i = input.ToLower();
    char[] arr = i.ToCharArray();

    string vowels = "aeiou";

    int count = 0;
    foreach (char c in input.ToLower())
        if (vowels.Contains(c)) count++;
    return count;
}
Console.WriteLine($"Number of vowels: {vowelCount}");
