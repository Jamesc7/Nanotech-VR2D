using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class insertSampleScript : MonoBehaviour {

    Animator insertSample;
    Animator insertBoth;

    public GameObject sample;
    public GameObject capsule;

    public GameObject container;
    public GameObject containerWall1;

    public GameObject bothObj;

    public GameObject beam;

    float startTime = 0;

    // Use this for initialization
    void Start () {
        insertSample = sample.GetComponent<Animator>();
        insertBoth = bothObj.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if ((Time.time - startTime) > 1.0f)
        {
            insertSample.SetBool("Trigger", true);
        }
        if (Time.time > 2.0f)
        {
            insertBoth.SetBool("Trigger", true);
        }
        if (Time.time > 3.0f)
        {
            containerWall1.GetComponent<changeMaterial>().enabled = true;
            containerWall1.GetComponent<changeColor>().enabled = true;
        } 
        if (Time.time > 4.0f)
        {
            beam.SetActive(true);
            capsule.GetComponent<changeColor>().enabled = true;
        }
	}
}
