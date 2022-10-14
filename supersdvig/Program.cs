void InputArray(int[] array) 
{ 
    for (int i = 0; i < array.Length; i++) 
    array[i] = new Random().Next(-10, 11); 
} 
void NewArray(int[] array, int m)
{   
    int l=array.Length;    
    int k = m%l;
    int[] newarr=new int[l];
    for (int i = 0; i < l; i++)
    {
        if(i+k<l && i+k>=0)
            newarr[i+k]=array[i];
        if(i+k>=l)
            newarr[i+k-l]=array[i];
        if (i+k<0)
            newarr[i+k+l]=array[i];
    }
    Console.WriteLine($"новый массив: [{string.Join(", ", newarr)}]");
}
Console.Clear(); 
Console.Write("Введите кол-во элементов массива: "); 
int n = Convert.ToInt32(Console.ReadLine()); 
int[] array = new int[n]; 
InputArray(array); 
Console.WriteLine($"массив: [{string.Join(", ", array)}]");
Console.WriteLine("Введите число К: ");
int k = Convert.ToInt32(Console.ReadLine()); 
NewArray(array, k); 
