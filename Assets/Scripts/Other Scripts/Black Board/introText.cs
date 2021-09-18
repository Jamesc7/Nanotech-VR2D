using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class introText : MonoBehaviour {

    public Text text;
    public GameObject next;
    private string[] intro = {
        "Welcome to the Introduction to Nanotechnology Lab!",
        "In this virtual reality (VR) simulation, you will learn the process of fabricating and characterizing nanotechnology-based drug delivery carriers. You will be randomly assigned to two learning modules on polymeric nanoparticles and liposomes.",
        "Are you ready to make your own nanoparticles?"
    };

    /*  "Virtual reality (VR), an emerging technology in the education field, allows educators to deliver content in a more engaging manner to students. In particular, labs and some concepts are very difficult to understand unless you are physically present performing the experiments.",
        "In this virtual reality(VR) simulation, you will learn the process of fabricating and characterizing the two most widely used nanotechnology-based drug delivery carriers: polymeric nanoparticles and liposomes. You will be randomly assigned to two learning modules on polymeric nanoparticles and liposomes. ",
        "Throughout the simulation, questions designed to assess your learning will appear on the boards in front of you. You will follow the instructions to complete the learning module in a step-wise manner.",
        "If a question is answered correctly, you will then move to the next question or the next part of the simulation. If a question is answered incorrectly, you will be provided a hint and will not be allowed to continue until the correct answer is selected. ",
        "This simulation is designed to provide a “real-life” representation of how these nanotechnology-based drug delivery systems are produced in a lab.",
        "Upon the completion of this simulation, you will become more familiar with common lab equipment, such as probe sonicators and rotary evaporators, and understand their role in producing nanotechnology-based drug delivery systems such as polymeric nanoparticles and liposomes."
    */
    private int i = 0;

	// Use this for initialization
	void Start () {
        text.text = intro[i];
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
