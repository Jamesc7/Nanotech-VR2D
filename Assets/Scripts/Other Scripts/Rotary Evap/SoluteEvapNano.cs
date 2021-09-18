using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoluteEvapNano : MonoBehaviour {

    bool setTime = false;
    float startTime = 0;

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
    /*public GameObject soluteEvap28;
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

    public GameObject nanoparticle1;
    public GameObject nanoparticle2;
    public GameObject nanoparticle3;
    public GameObject nanoparticle4;
    public GameObject nanoparticle5;
    public GameObject nanoparticle6;
    public GameObject nanoparticle7;
    public GameObject nanoparticle8;
    public GameObject nanoparticle9;
    public GameObject nanoparticle10;
    public GameObject nanoparticle11;

    public GameObject nanoparticle1end;
    public GameObject nanoparticle2end;
    public GameObject nanoparticle3end;
    public GameObject nanoparticle4end;
    public GameObject nanoparticle5end;
    public GameObject nanoparticle6end;
    public GameObject nanoparticle7end;
    public GameObject nanoparticle8end;
    public GameObject nanoparticle9end;
    public GameObject nanoparticle10end;
    public GameObject nanoparticle11end;*/

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (setTime == false)
        {
            startTime = Time.time;
            setTime = true;
        }

        if (Time.time - startTime >= 5)
        {
            soluteEvap1.SetActive(false);
            soluteEvap2.SetActive(false);

            /*nanoparticle1.SetActive(false);
            nanoparticle2.SetActive(false);
            nanoparticle1end.SetActive(true);
            nanoparticle2end.SetActive(true);*/
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

            /*nanoparticle3.SetActive(false);
            nanoparticle4.SetActive(false);
            nanoparticle3end.SetActive(true);
            nanoparticle4end.SetActive(true);*/
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

            /*nanoparticle5.SetActive(false);
            nanoparticle6.SetActive(false);
            nanoparticle5end.SetActive(true);
            nanoparticle6end.SetActive(true);*/
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
            //soluteEvap28.SetActive(false);
        }
        /*if (Time.time >= 22.5f)
        {
            //soluteEvap15.SetActive(false);
            soluteEvap29.SetActive(false);
            soluteEvap30.SetActive(false);
        }
        if (Time.time >= 23.75f)
        {
            //soluteEvap16.SetActive(false);
            soluteEvap31.SetActive(false);
            soluteEvap32.SetActive(false);

            nanoparticle7.SetActive(false);
            nanoparticle8.SetActive(false);
            nanoparticle7end.SetActive(true);
            nanoparticle8end.SetActive(true);
        }
        if (Time.time >= 25)
        {
            //soluteEvap17.SetActive(false);
            soluteEvap33.SetActive(false);
            soluteEvap34.SetActive(false);
        }
        if (Time.time >= 26.25f)
        {
            //soluteEvap18.SetActive(false);
            soluteEvap35.SetActive(false);
            soluteEvap36.SetActive(false);
        }
        if (Time.time >= 27.5f)
        {
            //soluteEvap19.SetActive(false);
            soluteEvap37.SetActive(false);
            soluteEvap38.SetActive(false);
        }

        if (Time.time >= 28.75f)
        {
            //soluteEvap20.SetActive(false);
            soluteEvap39.SetActive(false);
            soluteEvap40.SetActive(false);
        }
        if (Time.time >= 30)
        {
            //soluteEvap21.SetActive(false);
            soluteEvap41.SetActive(false);
            soluteEvap42.SetActive(false);

            nanoparticle9.SetActive(false);
            nanoparticle10.SetActive(false);
            nanoparticle9end.SetActive(true);
            nanoparticle10end.SetActive(true);
        }
        if (Time.time >= 31.25f)
        {
            //soluteEvap22.SetActive(false);
            soluteEvap43.SetActive(false);
            soluteEvap44.SetActive(false);
        }
        if (Time.time >= 32.5f)
        {
            //soluteEvap23.SetActive(false);
            soluteEvap45.SetActive(false);
            soluteEvap46.SetActive(false);
        }
        if (Time.time >= 33.75f)
        {
            //soluteEvap24.SetActive(false);
            soluteEvap47.SetActive(false);
            soluteEvap48.SetActive(false);
        }
        if (Time.time >= 35)
        {
            //soluteEvap25.SetActive(false);
            soluteEvap49.SetActive(false);
            soluteEvap50.SetActive(false);
        }
        if (Time.time >= 36.25f)
        {
            //soluteEvap26.SetActive(false);
            soluteEvap51.SetActive(false);
            soluteEvap52.SetActive(false);

            nanoparticle11.SetActive(false);
            nanoparticle11end.SetActive(true);
        }*/

        /*if (Time.time >= 5)
        {
            soluteEvap1.SetActive(false);
        }
        if (Time.time >= 6.25f)
        {
            soluteEvap2.SetActive(false);
        }
        if (Time.time >= 7.5f)
        {
            soluteEvap3.SetActive(false);
        }
        if (Time.time >= 8.75f)
        {
            soluteEvap4.SetActive(false);
        }
        if (Time.time >= 10)
        {
            soluteEvap5.SetActive(false);
        }
        if (Time.time >= 11.25f)
        {
            soluteEvap6.SetActive(false);
        }
        if (Time.time >= 12.5f)
        {
            soluteEvap7.SetActive(false);
        }
        if (Time.time >= 13.75f)
        {
            soluteEvap8.SetActive(false);
        }
        if (Time.time >= 15)
        {
            soluteEvap9.SetActive(false);
        }
        if (Time.time >= 16.25f)
        {
            soluteEvap10.SetActive(false);
        }
        if (Time.time >= 17.5f)
        {
            soluteEvap11.SetActive(false);
        }*/
    }
}
