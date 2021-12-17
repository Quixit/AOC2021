// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

var input = new Dictionary<string, string>
{
    {"CH", "S"},
    {"KK", "V"},
    {"FS", "V"},
    {"CN", "P"},
    {"VC", "N"},
    {"CB", "V"},
    {"VK", "H"},
    {"CF", "N"},
    {"PO", "O"},
    {"KC", "S"},
    {"HC", "P"},
    {"PP", "B"},
    {"KO", "B"},
    {"BK", "P"},
    {"BH", "N"},
    {"CC", "N"},
    {"PC", "O"},
    {"FK", "N"},
    {"KF", "F"},
    {"FH", "S"},
    {"SS", "V"},
    {"ON", "K"},
    {"OV", "K"},
    {"NK", "H"},
    {"BO", "C"},
    {"VP", "O"},
    {"CS", "V"},
    {"KS", "K"},
    {"SK", "B"},
    {"OP", "S"},
    {"PK", "S"},
    {"HF", "P"},
    {"SV", "P"},
    {"SB", "C"},
    {"BC", "C"},
    {"FP", "H"},
    {"FC", "P"},
    {"PB", "N"},
    {"NV", "F"},
    {"VO", "F"},
    {"VH", "P"},
    {"BB", "N"},
    {"SF", "F"},
    {"NB", "K"},
    {"KB", "S"},
    {"VV", "S"},
    {"NP", "N"},
    {"SO", "O"},
    {"PN", "B"},
    {"BP", "H"},
    {"BV", "V"},
    {"OB", "C"},
    {"HV", "N"},
    {"PF", "B"},
    {"SP", "N"},
    {"HN", "N"},
    {"CV", "H"},
    {"BN", "V"},
    {"PS", "V"},
    {"CO", "S"},
    {"BS", "N"},
    {"VB", "H"},
    {"PV", "P"},
    {"NN", "P"},
    {"HS", "C"},
    {"OS", "P"},
    {"FB", "S"},
    {"HO", "C"},
    {"KH", "H"},
    {"HB", "K"},
    {"VF", "S"},
    {"CK", "K"},
    {"FF", "H"},
    {"FN", "P"},
    {"OK", "F"},
    {"SC", "B"},
    {"HH", "N"},
    {"OH", "O"},
    {"VS", "N"},
    {"FO", "N"},
    {"OC", "H"},
    {"NF", "F"},
    {"PH", "S"},
    {"HK", "K"},
    {"NH", "H"},
    {"FV", "S"},
    {"OF", "V"},
    {"NC", "O"},
    {"HP", "O"},
    {"KP", "B"},
    {"BF", "N"},
    {"NO", "S"},
    {"CP", "C"},
    {"NS", "N"},
    {"VN", "K"},
    {"KV", "N"},
    {"OO", "V"},
    {"SN", "O"},
    {"KN", "C"},
    {"SH", "F"}
};

var data = "BNBBNCFHHKOSCHBKKSHN";

var pairs = new Dictionary<string, long>();
var letters = new Dictionary<string, long>();

for (var i = 0; i < data.Length; i++)
{
    if (data.Length - i >= 2)
    {
        var pair = $"{data[i]}{data[i+1]}";
        
        pairs[pair] = pairs.GetValueOrDefault(pair) + 1;
    }
}

foreach (var letter in data.Select(c => c.ToString()))
{
    letters[letter] = letters.GetValueOrDefault(letter) + 1;
}

for (var i = 0; i < 40; i++)
{
    var nextPairs = new Dictionary<string, long>();
    foreach (var pair in pairs.Keys)
    {
        var one = pair[0] + input[pair];
        var two = input[pair] + pair[1];

        nextPairs[one] = nextPairs.GetValueOrDefault(one) + pairs[pair];;
        nextPairs[two] = nextPairs.GetValueOrDefault(two) + pairs[pair];;

        letters[input[pair]] = letters.GetValueOrDefault(input[pair]) + pairs[pair];;
    }

    pairs = nextPairs;
}

Console.WriteLine($"Max - Min: {letters.Max(x => x.Value) - letters.Min(x => x.Value)}");