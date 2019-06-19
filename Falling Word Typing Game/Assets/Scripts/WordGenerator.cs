using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour {


	/* Goal: 
		Generate a set of Hiragana & Katakana Text as the value which appears on screen, 
		then type the answer in romaji.

		Source of Table:
		https://www.omniglot.com/writing/japanese_hiragana.htm
		
	*/

	public static string[] wordList_Hiragana = { 	
		"あ", "い", "う", "え", "お", 
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
		"ぱ", "ぴ", "ぷ", "ぺ", "ぽ",
	
		"きゃ", "きゅ", "きょ", "ぎゃ", "ぎゅ", "ぎょ",
		"にゃ", "にゅ", "にょ", "ひゃ", "ひゅ", "ひょ",
		"びゃ", "びゅ", "びょ", "ぴゃ", "ぴゅ", "ぴょ",
		"みゃ", "みゅ", "みょ", "りゃ", "りゅ", "りょ",
		"じゃ", "じゅ", "じぇ", "じょ", "ちゃ", "ちゅ",
		"ちぇ", "ちょ", "しゃ", "しゅ", "しぇ", "しょ",
	};

	public static string[] wordList_Katakana = {
		"ア", "イ", "ウ", "エ", "オ",
		"カ", "キ", "ク", "ケ", "コ",
		"サ", "シ", "ス", "セ", "ソ",
		"タ", "チ", "ツ", "テ", "ト",
		"ナ", "ニ", "ヌ", "ネ", "ノ",
		"ハ", "ヒ", "フ", "ヘ", "ホ",
		"マ", "ミ", "ム", "メ", "モ",
		"ヤ", 		"ユ", 		"ヨ",
		"ラ", "リ", "ル", "レ", "ロ",
		"ワ", 					"ヲ",
		"ン", 												// 0 - 45

		"ガ", "ギ", "グ", "ゲ", "ゴ",
		"ザ", "ジ", "ズ", "ゼ", "ゾ",
		"ダ", "ヂ", "ヅ", "デ", "ド",
		"バ", "ビ", "ブ", "ベ", "ボ",
		"パ", "ピ", "プ", "ペ", "ポ",						// 46 - 70

		"キャ", "キュ", "キョ", "ギャ", "ギュ", "ギョ",
		"ニャ", "ニュ", "ニョ", "ヒャ", "ヒュ", "ヒョ",
		"ビャ", "ビュ", "ビョ", "ピャ", "ピュ", "ピョ",
		"ミャ", "ミュ", "ミョ", "リャ", "リュ", "リョ",
		"ジャ", "ジュ", "ジェ", "ジョ", "チャ", "チュ",
		"チェ", "チョ", "シャ", "シュ", "シェ", "ショ", 		// 71 - 106

	};

	public static string[] wordList_Romaji = {		
		"a", "i", "u", "e", "o",
		"ka", "ki", "ku", "ke", "ko",
		"sa", "shi", "su", "se", "so",
		"ta", "chi", "tsu", "te", "to",
		"na", "ni", "nu", "ne", "no",
		"ha", "hi", "fu", "he", "ho",
		"ma", "mi", "mu", "me", "mo",
		"ya",		"yu", 		"yo",
		"ra", "ri", "ru", "re", "ro",
		"wa",					"wo",
		"n",											// 0 - 45

		"ga", "gi", "gu", "ge", "go",
		"za", "ji", "zu", "ze", "zo",
		"da", "ji", "zu", "de", "do",
		"ba", "bi", "bu", "be", "bo",
		"pa", "pi", "pu", "pe", "po",					// 46 - 70
	
		"kya", "kyu", "kyo", "gya", "gyu", "gyo",
		"nya", "nyu", "nyo", "hya", "hyu", "hyo",
		"bya", "byu", "byo", "pya", "pyu", "pyo",
		"mya", "myu", "myo", "rya", "ryu", "ryo",
		"ja", "ju", "je", "jo", "cha", "chu",
		"che", "cho", "sha", "shu", "she", "sho",		// 71 - 106
	};

	public static string[] wordList_Kanji = {
		
		// Category 1: Numbers (0 - 19)
		"一", "二", "三", "四", "五", "六", "七", "八", "九", "十",
		"百", "千", "万", "半", "十一", "十五", "三十一", "二百九", "三千", "一万五千", 

		// Category 2: Directions (20 - 27)
		"上", "下", "左", "右",　 "北", "南", "東", "西", // North South East West

		// First Set (28 - 73)
		"今", "日", "週", "月", "年", "目", "耳", "手", "足", "人", "立つ", "花", "休む", "何",
		"先", "前", "入る", "外", "中", "多い", "大きい", "小さい", "天", "女", "男", "学",
		"山", "川", "母", "父", "空", "聞く", "話す", "行く", "来る", "白", "前", "後ろ",
		"気", "水", "火", "生きる", "毎日", "先生", "学生", "分かる", "会う",

		// Second Set (74 - 104)
		"名前", "会社", "新しい", "古い", "時", "書く", "木", "本", "来る", "学校", "安い",
		"高い",　 "書店", "魚", "見る", "言う", "語", "読む", "買う", "車", "週", "道", 
		"話す", "駅", "金",  "長い", "間",  "雨", "電気", "食べる", "飲む"
	};

	public static string[] wordList_Romaji_Kanji = {

		// Category 1: Numbers
		"ichi", "ni", "san", "yon", "go", "roku", "nana", "hachi", "kyuu", "jyuu",
		"hyaku", "sen", "man", "han", "jyuuichi", "jyuugo", "sanjyuuichi", "nihyakukyuu", "sanzen", "ichimangosen",

		// Category 2: Directions
		"ue", "shita", "hidari", "migi",　 "kita", "minami", "higashi", "nishi", 

		// First Set
		"ima", "nichi", "syuu", "gatsu", "nen", "me", "mimi", "te", "ashi", "hito", "tatsu", "hana", "yasumu", "nani",
		"saki", "mae", "hairu", "soto", "naka", "ooi", "ookii", "chiisai", "ten", "onna", "otoko", "gaku",
		"yama", "kawa", "haha", "chichi", "sora", "kiku", "hanasu", "iku", "kuru", "shiro", "mae", "ushiro",
		"ki", "mizu", "hi", "ikiru", "mainichi", "sensei", "gakusei", "wakaru", "au",

		// Second Set
		"namae", "kaisha", "atarashii", "furui", "ji", "kaku", "ki", "hon", "kuru", "gakkoo", "yasui",
		"takai", "shoten", "sakana", "miru", "iu", "go", "nomu", "kau", "kuruma", "michi", 
		"hanasu", "eki", "kane",  "nagai", "aida",  "ame", "denki", "taberu", "nomu"
	};







	public static int GetIndex()
	{
		// int index = Random.Range (0, wordList_Romaji.Length - 1);	// Get Random number which has the same index for Hiragana, Katakana, and Romaji arrays
		int index = Random.Range (LevelSelector.getWordList_Length_Start(), LevelSelector.getWordList_Length_End()); // Get Random number based on LevelSelector
		Debug.Log ("Index #" + index + ": " + wordList_Hiragana[index] + " " + wordList_Katakana[index] + " " + wordList_Romaji[index] ); // Debug Log
		return index;
	}
}
































	/*
	public static string GetWord_Hiragana ()	// A function to return the result of GetIndex as Hiragana word to be used on WordManager and in turn, displays that Hiragana.
	{
		string getWord_Hiragana = wordList_Hiragana [index];
		return getWord_Hiragana;
	}
			
	public static string GetWord_Katakana ()	
	{
		string getWord_Katakana = wordList_Katakana [index];
		return getWord_Katakana;
	}

	public static string GetWord_Romaji ()	// A function to return the result of GetIndex as Romaji word. This is used as the typeletter.
	{
		string getWord_Romaji = wordList_Romaji [index];
		return getWord_Romaji;
	}
}
*/