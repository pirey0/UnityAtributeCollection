using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class EditableScriptableObjectAttribute : PropertyAttribute
{

}

#if UNITY_EDITOR
[CustomPropertyDrawer(typeof(EditableScriptableObjectAttribute))]
public class EditableScriptableObjectDrawer : PropertyDrawer
{
    private UnityEditor.Editor cachedEditor;
    private bool unfolded = false;

    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        //base.OnGUI(position, property, label);
        EditorGUI.BeginProperty(position, label, property);
        Rect rect1 = position;
        rect1.height = 20;
        EditorGUI.ObjectField(rect1, property, label);

        var value = property.objectReferenceValue;
        if (value != null)
        {
            rect1.y += 25;
            unfolded = EditorGUI.InspectorTitlebar(rect1, unfolded, value, true);
            if (unfolded)
            {
                UnityEditor.Editor.CreateCachedEditor(value, null, ref cachedEditor);
                cachedEditor.OnInspectorGUI();
            }
        }
        EditorGUI.EndProperty();
    }

    public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
    {
        var value = property.objectReferenceValue;

        if (value)
        {
            return 50;
        }
        else
        {
            return base.GetPropertyHeight(property, label);
        }
    }
}
#endif