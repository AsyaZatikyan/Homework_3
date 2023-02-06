/*
Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
 int GetNumber (string massege)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(massege);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число, попробуйте еще раз");
        }
    }

    return result;
}


void GetCube (int n)
{
for (int i = 1; i <= n; i++)
{
 Console.WriteLine($"{i*i*i}");
}
}

 int n = GetNumber("Введите число N: ");
 GetCube (n) ;
