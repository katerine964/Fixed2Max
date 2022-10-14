// See https://aka.ms/new-console-template for more information
void InputArray(int[] array) 
{ 
    for (int i = 0; i < array.Length; i++) 
    array[i] = new Random().Next(100, 1000); } 
int Func (int[] array)
{
    int m=0;
    for (int i = 0; i < array.Length; i++) 
    {
        if (array[i]%2==0)
        m++;
    }
    return m;
}
Console.Clear(); 
Console.Write("Введите кол-во элементов массива: "); 
int n = Convert.ToInt32(Console.ReadLine()); 
int[] array = new int[n]; 
InputArray(array); 
Console.WriteLine($"массив: [{string.Join(", ", array)}]");
Console.Write($"количество четных элементов: {Func(array)} ");