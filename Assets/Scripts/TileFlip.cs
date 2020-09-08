using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileFlip : MonoBehaviour
{
    [SerializeField] SpriteRenderer tileSprite;
    [SerializeField] Sprite spriteOrange;
    [SerializeField] Sprite spritePurple;
    private void Start()
    {
    }

  

    void OnMouseDown()
    {
        GetTileSpriteComponent();
        tileSprite.sprite = SpriteLogic();
    }

    private Sprite SpriteLogic()
    {
        if(tileSprite.sprite == spriteOrange)
        {
            return spritePurple;
        }
        else if (tileSprite.sprite == spritePurple)
        {
            return spriteOrange;
        }
        else
        {
            return spriteOrange;
        }
    }

    private void GetTileSpriteComponent()
    {
        tileSprite = GetComponent<SpriteRenderer>();
    }
}
