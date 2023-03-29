// Главная функция для обработки массива массива
string[] ResArray(string[] array, int maxLength = 3)
{
    int j = 0;

    foreach (string str in array)
        if (str.Length <= maxLength)
            j++;

    string[] resultArray = new string[j];
    j = 0;

    foreach (string str in array)
        if (str.Length <= maxLength)
        {
            resultArray[j] = str;
            j++;
        }

    return resultArray;
}

// Вспомогательная функция для вывода массива в консоль
void ShowArray(string[] array, string msg = "Array")
{
    Console.WriteLine(msg + ":");

    foreach (string str in array)
        Console.Write(str + " ");

    Console.WriteLine();
}


string[] initArray = new string[] { "-2", "2", "world", ":-)" };

ShowArray(initArray);
string[] resultArray = ResArray(initArray);
ShowArray(resultArray, "Final array");