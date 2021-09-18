using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mix : MonoBehaviour {

    public float speed = 1.0f;
    public float speed2 = 0.1f;
    public Color startColor;
    public Color endColor;
    public Color startColor2;
    public Color endColor2;
    float startTime;

    public GameObject mixed;
    bool setTime = true;
    public static bool nanoparticle = true;
    public static bool liposome = true;

    bool startEmul = false;

    public GameObject solventLipid;

    //public GameObject solventDrop;
    public GameObject solventDropNano;

    // Use this for initialization
    void Start () {
        //startTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
        if (setTime == true)
        {
            startTime = Time.time;
            setTime = false;
        }

        // For the Probe Sonicator
        float t = (Time.time - startTime) * speed;

        // For the Rotary Evap
        float z = (Time.time - startTime) * speed2;

        // Probe Sonicator
        if (/*startEmul.startAnim == true && */ Time.time - startTime > 2 && gameObject.CompareTag("ProbeSonicator"))
        {
            /*if (setTime == true)
            {
                startTime = Time.time;
                setTime = false;
            }
            float t = (Time.time - startTime) * speed;*/
            GetComponent<Renderer>().material.color = Color.Lerp(startColor, endColor, t);
            if (Time.time - startTime > 10 && Time.time - startTime < 11)
            {
                gameObject.SetActive(false);
                mixed.SetActive(true);
            }
        }
        // For Nanoparticles (Condenser Vapor) - Enables Droplet 
        else if (gameObject.CompareTag("rotaryEvapNano"))
        {
            /*if (setTime == true)
            {
                startTime = Time.time;
                setTime = false;
            }
            float t = (Time.time - startTime) * speed;*/
            GetComponent<Renderer>().material.color = Color.Lerp(startColor, endColor, z);
            if (Time.time - startTime >= 5 && Time.time - startTime <= 6 && nanoparticle == true)
            {
                solventDropNano.SetActive(true);
            }
            /*else if (Time.time >= 5 && Time.time <= 6 && nanoparticle == false)
            {
                solventDrop.SetActive(true);
            }*/
            
        }
        // For lipids (Condenser Vapor) - Enables layer of liposomes
        else if (gameObject.CompareTag("rotaryEvapLipid"))
        {
            GetComponent<Renderer>().material.color = Color.Lerp(startColor2, endColor2, z);
            if (Time.time - startTime >= 5 && Time.time - startTime <= 6 && liposome == true)
            {
                //solventDropNano.SetActive(true);
                solventLipid.SetActive(true);
                //changeColor.startup = true;
            }
        }
        
	}
}
