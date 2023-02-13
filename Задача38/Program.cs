// Задача 38: Задайте массив вещественных чисел. Найдите 
// разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
// Это задача для отправки не проверку по pull request

Console.Clear();

int[] arrayRealNum = new int[7];
Console.ForegroundColor = ConsoleColor.Green;
Console.Write("[ ");
  for (int i = 0; i < arrayRealNum.Length; i++ )
  {
    arrayRealNum[i] = new Random().Next(1, 100);
    Console.Write(arrayRealNum[i] + ", ");
  }

int maxNum = arrayRealNum[0];
int minNum = arrayRealNum[0];

  for (int i = 1; i < arrayRealNum.Length; i++)
  {
    if (maxNum < arrayRealNum[i])
    {
      maxNum = arrayRealNum[i];
    }
        if (minNum > arrayRealNum[i])
    {
      minNum = arrayRealNum[i];
    }
  }

  int answer = maxNum - minNum;
  Console.WriteLine($"]-->\nразница между максимальным ({maxNum}) и минимальным({minNum}) элементами = {answer}");
