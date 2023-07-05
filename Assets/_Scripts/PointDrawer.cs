using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class PointDrawer : MonoBehaviour
{
    [FormerlySerializedAs("Points")] public List<Point> points;
    [SerializeField] private Material material;

    public void Clear()
    {
        // destroy all children
        var childCount = transform.childCount;
        for (var i = childCount - 1; i >= 0; i--)
        {
            var child = transform.GetChild(i);
            DestroyImmediate(child.gameObject);
        }
    }
    
    public void Draw()
    {
        foreach (var point in points)
        {
            DrawPoint(point);
        }
    }
    
    private void DrawPoint(Point point)
    {
        var obj = new GameObject("Point");
        obj.transform.SetParent(transform);
        obj.transform.localPosition = point.position;
        obj.transform.localRotation = Quaternion.identity;
        obj.transform.localScale = Vector3.one * (point.radius * 2f);
        var meshFilter = obj.AddComponent<MeshFilter>();
        var meshRenderer = obj.AddComponent<MeshRenderer>();
        var mesh = QuadMeshGenerator.GetQuadMesh();
        meshFilter.mesh = mesh;
        meshRenderer.material = material;
    }
}