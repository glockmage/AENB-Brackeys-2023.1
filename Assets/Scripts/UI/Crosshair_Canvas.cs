using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Crosshair_Canvas : MonoBehaviour
{
    
    private bool enableCrosshair = true;

    [SerializeField] Image image;

    [SerializeField] private Texture2D cursorTexture;


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
        Cursor.SetCursor(cursorTexture, Vector2.zero, CursorMode.Auto);
        //Cursor.visible = false;
    }

    // hides the crosshair and re-enables the cursor
}
