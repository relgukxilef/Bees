using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySlot : MonoBehaviour
{
    public Item item;

    void OnMouseDown() 
    {
        Debug.Log("InventorySlot.OnMouseDown");
        if (item != null && Item.selection == null) {
            Item.selection = item;
        }
    }
}