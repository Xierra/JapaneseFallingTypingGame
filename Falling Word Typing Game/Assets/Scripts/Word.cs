using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Word {

	public string romaji;
	public string hiragana;
	private int typeIndex; // Checks for current letter

	private int wordIndex; // Index of word used from WordGenerator

	WordDisplay display;

	public Word (WordDisplay _display)  // Displays the word as Hiragana / Katakana
	{
		wordIndex = WordGenerator.GetIndex ();
		romaji = WordGenerator.wordList_Romaji[wordIndex];

		hiragana = WordGenerator.wordList_Hiragana[wordIndex];

		display = _display;
		display.SetWord (hiragana);
	}

	public char GetNextLetter ()
	{
		return romaji[typeIndex]; // Gets the next letter of the Romaji array
	}

	public void TypeLetter ()
	{
		typeIndex++;
	}

	public bool WordTyped ()
	{
		bool wordTyped = (typeIndex >= romaji.Length); // Checks if the whole word has been typed
		if (wordTyped) 
		{
			display.RemoveWord (); // Remove the whole object on screen
		}
		return wordTyped;
	}
}
