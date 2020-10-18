using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurseurVisibility : MonoBehaviour
{
    private void Update()
    {
        Cursor.lockState = CursorLockMode.Confined;
    }
    void Start()
    {
        //Set Cursor to be visible or not (true / false)
        Cursor.visible = false;
    }
}
