using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Curve), true, isFallback = true)]
[CanEditMultipleObjects]
public class CurveEditor : Editor
{
    public override void OnInspectorGUI()
    {
        var curve = (Curve) target;
        // display formula
        GUILayout.Label(curve.Formula(), MyEditorStyles.GetLabelStyle());
        base.OnInspectorGUI();
        if (GUILayout.Button("Draw", MyEditorStyles.GetButtonStyle()))
        {
            var line = curve.Sample();
            var lineDrawer = curve.GetComponentInChildren<LineDrawer>();
            if (lineDrawer == null)
            {
                var obj = new GameObject("Line Renderer");
                obj.transform.localPosition = Vector3.zero; 
                obj.transform.SetParent(curve.transform);
                lineDrawer = curve.AddComponent<LineDrawer>();
            }
            lineDrawer.Clear();
            lineDrawer.AddLine(line);
            lineDrawer.Draw();
        }
    }
}
