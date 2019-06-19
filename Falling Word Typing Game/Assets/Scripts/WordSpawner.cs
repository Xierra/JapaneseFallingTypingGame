using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordSpawner : MonoBehaviour {

	public GameObject wordPrefab;
	public Transform wordCanvas;

	public WordDisplay SpawnWord ()
	{
		Vector3 randomPosition = new Vector3 (Random.Range(-2.5f, 2.5f), 6f);

		GameObject wordObject = Instantiate(wordPrefab, wordCanvas);
		wordObject.transform.position = randomPosition;
		WordDisplay wordDisplay = wordObject.GetComponent<WordDisplay> ();

	//	Debug.Log (randomPosition);

		return wordDisplay;
	}
}
