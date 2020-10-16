using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CursorVisibleOnPress : MonoBehaviour
{
    void Update()
    {
        // On press active - désactive le curseur

        if (Input.GetKeyDown(KeyCode.A))
        {
            
            Cursor.visible = true;

        }

        if (Input.GetKeyDown(KeyCode.W))
        {

            Cursor.visible = false;

        }

    }
}
