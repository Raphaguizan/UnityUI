using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using Game.UI.Screen;

[CustomEditor(typeof(ScreenManager))]
public class ScreenManagerEditor : Editor
{
    public override void OnInspectorGUI()
    {
        ScreenManager myTarget = (ScreenManager)target;
        base.OnInspectorGUI();

        GUILayout.Space(10f);

        if (GUILayout.Button("Random Screen") && Application.isPlaying)
        {
            myTarget.OpenRandomScreen();
        }
    }
}
