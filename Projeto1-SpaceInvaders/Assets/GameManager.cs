using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static int vidas;
    public Text texto_vidas;
    public Text texto_score;
    public static int score;
    // Start is called before the first frame update
    void Start()
    {
        GameManager.vidas = 3;
        GameManager.score = 0;
        texto_vidas.text = "Vidas: " + GameManager.vidas.ToString();
        texto_score.text = "Score: " + GameManager.score.ToString();
         
    }

    // Update is called once per frame
    void Update()
    {
        texto_vidas.text = "Vidas: " + GameManager.vidas.ToString();
        texto_score.text = "Score: " + GameManager.score.ToString();
    }
}
