using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Highscore : MonoBehaviour
{
    [SerializeField] private int highscore;
    [SerializeField] private Text highscoreText;

    private void Start()
    {
        highscore = PlayerPrefs.GetInt("Highscore");
        highscoreText.text = highscore.ToString();

        if (PlayerPrefs.GetInt("Score") > highscore)
        {
            highscore = PlayerPrefs.GetInt("Score");

            PlayerPrefs.SetInt("Highscore", highscore);
            highscoreText.text = highscore.ToString();
        }
        else
        {
            highscore = PlayerPrefs.GetInt("Highscore");
        }
    }
}
