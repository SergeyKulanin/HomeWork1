// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear();
Console.Write("Введите A: ");
int number1=int.Parse(Console.ReadLine());
Console.Write("Введите B: ");
int number2=int.Parse(Console.ReadLine());

if(number1>number2)
{
  Console.WriteLine("Большим числом является А");  
}
else
{
  Console.WriteLine("Большим числом является B");
}
