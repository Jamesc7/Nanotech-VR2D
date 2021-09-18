using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guidanceProbeSon : MonoBehaviour {
    public AudioClip NanoTransition3;
    public GameObject stopWarning;
    AudioSource audioSource;
    private bool stopAudio = false;


    public GameObject grabBeaker;
    public GameObject arrow;
    public GameObject placeIndicator;

    // Gets changed in "combineBoth" script
    public static bool stop = false;

	// Use this for initialization
	void Start () {
        audioSource = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        if (stop == false)
        {
            if (grabBeaker.activeInHierarchy)
            {
                arrow.SetActive(true);
                placeIndicator.SetActive(true);
                if (!audioSource.isPlaying && !stopAudio)
                {
                    //stopWarning.GetComponent<AudioSource>().Stop();
                    stopWarning.SetActive(false);
                    audioSource.PlayOneShot(NanoTransition3, .7f);
                    stopAudio = !stopAudio;
                }

            }
            
        }
        else
        {
            arrow.SetActive(false);
            placeIndicator.SetActive(false);
        }
    }
}
