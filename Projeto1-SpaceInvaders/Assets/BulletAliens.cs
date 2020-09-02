using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletAliens : MonoBehaviour
{

    public float speed = 5.0f;
    private int n;

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
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }

        if (collision.tag == "Base")
        {
            Destroy(gameObject);

            n = n + 1;
            if (n >= 2)
            {
                Destroy(collision.gameObject);
            }
        }
    }
}