Console.Clear();

string [] array = {"hello", "hi", "ola", "bonjour", "buongiorno", "Hej"};

string [] result = new string [array.Length];
int wordSize = 0;

foreach (string value in array)
{
    if (value.Length <=3)
    {
    result [wordSize] = value;
    wordSize++;
    }
}
Console.WriteLine(string.Join(" ", result, 0, wordSize));