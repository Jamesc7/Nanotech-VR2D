using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class guidanceDLSNano : MonoBehaviour {
    AudioSource audioSource;
    public AudioClip Lipo;
    private bool stopAudio = false;


    public GameObject grabFlask;
    public GameObject syringe;
    public GameObject arrow1;
    public GameObject arrow2;

    public GameObject text_guidance;
    public GameObject white;

    public Text text;
    public Text text2;

    // Gets changed in "openLid" script
    public static bool stop = false;

    // Use this for initialization
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (stop == false)
        {
            if (grabFlask.activeInHierarchy)
            {
                arrow1.SetActive(true);
                arrow2.SetActive(true);
                text_guidance.SetActive(true);
                white.SetActive(true);
            }
            if (syringe.activeInHierarchy)
            {
                if (stopAudio == false)
                {
                    if (!audioSource.isPlaying)
                    {
                        audioSource.Stop();
                        audioSource.PlayOneShot(Lipo, .7f);
                        stopAudio = true;
                    }
                }
                text_guidance.SetActive(true);
                white.SetActive(true);
                arrow1.SetActive(true);
                text2.text = "";
                text.text = "Let’s measure the particle size of your liposomes. Transfer liposomes to a cuvette and place the cuvette in the Zetasizer.";
            }
        }
        else
        {
            arrow1.SetActive(false);
            arrow2.SetActive(false);
            text_guidance.SetActive(false);
            white.SetActive(false);
        }
    }
}
