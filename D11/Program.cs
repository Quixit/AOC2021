// See https://aka.ms/new-console-template for more information

using System;
using System.Linq;
using D11;

var input = new Octopus[,]
{
    // { new Octopus(5), new Octopus(4), new Octopus(8), new Octopus(3), new Octopus(1), new Octopus(4), new Octopus(3), new Octopus(2), new Octopus(2), new Octopus(3)},
    // { new Octopus(2), new Octopus(7), new Octopus(4), new Octopus(5), new Octopus(8), new Octopus(5), new Octopus(4), new Octopus(7), new Octopus(1), new Octopus(1)},
    // { new Octopus(5), new Octopus(2), new Octopus(6), new Octopus(4), new Octopus(5), new Octopus(5), new Octopus(6), new Octopus(1), new Octopus(7), new Octopus(3)},
    // { new Octopus(6), new Octopus(1), new Octopus(4), new Octopus(1), new Octopus(3), new Octopus(3), new Octopus(6), new Octopus(1), new Octopus(4), new Octopus(6)},
    // { new Octopus(6), new Octopus(3), new Octopus(5), new Octopus(7), new Octopus(3), new Octopus(8), new Octopus(5), new Octopus(4), new Octopus(7), new Octopus(8)},
    // { new Octopus(4), new Octopus(1), new Octopus(6), new Octopus(7), new Octopus(5), new Octopus(2), new Octopus(4), new Octopus(6), new Octopus(4), new Octopus(5)},
    // { new Octopus(2), new Octopus(1), new Octopus(7), new Octopus(6), new Octopus(8), new Octopus(4), new Octopus(1), new Octopus(7), new Octopus(2), new Octopus(1)},
    // { new Octopus(6), new Octopus(8), new Octopus(8), new Octopus(2), new Octopus(8), new Octopus(8), new Octopus(1), new Octopus(1), new Octopus(3), new Octopus(4)},
    // { new Octopus(4), new Octopus(8), new Octopus(4), new Octopus(6), new Octopus(8), new Octopus(4), new Octopus(8), new Octopus(5), new Octopus(5), new Octopus(4)},
    // { new Octopus(5), new Octopus(2), new Octopus(8), new Octopus(3), new Octopus(7), new Octopus(5), new Octopus(1), new Octopus(5), new Octopus(2), new Octopus(6)}
    
    { new Octopus(6), new Octopus(1), new Octopus(1), new Octopus(1), new Octopus(8), new Octopus(2), new Octopus(1), new Octopus(7), new Octopus(6), new Octopus(7)},
    { new Octopus(1), new Octopus(7), new Octopus(6), new Octopus(3), new Octopus(6), new Octopus(1), new Octopus(1), new Octopus(6), new Octopus(1), new Octopus(5)},
    { new Octopus(3), new Octopus(5), new Octopus(1), new Octopus(2), new Octopus(6), new Octopus(8), new Octopus(3), new Octopus(1), new Octopus(3), new Octopus(1)},
    { new Octopus(8), new Octopus(5), new Octopus(8), new Octopus(2), new Octopus(7), new Octopus(7), new Octopus(1), new Octopus(4), new Octopus(7), new Octopus(3)},
    { new Octopus(8), new Octopus(2), new Octopus(1), new Octopus(4), new Octopus(8), new Octopus(1), new Octopus(3), new Octopus(8), new Octopus(7), new Octopus(4)},
    { new Octopus(2), new Octopus(3), new Octopus(2), new Octopus(5), new Octopus(8), new Octopus(2), new Octopus(3), new Octopus(2), new Octopus(1), new Octopus(7)},
    { new Octopus(2), new Octopus(2), new Octopus(2), new Octopus(2), new Octopus(4), new Octopus(8), new Octopus(2), new Octopus(8), new Octopus(2), new Octopus(3)},
    { new Octopus(5), new Octopus(4), new Octopus(7), new Octopus(1), new Octopus(3), new Octopus(5), new Octopus(6), new Octopus(7), new Octopus(8), new Octopus(2)},
    { new Octopus(3), new Octopus(7), new Octopus(3), new Octopus(8), new Octopus(6), new Octopus(7), new Octopus(1), new Octopus(2), new Octopus(8), new Octopus(7)},
    { new Octopus(8), new Octopus(6), new Octopus(7), new Octopus(5), new Octopus(2), new Octopus(2), new Octopus(6), new Octopus(5), new Octopus(7), new Octopus(4)}
};

var flashes = 0L;

for (var i = 0; i < 1000; i++)
{
    //increase energy
    foreach (var octopus in input)
    {
        octopus.Energy++;
        octopus.Flashed = false;
    }

    //flashy flashy
    for (var x = 0; x < input.GetLength(0); x++)
    {
        for (var y = 0; y < input.GetLength(1); y++)
        {
           Flash(x, y, false);
        }
    }

    var allFlashed = true;

    //reset flashed
    foreach (var octopus in input)
    {
        if (octopus.Flashed)
        {
            octopus.Flashed = false;
            octopus.Energy = 0;
        }
        else
        {
            allFlashed = false;
        }
    }

    if (allFlashed)
    {
        Console.WriteLine($"All flashed at step {i+1}");
        break;
    }
}

Console.WriteLine($"Flashes: {flashes}");

void Flash(int x, int y, bool chain)
{
    var octopus = input[x, y];

    if (chain)
        octopus.Energy++;

    if (octopus.Energy > 9 && !octopus.Flashed)
    {
        octopus.Flashed = true;
        flashes++;
        
        if (x - 1 >= 0)
        {
            Flash(x-1, y, true);
            
            if (y - 1 >= 0)
            {
                Flash(x - 1, y - 1, true);
            }

            if (y + 1 < input.GetLength(1))
            {
                Flash(x-1, y + 1, true);
            }
        }

        if (x + 1 < input.GetLength(0))
        {
            Flash(x+1, y, true);
            
            if (y - 1 >= 0)
            {
                Flash(x+1, y - 1, true);
            }

            if (y + 1 < input.GetLength(1))
            {
                Flash(x+1, y + 1, true);
            }
        }

        if (y - 1 >= 0)
        {
            Flash(x, y-1, true);
        }

        if (y + 1 < input.GetLength(1))
        {
            Flash(x, y+1, true);
        }
    }
}