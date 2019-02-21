using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(TorusController))]
public class TorusControllerInspector : Editor
{
    public override void OnInspectorGUI()
    {
        TorusController targetTorus = (TorusController)target;

        targetTorus.SetSpinSpeed(EditorGUILayout.Slider("Spin Speed", targetTorus.GetSpinSpeed(), -10, 10));
    }
}
