// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
Console.ForegroundColor = ConsoleColor.Blue;
Console.Write($"Введи количество элементов массива: ");
int numberElements = int. Parse(Console.ReadLine()); 

int RandomNum(int numElem, int min, int max)
  {
  int[] randomNum = new int[numElem];
  int SumElem = 0;
  Console.ForegroundColor = ConsoleColor.Yellow;
  Console.Write("Получившийся массив: [ ");
  
   
    for (int i = 0; i <randomNum.Length; i++ )
    {
      randomNum[i] = new Random().Next(min, max);

      Console.Write(randomNum[i] + ", ");
      if (i % 2 != 0)
      
      {
        SumElem = SumElem + randomNum[i]; 
      }
    }
  return SumElem;
  }
int randomNumbers =  RandomNum(numberElements, 1, 10);
Console.WriteLine($"]-->\nСумма нечётных элементов: {randomNumbers}");
