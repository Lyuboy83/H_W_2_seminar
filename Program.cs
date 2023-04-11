// Начинаем начинать

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.WriteLine("Введите трехзначное число, лучше трехзначное иначе будете переписывать - ");
// string text_a = Console.ReadLine();
// int chislo = Convert.ToInt32(text_a);

// if (chislo < 100 || chislo > 999)
// {
//     Console.WriteLine("Переписывайте, здесь не трёхзначное число");
// }
// else
// {
//     int middle = (chislo / 10) % 10;
//     Console.WriteLine("Средняя цифра числа" + middle);
// }



// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6


// Console.WriteLine("Введите любое число чтобы узнать его третью цифру - ");
// string text_a = Console.ReadLine();
// int chislo = Convert.ToInt32(text_a);

// if ((chislo / 100) == 0)
// {
//     Console.WriteLine("третьей цифры нет");
// }
// while (chislo > 999)
// {
//     chislo = chislo / 10;
// }
// int third_cifra = (chislo % 100) % 10;

// Console.WriteLine(third_cifra);



// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// Console.WriteLine("Введите цифру дня недели - ");
// string text_a = Console.ReadLine();
// int data = Convert.ToInt32(text_a);

// if (data >= 6 && data <= 7)
// {
//     Console.WriteLine("да");
// }
// else{
    
//     Console.WriteLine("нет");
// }
