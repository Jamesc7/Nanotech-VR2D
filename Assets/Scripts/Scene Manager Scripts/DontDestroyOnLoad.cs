using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Valve.VR;

public class DontDestroyOnLoad : MonoBehaviour
{

    static DontDestroyOnLoad Instance;
    private SteamVR_Input_Sources Nexty = SteamVR_Input_Sources.Any;
    //Go to file -> build settings, then add open scene to add the scene you are on. Do this to all the scenes you need.
    //Then adjust the string to exactly the scene names
    private string[] Scenes = new string[] { "(1) Folate And MTX Animation", "(2) Methyl Group", "(3) Compare Closeups", "(4) Folate And MTX Demo"};
    //Variable to increment scene counter
    private int stopForward = 1;
    private int stopBackward = 0;
    public int numberScenes;

    // Use this for initialization
    void Start()
    {

        if (Instance != null)
        {
            GameObject.Destroy(gameObject);
        }
        else
        {
            GameObject.DontDestroyOnLoad(gameObject);
            Instance = this;
        }
    }

    private void Update()
    {
        //Variable from dialogue trigger to scene change
        //Counter is the scene number its on
        int counter = DialogueTrigger.sceneCounter;
        
        //Scene forward is to allow scenes to go to next scene and stopForward is used to stop the scene from continously triggering
        //Backwards incremented b/c the forward is incremented
        //Basically the opposite for the backwards part
        if (counter == stopForward && DialogueTrigger.sceneForward == true)
        {
            if (counter == numberScenes)
                counter = 0;
            SceneManager.LoadScene(Scenes[counter], LoadSceneMode.Single);
            if (stopForward == numberScenes)
                stopForward = 0;
            if (stopBackward == numberScenes - 1)
                stopBackward= -1;
            stopForward++;
            stopBackward++;
        }

        else if (counter == stopBackward -1 && DialogueTrigger.sceneForward == false)
        {

            if (counter == -1)
                counter = 4;
            SceneManager.LoadScene(Scenes[counter], LoadSceneMode.Single);
            if (stopBackward == -1)
                stopBackward = 0;
            if (stopForward == 1)   
                stopForward = 2;
            stopBackward--;
            stopForward--;
        }
    }
}
