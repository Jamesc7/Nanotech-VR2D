using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class solventDropNano : MonoBehaviour {

    Animator solventDrop;
    public GameObject solvent1;
    public GameObject solvent2;
    public GameObject solvent3;
    public GameObject solvent4;
    public GameObject solvent5;
    public GameObject solvent6;
    public GameObject solvent7;
    public GameObject solvent8;
    public GameObject solvent9;
    public GameObject solvent10;
    public GameObject solvent11;
    public GameObject solvent12;
    public GameObject solvent13;
    public GameObject solvent14;
    public GameObject solvent15;
    public GameObject solvent16;
    public GameObject solvent17;
    public GameObject solvent18;
    public GameObject solvent19;
    public GameObject solvent20;
    public GameObject solvent21;
    public GameObject solvent22;
    public GameObject solvent23;
    public GameObject solvent24;
    public GameObject solvent25;
    public GameObject solvent26;
    public GameObject solvent27;
    /*public GameObject solvent28;
    public GameObject solvent29;
    public GameObject solvent30;
    public GameObject solvent31;
    public GameObject solvent32;
    public GameObject solvent33;
    public GameObject solvent34;
    public GameObject solvent35;
    public GameObject solvent36;
    public GameObject solvent37;
    public GameObject solvent38;
    public GameObject solvent39;
    public GameObject solvent40;
    public GameObject solvent41;
    public GameObject solvent42;
    public GameObject solvent43;
    public GameObject solvent44;
    public GameObject solvent45;
    public GameObject solvent46;
    public GameObject solvent47;
    public GameObject solvent48;
    public GameObject solvent49;
    public GameObject solvent50;
    public GameObject solvent51;
    public GameObject solvent52;*/

    float startTime;
    bool setTime = true;

    // Use this for initialization
    void Start()
    {
        solventDrop = gameObject.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (setTime == true)
        {
            startTime = Time.time;
            setTime = false;
        }
        //Debug.Log("Start Time: " + startTime);
        //Debug.Log("Adjusted Time: " + (Time.time - startTime));

        if (Time.time - startTime <= 6)
        {
            solventDrop.SetBool("Trigger", true);
        }
        if (Time.time - startTime >= 6.75f && Time.time - startTime <= 8)
        {
            solvent1.SetActive(true);
            solvent2.SetActive(true);
        }
        if (Time.time - startTime >= 8 && Time.time - startTime <= 9.25f)
        {
            //solvent2.SetActive(true);
            solvent3.SetActive(true);
            solvent4.SetActive(true);
        }
        if (Time.time - startTime >= 9.25f && Time.time - startTime <= 10.5f)
        {
            //solvent3.SetActive(true);
            solvent5.SetActive(true);
            solvent6.SetActive(true);
        }
        if (Time.time - startTime >= 10.5f && Time.time - startTime <= 11.75f)
        {
            //solvent4.SetActive(true);
            solvent7.SetActive(true);
            solvent8.SetActive(true);
        }
        if (Time.time - startTime >= 11.75f && Time.time - startTime <= 13)
        {
            //solvent5.SetActive(true);
            solvent9.SetActive(true);
            solvent10.SetActive(true);
        }
        if (Time.time - startTime >= 13 && Time.time - startTime <= 14.25f)
        {
            //solvent6.SetActive(true);
            solvent11.SetActive(true);
            solvent12.SetActive(true);
        }
        if (Time.time - startTime >= 14.25f && Time.time - startTime <= 15.5f)
        {
            //solvent7.SetActive(true);
            solvent13.SetActive(true);
            solvent14.SetActive(true);
        }
        if (Time.time - startTime >= 15.5f && Time.time - startTime <= 16.75f)
        {
            //solvent8.SetActive(true);
            solvent15.SetActive(true);
            solvent16.SetActive(true);
        }
        if (Time.time - startTime >= 16.75f && Time.time - startTime <= 18)
        {
            //solvent9.SetActive(true);
            solvent17.SetActive(true);
            solvent18.SetActive(true);
        }
        if (Time.time - startTime >= 18 && Time.time - startTime <= 19.25f)
        {
            //solvent10.SetActive(true);
            solvent19.SetActive(true);
            solvent20.SetActive(true);
        }
        if (Time.time - startTime >= 19.25f && Time.time - startTime <= 20.5f)
        {
            solvent21.SetActive(true);
            solvent22.SetActive(true);
        }

        if (Time.time - startTime >= 20.5f && Time.time - startTime <= 21.75f)
        {
            solvent23.SetActive(true);
            solvent24.SetActive(true);
        }
        if (Time.time - startTime >= 21.75f && Time.time - startTime <= 23)
        {
            solvent25.SetActive(true);
            solvent26.SetActive(true);
        }
        if (Time.time - startTime >= 23 && Time.time - startTime <= 24.25f)
        {
            solvent27.SetActive(true);
            //solvent28.SetActive(true);
        }
        /*if (Time.time >= 24.25f && Time.time <= 25.5f)
        {
            solvent29.SetActive(true);
            solvent30.SetActive(true);
        }
        if (Time.time >= 25.5f && Time.time <= 26.75f)
        {
            solvent31.SetActive(true);
            solvent32.SetActive(true);
        }
        if (Time.time >= 26.75f && Time.time <= 28)
        {
            solvent33.SetActive(true);
            solvent34.SetActive(true);
        }
        if (Time.time >= 28 && Time.time <= 29.25f)
        {
            solvent35.SetActive(true);
            solvent36.SetActive(true);
        }
        if (Time.time >= 29.25f && Time.time <= 30.5f)
        {
            solvent37.SetActive(true);
            solvent38.SetActive(true);
        }
        if (Time.time >= 30.5f && Time.time <= 31.75f)
        {
            solvent39.SetActive(true);
            solvent40.SetActive(true);
        }
        if (Time.time >= 31.75f && Time.time <= 33)
        {
            solvent41.SetActive(true);
            solvent42.SetActive(true);
        }
        if (Time.time >= 33 && Time.time <= 34.25f)
        {
            solvent43.SetActive(true);
            solvent44.SetActive(true);
        }
        if (Time.time >= 34.25f && Time.time <= 35.5f)
        {
            solvent45.SetActive(true);
            solvent46.SetActive(true);
        }
        if (Time.time >= 35.5f && Time.time <= 36.75f)
        {
            solvent47.SetActive(true);
            solvent48.SetActive(true);
        }
        if (Time.time >= 36.75f && Time.time <= 38)
        {
            solvent49.SetActive(true);
            solvent50.SetActive(true);
        }
        if (Time.time >= 38 && Time.time <= 39.25f)
        {
            solvent51.SetActive(true);
            solvent52.SetActive(true);
        }*/

        /*if (Time.time <= 6)
        {
            solventDrop.SetBool("Trigger", true);
        }
        if (Time.time >= 6.75f && Time.time <= 8)
        {
            solvent1.SetActive(true);
        }
        if (Time.time >= 8 && Time.time <= 9.25f)
        {
            solvent2.SetActive(true);
        }
        if (Time.time >= 9.25f && Time.time <= 10.5f)
        {
            solvent3.SetActive(true);
        }
        if (Time.time >= 10.5f && Time.time <= 11.75f)
        {
            solvent4.SetActive(true);
        }
        if (Time.time >= 11.75f && Time.time <= 13)
        {
            solvent5.SetActive(true);
        }
        if (Time.time >= 13 && Time.time <= 14.25f)
        {
            solvent6.SetActive(true);
        }
        if (Time.time >= 14.25f && Time.time <= 15.5f)
        {
            solvent7.SetActive(true);
        }
        if (Time.time >= 15.5f && Time.time <= 16.75f)
        {
            solvent8.SetActive(true);
        }
        if (Time.time >= 16.75f && Time.time <= 18)
        {
            solvent9.SetActive(true);
        }
        if (Time.time >= 18 && Time.time <= 19.25f)
        {
            solvent10.SetActive(true);
        }
        if (Time.time >= 19.25f && Time.time <= 20.5f)
        {
            solvent11.SetActive(true);
        }*/
    }
}