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
		// Word question = new Word (WordGenerator.GetWord_Hiragana(), wordSpawner.SpawnWord ()); // Feed a random word, and then display that word.
		Word word = new Word (WordGenerator.GetWord_Romaji(), wordSpawner.SpawnWord());

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
	}
}
