using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayText : MonoBehaviour {

    //Text display;
    Text instruction;

    void Start()
    {
        instruction = GetComponent<Text>();
    }

    public void Display (string Text) {
            instruction.text = Text;
    }

}
