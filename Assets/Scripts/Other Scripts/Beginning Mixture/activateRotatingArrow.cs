using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activateRotatingArrow : MonoBehaviour {

    public GameObject rotatingArrow;
    public GameObject arrow1;
    public GameObject arrow2;

    public GameObject water_PVA;
    public GameObject PLGA_DCM;

    public static bool stop = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (arrow1.activeInHierarchy == false && arrow2.activeInHierarchy == false && stop == false)
        {
            rotatingArrow.SetActive(true);
        }
	}
}
