using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraControler : MonoBehaviour
{
    public move thePlayer;
    private Vector3 lastPlayerPosition;
    private float distanceToMove;
    void Start()
    {
        thePlayer = FindObjectOfType<move>();
        lastPlayerPosition = thePlayer.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        distanceToMove = thePlayer.transform.position.y - lastPlayerPosition.x;
        //transform.position = new Vector3(transform.position.y + distanceToMove, transform.position.y, transform.position.z);
        lastPlayerPosition = thePlayer.transform.position;
    }
}
 