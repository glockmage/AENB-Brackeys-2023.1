using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutputSlot : InventoryElement
{
    public OutputSlot(Vector3 givenPos)
    {
        initialPosition = givenPos;
        prefab_path = "InventoryOutPutSlot";
    }
}
