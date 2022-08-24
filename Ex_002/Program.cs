//Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.

void Zadacha4()
{
    Console.WriteLine("Введите число m:");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число n:");
    int n = Convert.ToInt32(Console.ReadLine());
    Recursion(m,n);
   
}


void Recursion(int m, int n, int sum = 0)
{
    if (m > n) 
    {
        Console.Write($"Cумма натуральных элементов:{sum + n}");
        return;
    }
    
    sum += m % n;
    m++;
    
    Recursion(m,n, sum);
}

Zadacha4();

