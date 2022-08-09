// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями,
//  лучше обойтись исключительно массивами
string[] array1 = new string[4] {"1234", "1567", "-2", "computer science"};

int FindNewLentgth(string [] array1)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)               
        count++;
       // Console.WriteLine(count);
    }
    return count;
}

string[] GetNewArray(string[] array1, int count)
{
    string[] array2 = new string[count];
    int pos = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[pos] = array1[i];
        pos++;
        }
    }
    return array2;
}

void PrintArray(string[] arr)
{
     Console.Write("[");
    for ( int i  = 0; i < arr.Length; i ++)
{
    
    if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
    else Console.Write(arr[i]);
} 
 
  Console.Write("]");
  
}

PrintArray(GetNewArray(array1, FindNewLentgth(array1)));