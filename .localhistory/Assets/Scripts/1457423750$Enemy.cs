﻿using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{
    static private float speed = 3;
    //public float rotspeed = 50;
    [SerializeField]
    GameObject explosion;

    //Vector2[] moves = new Vector2[4];   

    Vector2[] vecArray;

        
    Vector2 movUp = new Vector2(0, speed);
    Vector2 movDown = new Vector2(0, -speed);
    Vector2 movLeft = new Vector2(-speed, 0);
    Vector2 movRight = new Vector2(speed, 0);


    void Update()
    {

        transform.Translate(movDown * Time.deltaTime);

        //if (Input.GetKey(KeyCode.UpArrow))
        //    transform.Translate(new Vector2(0, speed * Time.deltaTime));
        //if (Input.GetKey(KeyCode.DownArrow))
        //    transform.Translate(new Vector2(0, -speed * Time.deltaTime));
        //if (Input.GetKey(KeyCode.LeftArrow))
        //    transform.Rotate(new Vector3(0, 0, rotspeed * Time.deltaTime));
        //if (Input.GetKey(KeyCode.RightArrow))
        //    transform.Rotate(new Vector3(0, 0, -rotspeed * Time.deltaTime));
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.gameObject.CompareTag("PlayerBullet"))
        {
            gameObject.SetActive(false);
            Destroy(collision.gameObject);
            Instantiate(explosion, transform.position, Quaternion.identity);
        }
    }

    public void Movement()
    {
        // transform.Translate());
    }


}