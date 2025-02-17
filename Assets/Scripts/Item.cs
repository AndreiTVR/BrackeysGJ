using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public string itemName;
    Sprite itemSprite;
    private void Start()
    {
        itemSprite = GetComponent<SpriteRenderer>().sprite;
    }
}
