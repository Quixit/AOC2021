// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;

var input = new int[] { 1,3,4,1,5,2,1,1,1,1,5,1,5,1,1,1,1,3,1,1,1,1,1,1,1,2,1,5,1,1,1,1,1,4,4,1,1,4,1,1,2,3,1,5,1,4,1,2,4,1,1,1,1,1,1,1,1,2,5,3,3,5,1,1,1,1,4,1,1,3,1,1,1,2,3,4,1,1,5,1,1,1,1,1,2,1,3,1,3,1,2,5,1,1,1,1,5,1,5,5,1,1,1,1,3,4,4,4,1,5,1,1,4,4,1,1,1,1,3,1,1,1,1,1,1,3,2,1,4,1,1,4,1,5,5,1,2,2,1,5,4,2,1,1,5,1,5,1,3,1,1,1,1,1,4,1,2,1,1,5,1,1,4,1,4,5,3,5,5,1,2,1,1,1,1,1,3,5,1,2,1,2,1,3,1,1,1,1,1,4,5,4,1,3,3,1,1,1,1,1,1,1,1,1,5,1,1,1,5,1,1,4,1,5,2,4,1,1,1,2,1,1,4,4,1,2,1,1,1,1,5,3,1,1,1,1,4,1,4,1,1,1,1,1,1,3,1,1,2,1,1,1,1,1,2,1,1,1,1,1,1,1,2,1,1,1,1,1,1,4,1,1,1,1,1,1,1,1,1,1,1,1,1,1,2,1,1,2,5,1,2,1,1,1,1,1,1,1,1,1};
var fish = new long[9];
var days = 256;

foreach (var item in input)
{
    fish[item]++;
}

var lastZero = 0l;

for (var d = 0; d < days; d++)
{

    for (var i = 0; i <= 8; i++)
    {
        if (i == 0)
        {
            lastZero = fish[i];
            fish[i] = fish[i + 1];
        }
        else if (i == 8)
        {
            fish[i] = lastZero;
        }
        else if (i == 6)
        {
            fish[i] = fish[i + 1] + lastZero;
        }
        else
        {
            fish[i] = fish[i + 1];
        }
    }
}

Console.WriteLine($"Lanternfish {fish.Sum((f => f))}");