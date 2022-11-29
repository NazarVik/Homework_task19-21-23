// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли 
// оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void PolindromCheck(string str)
{
    char[] arr = str.ToCharArray();
    char[] reversedArr = new char[5];
    int count = 0;

    for(int i = arr.Length -1; i >= 0; i--)
    {
        reversedArr[count] = arr[i];
        count++;
    }

    if(arr.SequenceEqual(reversedArr)) Console.WriteLine(str + " -> да");
    else Console.WriteLine(str + " -> нет");
}

Console.Clear();
Console.Write("введите пятизначное число = ");
string number  = Console.ReadLine();
PolindromCheck(number);
