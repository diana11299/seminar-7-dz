//Задача 47. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
/*
double [,] CreateRandom2dArray()
{
    Console.Write("Imput a quantity of rows: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Imput a quantity of colums: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write("Imput a quantity of min: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Imput a quantity of max: ");
    int max = Convert.ToInt32(Console.ReadLine());

    double[,] array = new double[ m, n]; //память под двумерный массив

    for(int i = 0; i < m; i ++)
        for(int j = 0; j < n; j ++)
            array[i,j] = Math.Round (min + (max - min)* new Random().NextDouble(), 2);
    return array;
}

void Show2dArray(double[,] array) // метод вывода двумерного массива
{
    for (int i = 0; i < array.GetLength(0); i ++)
    {
        for(int j = 0; j < array.GetLength(1) ; j ++)
            Console.Write( array [i,j] + " ");

        Console.WriteLine();
    }
}

double[,] myArray =  CreateRandom2dArray ();
Show2dArray(myArray);
*/

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет
/*
Console.WriteLine("Imput array dimensions");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
 
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
        array [i, j] = Convert.ToInt32(new Random().Next(0,21));  
}
 
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i,j] + " ");
        Console.WriteLine();
}
 
 Console.WriteLine("Imput element position");
 int a = Convert.ToInt32(Console.ReadLine());
 int b = Convert.ToInt32(Console.ReadLine());
 if (a>m && b>n)
 Console.WriteLine("This element does not exist");
 else
 {
 object c = array.GetValue(a,b);
 Console.WriteLine(c);
 }
*/

//Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

/*
int [,] CreateRandom2dArray()
{
    Console.Write("Imput a quantity of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Imput a quantity of colums: ");
    int colums = Convert.ToInt32(Console.ReadLine());
    Console.Write("Imput a quantity of min: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Imput a quantity of max: ");
    int max = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[ rows, colums]; //память под двумерный массив

    for(int i = 0; i < rows; i ++)
        for(int j = 0; j < colums; j ++)
            array[i,j] = new Random().Next(min, max +1);
    return array;
}

void Show2dArray(int[,] array) // метод вывода двумерного массива

{
    for (int i = 0; i < array.GetLength(0); i ++)
    {
        for(int j = 0; j < array.GetLength(1) ; j ++)
            Console.Write( array [i,j] + " ");

        Console.WriteLine();
    }
}


void AveregeColomns(int[,] array)
{     
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];                        
        }                     
        double average = sum / (array.GetLength(1));
        Console.WriteLine($"{average} is averege of {j} colomn");
    }
                
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
AveregeColomns(myArray);
*/
