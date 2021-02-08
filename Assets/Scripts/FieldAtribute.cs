using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;


[AttributeUsage(AttributeTargets.Field)]
public class LabelAttribute : PropertyAttribute {}


#if UNITY_EDITOR

//https://answers.unity.com/questions/489942/how-to-make-a-readonly-property-in-inspector.html?_ga=2.10842356.1154741727.1570098086-719267999.1526065553

[CustomPropertyDrawer(typeof(LabelAttribute))]
[CanEditMultipleObjects]
public class LabelDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property,GUIContent label)
    {
        GUI.enabled = false;
        EditorGUI.PropertyField(position, property, label, true);
        GUI.enabled = true;
    }
}

#endif
