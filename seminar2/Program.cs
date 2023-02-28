// задача 4 напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите первое число");
number_1 = Console.int.Parse(Console.Readline());

Console.Write("Введите второе число");
number_2 = Console.int.Parse(Console.Readline());

Console.Write("Введите третье число");
number_3 = Console.int.Parse(Console.Readline());
int max = number_1;

if(number_2 > max){
	max = number_2;
}
if(number_3 > max){
	max = number_3;
}
Console.Write($"Наибольшое число: {max}");