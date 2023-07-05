using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(LineDrawer))]
public class LineDrawerEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        
        var lineDrawer = (LineDrawer) target;
        
        if (GUILayout.Button("Draw", MyEditorStyles.GetButtonStyle()))
        {
            lineDrawer.Clear();
            lineDrawer.Draw();
        }
    }
}
