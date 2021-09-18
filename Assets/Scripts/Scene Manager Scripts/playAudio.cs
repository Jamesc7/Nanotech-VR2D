using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using UnityEditor;

[RequireComponent(typeof(AudioSource))]
public class playAudio : MonoBehaviour {
    public AudioClip a1;
    public AudioClip a2;
    public AudioClip a3;

    public AudioClip b1;
    public AudioClip b2;
    public AudioClip b3;

    public AudioClip c1;
    public AudioClip c2;
    public AudioClip c3;
    public AudioClip c4;

    public AudioClip d1;
    public AudioClip d2;
    public AudioClip d3;

    public Texture2D texture;

    AudioSource audioSource;
    private int stopAudio = 1;

    //this bool is to stop audio from replaying when going backward in text
    //Its checked for the opposite boolean every scene to stop audio
    private bool replay = false;


    public static bool stopMethyl = false;

    //Variable for the hover text in scene 1 to enable audio
    public static bool beginScene1 = false;

    //This variable used in various scripts to lock the trigger from being pressed
    public static bool triggerLock = false;

    // Use this for initialization
    void Start() {
        audioSource = GetComponent<AudioSource>();
        
    }
	// Update is called once per frame
	void Update () {
        
        //Locking the player from moving to the next line until the audio finishes
        //Stop is used for overall enabling text but trigger lock is to enable text for certain things
        //For example if triggerlock is on then this script wont be toggling it off until its toggled on in another script
        if (audioSource.isPlaying)
        {
            DialogueTrigger.stop = true;
        }
        else if (triggerLock == false)
        {
            DialogueTrigger.stop = false;
            //Debug.Log("You can move on");
        }
        else
        {
            DialogueTrigger.stop = true;
        }


        //Scene 1
        if (DialogueTrigger.sceneCounter == 0)
        {
            if (DialogueTrigger.number == 1 && stopAudio == 1 && beginScene1 == true)
            {
                audioSource.Stop();
                stopAudio++;
                audioSource.PlayOneShot(a1, .7f);
                beginScene1 = false;
            }
            else if (DialogueTrigger.number == 2 && stopAudio == 2)  
            {
                audioSource.Stop();
                stopAudio++;
                audioSource.PlayOneShot(a2, .7f);
            }
            else if (DialogueTrigger.number == 3)
            {
                audioSource.Stop();
            }
            else if (DialogueTrigger.number == 4 && stopAudio == 3)
            {

                audioSource.Stop();
                stopAudio = 1;
                audioSource.PlayOneShot(a3, .7f);
            }
        }

        //Scene 2
        if (DialogueTrigger.sceneCounter == 1)
        {
            
            if (stopMethyl == true)
            {
                audioSource.Stop();
                stopMethyl = false;
                triggerLock = true;
            }

            if (DialogueTrigger.number == 1 && stopAudio == 1 && replay == false)
            {
                audioSource.Stop();
                stopAudio++;
                audioSource.PlayOneShot(b1, .7f);
                replay = true;
            }
            else if (DialogueTrigger.number == 2 && stopAudio == 2)
            {
                audioSource.Stop();
                stopAudio++;
                audioSource.PlayOneShot(b2, .7f);
            }

            else if (DialogueTrigger.number == 3 && stopAudio == 3)
            {
                audioSource.Stop();
                stopAudio = 1;
                audioSource.PlayOneShot(b3, .7f);
                
            }

        }

        //Scene 3
        if (DialogueTrigger.sceneCounter == 2)
        {

            if (DialogueTrigger.number == 1 && stopAudio == 1 && replay == true)
            {
                audioSource.Stop();
                stopAudio++;
                audioSource.PlayOneShot(c1, .7f);
                replay = false;
            }
            else if (DialogueTrigger.number == 2 && stopAudio == 2)
            {
                audioSource.Stop();
                stopAudio++;
                audioSource.PlayOneShot(c2, .7f);
            }
            else if (DialogueTrigger.number == 3 && stopAudio == 3)
            {
                audioSource.Stop();
                stopAudio++;
                audioSource.PlayOneShot(c3, .7f);
            }
            else if (DialogueTrigger.number == 4 && stopAudio == 4)
            {
                audioSource.Stop();
                stopAudio = 1;
                audioSource.PlayOneShot(c4, .7f);
            }
        }

        //Scene 4
        if (DialogueTrigger.sceneCounter == 3)
        {
            if (DialogueTrigger.number == 1 && stopAudio == 1 && replay == false)
            {
                audioSource.Stop();
                stopAudio++;
                audioSource.PlayOneShot(d1, .7f);
                replay = true;
                
            }
            else if (DialogueTrigger.number == 2 && stopAudio == 2)
            {
                audioSource.Stop();
                stopAudio++;
                audioSource.PlayOneShot(d2, .7f);
            }
            else if (DialogueTrigger.number == 3 && stopAudio == 3)
            {
                audioSource.Stop();
                stopAudio = 1;
                audioSource.PlayOneShot(d3, .7f);
            }
        }



        //Scene 1 to play again after last scene
        if (DialogueTrigger.sceneCounter == 4)
        {

            if (DialogueTrigger.number == 1 && stopAudio == 1 && beginScene1 == true)
            {

                audioSource.Stop();
                stopAudio++;
                audioSource.PlayOneShot(a1, .7f);
                beginScene1 = false;
                replay = false;
            }
            else if (DialogueTrigger.number == 2 && stopAudio == 2)
            {
                audioSource.Stop();
                stopAudio++;
                audioSource.PlayOneShot(a2, .7f);
            }
            else if (DialogueTrigger.number == 3)
            {
                audioSource.Stop();
            }
            else if (DialogueTrigger.number == 4 && stopAudio == 3)
            {
                audioSource.Stop();
                stopAudio = 1;
                audioSource.PlayOneShot(a3, .7f);
            }
        }
    }
}
