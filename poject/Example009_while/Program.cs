Console.Clear();
int count = 0;
Console.Write("Введите число ");
int number = int.Parse(Console.ReadLine());

count = count - (number + 1);

while (count < number)  
{
    count += 1;
    Console.WriteLine(count + " ");
}