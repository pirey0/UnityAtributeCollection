using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [Label]
    [SerializeField] private float exampleLabel = 3.14159f;

    [SerializeField] float lateField;

    [EditableScriptableObject]
    [SerializeField] TestScriptableObject scriptableObject;

}
