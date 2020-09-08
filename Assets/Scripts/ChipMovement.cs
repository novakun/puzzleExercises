using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChipMovement : MonoBehaviour
{
    SwipeControlls swipeControlls;

    private Transform objectOriginPosision;




    // Start is called before the first frame update
    void Start()
    {
        swipeControlls = GetComponent<SwipeControlls>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveInDirection(Vector3 direction)
    {
        transform.Translate(direction);
    }
}
