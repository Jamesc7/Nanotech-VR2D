using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextToCam : MonoBehaviour {

    // Use this for initialization

    public GameObject following;

	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(Camera.main.transform.localPosition);
        if (following != null && following.activeSelf == true)
        {
            this.transform.position = new Vector3(following.transform.position.x, following.transform.position.y + (float).25, following.transform.position.z);
        } else {
            
            GameObject.Destroy(this.gameObject);
        }

    }
}
