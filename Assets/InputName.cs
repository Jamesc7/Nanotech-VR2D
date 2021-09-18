using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Valve.VR.InteractionSystem;

public class InputName : MonoBehaviour {

    public static string nameOfPlayer;
    public string saveName;

    public static string studentID;
    public string saveID;
    private int numberID;

    private bool setName = false;

    public InputField resetInputText;

    public Text inputText;
    public Text buttonText;
    public Text instructions;
    public GameObject intro;
    public GameObject info;
    public GameObject ID;
    public GameObject PlayerName;

    AudioSource audioSource;
    public AudioClip username;
    public AudioClip fullname;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        //audioSource.Stop();
        audioSource.PlayOneShot(username); //play audio
    }

    public void SetName()
    {
        if (!setName)
        {
            if (inputText.text.Length > 12)
            {
                buttonText.text = "Please enter a valid name..";
            }
            else
            {
                saveName = inputText.text;
                PlayerPrefs.SetString("name", saveName);
                nameOfPlayer = PlayerPrefs.GetString("name", "none");
                instructions.text = "Your full name will be required to receive a grade.\nClick on the text box to enter your full name.\nAfter submitting your name, press the Alt key to exit mouse mode.";
                buttonText.text = "Click here when done";
                resetInputText.text = "";
                setName = true;
                //Debug.Log(nameOfPlayer);
                PlayerName.name = nameOfPlayer;
                audioSource.Stop();
                audioSource.PlayOneShot(fullname); //play audio
            }
            
        }
        else
        {
            if (inputText.text.Length < 3)
            {
                buttonText.text = "Please try again..";
            }
            else
            {
                audioSource.Stop();
                saveID = inputText.text;
                PlayerPrefs.SetString("ID", saveID);
                studentID = PlayerPrefs.GetString("ID", "none");
                //Debug.Log(studentID);
                ID.name = studentID;
                intro.SetActive(true);
                info.SetActive(false);
            }
        }
    }


}
