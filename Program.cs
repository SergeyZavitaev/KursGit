Random rd = new Random();

Console.WriteLine("Hello, World!");
//int sd = Console.ReadLine();

//1 задачка*
int x = rd.Next(-10, 11);
int y = rd.Next(-10, 11);
Console.WriteLine(String.Format(
    x + " + " + y + " = " + (x + y)));
Console.WriteLine(String.Format(
    $"{x} + {y} = {x + y}"));
//Интерполяция строк

//DZ zadacha 8:
int input = 8;//rd.Next(1,1000);
int count = (input / 2);
for (int index = 1; index < count + 1; index++)
{
    Console.Write($"{index * 2}, ");
}

//DZ zadacha 2:
int input1 = 32359630;
int input2 = 34929570;
if (input1 > input2)
{
    System.Console.WriteLine($"max = {input1}");

}
else
{
    System.Console.WriteLine($"max = {input2}");
}

//DZ zadacha 6:
System.Console.WriteLine(input = rd.Next(-10, 11));
if (input % 2 == 0)
{
    Console.WriteLine("Число чётное!");
}
else
{
    Console.WriteLine("Число не чётное!");
}

/////////////////////////////////////
//       Домашнее задание 2        //
/////////////////////////////////////

//Zadacha 10:
Console.WriteLine(input = rd.Next(100, 1000));
input = (input / 10)%10;
Console.WriteLine(input);

//Zadacha 13:
Console.WriteLine(input = rd.Next(1, 200));
if (input > 99)
{
    Console.WriteLine(input = (input / 100) % 10);
}
else
{
    Console.WriteLine("третьей цифры нет");
}

Console.WriteLine("Zadacha 15");
Console.WriteLine(input = rd.Next(-10, 11));
if (input > 7 || input < 1)
{
    Console.WriteLine("такого дня недели нет");
}
else
{
    if (input == 1) { Console.WriteLine("Понедельник"); }
    if (input == 2) { Console.WriteLine("Вторник"); }
    if (input == 3) { Console.WriteLine("Среда"); }
    if (input == 4) { Console.WriteLine("Четверг"); }
    if (input == 5) { Console.WriteLine("Пятница"); }
    if (input == 6) { Console.WriteLine("Суббота"); }
    if (input == 7) { Console.WriteLine("Воскресенье"); }
}

/////////////////////////////////////
//       Домашнее задание 3        //
/////////////////////////////////////

Console.WriteLine("Zadacha 19");
Console.WriteLine(input = rd.Next(10000, 100000));
//input = 12321;
Console.WriteLine(input / 10000 == input % 10);
if (input / 10000 == input % 10 &
    (input / 1000) % 10 == (input % 100) / 10)
{ 
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}

Console.WriteLine("Zadacha 21");
Console.WriteLine(input = rd.Next(10000, 100000));
//input = 12321;
Console.WriteLine(input / 10000 == input % 10);
if (input / 10000 == input % 10 &
    (input / 1000) % 10 == (input % 100) / 10)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}