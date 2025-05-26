using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shakeTester : MonoBehaviour
{
    public Shaker Shaker;
    public float duration = 1f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            Shaker.shake(duration);
        }

    }
}
