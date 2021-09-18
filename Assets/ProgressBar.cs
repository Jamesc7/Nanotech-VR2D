using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour {

	public GameObject prog1;
	public GameObject prog2;
	public GameObject prog3;
	public GameObject prog4;
	public GameObject prog5;
	public GameObject prog6;
	public GameObject prog7;
	public GameObject prog8;
	public GameObject prog9;
	public GameObject prog10;

	public Image Fill;

	private Slider slider;
	public float fillSpeed = 0.5f;
	private float targetProgress = 0;
	private bool change = true;

	

	private void Awake() {
		slider = gameObject.GetComponent<Slider>();
	}
	// Use this for initialization
	void Start () {
		targetProgress = 0.0f;

	}
	
	// Update is called once per frame
	void Update () {
		if(slider.value < targetProgress){
            //slider.value += fillSpeed * Time.deltaTime;
            slider.value = targetProgress;
		}
		if (change == true);
		{
			
			if(prog10.activeSelf){
				Fill.color = Color.green;
				targetProgress = 100.0f;
				change = false;
				prog10.SetActive(false);
			}
			if(prog9.activeSelf){
				targetProgress = 90.0f;
				prog9.SetActive(false);
			}
			if(prog8.activeSelf){
				targetProgress = 80.0f;
				prog8.SetActive(false);
			}
			if(prog7.activeSelf){
				targetProgress = 70.0f;
				prog7.SetActive(false);
			}
			if(prog6.activeSelf){
				targetProgress = 60.0f;
				prog6.SetActive(false);
			}
			if(prog5.activeSelf){
				targetProgress = 50.0f;
				prog5.SetActive(false);
			}
			if (prog4.activeSelf){
				targetProgress = 40.0f;
				prog4.SetActive(false);
			}
			if (prog3.activeSelf){
				targetProgress = 30.0f;
				prog3.SetActive(false);
			}
			if (prog2.activeSelf){
				targetProgress = 20.0f;
				prog2.SetActive(false);
			}
			if (prog1.activeSelf){
				targetProgress = 10.0f;
				prog1.SetActive(false);
			}
		}
	}

	public void IncrementProgress(float newProgress) {
		targetProgress = slider.value + newProgress;
	}

	public void finish(){
		slider.GetComponent<Renderer>().material.color = Color.green;
		targetProgress = 100.0f;
		change = false;
	}
}
