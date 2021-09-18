using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class match : MonoBehaviour {

    public static bool attached1 = false;
    static bool attached2 = false;
    static bool attached3 = false;

    static bool attached4 = false;
    static bool attached5 = false;
    static bool attached6 = false;

    public GameObject correctEvap;
    public GameObject correctCon;

	// Use this for initialization
	void Start () {
        gameObject.GetComponent<Collider>();
	}

    private void OnTriggerEnter(Collider collider)
    {
        

        if (collider.gameObject.CompareTag("Evaporation"))
        {
            //Debug.Log("Correct!");
            //collision = null;
            if (gameObject.CompareTag("ans0") && !attached1 && !attached2 && !attached3)
            {
                
                gameObject.transform.position = new Vector3(-2.934f, 1.328f, 0.3520017f);
                attached1 = true;
                correctEvap.SetActive(true);
                //Debug.Log("TRU THO EVAP");
            }
            else if (gameObject.CompareTag("ans1") && !attached1 && !attached2 && !attached3)
            {
                gameObject.transform.position = new Vector3(-2.934f, 1.328f, 0.3520017f);
                attached2 = true;
            }
            else if (gameObject.CompareTag("ans2") && !attached1 && !attached2 && !attached3)
            {
                gameObject.transform.position = new Vector3(-2.934f, 1.328f, 0.3520017f);
                attached3 = true;
            }
            
            //Debug.Log("attached1 = " + attached1);
        }
        else if (collider.gameObject.CompareTag("Condensation"))
        {
            //Debug.Log("weirdChamp");
            if (gameObject.CompareTag("ans0") && !attached4 && !attached5 && !attached6)
            {
                gameObject.transform.position = new Vector3(-2.934f, 1.604f, 0.09000206f);
                attached4 = true;
            }
            else if (gameObject.CompareTag("ans1") && !attached4 && !attached5 && !attached6)
            {
                gameObject.transform.position = new Vector3(-2.934f, 1.604f, 0.09000206f);
                attached5 = true;
                correctCon.SetActive(true);
                //Debug.Log("TRU THO CON");
            }
            else if (gameObject.CompareTag("ans2") && !attached4 && !attached5 && !attached6)
            {
                gameObject.transform.position = new Vector3(-2.934f, 1.604f, 0.09000206f);
                attached6 = true;
            }

            //Debug.Log("attached2 = " + attached2);
        }
    }
    private void OnTriggerExit(Collider collider)
    {
        

        if (collider.gameObject.CompareTag("Evaporation"))
        {
            if (gameObject.CompareTag("ans0"))
            {
                attached1 = false;
                correctEvap.SetActive(false);
                //Debug.Log("BYE EVAP");
            }
            else if (gameObject.CompareTag("ans1"))
            {
                attached2 = false;
            }
            else if (gameObject.CompareTag("ans2"))
            {
                attached3 = false;
            }

            //Debug.Log("attached1 = " + attached1);
        }
        else if (collider.gameObject.CompareTag("Condensation"))
        {
            if (gameObject.CompareTag("ans0"))
            {
                attached4 = false;
            }
            else if (gameObject.CompareTag("ans1"))
            {
                attached5 = false;
                correctCon.SetActive(false);
                //Debug.Log("BYE CON");
            }
            else if (gameObject.CompareTag("ans2"))
            {
                attached6 = false;
            }
            //Debug.Log("attached2 = " + attached2);
        }
        
    }

    // Update is called once per frame
    void Update () {

	}
}
