string number = ReadStr("Введите символ: ");
int length = number.Length;

string[] baseArray = GetArrayFromString(number);

if (length <= 3)
    {
    
        Console.Write($" --> {number} ");
    }
    else
    {
        Console.WriteLine();
    }


string[] GetArrayFromString(string stringArray)
{
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string[] res = new string[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = Convert.ToString(nums[i]);
    }
         
    return res;
}

string ReadStr(string message)
{
    Console.Write(message);
    return Convert.ToString(Console.ReadLine());
}