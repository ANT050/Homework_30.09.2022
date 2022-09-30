/*

Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22

*/

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
	
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Math.Max(a, Math.Max(b, c)));

/*

Math - класс для выполнения различных математических действий,
       имеет определенное количество методов. В нашем примере 
       используется метод Max.

Метод Max - возвращает наибольшее число из двух.

*/
