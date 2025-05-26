using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class score : MonoBehaviour
{
    public UnityEngine.UI.Text scoreText;
    public float scoreAmount;
    public float pointIncreasedPerSecond;
    public float ScoreMult = 10f;
    public float pointsStart;

    // Start is called before the first frame update
    void Start()
    {
        ScoreMult = 10f;
        scoreAmount = 0f;
        pointIncreasedPerSecond = pointsStart;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = (int)scoreAmount * ScoreMult + " m";
        scoreAmount += pointIncreasedPerSecond * Time.deltaTime;

    }

    public static explicit operator int(score v)
    {
        throw new NotImplementedException();
    }
}
