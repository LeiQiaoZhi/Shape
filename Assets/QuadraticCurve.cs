

using UnityEngine;

public class QuadraticCurve : Curve
{
    public float a;
    public float b;
    public float c;
    
    public Vector2 xRange;
    
    private float Point(float x)
    {
        return a * x * x + b * x + c;
    }
    
    public override string Formula()
    {
        return $"{a}x^2 + {b}x + {c}";
    }
    
    public override Line Sample()
    {
        var line = new Line();
        var xStep = (xRange.y - xRange.x) / (numSamples-1);
        for (var i = 0; i < numSamples; i++)
        {
            var x = xRange.x + i * xStep;
            var y = Point(x);
            line.AddPoint(new Vector3(x, y, 0));
        }
        return line;
    }
}