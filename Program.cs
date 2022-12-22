string text = ReadString("Введите символы через запятую: ");
string[] baseArray = GetArrayFromString(text);

string ReadString(string message)
{
    Console.Write(message);
    return Convert.ToString(Console.ReadLine());
}

string[] GetArrayFromString(string stringArray)
{
    string[] nums = stringArray.Split(",", StringSplitOptions.RemoveEmptyEntries);
    string[] res = new string[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = Convert.ToString(nums[i]);
    }

    return res;
}

void methodNewArray(string[] array)
{
    string[] newarr = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newarr[i] = array[i]; ;
            Console.WriteLine(newarr[i]);
        }
    }
    Console.WriteLine();
}
methodNewArray(baseArray);

