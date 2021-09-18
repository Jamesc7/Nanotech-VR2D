using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Valve.VR.InteractionSystem
{
    public class collideRotFlask : MonoBehaviour
    {
        public AudioClip NanoTransition5;
        public AudioClip Lipo;
        AudioSource audioSource;
        public GameObject start2;
        public GameObject stopWarning;
        //public GameObject stopLipoTransition2;


        public Collider rotFlask;
        public GameObject beakerAnim;

        public GameObject flask;

        public Hand handRight;
        public Hand handLeft;

        public Text text;
        public Text text2;

        public GameObject questionSet1;


        // Use this for initialization
        void Start()
        {
            audioSource = GetComponent<AudioSource>();
            handRight.GetComponent<Hand>();
            handLeft.GetComponent<Hand>();
        }

        // Update is called once per frame
        void Update()
        {
            
        }

        private void OnCollisionEnter(Collision collision)
        {
            ContactPoint contact = collision.contacts[0];
            float backTrackLength = 1f;
            Ray ray = new Ray(contact.point - (-contact.normal * backTrackLength), -contact.normal);
            if (collision.collider == rotFlask)
            {
                //hand.DetachObject(collision.transform.gameObject);
                handRight.DetachObject(collision.transform.gameObject);
                handLeft.DetachObject(collision.transform.gameObject);
                beakerAnim.SetActive(true);
                flask.GetComponent<pouringSubstance>().enabled = true;
                guidanceRotEvap.stop = true;
                if (questionSet1.activeInHierarchy)
                {
                    text.text = "After that, the round bottom flask is then attached to the rotary evaporator to initiate the evaporation process. After organic solvent removal, nanoparticles are formed.";
                    text2.text = "";
                    if (!audioSource.isPlaying)
                    {
                        //stopWarning.GetComponent<AudioSource>().Stop();
                        stopWarning.SetActive(false);
                        //start2.transform.localPosition = new Vector3(start2.transform.localPosition.x, .15f, start2.transform.localPosition.z);
                        audioSource.PlayOneShot(NanoTransition5, .7f);
                    }
                } else
                {
                    text.text = "Please observe the animation. The round bottom flask is then attached to the rotary evaporator to remove organic solvent. When removing the solvent, a thin film will form on the round bottom flask. Continue and answer the following question.";
                    text2.text = "";
                    if (!audioSource.isPlaying)
                    {
                        //stopWarning.GetComponent<AudioSource>().Stop();
                        stopWarning.SetActive(false);
                        //start2.transform.localPosition = new Vector3(start2.transform.localPosition.x, .15f, start2.transform.localPosition.z);
                        audioSource.PlayOneShot(Lipo, .7f);
                    }
                }
                
                
                /*if (questionSet1.activeInHierarchy)
                {
                    this.gameObject.transform.localPosition = new Vector3(-3, -10, 12);
                } else
                {
                    Destroy(gameObject);
                }*/
                this.gameObject.transform.localPosition = new Vector3(-3, -10, 12);
                //Destroy(gameObject);
            }
        }
    }
}

