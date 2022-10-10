Console.WriteLine("Введите любое число.");
int number = int.Parse(Console.ReadLine()!);

if (number <= 99)
{
    Console.WriteLine("Третья цифра числа отсутствует");
}
else
{
    string str = $"{number}";
    Console.WriteLine("Третья цифра числа: ");
    Console.WriteLine(str[2]);
}