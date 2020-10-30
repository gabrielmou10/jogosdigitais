using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{

    public GameObject UIScore;
    public GameObject UILifes;
 
    public Nave nave;
    public int score = 0;

    // Update is called once per frame
    void Update()
    {
        UILifes.GetComponent<Text>().text = "Lifes: " + nave.lives;
        UIScore.GetComponent<Text>().text = "Score: " + score;
        if (nave.lives == 0) {
            PlayerPrefs.SetInt("highscore", score);
            SceneManager.LoadScene(0);
        }
    }
}
