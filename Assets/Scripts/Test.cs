using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [Label]
    [SerializeField] private float exampleLabel = 3.14159f;

    [EditableScriptableObject]
    [SerializeField] TestScriptableObject scriptableObject;
    [EditableScriptableObject]
    [SerializeField] TestScriptableObject scriptableObject2;

    [EditableScriptableObject]
    [SerializeField] TestScriptableObject scriptableObject3;

    [SerializeField] float lateField;
}
