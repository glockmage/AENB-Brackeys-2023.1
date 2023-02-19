using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket_Inventory : BaseInventory
{
    public Rocket_Inventory()
    {
        inventory_grid = new Dictionary<(int, int), InventoryElement>()
        {
            // this arrangement is based off the furnace inventory and should be changed
            {(0,0), new ItemSlot(new Vector3(-6.26f, -25.78f, 0))}, // Input  Buffer - 1
            {(0,1), new ItemSlot(new Vector3(10.35f, -25.78f, 0))}, // Input  Buffer - 2
            {(0,2), new ItemSlot(new Vector3(26.96f, -25.75f, 0))}, // Input  Buffer - 3
            {(0, 3), new ItemSlot(new Vector3(44.25f, -25.75f, 0))} // Input Buffer - 4
        };
        
        inventory.Add(new ItemCollection(12));
        
    }
}
