using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [Label] [SerializeField] private float exampleLabel = 3.14159f;
    
    [Button]
    public void TestMethod ()
    {
        Debug.Log("TEST");
    }

    [Button]
    public bool TestParameter( bool flag, string str)
    {
        Debug.Log(str + ": " + flag);
        return flag;
    }
    
}
