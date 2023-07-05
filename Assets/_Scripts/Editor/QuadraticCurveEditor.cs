using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEditor;

// [CustomEditor(typeof(QuadraticCurve))]
// public class QuadraticCurveEditor : Editor
// {
//     // public override void OnInspectorGUI()
//     // {
//     //     base.OnInspectorGUI();
//     //     var curve = (QuadraticCurve) target;
//     //     if (GUILayout.Button("Draw", MyEditorStyles.GetButtonStyle()))
//     //     {
//     //         var line = curve.Sample();
//     //         var lineDrawer = curve.GetComponentInChildren<LineDrawer>();
//     //         if (lineDrawer == null)
//     //         {
//     //             var obj = new GameObject("Line Renderer");
//     //             obj.transform.localPosition = Vector3.zero; 
//     //             obj.transform.SetParent(curve.transform);
//     //             lineDrawer = obj.AddComponent<LineDrawer>();
//     //         }
//     //         lineDrawer.Clear();
//     //         lineDrawer.AddLine(line);
//     //         lineDrawer.Draw();
//     //     }
//     // }
// }
