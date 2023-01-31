//array - 10
//m - 3

//1 5 4 1 3 4 7 4 1 2
//m = 3
//max-> 

int m = 3;
int size = 10;                        // Рандомнный массив
int[] array = Enumerable.Range(1,size)
                        .Select(item => Random.Shared.Next(10))
                        .ToArray();
Console.WriteLine($"[{string.Join(' ' , array)}]");

int max = 0;

for (int i = 0; i < array.Length - m; i++)
{
    int t = 0;
    for (int j = i; j < i + m ; j++)
    {
     t =t + array[j];        
    }
    if(t > max)max =t;
}
Console.WriteLine(max);