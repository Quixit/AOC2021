// See https://aka.ms/new-console-template for more information
var start = new {x = 0L, y = 0L};
var destination = new { x= new { min =244, max = 303}, y = new { min = -91, max = -54}};

var overallMaxY = 0L;
var numberOfHits = 0L;

for(var x = -100; x < 1000; x++)
{
    for (var y = -100; y < 1000; y++)
    {
        var maxY = 0L;
        var xVelocity = x;
        var yVelocity = y;
        var position = new long[]{start.x, start.y};
       
        while (position[0] <= destination.x.max)
        {
            position[0] += xVelocity;
            position[1] += yVelocity;
        
            if (xVelocity > 0)
            {
                xVelocity--;
            }
            else if (xVelocity < 0)
            {
                xVelocity++;
            }
        
            yVelocity--;
        
            if (position[1] > maxY)
                maxY = position[1];
            
            //Check if will never it the target.
            if (xVelocity == 0 && position[1] < destination.y.min)
            {
                break;
            }
            
            //Check if has hit the target.
            if (position[0] >= destination.x.min 
                && position[0] <= destination.x.max
                && position[1] >= destination.y.min 
                && position[1] <= destination.y.max)
            {
                if (maxY > overallMaxY)
                    overallMaxY = maxY;

                numberOfHits++;
                
                break;
            }
        }
    }
}

Console.WriteLine($"Max Found: {overallMaxY} Hits: {numberOfHits}");