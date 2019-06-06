using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordDisplay : MonoBehaviour {

	public Text text;
	public float fallSpeed = 1f;

	public void SetWord (string word)
	{
		text.text = word;
	}

	public void Highlighter ()
	{
		text.color = Color.red;
	}

	public void RemoveWord ()
	{
		Destroy (gameObject);
	}

	public void Update()
	{
		transform.Translate (0f, -fallSpeed * Time.deltaTime, 0f);
	}
}
