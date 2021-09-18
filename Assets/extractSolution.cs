using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Valve.VR.InteractionSystem
{
    public class extractSolution : MonoBehaviour
    {

        public Hand handRight;
        public Hand handLeft;
        public Collider syringeNeedle;
        public GameObject plunger;
        public GameObject flask;
        public GameObject solution;
        Animator extract;
        Animator removeFlask;

        float setTime = 0;
        bool beginTime = false;

        // Use this for initialization
        void Start()
        {
            extract = plunger.GetComponent<Animator>();
            removeFlask = flask.GetComponent<Animator>();
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.collider == syringeNeedle)
            {
                handRight.DetachObject(collision.transform.gameObject);
                handLeft.DetachObject(collision.transform.gameObject);
                
                //gameObject.SetActive(false);
                flask.SetActive(true);
                extract.SetBool("Trigger", true);
                /*if (beginTime == false)
                {
                    setTime = Time.time;
                    beginTime = true;
                }*/
                Destroy(gameObject);

            }
        }

        // Update is called once per frame
        void Update()
        {
            /*if (beginTime == true)
            {
                if (Time.time - setTime > 1.1f)
                {
                    solution.SetActive(false);
                    Debug.Log("yes");
                }
                if (Time.time - setTime > 2.0f)
                {
                    removeFlask.SetBool("Trigger", true);
                }
            }*/
            
        }
    }
}

