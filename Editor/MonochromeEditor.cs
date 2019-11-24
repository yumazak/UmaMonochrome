using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace Uma
{
    [CanEditMultipleObjects]
    [CustomEditor(typeof(Monochrome))]
    public class MonochromeEditor : Editor
    {
        SerializedProperty _mode;

        void OnEnable()
        {
            _mode = serializedObject.FindProperty("_mode");

        }

        public override void OnInspectorGUI()
        {
            serializedObject.Update();
            EditorGUILayout.PropertyField(_mode);
            serializedObject.ApplyModifiedProperties();
        }
    }
}

