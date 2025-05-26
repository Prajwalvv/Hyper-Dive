using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shakeTim : MonoBehaviour
{
    // Start is called before the first frame update
    private float shakeTimeRemaining, shakePower;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            startShake(1f, 1f);
        }
    }

    private void LateUpdate()
    {
        if (shakeTimeRemaining > 0)
        {
            shakeTimeRemaining -= Time.deltaTime;

            float xAmount = Random.Range(-1f, 1f) * shakePower;
            float yAmount = Random.Range(-1f, 1f) * shakePower;

            transform.position += new Vector3(xAmount, yAmount, 0f);
        }

    }

    public void startShake(float length,float power)
    {
        shakeTimeRemaining = length;
        shakeTimeRemaining = power;
    }
}
