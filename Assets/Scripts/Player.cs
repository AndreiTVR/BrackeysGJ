using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Item equippedItem;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Equip(Item item)
    {
        if (!equippedItem) equippedItem = item;
        else
        {
            Instantiate(equippedItem, transform.position, transform.rotation);
            equippedItem = item;
        }
    }
}
