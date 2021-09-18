using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class guidanceRotEvap : MonoBehaviour {
    public GameObject stopLipoAudio;
    public GameObject stopNanoAudioOnRotEvapText3;

    public GameObject grabBeaker;
    public GameObject grabBeaker2;

    public static bool stopArrow = false;

    public GameObject combinedMaterial;

    public GameObject arrow1;
    public GameObject arrow2;
    public GameObject arrow3;

    public GameObject beakerPlacement;

    public GameObject questionSet1;

    public Text text;

    // Gets changed in "collideRotFlask" script
    public static bool stop = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (stop == false)
        {
            if (grabBeaker.activeInHierarchy && questionSet1.activeInHierarchy)
            {
                text.text = "Once the emulsion is formed, a solvent evaporation step is needed to remove toxic organic solvent to solidify nanoparticles. To accomplish this, transfer the emulsion from the beaker to round bottom flask.";
                arrow1.SetActive(true);
                //arrow2.SetActive(true);
                beakerPlacement.SetActive(true);
                //arrow3.SetActive(false);
                /*if (questionSet1.activeInHierarchy)
                {
                    arrow2.SetActive(true);
                } else
                {
                    arrow3.SetActive(true);
                }*/

            } else if (questionSet1.activeInHierarchy == false)
            {
                if (grabBeaker2.activeInHierarchy == true && stopArrow == true)
                {
                    //text.text = "Once the emulsion is formed, a solvent evaporation step is needed to remove toxic organic solvent to solidify nanoparticles. To accomplish this, transfer the emulsion from the beaker to round bottom flask.";
                    arrow1.SetActive(true);
                    stopLipoAudio.GetComponent<AudioSource>().Stop();
                    stopNanoAudioOnRotEvapText3.GetComponent<AudioSource>().Stop();
                    arrow3.SetActive(true);
                    beakerPlacement.SetActive(true);
                }
                
            }

        }
        else
        {
            arrow1.SetActive(false);
            arrow2.SetActive(false);
            arrow3.SetActive(false);
            beakerPlacement.SetActive(false);
        }
    }
}
