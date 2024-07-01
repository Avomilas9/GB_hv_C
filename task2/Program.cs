// Задача 2: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 29

int m = AskNumber("m"); 
int n = AskNumber("n"); 
 
int AckermannFunction(int m, int n) 
{ 
    if (m == 0)
        return n + 1; 
    if (m != 0 && n == 0)
        return AckermannFunction(m - 1, 1); 
    if (m > 0 && n > 0)
        return AckermannFunction(m - 1, AckermannFunction(m, n - 1)); 
    return AckermannFunction(m, n); 
} 
 
Console.WriteLine($"Функция Аккермана для чисел A({m},{n}) = {AckermannFunction(m, n)}"); 
 
int AskNumber(string name) 
{ 
    Console.Write($"Введите число {name}: "); 
    return int.Parse(Console.ReadLine()); 
}
