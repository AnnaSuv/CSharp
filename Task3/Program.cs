﻿/*
Дано 5 гирь с разным весом. Необходимо найти вес самой тяжёлой гири.
*/
int n = 5;
int[] num = { 1, 15, 8, 21, 15 };
int i = 0;
int max = num[i];

while (i < n)//5<5
{
    if (num[i] > max) ;//15>21
    {
        max = num[i];//max=21
    }
    i = i + 1;//i=5
}
Console.WriteLine($"Максимальный вес гири  равен {max}");