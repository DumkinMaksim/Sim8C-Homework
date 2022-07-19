//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

//Например, задан массив:

//1 4 7 2

//5 9 2 3

//8 4 2 4

//В итоге получается вот такой массив:

//1 2 4 7

//2 3 5 9

//2 4 4 8







int[,] CreateRandom2dArray(int rows,int colums,int minValue,int maxValue)
{
    int[,] newArray= new int[rows,colums];

    for(int i=0;i<rows;i++)
        for(int j=0;j<colums;j++)
            newArray[i,j]= new Random().Next(minValue,maxValue+1);
    return newArray;
}

void Show2dArray(int[,]array)
{
     for(int i=0;i<array.GetLength(0);i++)
        {
        for(int j=0;j<array.GetLength(1);j++)
            Console.Write(" "+array[i,j]+" ");
            Console.WriteLine();
        }
}



int[,] SortArrayindex(int[,] array)
{

     for(int i=0;i<array.GetLength(0);i++)
    {
        for(int j=0;j<array.GetLength(1);j++)
       {
        //цикл сортировки    
            for (int k=0;k<array.GetLength(1)-j-1;k++)
            {
                if (array[i,k]>array[i,k+1])
                {
                    int temp=array[i,k];
                    array[i,k]=array[i,k+1];
                    array[i,k+1]=temp;
                }
            }
        }
    }        
return array;
}
Console.WriteLine("Input m: ->");
int m=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input n: ->");
int n=Convert.ToInt32(Console.ReadLine());

int[,]myArray=CreateRandom2dArray(m,n,-9,9);
Console.WriteLine("An array with the specified parameters has been created ");
Show2dArray(myArray);

Console.WriteLine();

Console.WriteLine("The array is sorted from smaller to larger by rows");

int[,]changeArray=SortArrayindex(myArray);
Show2dArray(changeArray);
