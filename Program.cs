string number = ReadStr("Введите символы через запятую: ");
int length = number.Length;
string[] a = new string[0];
string[] baseArray = GetArrayFromString(number);
 
 void methodArray (string [] array){
     string[] newarr = new string[array.Length];
     for (int i=0; i<array.Length; i++){      
        if(array[i].Length<=3){
        newarr[i]=array[i];;
        Console.WriteLine(newarr[i]); 
        }
     }
        Console.WriteLine(); 
}


void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
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

string ReadStr(string message)
{
    Console.Write(message);
    return Convert.ToString(Console.ReadLine());
}

methodArray(baseArray);
PrintArray(a);
