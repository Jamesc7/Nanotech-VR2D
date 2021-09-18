using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeMaterial : MonoBehaviour {

    public Material material;
    bool shift = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (shift == true)
        {
            gameObject.GetComponent<Renderer>().material = material;
            shift = false;
        }
	}
}
