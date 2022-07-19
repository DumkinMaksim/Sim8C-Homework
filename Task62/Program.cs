/* Задача 62. Заполните спирально массив 4 на 4.

Например, на выходе получается вот такой массив:

1 2 3 4

12 13 14 5

11 16 15 6

10 9 8 7 */

int[,] CreateSpirArray()
{
    int i = 0, n = 4, l = 1, j = 0;             
    int[,] modarray = new int[n, n];               
    for (i = 0; i < n; i++)            
    {   
        modarray[j, i] = l;                 
        l++;            
    }                      
    for (i = 1; i < n; i++)             
    {                
        modarray[i, n - 1] = l;                 
        l++;             
    }                       
    for (i = n - 2; i >= 0; i--)             
    {                 
        modarray[n - 1, i] = l;                 
        l++;            
    }                               
    for (i = n-2; i > 0; i--)             
    {                 
        modarray[i,n-4] = l;   
        l++;          
    }
    for (i = n - 3; i < 3; i++)             
    {                 
        modarray[n - 3, i] = l;                 
        l++;            
    }  
    for (i = n - 2; i > 0; i--)             
    {                 
        modarray[n - 2, i] = l;                 
        l++;            
    }                        
    return modarray;
}

void ShowModArray(int[,]array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(" "+array[i,j]+" ");
        }
        Console.WriteLine();
    }        
            
}
int[,]spirarray=CreateSpirArray();
ShowModArray(spirarray);