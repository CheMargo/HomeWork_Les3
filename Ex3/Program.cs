/*Задача 23

Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/


string Cub(int N)
{
string result="";    
for(int count = 1; count<N+1; count++ )
    {
        int cub = count * count * count; 
        if (count == N)
        {
            result = result + Convert.ToString(cub);
        }
        else
        {
            result = result + Convert.ToString(cub) + ", ";
        }
    }
    return result;
}

Console.WriteLine("введите число");
int N = Convert.ToInt32(Console.ReadLine());
string programResult = Cub(N);
Console.WriteLine(N + " -> " + programResult);