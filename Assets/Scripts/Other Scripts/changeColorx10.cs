using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColorx10 : MonoBehaviour {
    public Color startColor;

    public Color extrude1;  // Extruded to right
    public Color extrude2;  // Extruded to left
    public Color extrude3;  // Extruded to right
    public Color extrude4;  // Extruded to left
    public Color extrude5;  // Extruded to right
    public Color extrude6;  // Extruded to left
    public Color extrude7;  // Extruded to right
    public Color extrude8;  // Extruded to left
    public Color extrude9;  // Extruded to right
    public Color extrude10; // Extruded to left

    public GameObject plunger;

    public GameObject plungers;
    public GameObject leftPlunger;
    Animator extrude;

    public float speed = .1f;

    int counterLeft = 0;
    int counterRight = 0;
    static int counter = 0;

    public GameObject beforeAndAfter;

    bool stop = false;
    static float startTime = 0;

    public GameObject grabSyringe;
    public GameObject leftSyringe;

    public GameObject arrow1;
    public GameObject arrow2;

    static bool beginTime = false;


    // Use this for initialization
    void Start () {
        extrude = plungers.GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        // Pressing on the left plunger
        if (plunger.CompareTag("RightExtrude"))
        {
            if (extrude.GetBool("extrudeLeft") == true && counter == 0)
            {
                startTime = Time.time;
                float z = (Time.time - startTime) * speed;
                GetComponent<Renderer>().material.color = Color.Lerp(startColor, extrude3, z);
                //extrude.SetInteger("counter", 1);
                //Debug.Log("counterRight = " + counterRight);
                if (counter == 0)
                {
                    counter++;
                }
                arrow1.SetActive(false);
                arrow2.SetActive(true);
                Debug.Log("counter = " + counter);
            }
            if (extrude.GetBool("extrudeLeft") == true && counter == 2)
            {
                startTime = Time.time;
                float z = (Time.time - startTime) * speed;
                GetComponent<Renderer>().material.color = Color.Lerp(extrude6, extrude9, z);
                //extrude.SetInteger("counter", 3);
                if (counter == 2)
                {
                    counter++;
                }
                arrow1.SetActive(false);
                arrow2.SetActive(true);
                Debug.Log("counter = " + counter);
            }
        }

        if (plunger.CompareTag("LeftExtrude"))
        {
            if (extrude.GetBool("extrudeRight") == true && counter == 1)
            {
                startTime = Time.time;
                float z = (Time.time - startTime) * speed;
                GetComponent<Renderer>().material.color = Color.Lerp(extrude3, extrude6, z);
                //extrude.SetInteger("counter", 2);
                if (counter == 1)
                {
                    counter++;
                }
                arrow2.SetActive(false);
                arrow1.SetActive(true);
                Debug.Log("counter = " + counter);
                //Debug.Log("counterLeft = " + counterLeft);
            }
            if (extrude.GetBool("extrudeRight") == true && counter == 3)
            {
                startTime = Time.time;
                float z = (Time.time - startTime) * speed;
                GetComponent<Renderer>().material.color = Color.Lerp(extrude9, extrude10, z);
                //extrude.SetInteger("counter", 4);
                if (counter == 3)
                {
                    counter++;
                }
                arrow2.SetActive(false);
                Debug.Log("counter = " + counter);
                startTime = Time.time;
                beginTime = true;
            }
        }
        if (beginTime == true)
        {
            if (Time.time - startTime > 2)
            {
                beforeAndAfter.SetActive(true);
                grabSyringe.SetActive(true);
                leftSyringe.SetActive(false);
                leftPlunger.SetActive(false);
                beginTime = false;
            }
        }
    }
}
