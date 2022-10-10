/* выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5,    78 -> третьей цифры нет,     32679 -> 6 */

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

//Console.WriteLine(str);


/* int i = 10;
string str = i.ToString();


int index = 0;
int num = num[0];
int result = num[2];

if (num <= 1)
{
    Console.WriteLine("Третьей цифры нет.");
}

if (num > 1)
{
    Console.WriteLine("Третья цифра:");
    Console.Write(num[3]);
} */