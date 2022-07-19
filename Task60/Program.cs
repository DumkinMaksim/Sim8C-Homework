//Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

//массив размером 2 x 2 x 2

//12(0,0,0) 22(0,0,1)

//45(1,0,0) 53(1,0,1)

int[,,] CreateRandom2dArray(int rows,int colums,int height,int minValue,int maxValue)
{
    int[,,] newArray= new int[rows,colums,height];

    for(int i=0;i<rows;i++)
        for(int j=0;j<colums;j++)
            for(int k=0;k<height;k++)
            newArray[i,j,k]= new Random().Next(minValue,maxValue+1);
    return newArray;
}

void Show3dArray(int[,,]array)
{
     for(int i=0;i<array.GetLength(0);i++)
        {
           
        for(int j=0;j<array.GetLength(1);j++)
            {
                
                for(int k=0;k<array.GetLength(2);k++)
                {
                   
                    Console.Write(" "+array[i,j,k]+" ("+i+","+j+","+k+")");
                   
                }
                Console.WriteLine();
            }   
           Console.WriteLine() ;         
        }
}
Console.WriteLine("Input size 3dArray->");
int z=Convert.ToInt32(Console.ReadLine());
if(z>0 && z<=10)
{
int[,,]myArray3d=CreateRandom2dArray(z,z,z,10,99);
Show3dArray(myArray3d);
}
else
Console.WriteLine("Error,size 3dArray incorrect,please try again leter");