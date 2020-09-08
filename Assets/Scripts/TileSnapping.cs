using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class TileSnapping : MonoBehaviour
{
    

    void Update()
    {
        Vector3 snapPos;
        snapPos.x = Mathf.RoundToInt(transform.position.x / 1f);
        snapPos.y = Mathf.RoundToInt(transform.position.y / 1f);

        transform.position = new Vector3(snapPos.x, snapPos.y, 0);
    }
}
