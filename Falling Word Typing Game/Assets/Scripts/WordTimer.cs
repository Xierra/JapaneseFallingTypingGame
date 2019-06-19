using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordTimer : MonoBehaviour {

	public WordManager wordManager;

	public float wordDelay = 1f;
	public float delayMultiplier = LevelSelector.getSpawnFrequency();
	public float nextWordTime = 0f;

	private void Update()
	{
		if (Time.time >= nextWordTime) {
			Debug.Log (nextWordTime);
			wordManager.AddWord ();
			nextWordTime = Time.time + wordDelay * delayMultiplier;
		//	wordDelay *= .99f;
		}
	}

}
