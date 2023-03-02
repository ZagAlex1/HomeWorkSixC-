// Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();

int arrayLength = PutNumber("Введите количество элементов массива : ");
System.Console.WriteLine("Количество элементов в массиве : {0}", arrayLength);
int[] array = FillArray(arrayLength);
PrintArray(array);
System.Console.WriteLine("Количество элементов больше нуля : {0}", CountNumbersBiggerZero(array));

int PutNumber(string greeting)
{
  System.Console.Write(greeting);
  int numberFromeConsole = Convert.ToInt32(Console.ReadLine());
  return numberFromeConsole;
}

int[] FillArray(int arrayLength)
{
  int[] arrayFromConsole = new int[arrayLength];
  for (int i = 0; i < arrayLength; i++)
  {
    arrayFromConsole[i] = PutNumber($"Введите {i} элемент : ");
  }
  return arrayFromConsole;
}

int CountNumbersBiggerZero(int[] arrayFromConsole)
{
  int count = 0;
  for (int i = 0; i < arrayFromConsole.Length; i++)
  {
    if (arrayFromConsole[i] > 0)
      count++;
  }
  return count;
}

void PrintArray(int[] arrayFromConsole)
{
  System.Console.WriteLine(String.Join(" ", arrayFromConsole));
}

