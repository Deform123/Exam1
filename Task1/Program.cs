Console.Clear();

string [] array = {"Hello", "Hi", "Ola", "Bonjour", "Buongiorno", "Hej"};

string [] result = new string [array.Length];
int count = 0;

foreach (string value in array)
{
    if (value.Length <=3)
    {
    result [count] = value;
    count++;
    }
}
Console.WriteLine($"Элементы массива которые состоят из трех или менее символов : {(string.Join(" ", result, 0, count))}");