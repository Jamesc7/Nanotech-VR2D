using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeFilling : MonoBehaviour {

    public GameObject nano;
    public GameObject lipid;
    public GameObject water;

    public GameObject questionSet1Check;
    public GameObject questionSet2Check;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (questionSet1Check.activeInHierarchy)
        {
            nano.SetActive(true);
            water.SetActive(true);
        }
        else
        {
            lipid.SetActive(true);
        }
    }
}
