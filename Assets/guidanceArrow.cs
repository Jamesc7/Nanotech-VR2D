using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Sets guidance arrow for beaker off for nanoparticle module. Arrow is only allowed to stay on for liposome particle
public class guidanceArrow : MonoBehaviour {

    public GameObject questionSet1;
    public GameObject arrow;

    public static bool stopArrow = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(questionSet1.activeInHierarchy)
        {
            arrow.SetActive(false);
        }
        // stopArrow is changed to true in the combineWater script, also located on the beaker (grab) object
        if (stopArrow == true)
        {
            arrow.SetActive(false);
        }
	}
}
