// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


// Console.WriteLine("Введите число M");
// int M = Convert.ToInt32(Console.ReadLine());
// int[] Numbers = new int[M];

// void InputArray(int M)
// {
// for (int i = 0; i < M; i++)
//   {
//     Console.Write($"Введите {i+1} число: ");
//     Numbers[i] = Convert.ToInt32(Console.ReadLine());
//   }
// }

// int AboveZero(int[] Numbers)
// {
//   int count = 0;
//   for (int i = 0; i < Numbers.Length; i++)
//   {
//     if(Numbers[i] > 0 ) 
//     {
//         count += 1; 
//     }
//   }
//   return count;
// }

// InputArray(M);

// int result = AboveZero(Numbers);

// Console.WriteLine($"Введено чисел больше 0: {result} ");


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)



double[,] Koef = new double[2, 2];
double[] Point = new double[2];

void InputKoef(){
  for (int i = 0; i < Koef.GetLength(0); i++)
  {
    Console.Write($"Введите коэффициенты {i+1}-го уравнения (y = k * x + b):");
    for (int j = 0; j < Koef.GetLength(1); j++)
    {
      if(j==0) Console.WriteLine($"Введите коэффициент k: ");
      else Console.WriteLine($"Введите коэффициент b: ");
      Koef[i,j] = Convert.ToInt32(Console.ReadLine());
    }
  }
}

double[] Result(double[,] Koef)
{
  Point[0] = (Koef[1,1] - Koef[0,1]) / (Koef[0,0] - Koef[1,0]);
  Point[1] = Point[0] * Koef[0,0] + Koef[0,1];
  return Point;
}

InputKoef();
Result(Koef);
Console.Write($"\nТочка пересечения прямых: ({Point[0]}, {Point[1]})");
