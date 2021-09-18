using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Valve.VR.InteractionSystem
{
    public class combineWater : MonoBehaviour
    {
        public Collider water_PVA;

        public Collider combinedMat;

        public Hand handRight;
        public Hand handLeft;

        public GameObject beakerWater;
        public GameObject beakerCombinedMat;

        public GameObject arrow;

        public Text text;

        //public GameObject questionSet1;

        // Use this for initialization
        void Start()
        {

        }

        private void OnCollisionEnter(Collision collision)
        {
            ContactPoint contact = collision.contacts[0];
            float backTrackLength = 1f;
            Ray ray = new Ray(contact.point - (-contact.normal * backTrackLength), -contact.normal);

            if (collision.collider == water_PVA)
            {
                //collision.transform.gameObject.GetComponent<Valve.VR.InteractionSystem.Hand>().DetachObject();
                handRight.DetachObject(water_PVA.transform.gameObject);
                handLeft.DetachObject(water_PVA.transform.gameObject);
                beakerWater.SetActive(true);
                //water_.SetActive(false);
                arrow.SetActive(false);
                combineBoth.beaker1Ready = true;
                Destroy(water_PVA.transform.gameObject);
                //collision.transform.gameObject.SetActive(false);
            }
            else if (collision.collider == combinedMat)
            {
                handRight.DetachObject(combinedMat.transform.gameObject);
                handLeft.DetachObject(combinedMat.transform.gameObject);
                beakerCombinedMat.SetActive(true);
                guidanceArrow.stopArrow = true;
                guidanceRotEvap.stopArrow = true;
                text.text = "";
                Destroy(combinedMat.transform.gameObject);
            }

        }

        // Update is called once per frame
        void Update()
        {

        }
    }

}