Console.Clear();
int a = 44;
int b = 5;
int c = 78;
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