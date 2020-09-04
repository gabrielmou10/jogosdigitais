using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base : MonoBehaviour
{
    private int n = 0;
    public AudioClip BaseDestroy;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Alien")
        {
            Destroy(gameObject);
        }

        if (collision.tag == "TiroAlien")
        {
            n = n + 1;
            if (n >= 3)
            {
                Destroy(gameObject);
                AudioSource.PlayClipAtPoint(BaseDestroy, transform.position);
            }


        }
    }
}
