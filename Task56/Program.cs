//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

//Например, задан массив:

//1 4 7 2

//5 9 2 3

//8 4 2 4

//5 2 6 7

//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка




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



int[] SortArrayindex(int[,] array)
{
    int[]sum=new int[array.GetLength(0)];
        for(int i=0;i<array.GetLength(0);i++)
        {   
        
        for(int j=0;j<array.GetLength(1);j++)
        {
            sum[i]+=array[i,j];
        }
    }          
return sum;
}
int MinRows(int[]array)
{
    int minel=array[0];
    int min=0;
    for (int k=0;k<array.Length;k++)
    {
        if(minel>array[k])
        {
            minel=array[k];
            min=k;
        }  
    }            
    return min;
}
void ShowArray(int[]array)
{
     for(int i=0;i<array.GetLength(0);i++)
        {
            Console.Write(" "+array[i]+" ");
            Console.WriteLine();
        }
}
//Console.WriteLine("Input m: ->");
//int m=Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Input n: ->");
//int n=Convert.ToInt32(Console.ReadLine());

int[,]myArray=CreateRandom2dArray(7,4,-9,9);
Show2dArray(myArray);
Console.WriteLine();

int[] index=SortArrayindex(myArray);

ShowArray(index);
Console.WriteLine();
Console.WriteLine("The row with the smallest sum of elements-> "+(MinRows(index)+1));
