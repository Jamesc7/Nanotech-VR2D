using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueAppear : MonoBehaviour {

    public GameObject thing;
    public GameObject player;
    Vector3 tempPos;

    public float distance;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        distance = Vector3.Distance(gameObject.transform.position, player.transform.position);
		if (distance < 0.1f)
        {
            Debug.Log("HELLO???");
        }
	}
}
