using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordDisplay : MonoBehaviour {

	public Text text;
	public float fallSpeed = 1f;

	public void SetWord (string word) // Displays the word. What displays is based on Word constructor.
	{
		text.text = word;
	}

	public void Highlighter () // Highlights the object when active.
	{
		text.color = Color.red;
	}

	public void RemoveWord () // Goal: Give it a green color, and fade out.
	{
		text.color = Color.green;
		StartCoroutine(FadeText(1f, text));
	}

	public IEnumerator FadeText(float t, Text i)
	{
		i.color = new Color (i.color.r, i.color.g, i.color.b, 1);
		while (i.color.a > 0.0f) 
		{
			i.color = new Color (i.color.r, i.color.g, i.color.b, i.color.a - (Time.deltaTime / t));
			yield return null;
		}
		Destroy (gameObject);
	}

	public void Update()
	{
		transform.Translate (0f, -fallSpeed * Time.deltaTime, 0f);
	}
}

