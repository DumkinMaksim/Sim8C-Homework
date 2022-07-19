//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

//Например, заданы 2 массива:

//1 4 7 2

//5 9 2 3

//8 4 2 4

//5 2 6 7

//и

//1 5 8 5

//4 9 4 2

//7 2 2 6

//2 3 4 7

//Их произведение будет равно следующему массиву:

//1 20 56 10

//20 81 8 6

//56 8 4 24

//10 6 24 49


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



int[,] SortArrayindex(int[,] array,int[,] array2)
{
    int[,]multiplication=new int[array.GetLength(0),array.GetLength(1)];
    
        for(int i=0;i<array.GetLength(0);i++)
        
            for(int j=0;j<array.GetLength(1);j++)
            
                multiplication[i,j]=array[i,j]*array2[i,j];
              
return multiplication;
}

//Console.WriteLine("Input m: ->");
//int m=Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Input n: ->");
//int n=Convert.ToInt32(Console.ReadLine());

int[,]myArray=CreateRandom2dArray(3,3,-9,9);
Show2dArray(myArray);
Console.WriteLine();
int[,]myArray2=CreateRandom2dArray(3,3,-9,9);
Show2dArray(myArray2);
Console.WriteLine();
int[,] index=SortArrayindex(myArray,myArray2);

//ShowArray(index);
Console.WriteLine();
Show2dArray(index);
//Console.WriteLine(MinRows(index));

