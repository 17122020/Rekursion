// Задайте значения M и N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

// Console.Write("Введите значение m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// void ShowNumbers(int start, int end)
// {
// if (start == end )
// {
//    Console.Write(start);
//    return;
// }
// Console.Write(start + " ");
// ShowNumbers(start+1, end);
// }
// ShowNumbers(m, n);


// Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.


// Console.Write("Введите неотрицательное число m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите неотрицательное число n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// AkkermanFunction(m,n);
// int Akkerman(int m, int n)
// {
// if (m == 0)
// {
// return n + 1;
// }
// else if (n == 0 && m > 0)
// {
// return Akkerman(m - 1, 1);
// }
// else 
// {
// return (Akkerman(m - 1, Akkerman(m, n - 1)));
// }
// }

// void AkkermanFunction(int m, int n)
// {
//     Console.Write(Akkerman(m, n)); 
// }

// Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

int[] array = {1, 2, 5, 0, 10, 34};
int size = array.Length;
void ShowArray (int [] array, int size)
{
   if (size == 0)
   {
      Console.Write(array[size]);
      return;
   }
   else 
   {
      Console.Write(array[size] + " ");
      ShowArray(array,size - 1);
   }
}
ShowArray(array, array.Length - 1);

