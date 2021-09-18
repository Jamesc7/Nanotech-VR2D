using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Valve.VR.InteractionSystem
{
    public class hydrationStepController : MonoBehaviour
    {

        bool moveNextButton;
        float startTimer;
        public GameObject next2;

        public Collider flask;
        Animator inject;
        public GameObject plunger;
        public GameObject hydrationFlask;
        public GameObject substance;

        public GameObject flaskPlacement;

        public Hand handRight;
        public Hand handLeft;

        //public GameObject next2;
        Vector3 temp2 = new Vector3(7.0f, 14.0f, 0);

        // Use this for initialization
        void Start()
        {
            inject = plunger.GetComponent<Animator>();
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.collider == flask)
            {
                handRight.DetachObject(collision.transform.gameObject);
                handLeft.DetachObject(collision.transform.gameObject);
                Destroy(collision.transform.gameObject);
                //next2.transform.position += temp2;
                hydrationFlask.SetActive(true);
                inject.SetBool("Trigger", true);
                substance.SetActive(true);
                flaskPlacement.SetActive(false);
                RemovePipette.trigger = true;
                HydrationStepShake.trigger = true;
                HydrationColor.trigger = true;
                moveNextButton = true;
                startTimer = Time.time;
            }
        }

        // Update is called once per frame
        void Update()
        {
            if (moveNextButton)
            {
                if (Time.time - startTimer > 3.5)
                {
                    next2.transform.position += temp2;
                    moveNextButton = false;
                }
            }
        }
    }

}
