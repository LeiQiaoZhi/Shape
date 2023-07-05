using UnityEngine;

[System.Serializable]
public class Point
{
    public Vector3 position;
    [Range(0,10)]
    public float radius;
}