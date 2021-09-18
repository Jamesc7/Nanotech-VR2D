using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoluteEvapLiposome : MonoBehaviour {

    public GameObject soluteEvap1;
    public GameObject soluteEvap2;
    public GameObject soluteEvap3;
    public GameObject soluteEvap4;
    public GameObject soluteEvap5;
    public GameObject soluteEvap6;
    public GameObject soluteEvap7;
    public GameObject soluteEvap8;
    public GameObject soluteEvap9;
    public GameObject soluteEvap10;
    public GameObject soluteEvap11;
    public GameObject soluteEvap12;
    public GameObject soluteEvap13;
    public GameObject soluteEvap14;
    public GameObject soluteEvap15;
    public GameObject soluteEvap16;
    public GameObject soluteEvap17;
    public GameObject soluteEvap18;
    public GameObject soluteEvap19;
    public GameObject soluteEvap20;
    public GameObject soluteEvap21;
    public GameObject soluteEvap22;
    public GameObject soluteEvap23;
    public GameObject soluteEvap24;
    public GameObject soluteEvap25;
    public GameObject soluteEvap26;
    public GameObject soluteEvap27;
    public GameObject soluteEvap28;
    public GameObject soluteEvap29;
    public GameObject soluteEvap30;
    public GameObject soluteEvap31;
    public GameObject soluteEvap32;
    public GameObject soluteEvap33;
    public GameObject soluteEvap34;
    public GameObject soluteEvap35;
    public GameObject soluteEvap36;
    public GameObject soluteEvap37;
    public GameObject soluteEvap38;
    public GameObject soluteEvap39;
    public GameObject soluteEvap40;
    public GameObject soluteEvap41;
    public GameObject soluteEvap42;
    public GameObject soluteEvap43;
    public GameObject soluteEvap44;
    public GameObject soluteEvap45;
    public GameObject soluteEvap46;
    public GameObject soluteEvap47;
    public GameObject soluteEvap48;
    public GameObject soluteEvap49;
    public GameObject soluteEvap50;
    public GameObject soluteEvap51;
    public GameObject soluteEvap52;

    float startTime;
    bool beginTime = false;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (beginTime == false)
        {
            startTime = Time.time;
            beginTime = true;
        }
        if (Time.time - startTime >= 5)
        {
            soluteEvap1.SetActive(false);
            soluteEvap2.SetActive(false);
        }
        if (Time.time - startTime >= 6.25f)
        {
            //soluteEvap2.SetActive(false);
            soluteEvap3.SetActive(false);
            soluteEvap4.SetActive(false);
        }
        if (Time.time - startTime >= 7.5f)
        {
            //soluteEvap3.SetActive(false);
            soluteEvap5.SetActive(false);
            soluteEvap6.SetActive(false);
        }
        if (Time.time - startTime >= 8.75f)
        {
            //soluteEvap4.SetActive(false);
            soluteEvap7.SetActive(false);
            soluteEvap8.SetActive(false);
        }
        if (Time.time - startTime >= 10)
        {
            //soluteEvap5.SetActive(false);
            soluteEvap9.SetActive(false);
            soluteEvap10.SetActive(false);
        }
        if (Time.time - startTime >= 11.25f)
        {
            //soluteEvap6.SetActive(false);
            soluteEvap11.SetActive(false);
            soluteEvap12.SetActive(false);
        }
        if (Time.time - startTime >= 12.5f)
        {
            //soluteEvap7.SetActive(false);
            soluteEvap13.SetActive(false);
            soluteEvap14.SetActive(false);
        }
        if (Time.time - startTime >= 13.75f)
        {
            //soluteEvap8.SetActive(false);
            soluteEvap15.SetActive(false);
            soluteEvap16.SetActive(false);
        }
        if (Time.time - startTime >= 15)
        {
            //soluteEvap9.SetActive(false);
            soluteEvap17.SetActive(false);
            soluteEvap18.SetActive(false);
        }
        if (Time.time - startTime >= 16.25f)
        {
            //soluteEvap10.SetActive(false);
            soluteEvap19.SetActive(false);
            soluteEvap20.SetActive(false);
        }
        if (Time.time - startTime >= 17.5f)
        {
            //soluteEvap11.SetActive(false);
            soluteEvap21.SetActive(false);
            soluteEvap22.SetActive(false);
        }
        if (Time.time - startTime >= 18.75f)
        {
            //soluteEvap12.SetActive(false);
            soluteEvap23.SetActive(false);
            soluteEvap24.SetActive(false);
        }
        if (Time.time - startTime >= 20)
        {
            //soluteEvap13.SetActive(false);
            soluteEvap25.SetActive(false);
            soluteEvap26.SetActive(false);
        }
        if (Time.time - startTime >= 21.25f)
        {
            //soluteEvap14.SetActive(false);
            soluteEvap27.SetActive(false);
            soluteEvap28.SetActive(false);
        }
        if (Time.time - startTime >= 22.5f)
        {
            //soluteEvap15.SetActive(false);
            soluteEvap29.SetActive(false);
            soluteEvap30.SetActive(false);
        }
        if (Time.time - startTime >= 23.75f)
        {
            //soluteEvap16.SetActive(false);
            soluteEvap31.SetActive(false);
            soluteEvap32.SetActive(false);
        }
        if (Time.time - startTime >= 25)
        {
            //soluteEvap17.SetActive(false);
            soluteEvap33.SetActive(false);
            soluteEvap34.SetActive(false);
        }
        if (Time.time - startTime >= 26.25f)
        {
            //soluteEvap18.SetActive(false);
            soluteEvap35.SetActive(false);
            soluteEvap36.SetActive(false);
        }
        if (Time.time - startTime >= 27.5f)
        {
            //soluteEvap19.SetActive(false);
            soluteEvap37.SetActive(false);
            soluteEvap38.SetActive(false);
        }

        if (Time.time - startTime >= 28.75f)
        {
            //soluteEvap20.SetActive(false);
            soluteEvap39.SetActive(false);
            soluteEvap40.SetActive(false);
        }
        if (Time.time - startTime >= 30)
        {
            //soluteEvap21.SetActive(false);
            soluteEvap41.SetActive(false);
            soluteEvap42.SetActive(false);
        }
        if (Time.time - startTime >= 31.25f)
        {
            //soluteEvap22.SetActive(false);
            soluteEvap43.SetActive(false);
            soluteEvap44.SetActive(false);
        }
        if (Time.time - startTime >= 32.5f)
        {
            //soluteEvap23.SetActive(false);
            soluteEvap45.SetActive(false);
            soluteEvap46.SetActive(false);
        }
        if (Time.time - startTime >= 33.75f)
        {
            //soluteEvap24.SetActive(false);
            soluteEvap47.SetActive(false);
            soluteEvap48.SetActive(false);
        }
        if (Time.time - startTime >= 35)
        {
            //soluteEvap25.SetActive(false);
            soluteEvap49.SetActive(false);
            soluteEvap50.SetActive(false);
        }
        if (Time.time - startTime >= 36.25f)
        {
            //soluteEvap26.SetActive(false);
            soluteEvap51.SetActive(false);
            soluteEvap52.SetActive(false);
        }
        /*if (Time.time >= 37.5f)
        {
            //soluteEvap27.SetActive(false);
        }
        if (Time.time >= 38.75f)
        {
            //soluteEvap28.SetActive(false);
        }
        if (Time.time >= 40)
        {
            //soluteEvap29.SetActive(false);
        }

        if (Time.time >= 41.25f)
        {
            //soluteEvap30.SetActive(false);
        }
        if (Time.time >= 42.5f)
        {
            //soluteEvap31.SetActive(false);
        }
        if (Time.time >= 43.75f)
        {
            //soluteEvap32.SetActive(false);
        }
        if (Time.time >= 45)
        {
            //soluteEvap33.SetActive(false);
        }
        if (Time.time >= 46.25f)
        {
            //soluteEvap34.SetActive(false);
        }
        if (Time.time >= 47.5f)
        {
            //soluteEvap35.SetActive(false);
        }
        if (Time.time >= 48.75f)
        {
            //soluteEvap36.SetActive(false);
        }
        if (Time.time >= 50)
        {
            //soluteEvap37.SetActive(false);
        }
        if (Time.time >= 51.25f)
        {
            //soluteEvap38.SetActive(false);
        }
        if (Time.time >= 52.5f)
        {
            //soluteEvap39.SetActive(false);
        }

        if (Time.time >= 53.75f)
        {
            //soluteEvap40.SetActive(false);
        }
        if (Time.time >= 55)
        {
            //soluteEvap41.SetActive(false);
        }
        if (Time.time >= 56.25f)
        {
            //soluteEvap42.SetActive(false);
        }
        if (Time.time >= 57.5f)
        {
            //soluteEvap43.SetActive(false);
        }
        if (Time.time >= 58.75f)
        {
            //soluteEvap44.SetActive(false);
        }
        if (Time.time >= 60)
        {
            //soluteEvap45.SetActive(false);
        }
        if (Time.time >= 61.25f)
        {
            //soluteEvap46.SetActive(false);
        }
        if (Time.time >= 62.5f)
        {
            //soluteEvap47.SetActive(false);
        }
        if (Time.time >= 63.75f)
        {
            //soluteEvap48.SetActive(false);
        }
        if (Time.time >= 65)
        {
            //soluteEvap49.SetActive(false);
        }

        if (Time.time >= 66.25f)
        {
            //soluteEvap50.SetActive(false);
        }
        if (Time.time >= 67.5f)
        {
            //soluteEvap51.SetActive(false);
        }
        if (Time.time >= 68.75f)
        {
            //soluteEvap52.SetActive(false);
        }*/
    }
}
