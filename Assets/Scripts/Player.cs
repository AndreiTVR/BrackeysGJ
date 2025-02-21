using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Item equippedItem;
    [SerializeField] Transform itemTPSpot;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Equip(Item item)
    {
        if (equippedItem.name=="no Item") equippedItem = item;
        else
        {
            if(equippedItem.name!="no Item") equippedItem.transform.position = transform.position;
            equippedItem = item;
        }
        equippedItem.transform.position = itemTPSpot.transform.position;
    }
}
