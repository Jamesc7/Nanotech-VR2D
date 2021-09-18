using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startRotEvap : MonoBehaviour {

    bool setTime = false;
    float startTime = 0;

    public GameObject arrow;
    public GameObject rotationArrow;
    public GameObject rotFlaskNano;
    public GameObject rotFlaskLip;
    public GameObject soluteNano;
    public GameObject water;
    public GameObject soluteLip;
    public GameObject condVaporNano;
    public GameObject condVaporLip;
    public GameObject questionSet1Check;
    public GameObject questionSet2Check;

    public GameObject labelNanoOnly;
    public GameObject label_arrows;


    public GameObject startButton;
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
        if (Time.time - startTime > 1.0f)
        {
            if (questionSet1Check.activeInHierarchy)
            {
                condVaporNano.GetComponent<mix>().enabled = true;
                rotFlaskNano.SetActive(true);
                soluteNano.SetActive(true);
                water.SetActive(true);
                labelNanoOnly.SetActive(true);
                label_arrows.SetActive(true);
            } else
            {
                condVaporLip.GetComponent<mix>().enabled = true;
                rotFlaskLip.SetActive(true);
                soluteLip.SetActive(true);
                label_arrows.SetActive(true);
            }
            arrow.SetActive(true);
            rotationArrow.SetActive(true);
            //condVapor.GetComponent<mix>().enabled = true;
            //rotFlaskNano.SetActive(true);
            //solute.SetActive(true);
            //water.SetActive(true);
            startButton.transform.localPosition = new Vector3(startButton.transform.localPosition.x, .15f, startButton.transform.localPosition.z);
            gameObject.SetActive(false);
        }
	}
}
