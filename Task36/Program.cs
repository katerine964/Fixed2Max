// See https://aka.ms/new-console-template for more information
void InputArray(int[] array) 
{ 
    for (int i = 0; i < array.Length; i++) 
    array[i] = new Random().Next(); 
} 
int SumN (int[] array)
{
    int sum=0;
    for (int i = 1; i < array.Length; i=i+2) 
    {
        sum=sum+array[i];
    }
    return sum;
}    
Console.Clear(); 
Console.Write("Введите кол-во элементов массива: "); 
int n = Convert.ToInt32(Console.ReadLine()); 
int[] array = new int[n]; 
InputArray(array); 
Console.WriteLine($" массив: [{string.Join(", ", array)}]"); 
Console.Write($"Сумма элементов, стоящих на нечетных позициях: {SumN(array)} ");