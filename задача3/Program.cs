//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
System.Console.WriteLine("Введите цифру ");
int n = Convert.ToInt32(Console.ReadLine());
if (n>=6 && n<8)
{
    System.Console.Write("это вых ");
}

 else if (n>7)
{
    System.Console.WriteLine("такого дня нет");
}
else 
{
    System.Console.WriteLine("это рабочий день ");
}