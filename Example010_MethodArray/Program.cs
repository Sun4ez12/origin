﻿int[] array = { 1, 12, 33, 4, 18, 15, 66, 75, 18 };

int n = array.Length;
int find = 18;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }

    index++;
}