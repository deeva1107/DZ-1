// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

System.Console.Write("Введите число ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число ");
int number2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число ");
int number3 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2 && number1 > number3)
{
   System.Console.WriteLine( number1 + " max");    
}
else if (number2 > number1 && number2 > number3)
{
    System.Console.WriteLine( number2 + " max");

}
else System.Console.WriteLine( number3 + " max");

