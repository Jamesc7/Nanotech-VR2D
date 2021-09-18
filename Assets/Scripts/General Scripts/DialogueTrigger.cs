using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Valve.VR;
[RequireComponent(typeof(SteamVR_TrackedObject))]


public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    //private DisplayText displayText = new DisplayText();
    public static string[] sentences;
    public static int sentencenumber;
    public static int number = 1;
    private SteamVR_Action_Boolean grabGrip;
    private SteamVR_Action_Boolean touchPad;
    //Either hand for input
    private SteamVR_Input_Sources Lefty = SteamVR_Input_Sources.LeftHand;
    private SteamVR_Input_Sources Righty = SteamVR_Input_Sources.RightHand;
    private SteamVR_Input_Sources Any = SteamVR_Input_Sources.Any;
    public static int sceneReset = 4;
    public static int sceneCounter = 0;
    public static bool stop;
    public static bool sceneForward = true;
    //Used in hand script
    public static bool hoverStart = false;

    public static bool image = false;

    //GameObject audio = FindObjectOfType<GameObject>();

    public Object yes;
    public Object no;

    public void Start()
    {
        stop = false;
        sentences = new string[dialogue.sentences.Length];
        for (int i = 0; i < dialogue.sentences.Length; i++)
        {
            sentences[i] = dialogue.sentences[i];
        }

        sentencenumber = dialogue.sentences.Length;
        FindObjectOfType<DisplayText>().Display(sentences[0]);
    }

    void Update()
    {
        //if (yes)
        //Debug.Log(stop);
        //Remove && hoverStart == true for fast debugging
        //hoverStart boolean is true whenever the player hovers over the "hover to begin" text at the start of the game
        /*if (SteamVR_Input.__actions_default_in_GrabGrip.GetStateDown(Righty) && number < dialogue.sentences.Length && stop == false && hoverStart == true)
        {
            FindObjectOfType<DisplayText>().Display(sentences[number]);
            number++;

        }

        if (SteamVR_Input.__actions_default_in_GrabGrip.GetStateDown(Lefty) && number > 1 && stop == false) 
        {
            number--;
            FindObjectOfType<DisplayText>().Display(sentences[number - 1]);
        }

        if (SteamVR_Input.__actions_default_in_touchpad.GetStateDown(Any) && number == dialogue.sentences.Length)
        {
            sceneForward = true;
            if (sceneCounter == sceneReset)
                sceneCounter = 0;
            sceneCounter++;
            number = 1;
        }
        */
    }
}