using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject thePlatform;
    public Transform generationPoint;
    public float distanceBetween;

    private float platformHeight;

    void Start()
    {
        platformHeight = thePlatform.GetComponent<BoxCollider2D>().size.y;
    }
   
    // Update is called once per frame
    void Update()
    {
        

        //if(transform.position.y > generationPoint.position.y)

        //   transform.position = new Vector3(transform.position.x + platformHeight + distanceBetween, transform.position.y, transform.position.z);
        //  Instantiate(thePlatform, transform.position, transform.rotation);
        //}

    }
    
}
