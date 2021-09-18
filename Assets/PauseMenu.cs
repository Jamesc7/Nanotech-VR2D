using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PauseMenu : MonoBehaviour {

	public static bool GameIsPaused = false;
	public GameObject pauseMenuUI;
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("p"))
		{
			print("Ah");
			if(GameIsPaused)
			{
				Resume();
			}
			else
			{
				Pause();
			}
		}
	}
	public void Resume(){
		Cursor.lockState = CursorLockMode.Locked;
		pauseMenuUI.SetActive(false);
		Time.timeScale = 1f;
		GameIsPaused = false;
	}

	void Pause(){
		Cursor.lockState = CursorLockMode.None;
		pauseMenuUI.SetActive(true);
		Time.timeScale = 0f;
		GameIsPaused = true;
	}
	public void QuitGame(){
		print("Quiting Game");
		Application.Quit();
	}
}