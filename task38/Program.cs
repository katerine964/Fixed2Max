// See https://aka.ms/new-console-template for more information
void InputArray(float [] array) 
{ 
    for (int i = 0; i < array.Length; i++) 
    array[i] = new Random().Next(); 
} 
float Max (float[] array)
{
    float max=array[0];
    for (int i = 1; i < array.Length; i++) 
    {
        if(array[i]>=max)
            max=array[i];
    }
    return max;
}    
float Min (float[] array)
{
    float min=array[0];
    for (int i = 1; i < array.Length; i++) 
    {
        if(array[i]<=min)
            min=array[i];
    }
    return min;
}  
float Diff (float a, float b)
{
    float diff=a-b;
    return diff;
}
Console.Clear(); 
Console.Write("Введите кол-во элементов массива: "); 
int n = Convert.ToInt32(Console.ReadLine()); 
float [] array = new float[n]; 
InputArray(array); 
Console.WriteLine($"Массив: [{string.Join(", ", array)}]"); 
Console.WriteLine($"Наибольший элемемнт массива: {Max(array)} ");
Console.WriteLine($"Наименьший элемемнт массива: {Min(array)} ");
Console.WriteLine($"Разность: {Diff(Max(array),Min(array))} ");