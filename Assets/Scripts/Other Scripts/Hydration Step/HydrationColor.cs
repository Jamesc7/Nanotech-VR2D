using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HydrationColor : MonoBehaviour {

    bool stop1 = false;
    float startTime1;

    bool stop2 = false;
    float startTime2;

    public static bool trigger = false;

    // Water Color
    float red1 = 0;
    float green1 = 172;
    float blue1 = 255;
    float trans1 = 86;

    // Lipid Color
    float red2 = 255;
    float green2 = 179;
    float blue2 = 0;
    float trans2 = 85;

    // End Color
    float red3 = 0;
    float green3 = 0;
    float blue3 = 0;
    float trans3 = 0;

    Color startWater;
    Color startLipid;
    Color end;

    float speed = .2f;

    public GameObject mixture;


    // Use this for initialization
    void Start () {

        // Divide by 255 because "Color" only takes values from 0 to 1.
        startWater = new Color(red1 / 255, green1 / 255, blue1 / 255, trans1 / 255);
        startLipid = new Color(red2 / 255, green2 / 255, blue2 / 255, trans2 / 255);
        end = new Color(red3 / 255, green3 / 255, blue3 / 255, trans3 / 255);
	}
	
	// Update is called once per frame
	void Update () {
        if (trigger == true)
        {
            if (stop1 == false)
            {
                startTime1 = Time.time;
                stop1 = true;
            }
            if (Time.time - startTime1 > 5)
            {

                if (gameObject.CompareTag("LipidLayer"))
                {
                    float z = (Time.time - (startTime1 + 6) /*6 second offset for anim?*/) * speed;
                    GetComponent<Renderer>().material.color = Color.Lerp(startLipid, end, z);
                    mixture.SetActive(true);
                    //Debug.Log("Results: " + (Time.time - startTime1));
                    if ((Time.time - startTime1) > 8.5f)
                    {
                        gameObject.SetActive(false);
                    }
                }


            }
            else if (gameObject.CompareTag("Water"))
            {
                if (stop2 == false)
                {
                    // 2 second offset to account for filling anim
                    startTime2 = Time.time + 2;
                    stop2 = true;
                }
                float z = (Time.time - startTime2) * speed;
                GetComponent<Renderer>().material.color = Color.Lerp(startWater, end, z);
                if (Time.time - startTime2 > 2.9f)
                {
                    gameObject.SetActive(false);
                }
            }
        }
    }
}
