using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public string itemName;
    public Sprite itemSprite;
    private void Start()
    {
        itemSprite = GetComponent<SpriteRenderer>().sprite;
    }
    public void OnMouseDown()
    {
        Player player = FindObjectOfType<Player>();
        player.Equip(this);
    }
}
