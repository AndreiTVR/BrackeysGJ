using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseDoor : MonoBehaviour
{
    //variabilele pt usa din casa
    [SerializeField] Transform teleportPosition;
    [SerializeField] Transform player;
    // Start is called before the first frame update
    
    void OnMouseDown()
    {
        player.transform.position = teleportPosition.transform.position;
    }
}
