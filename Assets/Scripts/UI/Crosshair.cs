using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crosshair : MonoBehaviour
{

    // should rename this class to Canvas_Crosshair

    private bool enableCrosshair = true;

    // Update is called once per frame
    void Update()
    {
        if (enableCrosshair)
        {
            transform.position = Input.mousePosition;
        }
    }
    private void Awake()
    {
        Cursor.visible = false;
    }

    // hides the crosshair and re-enables the cursor
    public void SetCrosshairVisibility(bool enabled)
    {
        enableCrosshair = enabled;
        Cursor.visible = !enabled;
    }

}
