using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour {
	public int score;
	public Text scoreKeeper;

	// Use this for initialization
	void Start () {
		score = 0;
		scoreKeeper = GameObject.Find("Score").GetComponent<Text>();
		scoreKeeper.text = score.ToString();
	}

	public void Score(int points)
	{
		score += points;
		scoreKeeper.text = score.ToString();
	}

	public void Reset()
	{
		score = 0;
		scoreKeeper.text = score.ToString();
	} 
	
	// Update is called once per frame
	void Update () {
	
	}
}
