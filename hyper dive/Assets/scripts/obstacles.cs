﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class obstacles : MonoBehaviour
{
    public int damage = 1;
    public float speed;
    public GameObject effect;
    private Animator CamShake;
    //public GameObject score;

    private void Start()
    {
        //CamShake = GameObject.FindGameObjectWithTag("AniCam").GetComponent<Animator>();
    }
    private void Update()
    {
        //if ((int)score >= 2000)
        //{
        //    speed += 10;
        //}
        transform.Translate(Vector3.up * speed * Time.deltaTime);

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) {
            
            Instantiate(effect, transform.position, Quaternion.identity);
            // the player will take damage
            other.GetComponent<move>().health -= damage;
            Debug.Log(other.GetComponent<move>().health);
            Destroy(gameObject);
            //CamShake.SetTrigger("shake");
        }
    }
}
