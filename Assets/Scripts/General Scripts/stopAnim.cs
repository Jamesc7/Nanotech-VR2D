using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopAnim : MonoBehaviour {

    public Animator animator;

	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
	}

	
	// Update is called once per frame
	void Update () {
        /*if (DialogueTrigger.number == DialogueTrigger.sentences.Length)
        {
            animator.SetBool("right", false);
        }
        else if (DialogueTrigger.stop == true)
        {
            animator.SetBool("right", false);
        }
        else
        {
            animator.SetBool("right", true);
        }*/

	}
}
