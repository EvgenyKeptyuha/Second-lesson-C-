Console.WriteLine("Введите трехзначное число ->");
int num = int.Parse(Console.ReadLine());
int last = num % 10;
int second = num % 100;
int Number = second - last;
int num2 = Number / 10;
Console.WriteLine($"Вторая цифра - {num2}");