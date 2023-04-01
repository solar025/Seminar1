// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Укажите число ");
string value;
value = Console.ReadLine();
int numberA = Convert.ToInt32(value);

Console.Write("Укажите число ");
string value2;
value2 = Console.ReadLine();
int numberB = Convert.ToInt32(value2);

Console.Write("Укажите число ");
string value3;
value3 = Console.ReadLine();
int numberC = Convert.ToInt32(value3);

int max = numberA;
if (max < numberB)
{
    max = numberB;
}
if (max < numberC)
{
    max = numberC;
}
System.Console.WriteLine(max);
