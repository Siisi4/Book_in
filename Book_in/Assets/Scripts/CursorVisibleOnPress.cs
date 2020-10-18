using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CursorVisibleOnPress : MonoBehaviour
{
    void Update()
    {

        Cursor.lockState = CursorLockMode.Confined;

        
        // On press active(A) - désactive le curseur(W)

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
