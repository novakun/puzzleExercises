using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChipEatingLogic : MonoBehaviour
{
    SwipeControlls swipeControlls;
    GameEndController gameEndController;
    public GameObject selectedChip;


    private void Start()
    {
        swipeControlls = GetComponent<SwipeControlls>();
        gameEndController = GetComponent<GameEndController>();
    }

 
    private void OnTriggerEnter2D(Collider2D other)
    {
        swipeControlls.isMoving = false;
        if (swipeControlls.selectedGameObjectTag != other.tag)
        {
            Destroy(other.gameObject);
        }
        if (swipeControlls.selectedGameObjectTag == other.tag )
        {
            print("Same color!");
       
        }
        
      
         if(other.tag =="ChipDestroyer"){
            Destroy(gameObject);
         //   gameEndController.isGameOver = true;
       
        }
   
        Destroy(GetComponent<ChipEatingLogic>());

    }

}
