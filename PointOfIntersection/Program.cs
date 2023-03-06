// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, 
// b2 = 4, k2 = 9 -> (-0,5; -0,5)

// x =(b2 - b1) / (k1 - k2);

Console.Clear();

double k1 = PutNumber("Введите k1 : ");
double k2 = PutNumber("Введите k2 : ");
double b1 = PutNumber("Введите b1 : ");
double b2 = PutNumber("Введите b2 : ");

double xCoordinate = (b2 - b1)/(k1 - k2);
double yCoordinate = k1 * xCoordinate + b1;

System.Console.WriteLine($"Координаты точки пересечения({xCoordinate};{yCoordinate})");


double PutNumber(string greeting)
{
  System.Console.Write(greeting);
  double numberFromeConsole = Convert.ToDouble(Console.ReadLine());
  return numberFromeConsole;
}

