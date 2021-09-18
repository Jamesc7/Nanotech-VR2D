using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enableScript : MonoBehaviour {

    public static bool enable = false;
    changeColor script;

	// Use this for initialization
	void Start () {
        script.GetComponent<changeColor>();
	}
	
	// Update is called once per frame
	void Update () {
        if (enable == true)
        {
            script.enabled = true;
        }
        
	}
}
