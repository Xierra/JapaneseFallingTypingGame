using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Word {

	public string word;
	private int typeIndex; // Checks for current letter

	WordDisplay display;

	public Word (string _word, WordDisplay _display)  // Displays the word as Hiragana / Katakana
	{
		word = _word;

		display = _display;
		display.SetWord (word);
	}

	public char GetNextLetter ()
	{
		return word[typeIndex]; // Gets the next letter of the Romaji array
	}

	public void TypeLetter ()
	{
		typeIndex++;
	}

	public bool WordTyped ()
	{
		bool wordTyped = (typeIndex >= word.Length); // Checks if the whole word has been typed
		if (wordTyped) 
		{
			display.RemoveWord (); // Remove the whole object on screen
		}
		return wordTyped;
	}
}
