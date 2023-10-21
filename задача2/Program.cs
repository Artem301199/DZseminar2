// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
 System.Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
if (n/100>0)
{
    while (n>=1000)
    {
        n=n/10;
    }
    System.Console.WriteLine(n%10);
}


else
{
    System.Console.WriteLine("третьего числа нет");
}