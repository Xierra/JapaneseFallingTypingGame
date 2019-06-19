using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordManager : MonoBehaviour {

	public List<Word> words;

	public WordSpawner wordSpawner;

	private bool hasActiveWord;
	private Word activeWord;



	public void AddWord ()
	{
		Word word = new Word (wordSpawner.SpawnWord());

		words.Add (word);
	}

	public void TypeLetter (char letter)
	{
		if (hasActiveWord == true) 
		{
			if (activeWord.GetNextLetter () == letter) 
			{
				activeWord.TypeLetter ();
			}
		} else
		{
			foreach(Word word in words)
				{
					if (word.GetNextLetter() == letter)
					{
						activeWord = word;
						hasActiveWord = true;
						word.TypeLetter();
						break;
					}
				}
		}

		if (hasActiveWord && activeWord.WordTyped())
		{
			hasActiveWord = false;			// Set as non-active
			words.Remove(activeWord);		// Remove the object
		}

		/*
		else if (activeWord.TypeLetter() == null) {			// Attempt to detect if typeletter is still active
			hasActiveWord = false;
			words.Remove (activeWord);
		}
		*/
	}
}
