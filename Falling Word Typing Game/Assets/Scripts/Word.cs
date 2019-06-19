using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Word {

	public string word;

	public int wordDisplaySelect;
	public string wordDisplay;
	public int romajiSelect;
	public string romaji;
	private int typeIndex; // Checks for current letter

	private int wordIndex; // Index of word used from WordGenerator

	WordDisplay display;

/*	public void WordSelect() // Selects the word and romaji from the LevelSelector.
	{
		romajiSelect = LevelSelector.getWordList_Romaji_Select ();
		wordDisplaySelect = LevelSelector.getWordList_Select ();

		switch (wordDisplaySelect) {
		case 1: 	// Hiragana
			wordDisplay = WordGenerator.wordList_Hiragana [wordIndex];
			break;
		
		case 2:		// Katakana
			wordDisplay = WordGenerator.wordList_Katakana [wordIndex];
			break;
		
		case 3:		// Kanji
			wordDisplay = WordGenerator.wordList_Kanji [wordIndex];
			break;
		}

		switch (romajiSelect) {
		case 1: 	// Romaji list from Kana
			romaji = WordGenerator.wordList_Romaji [wordIndex];
			break;

		case 2:		// Romaji list from Kanji
			romaji = WordGenerator.wordList_Romaji_Kanji [wordIndex];
			break;
		}

	}
*/
	public Word (WordDisplay _display)  // Displays the word
	{
		


		wordIndex = WordGenerator.GetIndex ();

		romajiSelect = LevelSelector.getWordList_Romaji_Select ();
		wordDisplaySelect = LevelSelector.getWordList_Select ();

		switch (wordDisplaySelect) {
		case 1: 	// Hiragana
			wordDisplay = WordGenerator.wordList_Hiragana [wordIndex];
			break;

		case 2:		// Katakana
			wordDisplay = WordGenerator.wordList_Katakana [wordIndex];
			break;

		case 3:		// Kanji
			wordDisplay = WordGenerator.wordList_Kanji [wordIndex];
			break;
		}

		switch (romajiSelect) {
		case 1: 	// Romaji list from Kana
			romaji = WordGenerator.wordList_Romaji [wordIndex];
			break;

		case 2:		// Romaji list from Kanji
			romaji = WordGenerator.wordList_Romaji_Kanji [wordIndex];
			break;
		}

		display = _display;


		display.SetWord (wordDisplay);
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
		if (wordTyped) {
			display.RemoveWord (); // Remove the whole object on screen
		} else
		{
			display.Highlighter();
		}
		return wordTyped;
	}
}
