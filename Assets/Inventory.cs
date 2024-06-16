using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public InventorySlot[] slots;

    public InventorySlot GetEmptySlot()
    {
        foreach (InventorySlot slot in slots) {
            if (slot.item == null) {
                return slot;
            }
        }
        return null;
    }
}