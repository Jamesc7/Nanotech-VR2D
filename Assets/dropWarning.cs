using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropWarning : MonoBehaviour {
    //Pausing and resuming audio
    public GameObject nowtransferyour;
    public GameObject nowaddtheplga;
    public GameObject bringthebeaker;
    public GameObject oncetheemulsion;
    AudioSource audioSource;

    public GameObject warning;
    public GameObject beaker1;
    public GameObject beaker2;
    public GameObject beaker3;

    bool beginTime = false;
    float startTime;

    bool removeWarning = false;

	// Use this for initialization
	void Start () {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("beaker1") || other.gameObject.CompareTag("beaker2") || other.gameObject.CompareTag("beaker3"))
        {
            warning.SetActive(true);
            beginTime = true;
            if (other.gameObject.CompareTag("beaker1"))
            {
                // local position gives position in real world, not relative to parent
                beaker1.transform.localPosition = new Vector3(-0.206f, 0.8469f, -1.04f);
            }
            if (other.gameObject.CompareTag("beaker2"))
            {
                beaker2.transform.localPosition = new Vector3(0.095f, 0.8469f, -1.036f);
            }
            if (other.gameObject.CompareTag("beaker3"))
            {
                beaker3.transform.localPosition = new Vector3(-1.171303f, 0.8800706f, -1.086815f);
            }
        }
    }

    // Update is called once per frame
    void Update () {
		if (beginTime == true)
        {
            nowtransferyour.GetComponent<AudioSource>().Pause();
            nowaddtheplga.GetComponent<AudioSource>().Pause();
            bringthebeaker.GetComponent<AudioSource>().Pause();
            oncetheemulsion.GetComponent<AudioSource>().Pause();
            startTime = Time.time;
            beginTime = false;
            removeWarning = true;
        }
        if (removeWarning == true)
        {
            if (Time.time - startTime > 9)
            {
                warning.SetActive(false);
                removeWarning = false;
                nowtransferyour.GetComponent<AudioSource>().UnPause();
                nowaddtheplga.GetComponent<AudioSource>().UnPause();
                bringthebeaker.GetComponent<AudioSource>().UnPause();
                oncetheemulsion.GetComponent<AudioSource>().UnPause();
            }
        }
	}
}
