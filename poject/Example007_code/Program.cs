Console.Clear();
Console.Write("Введите число");
int numberA = int.Parse(Console.ReadLine());

int sqr = numberA * numberA;
Console.WriteLine(sqr);
sqr = Convert.ToInt32(Math.Pow(numberA, 2));
Console.WriteLine(sqr);