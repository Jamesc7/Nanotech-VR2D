using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Valve.VR.InteractionSystem
{
    public class openLid : MonoBehaviour
    {
        public AudioClip Lipo;
        public AudioClip NanoTransition7;
        AudioSource audioSource;
        public GameObject stopNanoT6;
        public GameObject stopLipo;
        public GameObject start3;

        public Collider rotFlask;
        public GameObject grabFlask;

        public GameObject flaskAnim;
        Animator pour;

        public Collider syringe;
        public GameObject grabSyringe;

        public GameObject plungerAnim;
        public GameObject syringeAnim;
        Animator inject;

        public GameObject lid;
        Animator moveLid;

        public GameObject solution;
        public GameObject solution2;

        public Hand handRight;
        public Hand handLeft;

        float startTime = 0;
        bool beginTime = false;

        int module;

        public Text text;
        public Text text2;
        // Use this for initialization
        void Start()
        {
            //hand.GetComponent<Hand>();
            pour = flaskAnim.GetComponent<Animator>();
            inject = plungerAnim.GetComponent<Animator>();
            moveLid = lid.GetComponent<Animator>();
            audioSource = GetComponent<AudioSource>();
        }

        private void OnCollisionEnter(Collision collision)
        {
            ContactPoint contact = collision.contacts[0];
            float backTrackLength = 1f;
            Ray ray = new Ray(contact.point - (-contact.normal * backTrackLength), -contact.normal);

            if (collision.collider == rotFlask)
            {
                module = 1;
                handRight.DetachObject(rotFlask.transform.gameObject);
                handLeft.DetachObject(rotFlask.transform.gameObject);
                flaskAnim.SetActive(true);
                if (beginTime == false)
                {
                    startTime = Time.time;
                    beginTime = true;
                    moveLid.SetBool("Trigger", true);
                    text2.text = "";
                    //text.text = "Based on light scattering principles, Brownian motions of nanoparticles are recorded and converted into particle size and size distribution result using a special algorithm. Monodispersed nanoparticles are desirable for good product performance and safety.";
                    /*if (!audioSource.isPlaying)
                    {
                        stopNanoT6.GetComponent<AudioSource>().Stop();
                        audioSource.PlayOneShot(NanoTransition7, .7f);
                        start3.transform.localPosition = new Vector3(start3.transform.localPosition.x, .135f, start3.transform.localPosition.z);
                    }*/
                }

                guidanceDLSNano.stop = true;
                //flask.GetComponent<pouringSubstance>().enabled = true;
                //grabFlask.SetActive(false);
                Destroy(grabFlask);
            }
            if (collision.collider == syringe)
            {
                module = 2;
                handRight.DetachObject(rotFlask.transform.gameObject);
                handLeft.DetachObject(rotFlask.transform.gameObject);
                syringeAnim.SetActive(true);
                if (beginTime == false)
                {
                    startTime = Time.time;
                    beginTime = true;
                    moveLid.SetBool("Trigger", true);
                }
                //grabSyringe.SetActive(false);
                guidanceDLSNano.stop = true;
                text2.text = "";
                //text.text = "Based on light scattering principles, Brownian motions of liposomes are recorded and converted into particle size and size distribution results using a special algorithm. Monodispersed liposomes are desirable for good product performance and safety.";
                /*if (!audioSource.isPlaying)
                {
                    stopLipo.GetComponent<AudioSource>().Stop();
                    audioSource.PlayOneShot(Lipo, .7f);
                    start3.transform.localPosition = new Vector3(start3.transform.localPosition.x, .135f, start3.transform.localPosition.z);
                }*/
                Destroy(grabSyringe);
            }
        }

        // Update is called once per frame
        void Update()
        {
            if (beginTime == true)
            {
                if (Time.time - startTime > 1.0f && Time.time - startTime < 2.5f)
                {
                    if (module == 1)
                    {
                        pour.SetBool("Trigger", true);
                    } else
                    {
                        inject.SetBool("Trigger", true);
                    }
                    
                }
                if (Time.time - startTime > 2.5f)
                {
                    moveLid.SetBool("Trigger2", true);
                }
                if (Time.time - startTime > 3.0f)
                {
                    if (module == 1)
                    {
                        solution.SetActive(true);
                    } else
                    {
                        solution2.SetActive(true);
                    }
                    
                }
                if (Time.time - startTime > 3.5f)
                {
                    InsertSampleVer2.trigger = true;
                }
                if (Time.time - startTime > 4.5f)
                {
                    flaskAnim.SetActive(false);
                    syringeAnim.SetActive(false);
                }
                if (Time.time - startTime > 12f && Time.time - startTime < 12.5f)
                {
                    if (module == 1)
                    {
                        text.text = "Based on light scattering principles, Brownian motions of nanoparticles are recorded and converted into particle size and size distribution result using a special algorithm. Monodispersed nanoparticles are desirable for good product performance and safety.";
                        if (!audioSource.isPlaying)
                        {
                            stopNanoT6.GetComponent<AudioSource>().Stop();
                            audioSource.PlayOneShot(NanoTransition7, .7f);
                            start3.transform.localPosition = new Vector3(start3.transform.localPosition.x, .135f, start3.transform.localPosition.z);
                        }
                        /*text.text = "Based on light scattering principles, Brownian motions of nanoparticles are recorded and converted into particle size and size distribution result using a special algorithm. Monodispersed nanoparticles are desirable for good product performance and safety.";
                        stopNanoT6.GetComponent<AudioSource>().Stop();
                        audioSource.PlayOneShot(NanoTransition7, .7f);*/
                    }
                    if (module == 2)
                    {
                        text.text = "Based on light scattering principles, Brownian motions of liposomes are recorded and converted into particle size and size distribution results using a special algorithm. Monodispersed liposomes are desirable for good product performance and safety.";
                        if (!audioSource.isPlaying)
                        {
                            stopLipo.GetComponent<AudioSource>().Stop();
                            audioSource.PlayOneShot(Lipo, .7f);
                            start3.transform.localPosition = new Vector3(start3.transform.localPosition.x, .135f, start3.transform.localPosition.z);
                        }
                    }
                }
            }
        }
    }

}

