﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightningbolt : MonoBehaviour
{
    //public int damage;
    public float speed;
    public float xStartValue;
    public float yStartValue;
    public float minimumX;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        if (transform.position.x <= minimumX)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {
            other.GetComponent<Player>().lightningboltsCollected = other.GetComponent<Player>().lightningboltsCollected + 1;
            Debug.Log(other.GetComponent<Player>().lightningboltsCollected);
            Destroy(gameObject);

        }
    }
}
