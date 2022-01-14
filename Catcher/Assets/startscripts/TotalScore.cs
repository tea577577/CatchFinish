using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TotalScore : MonoBehaviour
{
	public Text finalScoreText;
	public Text CurrScore;
	private int score;
	private int finalScore;


	void Start()
	{
// score = GameObject.FindObjectOfType<ScoreCode>().CurrScore;
	  finalScoreText.text = CurrScore.text;
	

	}

	
}
