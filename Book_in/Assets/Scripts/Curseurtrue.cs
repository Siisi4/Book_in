﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Curseurtrue : MonoBehaviour
{

    void Start()
    {
        //Set Cursor to be visible or not (true / false)
        Cursor.visible = true;
    }

    private void Update()
    {
        Cursor.lockState = CursorLockMode.Confined;
    }
}
