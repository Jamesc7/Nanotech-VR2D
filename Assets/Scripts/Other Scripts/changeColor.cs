using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColor : MonoBehaviour {

    public float speed = .1f;
    public Color startColor2;
    public Color endColor2;
    public Color secondColor;
    //public static bool startup = true; // used in mix script
    public bool repeatable;

    public bool thirdColor;
    bool thirdColorLock = false;

    bool stop = false;
    float startTime;

    // Use this for initialization
    void Start () {
        //startTime = Time.time;
    }
	
	// Update is called once per frame
	void Update ()
    {            
        if (stop == false)
        {
            startTime = Time.time;
                
            stop = true;
        }
        //Does not repeat. Changes color once
        if (!repeatable)
        {
            float z = (Time.time - startTime) * speed;
            GetComponent<Renderer>().material.color = Color.Lerp(startColor2, endColor2, z);
        }
        else
        {
            //lerp
            //Repeats colors. Only lerps between 2 colors.
            if (!thirdColor)
            {
                float z = (Mathf.Sin(Time.time - startTime) * speed);
                GetComponent<Renderer>().material.color = Color.Lerp(startColor2, endColor2, z);
            }
            // Repeats colors. Goes from starting color to second color, to third color. Lerps between the second and third colors.
            else
            {
                if (thirdColorLock == false)
                {
                    float z = (Time.time - startTime) * speed;
                    GetComponent<Renderer>().material.color = Color.Lerp(startColor2, endColor2, z);
                    thirdColorLock = true;
                }
                else
                {
                    float z = (Mathf.Sin(Time.time - startTime) * speed);
                    GetComponent<Renderer>().material.color = Color.Lerp(endColor2, secondColor, z);
                }
            }
            
        }
        

    }
}
