using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Tiles : MonoBehaviour
{
    [SerializeField] Transform tileTransform;
    [Range(1,6)]
    [SerializeField] int gridColumns = 3;
    [Range(1, 6)]
    [SerializeField] int gridRows = 3;


    private void Start()
    {
        UpdateGrid();
    }
    public void UpdateGrid()
    {
        CreateGrid(gridColumns, gridRows);
    }

    void CreateGrid(int columns, int rows)
    {
       
        for(int i =0; i< columns; i++)
        {
            for (int n = 0; n < rows; n++)
            {
                Instantiate(tileTransform, new Vector3(n, i, 0), Quaternion.identity);
            }
        }
 
    }

}
