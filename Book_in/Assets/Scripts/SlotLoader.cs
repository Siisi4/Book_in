﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SlotLoader : MonoBehaviour
{

    void Start()
    {
        
    }


    void Update()
    {
        
    }

    public void Slot0()
    {
        SceneManager.LoadScene("Writing");
    }


    public void Slot1()
    {
        SceneManager.LoadScene("Writing1");
    }

    public void Slot2(){
        SceneManager.LoadScene("Writing2");
    }

    public void GoToMainScene()
    {
        SceneManager.LoadScene("Main Scene");
    }
}
