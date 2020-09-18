using System.Collections;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    private string saveFile;

    void Start()
    {
        saveFile = Application.persistentDataPath + "/sauvegarde.sav";
    }


    void Update()
    {
        
    }
}
