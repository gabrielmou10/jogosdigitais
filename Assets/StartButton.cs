using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public Text UIHighScore;

    private void Update()
    {
        UIHighScore.text = "HighScore: " + PlayerPrefs.GetInt("highscore");

    }

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
}
