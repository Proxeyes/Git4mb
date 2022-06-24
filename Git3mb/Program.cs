int a;
int b;
int c;
Console.WriteLine("Введите а");
a = Convert.ToInt32(Console.ReadLine());
﻿Console.WriteLine("Введите b");
b = Convert.ToInt32(Console.ReadLine());
﻿Console.WriteLine("Выберите знак");
Console.WriteLine("1. +");
Console.WriteLine("2. -");
Console.WriteLine("3. *");
Console.WriteLine("4. /");
c = Convert.ToInt32(Console.ReadLine());
if (c == 1)
{
    Console.WriteLine(a + b);
}
else if (c == 2)
{
    Console.WriteLine(a - b);
}
else if (c == 3)
{
    Console.WriteLine(a * b);
}
else if (c == 4)
{
    Console.WriteLine(a / b);
}