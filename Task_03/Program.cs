// Задача 3: Напишите программу, которая перевернёт одномерный массив 
//(первый элемент станет последним, второй – предпоследним и т.д.)

void Main()
{
int[] array=GenerateArray(10, 1, 100);
PrintArray(array);
int[] invArray = InvertArray(array);
PrintArray(invArray);
}

int[] InvertArray(int[] array)
{
int[] result = new int[array.Length];

for (int i = 0; i < array.Length; i++)
{
result[array.Length - i -1] = array[i];
}
return result;

}

int[] GenerateArray(int size, int minValue, int maxValue)
{
int[] tempArray = new int[size];
Random rand = new Random();

for (int i = 0; i < tempArray.Length; i++)
tempArray[i] = rand.Next(minValue, maxValue + 1); // (0, 10)

return tempArray;
}

void PrintArray(int[] arrayForPrint)
{
Console.WriteLine("[" + string.Join(", ", arrayForPrint) + "]");
}

Main();




