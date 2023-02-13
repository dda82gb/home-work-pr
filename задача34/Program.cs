// Задача 34: Задайте массив заполненный случайными 
// положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
// ---------------------------
Console.Clear();

int[] numbers = new int[6];

void FillArray(int[] array, int min, int max)
{
  for (int i = 0; i<array.Length; i++ )
  {
    array[i] = new Random().Next(min, max);
  }
}

int QuanPosit(int[] array)
{
    int quantity = 0;
    for (int i = 0; i<array.Length; i++ ){
    if (array[i] % 2 == 0)
    {
      quantity++;
    }
  }
  return quantity;
}
FillArray(numbers, 100, 1000);
QuanPosit(numbers);

Console.ForegroundColor = ConsoleColor.Green;
 Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers [i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();

Console.ForegroundColor = ConsoleColor.Red;
int quantity = QuanPosit(numbers);
Console.WriteLine($"Количество чётных чисел в массиве: {quantity}");

