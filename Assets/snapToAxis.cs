using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snapToAxis : MonoBehaviour {

    public GameObject question1Check;
    public GameObject question2Check;

    public float x;
    public float y;
    public float z;

    public Vector3 contactPoint = new Vector3();
    public Vector3 contactPoint2 = new Vector3();

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (gameObject.CompareTag("beaker2") && question1Check.activeInHierarchy)
        {
            if (Vector3.Distance(gameObject.transform.position, contactPoint) < 0.2f)
            {
                gameObject.transform.position = new Vector3(transform.position.x, transform.position.y, -1.086815f);
            }
            
        }
        if (gameObject.CompareTag("beaker2") && question2Check.activeInHierarchy)
        {
            if (Vector3.Distance(gameObject.transform.position, contactPoint2) < 0.2f)
            {
                gameObject.transform.position = new Vector3(-1.3f, transform.position.y, transform.position.z);
            }
        }
        if (gameObject.CompareTag("beaker3"))
        {
            if (Vector3.Distance(gameObject.transform.position, contactPoint) < 0.2f)
            {
                gameObject.transform.position = new Vector3(-1.371f, transform.position.y, transform.position.z);
            }

        }
        if (gameObject.CompareTag("flask1"))
        {
            if (Vector3.Distance(gameObject.transform.position, contactPoint) < 0.2f)
            {
                gameObject.transform.position = new Vector3(transform.position.x, transform.position.y, 1.074f);
            }
        }
        if (gameObject.CompareTag("flask2"))
        {
            if (Vector3.Distance(gameObject.transform.position, contactPoint) < 0.2f)
            {
                gameObject.transform.position = new Vector3(-1.385658f, transform.position.y, transform.position.z);
            }
        }
        if (gameObject.CompareTag("Syringe1"))
        {
            if (Vector3.Distance(gameObject.transform.position, contactPoint) < 0.2f)
            {
                gameObject.transform.position = new Vector3(transform.position.x, transform.position.y, 1.074f);
            }
        }
    }
}
