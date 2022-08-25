Console.Clear();
int a = 52;
int b = 152;
int c = 1000;
int max = a;
int min = a;

if(max < b)
{
    max = b;
}
else 
{
    if(min>b)
    {
        min=b;
    }
}  
if(max < c)
{
    max = c;
}
else 
{
    if(min>c)
    {
        min=c;
    }
} 


Console.WriteLine($"Max{max} Min{min}");