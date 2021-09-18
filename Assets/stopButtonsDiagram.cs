using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopButtonsDiagram : MonoBehaviour {

    // Stops buttons in the rotary evaporator diagram (question 6) from moving outside of the walls

    // Update is called once per frame
    void Update () {

        if (gameObject.transform.position.z < -2.15f)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, -2.15f);
        }
        if (gameObject.transform.position.z > 2.3f)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, 2.3f);
        }

        if (gameObject.transform.position.y < .69f)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, .69f, gameObject.transform.position.z);
        }

        if (gameObject.transform.position.y > 2.4f)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, 2.4f, gameObject.transform.position.z);
        }
    }
}
