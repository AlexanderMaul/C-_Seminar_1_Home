// 7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа

Console.WriteLine("Программа нахождения единичного разряда трёхзначного числа ");
Console.WriteLine("Введите трёхзначное число число ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 100 && num <= 999) 
{
    int erch = (num % 100) % 10;
    Console.WriteLine($"Единичный разряд числа {num} равен {erch}.");
}
else if (num <= -100 && num >= -999) 
{
    int erch = (num % 100) % 10;
    Console.WriteLine($"Единичный разряд числа {num} равен {erch}.");
}
else Console.WriteLine($"Число {num} не является трёхзначным");


// Комментарий преподавателя - Общее замечание - в именах переменных в C# нижнее подчёркивание _ допускается, но не рекомендуется (на практике не принято).