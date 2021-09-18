using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class captionAppear : MonoBehaviour {

    public GameObject caption;
    public GameObject animationBeaker;

    bool stop = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (animationBeaker.activeInHierarchy)
        {
            caption.SetActive(true);
            stop = true;
        }
        else if (animationBeaker.activeInHierarchy == false && stop == true)
        {
            caption.SetActive(false);
        }
        
	}
}
