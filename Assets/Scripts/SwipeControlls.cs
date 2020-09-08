using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class SwipeControlls : MonoBehaviour
{
    private Vector2 startSwipePos;
    private Vector2 endSwipePos;
    private Vector2 swipe;
    private Vector3 moveDirection;
    [SerializeField] float minSwipeDistance = 0.06f;
    [SerializeField]float movementSpeed = 1.1f;

    public Vector3 objectOriginPosision;

    public string selectedGameObjectTag;
    public GameObject selectedGameObjectId;

    public bool isMoving = false;


    private void Update()
    {
        if (isMoving)
        {
            MoveInDirection();
            
            selectedGameObjectId.AddComponent<ChipEatingLogic>();
        }
       
    }



    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            startSwipePos = Camera.main.ScreenToViewportPoint(Input.mousePosition);
            SelectedGameObjectTag();
            SelectedGameObjectId();
            objectOriginPosision = SelectedGameObjectTransform();
          //  selectedGameObjectId.AddComponent<ChipEatingLogic>();
        }
      
    }

    private void OnMouseUp()
    {
        if (Input.GetMouseButtonUp(0))
        {
            endSwipePos = Camera.main.ScreenToViewportPoint(Input.mousePosition);
            swipe = endSwipePos - startSwipePos;
            MoveSelectedObjectInDirection(selectedGameObjectId);
        }
    }

    private void MoveSelectedObjectInDirection(GameObject swipeObject)
    {
     
        if (swipe.magnitude > minSwipeDistance)
        {
            isMoving = true;
            swipe = swipe.normalized;
            moveDirection = swipe;

            if (Mathf.Abs(swipe.x) > Mathf.Abs(swipe.y))
            {
                if (swipe.x < 0)
                {
                    print("moing left");
                   //transform.Translate(swipe.x, 0, 0);
                    moveDirection = swipe;
                    // swipedObject.transform.position += new Vector3(swipe.x * Time.deltaTime, 0, 0);
                }
                else
                {
                    moveDirection = swipe;
                    print("moing right");
                   // swipedObject.transform.Translate(swipe.x, 0, 0);
                }
            }
            else
            {
                if (swipe.y < 0)
                {
                    moveDirection = swipe;
                    print("moing down");
                   // swipedObject.transform.Translate(0, swipe.y, 0);
                }
                else
                {
                    moveDirection = swipe;
                    print("moing up");
                    //swipedObject.transform.Translate(0, swipe.y, 0);
                }
            }

        }

    }

    private void MoveInDirection()
    {
        print("moving?");
        transform.Translate(swipe );
    }

    private GameObject SelectedGameObjectId()
    {
        return selectedGameObjectId = this.gameObject;
    }

    public string SelectedGameObjectTag()
    {
        return selectedGameObjectTag = gameObject.tag;
    }
    public Vector3 SelectedGameObjectTransform()
    {
        return selectedGameObjectId.transform.position;
    }

}
