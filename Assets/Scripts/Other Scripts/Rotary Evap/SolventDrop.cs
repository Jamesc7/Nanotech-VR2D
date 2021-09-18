using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolventDrop : MonoBehaviour {
    Animator solventDrop;
    public GameObject solventPool1;
    public GameObject solventPool2;
    public GameObject solventPool3;
    public GameObject solventPool4;

    float startTime;
    bool setTime = true;

	// Use this for initialization
	void Start () {
        solventDrop = gameObject.GetComponent<Animator>();
        
	}
	
	// Update is called once per frame
	void Update () {
        if (setTime == true)
        {
            startTime = Time.time;
            setTime = false;
        }
        Debug.Log(Time.time);
        if (Time.time <= 6)
        {
            solventDrop.SetBool("Trigger", true);
        }
        if (Time.time >= 6.75f && Time.time <= 8)
        {
            solventPool1.SetActive(true);
        }
        if (Time.time >= 8 && Time.time <= 9.25f)
        {
            solventPool2.SetActive(true);
        }
        if (Time.time >= 9.25f && Time.time <= 10.5f)
        {
            solventPool3.SetActive(true);
        }
        if (Time.time >= 10.5f && Time.time <= 11.75f)
        {
            solventPool4.SetActive(true);
        }
    }
}
