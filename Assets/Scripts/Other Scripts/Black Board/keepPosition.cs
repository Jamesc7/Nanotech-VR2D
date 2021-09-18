using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keepPosition : MonoBehaviour {

    public float x = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Makes object stay locked to the x-axis
        gameObject.transform.position = new Vector3(x, transform.position.y, transform.position.z);
        //Makes object stay at current rotation
        gameObject.transform.rotation = Quaternion.Euler(360, 360, 360);
    }
}
