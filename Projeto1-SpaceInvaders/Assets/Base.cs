using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base : MonoBehaviour
{
    private int n = 0;

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
            }


        }
    }
}
