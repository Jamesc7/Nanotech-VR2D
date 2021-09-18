using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class emulsify : MonoBehaviour {
    float timeCounter = 0;
    /*float timeCounter2 = -1;
    float timeCounter3 = -2;
    float timeCounter4 = -3;*/
    float speed;
    float xaxis;
    float zaxis;
    float yaxis;

	// Use this for initialization
	void Start () {
        /*speed = 5;
        xaxis = 0.03f;
        zaxis = 0.03f;
        yaxis = 0.001f;*/

        speed = 1;
        xaxis = -2.0147f;
        zaxis = -0.03059999f;
        yaxis = 0.9198864f;

        /*xaxis = -0.22f;
        zaxis = 0.9341136f;
        yaxis = 0.2395f;*/

        if (gameObject.CompareTag("emulsify2"))
        {
            timeCounter = -1;
        }
        else if (gameObject.CompareTag("emulsify3"))
        {
            timeCounter = -2;
        }
        else if (gameObject.CompareTag("emulsify4"))
        {
            timeCounter = -3;
        }
        else if (gameObject.CompareTag("emulsify5"))
        {
            timeCounter = -4;
        }
        else if (gameObject.CompareTag("emulsify6"))
        {
            timeCounter = -5;
        }
        else if (gameObject.CompareTag("emulsify7"))
        {
            timeCounter = -23;
        }
        else if (gameObject.CompareTag("emulsify8"))
        {
            timeCounter = -24;
        }
        else if (gameObject.CompareTag("emulsify9"))
        {
            timeCounter = -25;
        }
        else if (gameObject.CompareTag("emulsify10"))
        {
            timeCounter = -26;
        }
        else if (gameObject.CompareTag("emulsify11"))
        {
            timeCounter = -27;
        }
        else if (gameObject.CompareTag("emulsify12"))
        {
            timeCounter = -28;
        }
        else if (gameObject.CompareTag("emulsify13"))
        {
            timeCounter = -46;
        }
        else if (gameObject.CompareTag("emulsify14"))
        {
            timeCounter = -47;
        }
        else if (gameObject.CompareTag("emulsify15"))
        {
            timeCounter = -48;
        }
        else if (gameObject.CompareTag("emulsify16"))
        {
            timeCounter = -49;
        }
        else if (gameObject.CompareTag("emulsify17"))
        {
            timeCounter = -50;
        }
        else if (gameObject.CompareTag("emulsify18"))
        {
            timeCounter = -51;
        }
        else if (gameObject.CompareTag("emulsify19"))
        {
            timeCounter = -69;
        }
        else if (gameObject.CompareTag("emulsify20"))
        {
            timeCounter = -70;
        }
        else if (gameObject.CompareTag("emulsify21"))
        {
            timeCounter = -71;
        }
        else if (gameObject.CompareTag("emulsify22"))
        {
            timeCounter = -72;
        }
        else if (gameObject.CompareTag("emulsify23"))
        {
            timeCounter = -73;
        }
        else if (gameObject.CompareTag("emulsify24"))
        {
            timeCounter = -74;
        }
    }
	
	// Update is called once per frame
	void Update () {
        

        if (CompareTag("emulsify2"))
        {
            if (timeCounter < 76) {
                timeCounter += Time.deltaTime * speed;
            }
            
        }
        else if (CompareTag("emulsify3"))
        {
            if (timeCounter < 75)
            {
                timeCounter += Time.deltaTime * speed;
            }

        }
        else if (CompareTag("emulsify4"))
        {
            if (timeCounter < 74)
            {
                timeCounter += Time.deltaTime * speed;
            }

        }
        else if (CompareTag("emulsify5"))
        {
            if (timeCounter < 73)
            {
                timeCounter += Time.deltaTime * speed;
            }

        }
        else if (CompareTag("emulsify6"))
        {
            if (timeCounter < 72)
            {
                timeCounter += Time.deltaTime * speed;
            }

        }
        else if (CompareTag("emulsify7"))
        {
            if (timeCounter < 54)
            {
                timeCounter += Time.deltaTime * speed;
            }

        }
        else if (CompareTag("emulsify8"))
        {
            if (timeCounter < 53)
            {
                timeCounter += Time.deltaTime * speed;
            }

        }
        else if (CompareTag("emulsify9"))
        {
            if (timeCounter < 52)
            {
                timeCounter += Time.deltaTime * speed;
            }

        }
        else if (CompareTag("emulsify10"))
        {
            if (timeCounter < 51)
            {
                timeCounter += Time.deltaTime * speed;
            }

        }
        else if (CompareTag("emulsify11"))
        {
            if (timeCounter < 50)
            {
                timeCounter += Time.deltaTime * speed;
            }

        }
        else if (CompareTag("emulsify12"))
        {
            if (timeCounter < 49)
            {
                timeCounter += Time.deltaTime * speed;
            }

        }
        else if (CompareTag("emulsify13"))
        {
            if (timeCounter < 31)
            {
                timeCounter += Time.deltaTime * speed;
            }

        }
        else if (CompareTag("emulsify14"))
        {
            if (timeCounter < 30)
            {
                timeCounter += Time.deltaTime * speed;
            }

        }
        else if (CompareTag("emulsify15"))
        {
            if (timeCounter < 29)
            {
                timeCounter += Time.deltaTime * speed;
            }

        }
        else if (CompareTag("emulsify16"))
        {
            if (timeCounter < 28)
            {
                timeCounter += Time.deltaTime * speed;
            }

        }
        else if (CompareTag("emulsify17"))
        {
            if (timeCounter < 27)
            {
                timeCounter += Time.deltaTime * speed;
            }

        }
        else if (CompareTag("emulsify18"))
        {
            if (timeCounter < 26)
            {
                timeCounter += Time.deltaTime * speed;
            }

        }
        else if (CompareTag("emulsify19"))
        {
            if (timeCounter < 8)
            {
                timeCounter += Time.deltaTime * speed;
            }

        }
        else if (CompareTag("emulsify20"))
        {
            if (timeCounter < 7)
            {
                timeCounter += Time.deltaTime * speed;
            }

        }
        else if (CompareTag("emulsify21"))
        {
            if (timeCounter < 6)
            {
                timeCounter += Time.deltaTime * speed;
            }

        }
        else if (CompareTag("emulsify22"))
        {
            if (timeCounter < 5)
            {
                timeCounter += Time.deltaTime * speed;
            }

        }
        else if (CompareTag("emulsify23"))
        {
            if (timeCounter < 4)
            {
                timeCounter += Time.deltaTime * speed;
            }

        }
        else if (CompareTag("emulsify24"))
        {
            if (timeCounter < 3)
            {
                timeCounter += Time.deltaTime * speed;
            }

        }
        else
        {
            if (timeCounter < 77)
            {
                timeCounter += Time.deltaTime * speed;
            }

        }

        float x = Mathf.Cos(timeCounter) * xaxis;
        float z = Mathf.Sin(timeCounter) * zaxis;
        float y = timeCounter * yaxis;

        transform.position = new Vector3(x - 0.22f, y + 0/*0.8633f*//*0.8471f*//*0.0001f*/, z + 0.2395f);
	}
}
