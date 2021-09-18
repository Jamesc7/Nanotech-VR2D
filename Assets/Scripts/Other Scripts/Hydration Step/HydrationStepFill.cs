using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HydrationStepFill : MonoBehaviour {

    public GameObject wave1;
    public GameObject wave2;
    public GameObject wave3;

    public GameObject hydrationInjection;

    float startTime;
    bool setTime = true;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (setTime == true)
        {
            startTime = Time.time;
            setTime = false;
        }
        if (Time.time - startTime > 1.75f && Time.time - startTime < 2.25f)
        {
            wave1.SetActive(true);
        }
        if (Time.time - startTime > 2.25f && Time.time - startTime < 2.75f)
        {
            wave2.SetActive(true);
        }
        if (Time.time - startTime > 2.75f && Time.time - startTime < 3)
        {
            wave3.SetActive(true);
            
        }
        if (Time.time - startTime > 3)
        {
            hydrationInjection.SetActive(false);
        }
        
	}
}
