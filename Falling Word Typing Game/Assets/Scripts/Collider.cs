using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider : MonoBehaviour {

	private void OnTriggerEnter2D(Collider2D other)
	{
		GameControlScript.health -= 1;
		Debug.Log ("One of the letters / words have slipped through!");
		Destroy (gameObject);

		// WordManager.RemoveActiveWord(); Some way to set inactive so the game doesn't get stuck when failing to finish the currently typed letter / word.
	}
}
