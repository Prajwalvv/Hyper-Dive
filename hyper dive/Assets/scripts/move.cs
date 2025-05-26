using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
//using GoogleMobileAds.Api;
public class move : MonoBehaviour
{
    private Vector3 touchPosition;
    private Rigidbody2D rb;
    private Vector3 direction;
    private float moveSpeed_R_L = 10f;
    [SerializeField]
    private float _speed = 5.0f;
    //public float down_speed;
    public Vector3 respawnPoint;
    private Vector3 targetPos;
    public int health = 0;
    //private RewardBasedVideoAd rewardBasedVideo;
    public bool publishingApp;
    public Animator animator;
    public scoreManager gameScore;
    public UnityEngine.UI.Text healthDisplay;
    public GameObject gameOver;
    public GameObject toxic_Particle_System;

    private Touch touch;
    public float speedModifer = 0.01f;
    //public GameObject effect;

    private void Start()
    {
       
        rb = GetComponent<Rigidbody2D>();
        respawnPoint = transform.position;
    }

    // Update is called once per frame
    void Update()
    {


        healthDisplay.text = health + "%";

        health = Mathf.Clamp(health, -10, 100);

        if (health <= 0)
        {
            gameOver.SetActive(true);
            Destroy(gameObject);
            Time.timeScale = 0f;
            //highScore_save();
            //RequestRewardBasedVideo();
            //gameScore.scoreText.gameObject.SetActive(false);
            //gameScore.scoreText.text = ((int)gameScore).ToString();
            //this code below is to change scene and show game over and even ask to play again
            //SceneManager.LoadScene("gameOver");
        }

        //move_with_touch_drag();
        move_with_touch_drag();
    }

    public void AddHealth(int numberOfCoins)
    {
        health += numberOfCoins;
        healthDisplay.text = "" + health;
    }

    

    void move_keyboard()
    {
        animator.SetFloat("Horizontal", Input.GetAxis("Horizontal"));
        float move = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(move * _speed * Time.deltaTime, rb.velocity.y);
        //Instantiate(effect, transform.position, Quaternion.identity);
    }
    //this is for touch input move

    void move_with_touch_drag()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                transform.position = new Vector3(transform.position.x + touch.deltaPosition.x * speedModifer, transform.position.y);
            }
        }
    }


    void move_touch()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            touchPosition.z = 0;
            direction = (touchPosition - transform.position);
            rb.velocity = new Vector2(direction.x, direction.y) * moveSpeed_R_L;

            if (touch.phase == TouchPhase.Ended)
                rb.velocity = Vector2.zero;
        }
    }
    public Vector3 GetPosition()
    {
        return transform.position;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "toxic")
        {
            Instantiate(toxic_Particle_System, transform.position, Quaternion.identity);
        }
    }
    //void OnTriggerEnter2D(Collider2D other)
    //{
    //if (other.tag == "FallDetector")
    //{
    //what will happen if player falls on rhe fall detector part
    //transform.position = respawnPoint;
    //}
    //if(other.tag == "Checkpoint")
    //{
    //respawnPoint = other.transform.position;
    //}
    //}
}

