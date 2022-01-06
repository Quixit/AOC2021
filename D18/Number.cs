namespace D18;

public class Number
{
    public int Level { get; set; }
    public int Numeral { get; set; }
}

public static class NumberExtensions
{
    public static IEnumerable<Number> ToNumber(this string problem)
    {
        var level = 0;
        foreach (var c in problem)
        {
            if (c == '[')
            {
                level++;
            }
            else if (c == ']')
            {
                level--;
            }
            else if (char.IsDigit(c))
            {
                yield return new Number {Level = level, Numeral = int.Parse(c.ToString())};
            }
        }
    }

    public static LinkedList<Number> Reduce(this LinkedList<Number> numbers)
    {
        Number working;
        while (true)
        {
            working = numbers.FirstOrDefault(n => n.Level > 4);

            if (working != null)
            {
                //Explode
                var node = numbers.Find(working);
                if (node?.Previous != null)
                {
                    node.Previous.Value.Numeral += node.Value.Numeral;
                }

                if (node?.Next?.Next != null)
                {
                    node.Next.Next.Value.Numeral += node.Next.Value.Numeral;
                }

                numbers.Remove(node, 0);
                continue;
            }

            //Split
            working = numbers.FirstOrDefault(n => n.Numeral > 9);

            if (working != null)
            {
                var node = numbers.Find(working);
                if (node != null)
                {
                    numbers.AddBefore(node,
                        new Number
                        {
                            Level = node.Value.Level + 1,
                            Numeral = node.Value.Numeral / 2
                        });
                    numbers.AddBefore(node,
                        new Number
                        {
                            Level = node.Value.Level + 1,
                            Numeral = node.Value.Numeral - (node.Value.Numeral / 2)
                        });
                    numbers.Remove(node);
                }

                continue;
            }
            break;
        }

        return numbers;
    }

    public static LinkedListNode<Number> Remove(this LinkedList<Number> numbers, LinkedListNode<Number> delete,
        int numeral)
    {
        var newNode = new LinkedListNode<Number>(new Number {Level = delete.Value.Level - 1, Numeral = numeral});

        numbers.AddBefore(delete, newNode);
        numbers.Remove(delete.Next);
        numbers.Remove(delete);

        return newNode;
    }

    public static LinkedList<Number> Add(this LinkedList<Number> numbers, LinkedList<Number> add)
    {
        return Reduce(new LinkedList<Number>(numbers.Union(add)
            .Select(s => new Number {Level = s.Level + 1, Numeral = s.Numeral})));
    }

    public static long Magnitude(this LinkedList<Number> numbers)
    {
        while (numbers.Count > 1)
        {
            var node = numbers.First;
            var level = numbers.Max(n => n.Level);

            while (node is {Next: { }})
            {
                if (node.Value.Level == node.Next.Value.Level && node.Value.Level == level)
                {
                    node = Remove(numbers, node, node.Value.Numeral * 3 + node.Next.Value.Numeral * 2);
                }

                node = node.Next;
            }
        }

        return numbers.First.Value.Numeral;
    }
}