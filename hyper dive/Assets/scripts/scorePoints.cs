using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scorePoints : MonoBehaviour
{
    private scoreManager ScoreManager;
    public int coinValue;
    public float speed;
    
    // Use this for initialization
    void Start()
    {
        ScoreManager = FindObjectOfType<scoreManager>();

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
            ScoreManager.AddCoins(coinValue);
            Destroy(gameObject);


        }
    }
    
}