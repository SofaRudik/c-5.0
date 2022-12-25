void InputArray (int [] array)
{
     for (int i=0; i<array.Length;i++)
    array[i]= new Random().Next(-5,5);
    Console.WriteLine($"[{string.Join(",",array)}]") ;
}

void ReleaseArray (int [] array)
{
    int sum = 0;
    for (int i=1; i<array.Length;i+=2)
    { sum=sum + array[i];} 
    Console.WriteLine($"Сумма нечетных элементов: {sum}") ;
}

Console.Clear();
Console.WriteLine("Введите количество элементов массива: ");
int n= Convert.ToInt32(Console.ReadLine());
int [] array = new int [n];
InputArray(array);
ReleaseArray(array);

