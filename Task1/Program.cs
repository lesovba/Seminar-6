/*Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]*/
Console.Clear(); 
int[] array = GetArray(10, 0, 10); 
Console.WriteLine(String.Join(" ", array));
RevreseArray (array); 
Console.WriteLine(String.Join(" ", array));
int[] revreseArray = ReverseArray2(array); 
Console.WriteLine(String.Join(" ", revreseArray));

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

void RevreseArray(int[] arr) 
{
  for (int i = 0; i<arr.Length/2; i++) 
    {
    int k = arr[i];
    arr[i] = arr[arr.Length - i - 1];
    arr[arr.Length - i - 1] = k;
    } 
}

int[] ReverseArray2 (int[] arr)
{
    int[] result = new int [arr.Length];
    for (int i=0; i<arr.Length; i++)
    {
        result[i] = arr[arr.Length-i-1];
    }
    return result; 
}


