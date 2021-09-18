using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemovePipette : MonoBehaviour {

    public Animator pipette;

    float startTime = 0;
    bool beginTime = false;

    public static bool trigger = false;

	// Use this for initialization
	void Start () {
        pipette.gameObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (trigger == true)
        {
            if (beginTime == false)
            {
                startTime = Time.time;
                beginTime = true;
            }
            if (Time.time - startTime > 3)
            {
                pipette.SetBool("Trigger", true);
            }
            if (Time.time - startTime > 4)
            {
                pipette.SetBool("Trigger2", true);
            }
            if (Time.time - startTime > 5)
            {
                gameObject.SetActive(false);
            }
        }
	}
}
