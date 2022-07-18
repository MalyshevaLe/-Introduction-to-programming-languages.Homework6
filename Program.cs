// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

 int[] fillAray (int number)
 {
    int[] newArray = new int[number];

    for (int i = 0; i < number; i++)
    {
        Console.Write($"Введите {i+1}-е число: ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return newArray;
 }

 int findPositiveNumber(int[]array)
 {    
   
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            count++;
        }
    }
    return count;
 }
 
 Console.Write("Введите желаемое количество чисел: ");
 int M = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine($"Количество чисел больше 0 = " + findPositiveNumber(fillAray(M)));



//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)


/*Console.WriteLine ("Введите значение b1: ");
double b1 = Convert.ToDouble (Console.ReadLine());

Console.WriteLine ("Введите значение k1: ");
double k1 = Convert.ToDouble (Console.ReadLine());

Console.WriteLine ("Введите значение b2: ");
double b2 = Convert.ToDouble (Console.ReadLine());

Console.WriteLine ("Введите значение k2: ");
double k2 = Convert.ToDouble (Console.ReadLine());


string findPointIntersect(double b1, double k1, double b2, double k2)
{   
    double x = 0;
    double y = 0;    
    x=(b2-b1)/(k1-k2);
    y=k1 * x + b1;
    return ($"Точка пересечения прямых [{x}; {y}]");    
}


Console.WriteLine(findPointIntersect(b1, k1, b2, k2));*/