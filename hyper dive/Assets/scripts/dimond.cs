using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dimond : MonoBehaviour
{
    private levelManager gameLevelManager;
    public int coinValue;
    public float speed;

    // Use this for initialization
    void Start()
    {
        gameLevelManager = FindObjectOfType<levelManager>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            gameLevelManager.AddCoins(coinValue);
            Destroy(gameObject);
        
        }
    }
}