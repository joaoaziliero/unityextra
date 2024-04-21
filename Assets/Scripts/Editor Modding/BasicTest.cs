using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(BasicScript))]
public class BasicTest : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        BasicScript myScript = (BasicScript)target;

        if (GUILayout.Button("Randomize List"))
        {
            var result = "";
            myScript.strings.Randomize().ForEach(str => result += str);
            Debug.Log(result);
        }
    }
}
