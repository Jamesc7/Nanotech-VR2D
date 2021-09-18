using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class extractionAnim : MonoBehaviour {
    AudioSource audioSource;
    public AudioClip Lipo;

    float startTime = 0;
    bool setTime = false;

    public GameObject solution;

    public GameObject flask;
    Animator removeFlask;

    public GameObject syringe;
    Animator insertSyringe;

    public GameObject realSyringe;
    public GameObject realPlunger;

    public GameObject grabFlask;

    public GameObject extrude_arrow1;
    public GameObject extrude_arrow2;

    public GameObject extrude_flask_placement;

    public Text text;

	// Use this for initialization
	void Start () {
        removeFlask = flask.GetComponent<Animator>();
        insertSyringe = syringe.GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        if (setTime == false)
        {
            startTime = Time.time;
            setTime = true;
            extrude_arrow1.SetActive(false);
            extrude_flask_placement.SetActive(false);
        }
        if (Time.time - startTime > 1.0f)
        {
            solution.SetActive(false);
        }
        if (Time.time - startTime > 2.0f)
        {
            removeFlask.SetBool("Trigger", true);
        }
        if (Time.time - startTime > 3.0f && Time.time - startTime < 4.0f)
        {
            insertSyringe.SetBool("Trigger", true);
        }
        if (Time.time - startTime > 7.0f && Time.time - startTime < 8.0f)
        {
            if (!audioSource.isPlaying)
            {
                audioSource.Stop();
                audioSource.PlayOneShot(Lipo, .7f);
            }
            syringe.SetActive(false);
            realSyringe.SetActive(true);
            realPlunger.SetActive(true);
            extrude_arrow2.SetActive(true);
            text.text = "Using the 2 syringes, extrude back and forth 4 times (although traditionally at least 10 times is required to reduce the size of the liposomes).";
        }
    }
}
