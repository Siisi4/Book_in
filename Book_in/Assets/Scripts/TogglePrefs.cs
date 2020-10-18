using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TogglePrefs : MonoBehaviour
{
    public Toggle checkRed;

    public void Start()
    {
        if(PlayerPrefs.GetInt("checkRouge") == 1)
        {
            checkRed.isOn = true;
        }
        else
        {
            checkRed.isOn = false;
        }
    }


    public void CheckRedManager()
    {
        if (checkRed.isOn == true)
        {
            PlayerPrefs.SetInt("checkRouge", 1);
        }
        else
        {
            PlayerPrefs.SetInt("checkRouge", 0);
        }
        
    }

    
}
