using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.ObjectModel;

namespace Valve.VR.InteractionSystem
{
    public class combinePLGA : MonoBehaviour
    {
        public Collider PLGA_DCM;

        public Collider chloroform;

        public GameObject addChloroform;

        public GameObject combination;

        public Hand handRight;
        public Hand handLeft;

        bool added1 = false;
        bool added2 = false;

        public GameObject questionSet1Check;
        public GameObject questionSet2Check;

        public GameObject arrow;

        // Use this for initialization
        void Start()
        {
            handRight.GetComponent<Hand>();
            handLeft.GetComponent<Hand>();
        }

        private void OnCollisionEnter(Collision collision)
        {
            ContactPoint contact = collision.contacts[0];
            float backTrackLength = 1f;
            Ray ray = new Ray(contact.point - (-contact.normal * backTrackLength), -contact.normal);

            if (collision.collider == PLGA_DCM)
            {
                handRight.DetachObject(PLGA_DCM.transform.gameObject);
                handLeft.DetachObject(PLGA_DCM.transform.gameObject);
                combination.SetActive(true);
                Destroy(PLGA_DCM.transform.gameObject);
                arrow.SetActive(false);
                combineBoth.beaker2Ready = true;
            }
            /*else if (collision.collider == chloroform)
            {
                handRight.DetachObject(chloroform.transform.gameObject);
                handLeft.DetachObject(chloroform.transform.gameObject);
                Destroy(chloroform.transform.gameObject);
                addChloroform.SetActive(true);
            }*/
            

        }

        // Update is called once per frame
        void Update()
        {
            /*if (added1 == true && added2 == true)
            {
                combination.SetActive(true);
            }*/
        }
    }
}

