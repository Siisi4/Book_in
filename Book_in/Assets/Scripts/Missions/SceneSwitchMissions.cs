﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitchMissions : MonoBehaviour
{
    public void LoadProust(){
        SceneManager.LoadScene("Proust");
    }
    public void LoadAcrostiche(){
        SceneManager.LoadScene("Acrostiche");
    }
    
}
