Console.Clear();
int i = 1;
bool not = true;

Console.WriteLine("Введите число:");
int N = 50;
Console.WriteLine("Чётные числа от 1 до " + N);
while (i <= N)
{
    if (i % 2 != 1)
        {
            Console.Write(i + ", ");
            not = false;
            
        }
    
            
       i++;
} 
if (N <= 1)
        {
            Console.WriteLine("Нет четных чисел");
        }


