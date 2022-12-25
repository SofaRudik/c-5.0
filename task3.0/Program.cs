void InputArray (double [] array)
{
     for (int i=0; i<array.Length;i++)
    array[i]= Convert.ToDouble(new Random().Next(0,10));
    Console.WriteLine($"[{string.Join(",",array)}]") ;
}

void ReleaseArray (double [] array)
{   double max=0,min=0;
     for (int i=0; i<array.Length;i++) 
    { 
        if(array[i]>max) max=array[i];
        else min =array[i];
    } 
    Console.WriteLine($" Макс= {max} и мин=  {min} разница= {max-min}") ;
}

Console.Clear();
Console.WriteLine("Введите количество элементов массива: ");
int n= Convert.ToInt32(Console.ReadLine());
double [] array = new double [n];
InputArray(array);
ReleaseArray(array);