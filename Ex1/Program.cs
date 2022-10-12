/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да*/

string Reverse( string s )
{
    char[] charArray = s.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
}

bool isPalindrome(string s)
{
    string reversedS = Reverse(s);
    if (s == reversedS)
    {
        return true;
    }
    else 
    {
        return false;
    }
}

Console.WriteLine("введите пятизначное число");
string N = Console.ReadLine();
if (isPalindrome(N) == true)
{
    Console.WriteLine(N + " -> является палиндромом");
}
else
{
    Console.WriteLine(N + " -> не является палиндромом");
 
}