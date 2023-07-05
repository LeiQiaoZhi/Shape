using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Serialization;

public class LineDrawer : MonoBehaviour
{
    [FormerlySerializedAs("_lines")] [SerializeField]
    private List<Line> lines = new List<Line>();

    public Material material;

    private void Start()
    {
        Clear();
        Draw();
    }

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

    public void ResetLines()
    {
        lines = new List<Line>();
    }

    // ReSharper disable Unity.PerformanceAnalysis
    public void Draw()
    {
        // draw each line
        foreach (var line in lines)
            DrawLine(line);
    }

    public void DrawLine(Line line)
    {
        // create mesh
        var mesh = new Mesh();
        mesh.vertices = line.Points.ToArray();
        // define indices
        var indices = new int[line.Points.Count];
        for (var i = 0; i < line.Points.Count; i++)
            indices[i] = i;
        mesh.SetIndices(indices, MeshTopology.LineStrip, 0);
        // create object
        var obj = new GameObject("Line");
        obj.transform.SetParent(transform);
        obj.transform.localPosition = Vector3.zero;
        obj.transform.localRotation = Quaternion.identity;
        obj.transform.localScale = Vector3.one;
        // add mesh renderer
        var meshRenderer = obj.AddComponent<MeshRenderer>();
        meshRenderer.sharedMaterial = material;
        // add mesh filter
        var meshFilter = obj.AddComponent<MeshFilter>();
        meshFilter.mesh = mesh;
    }
    
    public void AddLine(Line line)
    {
        lines.Add(line);
    }

    private void OnDrawGizmos()
    {
        if (lines == null)
            return;
        Gizmos.color = Color.yellow;
        foreach (var line in lines)
        {
            if (line.Points.Count == 0)
                continue;
            for (int i = 0; i < line.Points.Count - 1; i++)
            {
                Gizmos.DrawSphere(line.Points[i], 0.1f);
                Gizmos.DrawLine(line.Points[i], line.Points[i + 1]);
            }
            Gizmos.DrawSphere(line.Points[^1], 0.1f);
        }
    }
}