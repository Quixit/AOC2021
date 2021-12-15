// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

var input = new Dictionary<int, char>
{
    {'C' + 'H' * 100, 'S'},
    {'K' + 'K'* 100, 'V'},
    {'F' + 'S'* 100, 'V'},
    {'C' + 'N'* 100, 'P'},
    {'V' + 'C'* 100, 'N'},
    {'C' + 'B'* 100, 'V'},
    {'V' + 'K'* 100, 'H'},
    {'C' + 'F'* 100, 'N'},
    {'P' + 'O'* 100, 'O'},
    {'K' + 'C'* 100, 'S'},
    {'H' + 'C'* 100, 'P'},
    {'P' + 'P'* 100, 'B'},
    {'K' + 'O'* 100, 'B'},
    {'B' + 'K'* 100, 'P'},
    {'B' + 'H'* 100, 'N'},
    {'C' + 'C'* 100, 'N'},
    {'P' + 'C'* 100, 'O'},
    {'F' + 'K'* 100, 'N'},
    {'K' + 'F'* 100, 'F'},
    {'F' + 'H'* 100, 'S'},
    {'S' + 'S'* 100, 'V'},
    {'O' + 'N'* 100, 'K'},
    {'O' + 'V'* 100, 'K'},
    {'N' + 'K'* 100, 'H'},
    {'B' + 'O'* 100, 'C'},
    {'V' + 'P'* 100, 'O'},
    {'C' + 'S'* 100, 'V'},
    {'K' + 'S'* 100, 'K'},
    {'S' + 'K'* 100, 'B'},
    {'O' + 'P'* 100, 'S'},
    {'P' + 'K'* 100, 'S'},
    {'H' + 'F'* 100, 'P'},
    {'S' + 'V'* 100, 'P'},
    {'S' + 'B'* 100, 'C'},
    {'B' + 'C'* 100, 'C'},
    {'F' + 'P'* 100, 'H'},
    {'F' + 'C'* 100, 'P'},
    {'P' + 'B'* 100, 'N'},
    {'N' + 'V'* 100, 'F'},
    {'V' + 'O'* 100, 'F'},
    {'V' + 'H'* 100, 'P'},
    {'B' + 'B'* 100, 'N'},
    {'S' + 'F'* 100, 'F'},
    {'N' + 'B'* 100, 'K'},
    {'K' + 'B'* 100, 'S'},
    {'V' + 'V'* 100, 'S'},
    {'N' + 'P'* 100, 'N'},
    {'S' + 'O'* 100, 'O'},
    {'P' + 'N'* 100, 'B'},
    {'B' + 'P'* 100, 'H'},
    {'B' + 'V'* 100, 'V'},
    {'O' + 'B'* 100, 'C'},
    {'H' + 'V'* 100, 'N'},
    {'P' + 'F'* 100, 'B'},
    {'S' + 'P'* 100, 'N'},
    {'H' + 'N'* 100, 'N'},
    {'C' + 'V'* 100, 'H'},
    {'B' + 'N'* 100, 'V'},
    {'P' + 'S'* 100, 'V'},
    {'C' + 'O'* 100, 'S'},
    {'B' + 'S'* 100, 'N'},
    {'V' + 'B'* 100, 'H'},
    {'P' + 'V'* 100, 'P'},
    {'N' + 'N'* 100, 'P'},
    {'H' + 'S'* 100, 'C'},
    {'O' + 'S'* 100, 'P'},
    {'F' + 'B'* 100, 'S'},
    {'H' + 'O'* 100, 'C'},
    {'K' + 'H'* 100, 'H'},
    {'H' + 'B'* 100, 'K'},
    {'V' + 'F'* 100, 'S'},
    {'C' + 'K'* 100, 'K'},
    {'F' + 'F'* 100, 'H'},
    {'F' + 'N'* 100, 'P'},
    {'O' + 'K'* 100, 'F'},
    {'S' + 'C'* 100, 'B'},
    {'H' + 'H'* 100, 'N'},
    {'O' + 'H'* 100, 'O'},
    {'V' + 'S'* 100, 'N'},
    {'F' + 'O'* 100, 'N'},
    {'O' + 'C'* 100, 'H'},
    {'N' + 'F'* 100, 'F'},
    {'P' + 'H'* 100, 'S'},
    {'H' + 'K'* 100, 'K'},
    {'N' + 'H'* 100, 'H'},
    {'F' + 'V'* 100, 'S'},
    {'O' + 'F'* 100, 'V'},
    {'N' + 'C'* 100, 'O'},
    {'H' + 'P'* 100, 'O'},
    {'K' + 'P'* 100, 'B'},
    {'B' + 'F'* 100, 'N'},
    {'N' + 'O'* 100, 'S'},
    {'C' + 'P'* 100, 'C'},
    {'N' + 'S'* 100, 'N'},
    {'V' + 'N'* 100, 'K'},
    {'K' + 'V'* 100, 'N'},
    {'O' + 'O'* 100, 'V'},
    {'S' + 'N'* 100, 'O'},
    {'K' + 'N'* 100, 'C'},
    {'S' + 'H'* 100, 'F'}
};

var data = new LinkedList<char> (new char[] { 'B', 'N', 'B', 'B', 'N', 'C', 'F', 'H', 'H', 'K', 'O', 'S', 'C', 'H', 'B', 'K', 'K', 'S', 'H', 'N' });

for (var i = 0; i < 40; i++)
{
    var current = data.First;

    while (current.Next != null)
    {
        var value  = new LinkedListNode<char>(input[current.Value + current.Next.Value * 100]);
        
        data.AddAfter(current, value);
        
        current = current.Next.Next;
    }
    
    Console.WriteLine(i);
}

var quantities = data.GroupBy(d => d).Select(d => new {d.Key, Count = d.LongCount()});

Console.WriteLine($"Max - Min: { quantities.Max(q => q.Count) - quantities.Min(q => q.Count)}");