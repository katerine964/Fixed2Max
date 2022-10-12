Console.Clear();
int max1=0;
int max2=0;
for (int i = 0; i < 100; i++)
{
    Console.WriteLine("Введите число");
    int n = Convert.ToInt32(Console.ReadLine());
    if(n > max1)
    {
        max2=max1;
        max1=n;
    }
    if (n<max1 && n>=max2)
    {
        max2=n;
    }
    if(n==0)
    {
        break;
    } 
}    
Console.WriteLine("второй максимум "+max2);
