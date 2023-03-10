using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : BaseInventory
{
    public PlayerInventory()
    {
        inventory_grid = new Dictionary<(int, int), InventoryElement>()
        {
            {(0, 0), new ItemSlot(new Vector3(-25, 11, 0))},
            {(0, 1), new ItemSlot(new Vector3(-8.25f, 11, 0))},
            {(0, 2), new ItemSlot(new Vector3(8.25f, 11, 0))},
            {(0, 3), new ItemSlot(new Vector3(25, 11, 0))},
            {(0, 4), new ItemSlot(new Vector3(-25, -9, 0))},
            {(0, 5), new ItemSlot(new Vector3(-8.25f, -9, 0))},
            {(0, 6), new ItemSlot(new Vector3(8.25f, -9, 0))},
            {(0, 7), new ItemSlot(new Vector3(25, -9, 0))},
            {(0, 8), new ItemSlot(new Vector3(-25, -25.75f, 0))},
            {(0, 9), new ItemSlot(new Vector3(-8.25f, -25.75f, 0))},
            {(0, 10), new ItemSlot(new Vector3(8.25f, -25.75f, 0))},
            {(0, 11), new ItemSlot(new Vector3(25, -25.75f, 0))}
            
            
        };
        
        inventory.Add(new ItemCollection(12));
        
        setInventoryListener(0);
        
    }
    
    
}
