﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGame : MonoBehaviour
{
    public string sceneName;

    public void SwitchScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}