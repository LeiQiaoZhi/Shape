using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyEditorStyles 
{
    public static GUIStyle GetButtonStyle()
    {
        var style = new GUIStyle(GUI.skin.button)
        {
            fixedHeight = 40,
            margin = new RectOffset(10, 10, 10, 10),
            fontSize = 20,
            fontStyle = FontStyle.Bold,
            normal =
            {
                textColor = Color.white
            },
            alignment = TextAnchor.MiddleCenter
        };
        return style;
    }

    public static GUIStyle GetLabelStyle()
    {
        var style = new GUIStyle(GUI.skin.label)
        {
            fontSize = 20,
            margin = new RectOffset(10, 10, 10, 10),
            fontStyle = FontStyle.Bold,
            normal =
            {
                textColor = Color.white
            },
            alignment = TextAnchor.MiddleLeft
        };
        return style;
    }
}
