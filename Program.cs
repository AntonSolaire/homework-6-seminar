// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.WriteLine("Введите число M");
int M = Convert.ToInt32(Console.ReadLine());
int[] Numbers = new int[M];

void InputArray(int M)
{
for (int i = 0; i < M; i++)
  {
    Console.Write($"Введите {i+1} число: ");
    Numbers[i] = Convert.ToInt32(Console.ReadLine());
  }
}

int AboveZero(int[] Numbers)
{
  int count = 0;
  for (int i = 0; i < Numbers.Length; i++)
  {
    if(Numbers[i] > 0 ) 
    {
        count += 1; 
    }
  }
  return count;
}

InputArray(M);

int result = AboveZero(Numbers);

Console.WriteLine($"Введено чисел больше 0: {result} ");
