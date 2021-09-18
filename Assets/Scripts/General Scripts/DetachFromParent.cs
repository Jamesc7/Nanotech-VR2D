using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetachFromParent : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        transform.parent = null;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
