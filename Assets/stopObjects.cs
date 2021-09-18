using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopObjects : MonoBehaviour {

    // This script is to be added on grabbable objects to stop them from moving outside of the walls. 
    // The drag-and-drop buttons for the questions are restricted in the StopButtonsLipo, StopButtonsNano, and StopButtonsDiagram scripts

    // Approx dimensions of DLS machine
    float left = -0.60f;
    float right = 0.15f;
    float top = 1.1f;
    float front = 0.8f;
    float back = 1.36f;


    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update () {

        // Stops all grabable flasks, syringes from moving below the table 
        if ((gameObject.CompareTag("kinematic") || gameObject.CompareTag("flask1") 
            || gameObject.CompareTag("flask2") || gameObject.CompareTag("Syringe1")) 
            && gameObject.transform.position.y < 0.808f)
        {
            gameObject.transform.position = new Vector3(transform.position.x, 0.808f, transform.position.z);
        }

        // These are the boundaries for the walls. All objects that have this script will be restrained within these boundaries.
        if (gameObject.transform.position.y > 2.3f)
        {
            gameObject.transform.position = new Vector3(transform.position.x, 2.25f, transform.position.z);
        }
        if (gameObject.transform.position.z < -2.15)
        {
            gameObject.transform.position = new Vector3(transform.position.x, transform.position.y, -2.15f);
        }
        if (gameObject.transform.position.x > 2.57)
        {
            gameObject.transform.position = new Vector3(2.57f, transform.position.y, transform.position.z);
        }
        if (gameObject.transform.position.z > 2.25)
        {
            gameObject.transform.position = new Vector3(transform.position.x, transform.position.y, 2.25f);
        }
        if (gameObject.transform.position.x < -2.75)
        {
            gameObject.transform.position = new Vector3(-2.75f, transform.position.y, transform.position.z);
        }

        // stops objects from going inside of the particle analyzer (DLS machine)
        if (gameObject.transform.position.x > -0.60f && gameObject.transform.position.x < 0.15f && gameObject.transform.position.y < 1.1f && gameObject.transform.position.z > 0.8f && gameObject.transform.position.z < 1.36f)
        {
            // Debug.Log("Inside machine");
            // Determines which side the object is moved to
            if (Mathf.Abs(gameObject.transform.position.x - left) < Mathf.Abs(gameObject.transform.position.x - right))
            {
                gameObject.transform.position = new Vector3(-0.60f, transform.position.y, transform.position.z);
            }
            else
            {
                gameObject.transform.position = new Vector3(0.15f, transform.position.y, transform.position.z);
            }

        }




    }
}
