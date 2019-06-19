using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSelector : MonoBehaviour {

	public int levelIndex;
	public static int wordList_Select;				// Selects a Writing Style (1 Hiragana, 2 Katakana, 3 Kanji)
	public static int wordList_Romaji_Select; 		// Selects Romaji Table (1 Hiragana & Katakana, 2 Kanji)
	public static int wordList_Length_Start; 		// Start point of Array in WordGenerator
	public static int wordList_Length_End;			// End point of Array in WordGenerator
	public static int spawnFrequency;

	WordDisplay display;


		
	public static int getWordList_Select() // Selects the word list to be relayed to Word constructor.
	{
		return wordList_Select;
	}

	public static int getWordList_Romaji_Select() // Selects the word list to be relayed to Word constructor.
	{
		return wordList_Romaji_Select;
	}

	public static int getWordList_Length_Start()
	{
		return wordList_Length_Start;
	}

	public static int getWordList_Length_End()
	{
		return wordList_Length_End;
	}

	public static int getSpawnFrequency()
	{
		return spawnFrequency;
	}

	void LevelSelect() // This is the value for each level. It reads based on the user input by pressing an assigned button containing levelIndexSelect of a certain number.
	{
		switch (levelIndex) 
		{

		// Category 1: Hiragana Levels
		case 1: // Syllables 1
			wordList_Select = 1;  			// (1 for Hiragana, 2 for Katakana, 3 for Kanji)
			wordList_Romaji_Select = 1; 	// (1 for Hiragana & Katakana, 2 for Kanji)
			wordList_Length_Start = 0; 		// From あ  
			wordList_Length_End = 24; 		// To の
			spawnFrequency = 1;
			break;
		
		case 2: // Syllables 2
			wordList_Select = 1;
			wordList_Romaji_Select = 1;
			wordList_Length_Start = 25;		// From は  
			wordList_Length_End = 45; 		// To ん
			spawnFrequency = 1;
			break;

		case 3: // Basic Syllables
			wordList_Select = 1;
			wordList_Romaji_Select = 1;
			wordList_Length_Start = 0; 		// From あ 
			wordList_Length_End = 45; 		// To ん
			spawnFrequency = 1;
			break;

		case 4: // Dakuten
			wordList_Select = 1;
			wordList_Romaji_Select = 1;
			wordList_Length_Start = 46;		// From が 
			wordList_Length_End = 70; 		// To ぽ
			spawnFrequency = 1;
			break;

		case 5: // Additionals
			wordList_Select = 1;
			wordList_Romaji_Select = 1;
			wordList_Length_Start = 71; 	// From きゃ
			wordList_Length_End = 106; 		// To しょ
			spawnFrequency = 1;
			break;

		case 6: // All Syllables
			wordList_Select = 1;
			wordList_Romaji_Select = 1;
			wordList_Length_Start = 0;
			wordList_Length_End = 106; 
			spawnFrequency = 1;
			break;


		// Category 2: Katakana Levels
		case 7: // Syllables 1
			wordList_Select = 2;
			wordList_Romaji_Select = 1;
			wordList_Length_Start = 0;   
			wordList_Length_End = 24; 
			spawnFrequency = 1;
			break;

		case 8: // Syllables 2
			wordList_Select = 2;
			wordList_Romaji_Select = 1;
			wordList_Length_Start = 25;   
			wordList_Length_End = 45; 
			spawnFrequency = 1;
			break;

		case 9: // Basic Syllables
			wordList_Select = 2;
			wordList_Romaji_Select = 1;
			wordList_Length_Start = 0; 
			wordList_Length_End = 45; 
			spawnFrequency = 1;
			break;

		case 10: // Dakuten
			wordList_Select = 2;
			wordList_Romaji_Select = 1;
			wordList_Length_Start = 46; 
			wordList_Length_End = 70; 
			spawnFrequency = 1;
			break;

		case 11: // Additionals
			wordList_Select = 2;
			wordList_Romaji_Select = 1;
			wordList_Length_Start = 71; 
			wordList_Length_End = 106; 
			spawnFrequency = 1;
			break;

		case 12: // All Syllables
			wordList_Select = 2;
			wordList_Romaji_Select = 1;
			wordList_Length_Start = 0; 
			wordList_Length_End = 106; 
			spawnFrequency = 1;
			break;

		// Category 3: Kanji Levels
		case 13: // Numbers
			wordList_Select = 3;
			wordList_Romaji_Select = 2;
			wordList_Length_Start = 0;   
			wordList_Length_End = 19; 
			spawnFrequency = 2;
			break;

		case 14: // Directions
			wordList_Select = 3;
			wordList_Romaji_Select = 2;
			wordList_Length_Start = 20;   
			wordList_Length_End = 27; 
			spawnFrequency = 2;
			break;

		case 15: // First Set
			wordList_Select = 3;
			wordList_Romaji_Select = 2;
			wordList_Length_Start = 28; 
			wordList_Length_End = 73; 
			spawnFrequency = 3;
			break;

		case 16: // Second Set
			wordList_Select = 3;
			wordList_Romaji_Select = 2;
			wordList_Length_Start = 74; 
			wordList_Length_End = 104; 
			spawnFrequency = 3;
			break;

		case 17: // Full Test
			wordList_Select = 3;
			wordList_Romaji_Select = 2;
			wordList_Length_Start = 0; 
			wordList_Length_End = 104; 
			spawnFrequency = 3;
			break;
		}
	}

	public void levelIndexSelect(int newLevelIndex) // Chooses the levelIndex.
	{
		levelIndex = newLevelIndex;
		LevelSelect ();
		Debug.Log ("Level Index = " + levelIndex + " Spawn Frequency: " + spawnFrequency);
	}
}
