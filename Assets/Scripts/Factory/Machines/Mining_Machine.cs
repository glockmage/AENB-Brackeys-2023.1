using System.Collections;
using System.Collections.Generic;
using System.Runtime.Versioning;
using UnityEditor;
using UnityEngine;

[RequireComponent(typeof(Miner_Inventory))]
public class Mining_Machine : Machine, IKillable
{
    public Mining_Machine()
    {
        inpBuf = null;
        outBuf = new(1);
        type = MachineType.MINER;
        footPrint = new(2, 2);
        child_start = Mining_Start;
        //GetComponent<Miner_Inventory>().inventory = outBuf; 
    }

    private void Mining_Start()
    {
        //GetComponent<Miner_Inventory>().inventory[0] = outBuf;
        // change this to decide what ore to mine
        doing = new Recipe(Globals.allRecipes["ironOreMiner"]);
    }

    public void setDoing(string recipe)
    {
        doing = new Recipe(Globals.allRecipes[recipe]);
    }
    public override ItemCollection getInputBuffer()
    {
        return inpBuf;
    }

    public override ItemCollection getOutputBuffer()
    {
        return outBuf;
    }

    public void Die()
    {
        Destroy(gameObject);
    }

    public void NotifyDamage()
    {
        throw new System.NotImplementedException();
    }
}
