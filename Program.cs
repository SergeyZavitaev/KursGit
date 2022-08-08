Random rd = new Random();

Console.WriteLine("Hello, World!");
//int sd = Console.ReadLine();

//1 задачка*
int x = rd.Next(-10,11);
int y = rd.Next(-10,11);
Console.WriteLine(String.Format(
    x+" + "+y+" = "+(x+y)));
Console.WriteLine(String.Format(
    $"{x} + {y} = {x+y}"));
//Интерполяция строк

//DZ zadacha 8:
int input = 8;//rd.Next(1,1000);
int count = (input/2);
for(int index=1; index<count+1; index++)
{
    Console.Write($"{index*2}, ");
}

//DZ zadacha 2:
int input1 = 32359630;
int input2 = 34929570;
if(input1>input2)
{
    System.Console.WriteLine($"max = {input1}");

}
else
{
    System.Console.WriteLine($"max = {input2}");
}

//DZ zadacha 6:
System.Console.WriteLine(input = rd.Next(-10,11));
if (input%2==0)
{
    Console.WriteLine("Число чётное!");
}
else
{
    Console.WriteLine("Число не чётное!");
}