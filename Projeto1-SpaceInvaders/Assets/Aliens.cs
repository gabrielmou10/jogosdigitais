using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aliens : MonoBehaviour
{
    public float speed = 0.5f;
    public float wait = 0.4f;
    private bool invert = false;
    public GameObject bullet;
    public GameObject bulletespecial;

    private int n = 0;

    void Start()
    {
        InvokeRepeating("AliensAttack", 0, wait);
    }

    void AliensAttack()
    {

        if (invert)
        {
            speed = -speed;
            gameObject.transform.position += Vector3.down * Mathf.Abs(speed);
            invert = false;
            return;
        }
        else
        {
            gameObject.transform.position += Vector3.right * speed;
        }

        foreach (Transform alien in gameObject.transform)
        {
            if (alien.position.x < -9 || alien.position.x > 9)
            {
                invert = true;
                break;
            }
            if (Random.value < 0.02f)
            {
                if (n < 5)
                {
                    n = n + 1;
                    Instantiate(bullet, alien.position, alien.rotation);
                }
                
                if (n == 5)
                {
                    Instantiate(bulletespecial, alien.position, alien.rotation);
                    n = 0;
                }
                print(n);
              
            }

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "TiroPlayer")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        if (collision.tag == "Base")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        if (collision.tag == "Nave")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }

    }


}
