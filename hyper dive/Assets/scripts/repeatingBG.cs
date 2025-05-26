using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class repeatingBG : MonoBehaviour
{
    public float speed;
    //public float endY;
    public float startY;
    Vector2 startPos;

    private void Start()
    {
        startPos = transform.position;
    }
    private void Update()
    {
        float newPos = Mathf.Repeat(Time.time * speed, startY);
        transform.position = startPos + Vector2.up * newPos;
        //transform.Translate(Vector2.up * speed * Time.deltaTime);
        //if (transform.position.x <= endY)
        //{
            //Vector2 pos = new Vector2(startY, transform.position.x);
            //transform.position = pos;

        //}
    }
}
