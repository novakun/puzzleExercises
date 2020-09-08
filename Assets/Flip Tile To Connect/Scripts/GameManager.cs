using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject []puzzlePiecesArray;
    [SerializeField] Canvas victoryCanvas;

  public static bool isPuzzleSolved = false;

    private void Awake()
    {
        isPuzzleSolved = false;
        victoryCanvas.enabled = false;
    }
    private void Update()
    {
        
            if (puzzlePiecesArray[0].transform.rotation.z == 0f &&
                 puzzlePiecesArray[1].transform.rotation.z == 0f &&
                 puzzlePiecesArray[2].transform.rotation.z == 0f &&
                 puzzlePiecesArray[3].transform.rotation.z == 0f &&
                 puzzlePiecesArray[4].transform.rotation.z == 0f &&
                 puzzlePiecesArray[5].transform.rotation.z == 0f &&
                 puzzlePiecesArray[6].transform.rotation.z == 0f &&
                 puzzlePiecesArray[7].transform.rotation.z == 0f &&
                 puzzlePiecesArray[8].transform.rotation.z == 0f &&
                 puzzlePiecesArray[9].transform.rotation.z == 0f &&
                 puzzlePiecesArray[10].transform.rotation.z == 0f &&
                 puzzlePiecesArray[11].transform.rotation.z == 0f &&
                 puzzlePiecesArray[12].transform.rotation.z == 0f &&
                 puzzlePiecesArray[13].transform.rotation.z == 0f &&
                 puzzlePiecesArray[14].transform.rotation.z == 0f &&
                 puzzlePiecesArray[15].transform.rotation.z == 0f &&
                 puzzlePiecesArray[16].transform.rotation.z == 0f &&
                 puzzlePiecesArray[17].transform.rotation.z == 0f )
            {
            isPuzzleSolved = true;
            victoryCanvas.enabled = true;
            print("puzzle is solved!");
            }
        
    }
   

}
