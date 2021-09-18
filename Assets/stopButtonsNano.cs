using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopButtonsNano : MonoBehaviour {

    // Stops buttons in the nanoparticle module's summary room (ending room) from moving outside of the walls
	
	// Update is called once per frame
	void Update () {
        if (gameObject.transform.position.z < -13.9f)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, -13.9f);
        }
        if (gameObject.transform.position.z > -8.8f)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, -8.8f);
        }

        if (gameObject.transform.position.y < .3f)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, .3f, gameObject.transform.position.z);
        }

        if (gameObject.transform.position.y > 2.4f)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, 2.4f, gameObject.transform.position.z);
        }
    }
}
