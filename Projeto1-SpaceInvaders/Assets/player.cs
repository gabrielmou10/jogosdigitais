using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed = 25000.0f;
    private float bound = 8;

    public GameObject bullet;
    public AudioSource Laser;

    public float wait = 0.3f;
    private float timer = 0;

    // Update is called once per frame
    void Update()
    {
        float dh = Input.GetAxis("Horizontal");
        if ((gameObject.transform.position.x > -bound || dh > 0) &&
            (gameObject.transform.position.x < bound || dh < 0))
        {
            gameObject.transform.position += Vector3.right * dh * speed * Time.deltaTime;
        }

        timer += Time.deltaTime;
        if (timer > wait && Input.GetButton("Jump"))
        {
            timer = 0;
            Instantiate(bullet, gameObject.transform.position, Quaternion.identity);
            Laser.Play();
        }

    }

}
