int num = new Random().Next(100, 1000);
Console.WriteLine($"Number = {num}");
int last = num % 10;
int first = num / 100;
int res = first * 10 + last;
Console.WriteLine($"Случайное число = {num}");
Console.WriteLine($"Результат = {res}");
