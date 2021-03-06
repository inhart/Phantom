using UnityEngine;
using UnityEditor;

namespace Klak.Wiring
{
    [CanEditMultipleObjects]
    [CustomEditor(typeof(BangInput))]
    public class BangInputEditor : Editor
    {
        SerializedProperty _bangEvent;

        void OnEnable()
        {
            _bangEvent = serializedObject.FindProperty("_bangEvent");
        }

        public override void OnInspectorGUI()
        {
            serializedObject.Update();

            EditorGUILayout.PropertyField(_bangEvent);

            serializedObject.ApplyModifiedProperties();
        }
    }
}
