﻿int a = 7;
int b = 2;
int c = 3;

int max = a;

if (b > max)
{
    max = c;
}
if (c > max)
{
    max = c;
}
Console.WriteLine(max);
