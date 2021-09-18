using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopButtonsLipo : MonoBehaviour {

    // Stops buttons in the liposome module's summary room (ending room) from moving outside of the walls

    // Update is called once per frame
    void Update () {
        if (gameObject.transform.position.z < 8.6f)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, 8.6f);
        }
        if (gameObject.transform.position.z > 13.8f)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, 13.8f);
        }

        if (gameObject.transform.position.y < .2f)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, .2f, gameObject.transform.position.z);
        }

        if (gameObject.transform.position.y > 2.3f)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, 2.3f, gameObject.transform.position.z);
        }
    }
}
