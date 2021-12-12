// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;

var input = new List<Tuple<string,string>> {
    new ("start", "kc"),
    new ("pd", "NV"),
    new ("start", "zw"),
    new ("UI", "pd"),
    new ("HK", "end"),
    new ("UI", "kc"),
    new ("pd", "ih"),
    new ("ih", "end"),
    new ("start", "UI"),
    new ("kc", "zw"),
    new ("end", "ks"),
    new ("MF", "mq"),
    new ("HK", "zw"),
    new ("LF", "ks"),
    new ("HK", "kc"),
    new ("ih", "HK"),
    new ("kc", "pd"),
    new ("ks", "pd"),
    new ("MF", "pd"),
    new ("UI", "zw"),
    new ("ih", "NV"),
    new ("ks", "HK"),
    new ("MF", "kc"),
    new ("zw", "NV"),
    new ("NV", "ks"),
};

var paths = input
    .Union(input.Select(i => new Tuple<string, string>(i.Item2, i.Item1)))
    .GroupBy(i => i.Item1)
    .Select(i => new
    {
        Start = i.First().Item1, 
        Destinations = i.Select(y => y.Item2)
    })
    .ToDictionary(i => i.Start);

var results = new List<HashSet<string>>();

Navigate(new HashSet<string> { "start" }, "start");

Console.WriteLine($"Paths {results.Count}");

results.Clear();

Navigate2(new HashSet<string> { "start" }, "start", false);

Console.WriteLine($"Paths 2 {results.Count}");

//Question 1 logic
void Navigate(HashSet<string> path, string start)
{
    if (paths.ContainsKey(start))
    {
        foreach (var destination in paths[start].Destinations)
        {
            //LCase
            if (destination.ToLowerInvariant() == destination && path.Contains(destination))
            {
                //Done
            }
            else if (destination == "end")
            {
                var newPath = new HashSet<string>(path, path.Comparer);

                newPath.Add(destination);

                results.Add(newPath);
            }
            else //Navigate.
            {
                var newPath = new HashSet<string>(path, path.Comparer);

                newPath.Add(destination);

                Navigate(newPath, destination);
            }
        }
    }
}

//Question 2 logic
void Navigate2(HashSet<string> path, string start, bool smallTwice)
{
    if (paths.ContainsKey(start))
    {
        foreach (var destination in paths[start].Destinations)
        {
            //LCase
            if (destination.ToLowerInvariant() == destination && path.Contains(destination))
            {
                if (destination == "start" || smallTwice)
                {
                    //Done
                }
                else
                {
                    var newPath = new HashSet<string>(path, path.Comparer);

                    newPath.Add(destination);

                    Navigate2(newPath, destination, true);
                }

                
            }
            else if (destination == "end")
            {
                var newPath = new HashSet<string>(path, path.Comparer);

                newPath.Add(destination);

                results.Add(newPath);
            }
            else //Navigate.
            {
                var newPath = new HashSet<string>(path, path.Comparer);

                newPath.Add(destination);

                Navigate2(newPath, destination, smallTwice);
            }
        }
    }
}