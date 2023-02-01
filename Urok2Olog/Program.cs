// int [] array = new int [5];
// for (int i = 0; i < 5; i++)
//     array[i] = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("["+string.Join(", ", array)+"]");
// Console.WriteLine(array[3]);                          //Сложность алгоритма O(1)



// int n = 5;
// int [] array = new int [n];
// for (int i = 0; i < n; i++)
//     array[i] = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("["+string.Join(", ", array)+"]");
// // [4, 5, 3, 1, 2]
// //O(n)
// //[1, 2, 3, 4, 5] - O(n*log n)
// // ((5+1)/2) * 5  - O(1)
// int summa = 0;
// for (int i = 0; i < n; i++)
// {
//     summa += array[i];
// }
// Console.WriteLine(summa);   //  O(n)


// int n = Convert.ToInt32(Console.ReadLine());      // O(n^2)   Таблица умножения
// for (int i = 1; i <= n; i++)
// {
//     for (int j = 1; j <= n; j++)
//     {
//         Console.Write(i * j);
//         Console.Write("\t ");
//     }
//     Console.WriteLine();
// }



int n = Convert.ToInt32(Console.ReadLine());      //   Таблица умножения c помошью матрицы  O(n^2/2)
int [,] matrix = new int [n,n];
for (int i = 0; i <  n; i++)
{
    for (int j = 1; j < n; j++)
    {
       if (i + j <= n)
            matrix[i, j] = (i + 1) * (j + 1);
            matrix[j, i] = (i + 1) * (j + 1);
    }
    Console.WriteLine();
}
for (int i = 1; i < n; i++)
{
    for (int j = 1; j < n; j++)
    {
        Console.Write(i * j);
        Console.Write("\t ");
    }
    Console.WriteLine();
}
