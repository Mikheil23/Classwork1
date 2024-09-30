#region Task 1
using System;
Console.WriteLine("Please write number");
var number1 = Convert.ToInt32(Console.ReadLine());
if (number1 % 5 == 0)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}
#endregion
#region Task 2
Console.WriteLine("Please provide x");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please provide y");
int y = Convert.ToInt32(Console.ReadLine());

int z1 = x + y;
int z2 = x - y;
int z3 = x * y;
Console.WriteLine("x+y={0}", z1);
if (y > x)
{
    int z4 = y - x;
    Console.WriteLine("x-y={0}", z4);
}
else
{
    Console.WriteLine("x-y={0}", z2);
}
Console.WriteLine("x*y={0}", z3);
if (y == 0)
{
    Console.WriteLine("Not Allowed To Divide By Zero");
}
else if (x == 0)
{
    Console.WriteLine("Not Allowed To Divide By Zero");
}
else if (y > x)
{
    int z6 = y / x;
    Console.WriteLine("x/y={0}", z6);
}
else
{
    int z5 = x / y;
    Console.WriteLine("x/y={0}", z5);
}
#endregion
#region Task 3
Console.WriteLine("Input x1");
var x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input y1");
var y1 = Convert.ToInt32(Console.ReadLine());
var temp = x1;
x1 = y1;
y1 = temp;
Console.WriteLine($"After swapping: x1 = {x1}");
Console.WriteLine($"After swapping: y1 = {y1}");
#endregion
#region Task 4
Console.WriteLine("Please write number for multiplying table");
var l = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{l} * {i} = {l * i}");
}
#endregion
#region Task 5
Console.WriteLine("Please write any number");
var f = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= f; i++)
{
    if (i % 2 == 0)
        Console.WriteLine($"{i} = {i * i}");
}
#endregion

