﻿// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

var input = new Dictionary<string, char>
{
    {"CH", 'S'},
    {"KK", 'V'},
    {"FS", 'V'},
    {"CN", 'P'},
    {"VC", 'N'},
    {"CB", 'V'},
    {"VK", 'H'},
    {"CF", 'N'},
    {"PO", 'O'},
    {"KC", 'S'},
    {"HC", 'P'},
    {"PP", 'B'},
    {"KO", 'B'},
    {"BK", 'P'},
    {"BH", 'N'},
    {"CC", 'N'},
    {"PC", 'O'},
    {"FK", 'N'},
    {"KF", 'F'},
    {"FH", 'S'},
    {"SS", 'V'},
    {"ON", 'K'},
    {"OV", 'K'},
    {"NK", 'H'},
    {"BO", 'C'},
    {"VP", 'O'},
    {"CS", 'V'},
    {"KS", 'K'},
    {"SK", 'B'},
    {"OP", 'S'},
    {"PK", 'S'},
    {"HF", 'P'},
    {"SV", 'P'},
    {"SB", 'C'},
    {"BC", 'C'},
    {"FP", 'H'},
    {"FC", 'P'},
    {"PB", 'N'},
    {"NV", 'F'},
    {"VO", 'F'},
    {"VH", 'P'},
    {"BB", 'N'},
    {"SF", 'F'},
    {"NB", 'K'},
    {"KB", 'S'},
    {"VV", 'S'},
    {"NP", 'N'},
    {"SO", 'O'},
    {"PN", 'B'},
    {"BP", 'H'},
    {"BV", 'V'},
    {"OB", 'C'},
    {"HV", 'N'},
    {"PF", 'B'},
    {"SP", 'N'},
    {"HN", 'N'},
    {"CV", 'H'},
    {"BN", 'V'},
    {"PS", 'V'},
    {"CO", 'S'},
    {"BS", 'N'},
    {"VB", 'H'},
    {"PV", 'P'},
    {"NN", 'P'},
    {"HS", 'C'},
    {"OS", 'P'},
    {"FB", 'S'},
    {"HO", 'C'},
    {"KH", 'H'},
    {"HB", 'K'},
    {"VF", 'S'},
    {"CK", 'K'},
    {"FF", 'H'},
    {"FN", 'P'},
    {"OK", 'F'},
    {"SC", 'B'},
    {"HH", 'N'},
    {"OH", 'O'},
    {"VS", 'N'},
    {"FO", 'N'},
    {"OC", 'H'},
    {"NF", 'F'},
    {"PH", 'S'},
    {"HK", 'K'},
    {"NH", 'H'},
    {"FV", 'S'},
    {"OF", 'V'},
    {"NC", 'O'},
    {"HP", 'O'},
    {"KP", 'B'},
    {"BF", 'N'},
    {"NO", 'S'},
    {"CP", 'C'},
    {"NS", 'N'},
    {"VN", 'K'},
    {"KV", 'N'},
    {"OO", 'V'},
    {"SN", 'O'},
    {"KN", 'C'},
    {"SH", 'F'}
};

var data = new LinkedList<char> (new char[] { 'B', 'N', 'B', 'B', 'N', 'C', 'F', 'H', 'H', 'K', 'O', 'S', 'C', 'H', 'B', 'K', 'K', 'S', 'H', 'N' });

for (var i = 0; i < 10; i++)
{
    var current = data.First;

    while (current.Next != null)
    {
        var value  = new LinkedListNode<char>(input[$"{current.Value}{current.Next.Value}"]);
        
        data.AddAfter(current, value);
        
        current = current.Next.Next;
    }

    // for (var j = 0; j < data.Length - 1; j++)
    // {
    //     next.Append($"{data[j]}{input[data.Substring(j, 2)]}");
    // }
    //
    // next.Append(data[data.Length - 1]);
    //
    // data = next.ToString();
    // next.Clear();
    
    Console.WriteLine(i);
}

var quantities = data.GroupBy(d => d).Select(d => new {d.Key, Count = d.LongCount()});

Console.WriteLine($"Max - Min: { quantities.Max(q => q.Count) - quantities.Min(q => q.Count)}");