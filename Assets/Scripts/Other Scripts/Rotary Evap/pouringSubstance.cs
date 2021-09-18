using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pouringSubstance : MonoBehaviour {

    bool beginAnim = false;
    float startTime = 0;

    public GameObject pouredSubstanceNano;
    public GameObject pouredSubstanceLip;
    public GameObject questionSet1Check;
    public GameObject removeWater;
    public GameObject removeParticles;
    public GameObject beaker;
    public GameObject rotatedFlask;

    public GameObject collisionBeaker;

    Animator moveRotFlask;
    Animator moveBeakerUp;


    // Use this for initialization
    void Start()
    {
        moveRotFlask = gameObject.GetComponent<Animator>();
        moveBeakerUp = beaker.transform.parent.gameObject.GetComponent<Animator>();
    }

    /*private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider == collisionBeaker)
        {
            triggerAnim = true;
            
        }
    }*/

    // Update is called once per frame
    void Update()
    {

        if (beginAnim == false)
        {
            startTime = Time.time;
            beginAnim = true;
        }
        if (Time.time - startTime > 2.0f)
        {
            if (questionSet1Check.activeInHierarchy)
            {
                pouredSubstanceNano.SetActive(true);
            } else
            {
                pouredSubstanceLip.SetActive(true);
            }
            
            removeWater.SetActive(false);
            removeParticles.SetActive(false);
        }
        if (Time.time - startTime > 3.0f)
        {
            moveBeakerUp.SetBool("Trigger", true);
            
        }
        if (Time.time - startTime > 4.0f)
        {
            moveRotFlask.SetBool("Trigger", true);

        }
        if (Time.time - startTime > 6.0f)
        {
            rotatedFlask.SetActive(true);
            beaker.SetActive(false);
            gameObject.SetActive(false);
        }
        
    }
}
