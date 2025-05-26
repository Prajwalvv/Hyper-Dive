using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorCycler : MonoBehaviour
{
    // Start is called before the first frame update
    public Color[] Colors;
    int _CurrentIndex = 0;
    public float speed = 5;
    Camera _cam;
    public bool _shouldChange = false;


    public void Start()
    {
        _cam = GetComponent<Camera>();
        _CurrentIndex = 0;
        SetColor(Colors[_CurrentIndex]);
    }

    public void SetColor(Color color)
    {
        _cam.backgroundColor = color;
    }

    public void CycleColor()
    {
        _shouldChange = true;
    }

    void Update()
    {
        if (_shouldChange)
        {
            var startColor = _cam.backgroundColor;

            var endColor = Colors[0];
            if (_CurrentIndex + 1 < Colors.Length)
            {
                endColor = Colors[_CurrentIndex + 1];
            }
            var newColor = Color.Lerp(startColor, endColor, Time.deltaTime * speed);
            SetColor(newColor);

            if (newColor == endColor)
            {
                _shouldChange = false;
                if (_CurrentIndex + 1 < Colors.Length)
                {
                    _CurrentIndex++;
                }
                else
                {
                    _CurrentIndex = 0;
                }
            }

        }
    }

}
