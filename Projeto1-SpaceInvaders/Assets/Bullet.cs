using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed = 5.0f;
    public AudioClip AlienDestroy;

    void Update()
    {
        gameObject.transform.position += Vector3.up * speed * Time.deltaTime;
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Alien")
        {

            Destroy(collision.gameObject);
            Destroy(gameObject);
            GameManager.score += 10;
            AudioSource.PlayClipAtPoint(AlienDestroy, transform.position);
        }
        if (collision.tag == "Base")
        {
            Destroy(gameObject);
        }

        if (collision.tag == "TiroAlien")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }

    }

}
