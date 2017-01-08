using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TitleController : MonoBehaviour 
{
	public Text highScoreLabel;

	public void Start ()
	{
		// ハイスコアを表示
		highScoreLabel.text = "High Score : " + PlayerPrefs.GetInt("HighScore") + "m";
	}

	public void OnStartButtonClicked ()
	{
		Application.LoadLevel("Main");
	}
}
