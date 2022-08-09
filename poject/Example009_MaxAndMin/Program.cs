Console.Clear();
int a = 7;
int b = 15;
int max = 0;
int min = 0;

if(a>b)
{
    max = a;
    min = b;
}
else 
{
    max = b;
    min = a;
}  

Console.WriteLine($"Max{max} Min{min}");