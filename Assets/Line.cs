using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Line
{
    public List<Vector3> Points;
    
    public Line()
    {
        Points = new List<Vector3>();
    }
    
    public Line(List<Vector3> points)
    {
        Points = points;
    }
    
    public void AddPoint(Vector3 point)
    {
        Points.Add(point);
    }


}