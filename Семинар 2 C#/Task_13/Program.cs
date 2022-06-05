Console.WriteLine("Введите число ->");
int n = int.Parse(Console.ReadLine());
Console.WriteLine(n > 99 ? n.ToString()[2] : "Третьей цифры нет");