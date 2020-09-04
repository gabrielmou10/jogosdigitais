using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletAliens : MonoBehaviour
{

    public float speed = 5.0f;

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position += Vector3.down * speed * Time.deltaTime;
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(gameObject);
            GameManager.vidas -= 1;
            if(GameManager.vidas == 0)
            {
                Destroy(collision.gameObject);

            }
        }

        if (collision.tag == "Base")
        {
            Destroy(gameObject);
        }
    }
}