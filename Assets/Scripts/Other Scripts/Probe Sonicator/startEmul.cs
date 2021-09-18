using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startEmul : MonoBehaviour {

    public GameObject emulsify;
    public float speed = 1.0f;
    float startTime;
    public static bool startAnim = false;

    // Use this for initialization
    void Start () {
        // NOTE: VVV This line doesn't actually do anything right now. startTime is just 0. Have to set it in update.
        startTime = Time.time;
    }
	
	// Update is called once per frame
	void Update () {
        //Debug.Log(startTime);
        float t = (Time.time - startTime) * speed;
        if (Time.time > 4 && Time.time < 5)
        {
            emulsify.SetActive(true);
            startAnim = true;
        }
    }
}
