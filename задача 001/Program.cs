// задание 1 Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

int max = A;
int min = A;

if (A > max) max = A;
if (B > max) max = B;

Console.Write("max= ");
Console.WriteLine(max);
Console.Write("min= ");
Console.WriteLine(min);

Console.WriteLine("задача выполнена");
Console.ReadLine();

Console.WriteLine("поздравляю, вы успешно выполнили задание 1");
