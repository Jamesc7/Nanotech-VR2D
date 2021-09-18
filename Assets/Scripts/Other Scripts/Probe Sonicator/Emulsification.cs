using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Emulsification : MonoBehaviour {

    public GameObject sphere1;
    public GameObject sphere2;
    public GameObject sphere3;
    public GameObject sphere4;
    public GameObject sphere5;
    public GameObject sphere6;
    public GameObject sphere7;
    public GameObject sphere8;
    public GameObject sphere9;
    public GameObject sphere10;
    public GameObject sphere11;
    public GameObject sphere12;
    public GameObject sphere13;
    public GameObject sphere14;
    public GameObject sphere15;
    public GameObject sphere16;
    public GameObject sphere17;
    public GameObject sphere18;
    public GameObject sphere19;
    public GameObject sphere20;
    public GameObject sphere21;
    public GameObject sphere22;
    public GameObject sphere23;
    public GameObject sphere24;
    public GameObject sphere25;
    public GameObject sphere26;
    public GameObject sphere27;
    public GameObject sphere28;
    public GameObject sphere29;
    public GameObject sphere30;
    public GameObject sphere31;
    public GameObject sphere32;
    public GameObject sphere33;
    public GameObject sphere34;
    public GameObject sphere35;
    public GameObject sphere36;
    public GameObject sphere37;
    public GameObject sphere38;
    public GameObject sphere39;
    public GameObject sphere40;
    public GameObject sphere41;
    public GameObject sphere42;
    public GameObject sphere43;
    public GameObject sphere44;
    public GameObject sphere45;
    public GameObject sphere46;
    public GameObject sphere47;
    public GameObject sphere48;
    public GameObject sphere49;
    public GameObject sphere50;

    public GameObject emulAnim;
    public GameObject emulGrab;

    float startTime;

    bool beginAnim = false;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (beginAnim == false)
        {
            startTime = Time.time;
            beginAnim = true;
        }
        if (Time.time - startTime > 2)
        {
            sphere1.SetActive(true);
        }
        if (Time.time - startTime > 2.15f)
        {
            sphere2.SetActive(true);
        }
        if (Time.time - startTime > 2.30f)
        {
            sphere3.SetActive(true);
        }
        if (Time.time - startTime > 2.45f)
        {
            sphere4.SetActive(true);
        }
        if (Time.time - startTime > 2.60f)
        {
            sphere5.SetActive(true);
        }
        if (Time.time - startTime > 2.75f)
        {
            sphere6.SetActive(true);
        }
        if (Time.time - startTime > 2.9f)
        {
            sphere7.SetActive(true);
        }
        if (Time.time - startTime > 3.05f)
        {
            sphere8.SetActive(true);
        }
        if (Time.time - startTime > 3.20f)
        {
            sphere9.SetActive(true);
        }
        if (Time.time - startTime > 3.35f)
        {
            sphere10.SetActive(true);
        }
        if (Time.time - startTime > 3.50f)
        {
            sphere11.SetActive(true);
        }
        if (Time.time - startTime > 3.65f)
        {
            sphere12.SetActive(true);
        }
        if (Time.time - startTime > 3.80f)
        {
            sphere13.SetActive(true);
        }
        if (Time.time - startTime > 3.95f)
        {
            sphere14.SetActive(true);
        }
        if (Time.time - startTime > 4.1f)
        {
            sphere15.SetActive(true);
        }
        if (Time.time - startTime > 4.25f)
        {
            sphere16.SetActive(true);
        }
        if (Time.time - startTime > 4.40f)
        {
            sphere17.SetActive(true);
        }
        if (Time.time - startTime > 4.55f)
        {
            sphere18.SetActive(true);
        }
        if (Time.time - startTime > 4.7f)
        {
            sphere19.SetActive(true);
        }
        if (Time.time - startTime > 4.85f)
        {
            sphere20.SetActive(true);
        }
        if (Time.time - startTime > 5)
        {
            sphere21.SetActive(true);
        }
        if (Time.time - startTime > 5.15f)
        {
            sphere22.SetActive(true);
        }
        if (Time.time - startTime > 5.30f)
        {
            sphere23.SetActive(true);
        }
        if (Time.time - startTime > 5.45f)
        {
            sphere24.SetActive(true);
        }
        if (Time.time - startTime > 5.6f)
        {
            sphere25.SetActive(true);
        }
        if (Time.time - startTime > 5.75f)
        {
            sphere26.SetActive(true);
        }
        if (Time.time - startTime > 5.9f)
        {
            sphere27.SetActive(true);
        }
        if (Time.time - startTime > 6.05f)
        {
            sphere28.SetActive(true);
        }
        if (Time.time - startTime > 6.20f)
        {
            sphere29.SetActive(true);
        }
        if (Time.time - startTime > 6.35f)
        {
            sphere30.SetActive(true);
        }
        if (Time.time - startTime > 6.5f)
        {
            sphere31.SetActive(true);
        }
        if (Time.time - startTime > 6.65f)
        {
            sphere32.SetActive(true);
        }
        if (Time.time - startTime > 6.80f)
        {
            sphere33.SetActive(true);
        }
        if (Time.time - startTime > 6.95f)
        {
            sphere34.SetActive(true);
        }
        if (Time.time - startTime > 7.1f)
        {
            sphere35.SetActive(true);
        }
        if (Time.time - startTime > 7.25f)
        {
            sphere36.SetActive(true);
        }
        if (Time.time - startTime > 7.4f)
        {
            sphere37.SetActive(true);
        }
        if (Time.time - startTime > 7.55f)
        {
            sphere38.SetActive(true);
        }
        if (Time.time - startTime > 7.7f)
        {
            sphere39.SetActive(true);
        }
        if (Time.time - startTime > 7.85f)
        {
            sphere40.SetActive(true);
        }
        if (Time.time - startTime > 8)
        {
            sphere41.SetActive(true);
        }
        if (Time.time - startTime > 8.15f)
        {
            sphere42.SetActive(true);
        }
        if (Time.time - startTime > 8.3f)
        {
            sphere43.SetActive(true);
        }
        if (Time.time - startTime > 8.45f)
        {
            sphere44.SetActive(true);
        }
        if (Time.time - startTime > 8.6f)
        {
            sphere45.SetActive(true);
        }
        if (Time.time - startTime > 8.75f)
        {
            sphere46.SetActive(true);
        }
        if (Time.time - startTime > 8.9f)
        {
            sphere47.SetActive(true);
        }
        if (Time.time - startTime > 9.05f)
        {
            sphere48.SetActive(true);
        }
        if (Time.time - startTime > 9.2f)
        {
            sphere49.SetActive(true);
        }
        if (Time.time - startTime > 9.35f)
        {
            sphere50.SetActive(true);
        }
        if (Time.time - startTime > 10)
        {
            emulAnim.SetActive(false);
            emulGrab.SetActive(true);
        }
    }
}
