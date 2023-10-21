//введите  программу которая принимает трехзначное число , а на выходе показывает 2 цифру  этого числа
System.Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int number2 = (number%100)/10;
Console.WriteLine(number2);