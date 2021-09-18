using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InsertSampleVer2 : MonoBehaviour {

    Animator insertSample;
    Animator closeLid;

    public GameObject sample;
    public GameObject capsule;
    public GameObject capsule2;
    public GameObject DLS;

    /*public GameObject container;
    public GameObject containerWall1;*/

    public GameObject lid;
    public GameObject beam;
    public GameObject particles;
    public GameObject image;

    public GameObject text;
    public GameObject background;

    float startTime = 0;
    bool beginTime = false;

    public static bool trigger = false;

    // Use this for initialization
    void Start()
    {
        insertSample = sample.GetComponent<Animator>();
        closeLid = lid.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (trigger == true)
        {
            if (beginTime == false)
            {
                startTime = Time.time;
                beginTime = true;
                closeLid.SetBool("Trigger", true);
            }
            if ((Time.time - startTime) > 1.0f)
            {
                insertSample.SetBool("Trigger", true);
            }
            if (Time.time - startTime > 2.0f)
            {
                insertSample.SetBool("Trigger2", true);
                
            }
            if (Time.time - startTime > 3.0f)
            {
                closeLid.SetBool("Trigger2", true);
                DLS.GetComponent<changeMaterial>().enabled = true;
                DLS.GetComponent<changeColor>().enabled = true;
            }
            if (Time.time - startTime > 5.0f)
            {
                beam.SetActive(true);
                // enable both because it doesn't really matter
                capsule.GetComponent<changeColor>().enabled = true;
                capsule2.GetComponent<changeColor>().enabled = true;
                particles.SetActive(true);
                text.SetActive(true);
                background.SetActive(true);
            }
            if (Time.time - startTime > 6.0f)
            {
                image.SetActive(true);
            }
        }
        
    }
}
