using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorTexture : MonoBehaviour
{
    public Texture2D cursorTexture;
    public CursorMode cursorMode = CursorMode.ForceSoftware;
    public Vector2 cursorOffset = Vector2.zero;
    
    private void Awake()
    {
        Cursor.SetCursor(cursorTexture, cursorOffset, cursorMode);
    }
}
