using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HydrationStepShake : MonoBehaviour {

    float startTime;
    bool setTime = true;

    public static bool trigger = false;

    Animator shake;

    public GameObject arrow;

    public GameObject next2;
    Vector3 temp2 = new Vector3(7.0f, 14.0f, 0);

    bool stop = false;

    // Use this for initialization
    void Start () {
        shake = gameObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (trigger == true)
        {
            arrow.SetActive(false);
            if (setTime == true)
            {
                startTime = Time.time;
                setTime = false;
            }
            if (Time.time - startTime > 5)
            {
                shake.SetBool("Trigger", true);
            }
            if (Time.time - startTime > 11 && stop == false)
            {
                next2.transform.position += temp2;
                stop = true;
            }
        }
    }
}
