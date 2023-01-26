// Задача 39
// Напишите программу, 
// которая перевернет одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т. д.)

void ReverseArrayVersion2(int[] aray)
{
int index1 = 0;
int index2 = array.Length - 1;

while (index1 < index2)
{
int obj = array[index1];
array[index1] = array[index2];
array[index2] = obj;
index++;
index--;
}
}


void ReversArray(int[] arr)
{
for (int i = 0; i < arr.Length / 2; i++)
{
int temp = arr[i];
arr[i] = arr[arr.Length - 1 -i];
arr[arr.Length - 1 - i] = temp;
}
}

int[] array = CreateArrayRndInt(12, 1, 10);
PrintArray(array);
ReversArray(array);
PrintArray(array); 
Array.Revers(array);
PrintArray(array);
ReversArrayVersion2(array);
PrintArray(array);
