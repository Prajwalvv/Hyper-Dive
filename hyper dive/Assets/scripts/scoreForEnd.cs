using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class scoreForEnd : MonoBehaviour
{
    public UnityEngine.UI.Text scoreText;
    public float scoreAmount;
    public float pointIncreasedPerSecond;
    public float ScoreMult;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
        scoreAmount = 0f;
        pointIncreasedPerSecond = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = (int)scoreAmount * ScoreMult + " ";
        scoreAmount += pointIncreasedPerSecond * Time.deltaTime;

    }
}
