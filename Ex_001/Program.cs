//Задайте значения M и N. Напишите программу, 
//которая выведет все натуральные числа кратные 3-ём в промежутке от M до N.

void Zadacha3()
{
    Console.WriteLine("Введите число m:");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число n:");
    int n = Convert.ToInt32(Console.ReadLine());
   
    Recursion(m,n);
   
}


void Recursion(int m, int n)
{
    if (m > n) 
    {
        return;
    }
    if (m%3 == 0) Console.Write(m + " ");
    m++;
    
    Recursion(m,n);
}

Zadacha3();
