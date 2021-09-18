using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Valve.VR.InteractionSystem
{
    
    public class combineBoth : MonoBehaviour
    {
        public AudioClip NanoTransition2;
        AudioSource audioSource;
        private bool stopAudio = false;
        public GameObject stopTransition;


        Animator pouring;
        public Collider otherBeaker;
        public GameObject otherBeaker_;

        public GameObject pouringBeaker;
        public GameObject pouring_PLGA_DCM_mix;
        public GameObject pouringChloroform;

        public GameObject added_PLGA_DCM_mix;
        public GameObject addedChloroform;
        public GameObject grabBeaker;

        //public GameObject pouringMixture;
        //public GameObject addedMixture;

        public Hand handRight;
        public Hand handLeft;

        float startTime = 0;
        bool beginTime = false;
        bool beginAnim = false;

        public Collider beginEmulAnim;
        public GameObject emulAnim;

        public GameObject questionSet1Check;
        public GameObject questionSet2Check;

        public GameObject rotatingArrow;

        public static bool beaker1Ready = false;
        public static bool beaker2Ready = false;

        public Text text;

        // Use this for initialization
        void Start()
        {
            pouring = pouringBeaker.GetComponent<Animator>();
            audioSource = GetComponent<AudioSource>();
        }

        private void OnCollisionEnter(Collision collision)
        {
            ContactPoint contact = collision.contacts[0];
            float backTrackLength = 1f;
            Ray ray = new Ray(contact.point - (-contact.normal * backTrackLength), -contact.normal);

            if (collision.collider == otherBeaker && beaker1Ready && beaker2Ready)
            {
                handRight.DetachObject(collision.transform.gameObject);
                handLeft.DetachObject(collision.transform.gameObject);
                //gameObject.SetActive(false);
                //otherBeaker.SetActive(true);
                activateRotatingArrow.stop = true;
                rotatingArrow.SetActive(false);
                otherBeaker_.SetActive(false);
                Destroy(otherBeaker_);
                pouringBeaker.SetActive(true);
                if (questionSet1Check.activeInHierarchy)
                {
                    pouring_PLGA_DCM_mix.SetActive(true);
                } else
                {
                    pouringChloroform.SetActive(true);
                }
                beginAnim = true;
            } else if (collision.collider == beginEmulAnim)
            {
                emulAnim.SetActive(true);
                guidanceProbeSon.stop = true;
                Destroy(gameObject);
            }
            
        }

        // Update is called once per frame
        void Update()
        {
            
            if (beaker1Ready && beaker2Ready == true)
            {
                text.text = "Now add the PLGA solution into the PVA solution in a beaker.";
                if (!audioSource.isPlaying && !stopAudio)
                {
                    stopTransition.GetComponent<AudioSource>().Stop();
                    audioSource.PlayOneShot(NanoTransition2, .7f);
                    stopAudio = !stopAudio;
                }

            }
            if (beginAnim == true)
            {
                if (beginTime == false)
                {
                    startTime = Time.time;
                    beginTime = true;
                }
                if (Time.time - startTime > 2.0f && Time.time - startTime < 4.0f)
                {
                    pouring.SetBool("Trigger", true);
                    if (questionSet1Check.activeInHierarchy)
                    {
                        pouring_PLGA_DCM_mix.SetActive(false);
                        added_PLGA_DCM_mix.SetActive(true);
                    } else
                    {
                        pouringChloroform.SetActive(false);
                        addedChloroform.SetActive(true);
                    }
                    //pouringMixture.SetActive(false);
                    //addedMixture.SetActive(true);

                }
                else if (Time.time - startTime > 4.0f)
                {
                    pouringBeaker.SetActive(false);
                    gameObject.SetActive(false);
                    grabBeaker.SetActive(true);
                    grabBeaker.GetComponent<changeFilling>().enabled = true;
                }
                
            }
        }
    }
}