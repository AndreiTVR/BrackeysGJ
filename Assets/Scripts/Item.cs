using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public string itemName;
    public Sprite itemSprite;
    [SerializeField] Player player;
    private void Start()
    {
        player = FindObjectOfType<Player>();
        itemSprite = GetComponent<SpriteRenderer>().sprite;
    }
    public void OnMouseDown()
    {
        player.Equip(this);
    }
}
