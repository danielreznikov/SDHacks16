using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour
{
	Text txt;
	private int score = 0;

	void Start() {
		txt = gameObject.GetComponent<Text> ();
		txt.text = "Items collected: " + score;
	}

	void Update() {
		txt.text = "Items collected: " + score;
		score = PlayerPrefs.GetInt ("SCORE");
	}
}