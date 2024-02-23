void TwoSimbolsArray (string[] Array, List<string> NewArray)
{
    foreach (string i in Array)
    {
    if (i.Length <= 3)
        NewArray.Add(i);
    }
}

string[] Array = {"Hellow", "2", "world", ":-)"};
var NewArray = new List<string>{};
TwoSimbolsArray(Array, NewArray);
Console.WriteLine($"Изначальный массив: {string.Join(' ', Array)}");
Console.WriteLine($"Новый массив: {string.Join(' ', NewArray)}");