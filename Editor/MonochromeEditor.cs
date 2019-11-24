using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UIElements;

namespace Uma
{
    [CanEditMultipleObjects]
    [CustomEditor(typeof(Monochrome))]
    public class Monochrome : Editor
    {
        public override void OnInspectorGUI() => base.OnInspectorGUI();
    }
}
