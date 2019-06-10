using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour {

	public GameObject GameOverCanvas;
	bool gameHasEnded = false;

	void Start ()
	{
		GameOverCanvas.SetActive (false);
		Time.timeScale = 1;
	}

	public void EndGame ()
	{
		if (gameHasEnded == false) {
			gameHasEnded = true;
			GameOverCanvas.SetActive (true);
			Time.timeScale = 0;
			Debug.Log ("Game Over!");
		}
	}

	public void Restart ()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}

	public void ReturnToMenu()
	{
		SceneManager.LoadScene (0);
	}
}
