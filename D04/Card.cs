using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace D04
{
    public class CardValue
    {
        public CardValue(int value)
        {
            Value = value;
            Marked = false;
        }
        public int Value { get; }
        public bool Marked { get; set; }
    }

    public class Card
    {
        public CardValue[] _values;
        public bool _won;

        public Card(params int[] values)
        {
            _values = new []
            {
                new CardValue(values[0]),  new CardValue(values[1]),  new CardValue(values[2]),  new CardValue(values[3]),  new CardValue(values[4]),
                new CardValue(values[5]),  new CardValue(values[6]),  new CardValue(values[7]),  new CardValue(values[8]),  new CardValue(values[9]),
                new CardValue(values[10]), new CardValue(values[11]), new CardValue(values[12]), new CardValue(values[13]), new CardValue(values[14]),
                new CardValue(values[15]), new CardValue(values[16]), new CardValue(values[17]), new CardValue(values[18]), new CardValue(values[19]),
                new CardValue(values[20]), new CardValue(values[21]), new CardValue(values[22]), new CardValue(values[23]), new CardValue(values[24]),
            };

            _won = false;
        }

        public bool Mark(int value)
        {
            for (var i = 0; i < _values.Length; i++)
            {
                if (_values[i].Value == value)
                {
                    _values[i].Marked = true;
                    if (CheckWin(i))
                    {
                        if (_won)
                        {
                            return false;
                        }
                        else
                        {
                            _won = true;
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        private bool CheckWin(int index)
        {
            int row = index / 5;
            int col = index % 5;
            
            var win = true;
            
            var start = row * 5;
            for (var i = start; i < start + 5; i++)
            {
                if (!_values[i].Marked)
                    win = false;
            }
            
            if (win)
                return win;
            
            win = true;
            
            for (var i = col; i < 25; i += 5)
            {
                if (!_values[i].Marked)
                    win = false;
            }
            
            return win;
        }

        public int Score {
            get
            {
                return _values.Where(v => !v.Marked).Sum(v => v.Value);
            }
        }
    }
}