using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyNave : MonoBehaviour
{
    public GameObject enemybullet;
    float speed = 0.5f;

    public float fireDelta = 0.5F;
    private float nextFire = 5.0F;
    private float myTime = 0.0F;

    public Transform explosionPrefab;
    public Transform target;

    public UIManager ui;
    public AudioClip AudioExplose;



    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target);
        myTime = myTime + Time.deltaTime;
        if (myTime > nextFire)
        {
            GameObject instancia = Instantiate(enemybullet, transform.position + (transform.forward * 2), transform.rotation) as GameObject;
            instancia.GetComponent<Rigidbody>().velocity = 5.0f * transform.forward;
            Destroy(instancia, 5.0f); // Destroi o tiro depois de 5 segundos
            myTime = 0.0F;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        ContactPoint contact = collision.contacts[0];
        Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
        Vector3 pos = contact.point;
        var instancia = Instantiate(explosionPrefab, pos, rot);
        Destroy(instancia.gameObject, 0.5f);
        Destroy(collision.gameObject);
        Destroy(gameObject);
        AudioSource.PlayClipAtPoint(AudioExplose, transform.position);
        ui.score = ui.score + 10;
    }
}
