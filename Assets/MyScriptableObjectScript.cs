using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MySO", menuName = "MyScriptableObject")]
public class MyScriptableObjectScript : ScriptableObject
{
    public int[] Value;
}