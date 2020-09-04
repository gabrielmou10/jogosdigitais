using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Victory : MonoBehaviour
{

    public GameObject aliens;
    public GameObject player;

    void Update()
    {
        if (player == null)
            gameObject.GetComponent<Text>().text = "GAME OVER";
        else if (aliens.transform.childCount == 0)
        {
            gameObject.GetComponent<Text>().text = "Parabéns! voce venceu o jogo";
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
