using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour {



	/* Goal: 
		Generate a set of Hiragana & Katakana Text as the value which appears on screen, 
		then type the answer in romaji.

	*/

	public static string[] wordList_Hiragana = { 	"あ", "い", "う", "え", "お", 
		"か", "き", "く", "け", "こ",
		"さ", "し", "す", "せ", "そ",
		"た", "ち", "つ", "て", "と",
		"な", "に", "ぬ", "ね", "の",
		"は", "ひ", "ふ", "へ", "ほ",
		"ま", "み", "む", "め", "も",
		"や", 		"ゆ",		"よ",
		"ら", "り", "る", "れ", "ろ",
		"わ",				    "を",
		"ん",
		"が", "ぎ", "ぐ", "げ", "ご",
		"ざ", "じ", "ず", "ぜ", "ぞ",
		"だ", "ぢ", "づ", "で", "ど",
		"ば", "び", "ぶ", "べ", "ぼ",
		"ぱ", "ぴ", "ぷ", "ぺ", "ぽ" };

	public static string[] wordList_Katakana = {	"ア", "イ", "ウ", "エ", "オ",
		"カ", "キ", "ク", "ケ", "コ",
		"サ", "シ", "ス", "セ", "ソ",
		"タ", "チ", "ツ", "テ", "ト",
		"ナ", "ニ", "ヌ", "ネ", "ノ",
		"ハ", "ヒ", "フ", "ヘ", "ホ",
		"マ", "ミ", "ム", "メ", "モ",
		"ヤ", 		"ユ", 		"ヨ",
		"ラ", "リ", "ル", "レ", "ロ",
		"ワ", 					"ヲ",
		"ン",
		"ガ", "ギ", "グ", "ゲ", "ゴ",
		"ザ", "ジ", "ズ", "ゼ", "ゾ",
		"ダ", "ヂ", "ヅ", "デ", "ド",
		"バ", "ビ", "ブ", "ベ", "ボ",
		"パ", "ピ", "プ", "ペ", "ポ" };

	public static string[] wordList_Romaji = {		"a", "i", "u", "e", "o",
		"ka", "ki", "ku", "ke", "ko",
		"sa", "shi", "su", "se", "so",
		"ta", "chi", "tsu", "te", "to",
		"na", "ni", "nu", "ne", "no",
		"ha", "hi", "fu", "he", "ho",
		"ma", "mi", "mu", "me", "mo",
		"ya",		"yu", 		"yo",
		"ra", "ri", "ru", "re", "ro",
		"wa",					"wo",
		"n",
		"ga", "gi", "gu", "ge", "go",
		"za", "ji", "zu", "ze", "zo",
		"da", "dji", "dzu", "de", "do",
		"ba", "bi", "bu", "be", "bo",
		"pa", "pi", "pu", "pe", "po" };

	public static int GetIndex ()
	{
		int index = Random.Range (0, wordList_Romaji.Length - 1);	// Get Random number which has the same index for Hiragana, Katakana, and Romaji arrays

		Debug.Log ("Index #" + index + ": " + wordList_Hiragana[index] + " " + wordList_Katakana[index] + " " + wordList_Romaji[index]); // Debug Log

		return index; // Returns the result of the random as a guidance.
	}
	

	public static string GetWord_Hiragana ()	// A function to return the result of GetIndex as Hiragana word to be used on WordManager and in turn, displays that Hiragana.
	{
		int index = GetIndex ();

		string getWord_Hiragana = wordList_Hiragana [index];

		// Debug.Log ("Hiragana is: " + getWord_Hiragana);
		return getWord_Hiragana;
	}

	// Problem: It doesn't read anything below. How can I fix this?

	public static string GetWord_Katakana ()	// A function to return the result of GetIndex as Katakana word to be used on WordManager and in turn, displays that Katakana.
	{

		int index = GetIndex ();
		string getWord_Katakana = wordList_Katakana [index];

		// Debug.Log ("Katakana is: " + getWord_Katakana);
		return getWord_Katakana;
	}

	public static string GetWord_Romaji ()	// A function to return the result of GetIndex as Romaji word. This is used as the typeletter.
	{
		int index = GetIndex ();
		string getWord_Romaji = wordList_Romaji [index];

		// Debug.Log ("Answer is:" + getWord_Romaji);
		return getWord_Romaji;
	}
}
