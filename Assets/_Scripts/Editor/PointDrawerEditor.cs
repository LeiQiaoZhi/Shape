using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(PointDrawer))]
public class PointDrawerEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        
        var lineDrawer = (PointDrawer) target;
        
        if (GUILayout.Button("Draw", MyEditorStyles.GetButtonStyle()))
        {
            lineDrawer.Clear();
            lineDrawer.Draw();
        }
    }
}
