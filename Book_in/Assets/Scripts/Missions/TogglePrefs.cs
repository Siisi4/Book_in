using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TogglePrefs : MonoBehaviour
{
    public Toggle checkRed;
    public Toggle R1;
    public Toggle R2;
    public Toggle R3;
    public Toggle R4;
    public Toggle R5;


    public void Start()
    {
        // Load Check Rouge Titre
        if(PlayerPrefs.GetInt("checkRouge") == 1)
        {
            checkRed.isOn = true;
        }
        else
        {
            checkRed.isOn = false;
        }

        // Load Check R1
        if (PlayerPrefs.GetInt("R1") == 1)
        {
            R1.isOn = true;
        }
        else
        {
            R1.isOn = false;
        }

        // Load Check R2
        if (PlayerPrefs.GetInt("R2") == 1)
        {
            R2.isOn = true;
        }
        else
        {
            R2.isOn = false;
        }

        // Load Check R3
        if (PlayerPrefs.GetInt("R3") == 1)
        {
            R3.isOn = true;
        }
        else
        {
            R3.isOn = false;
        }

        // Load Check R4
        if (PlayerPrefs.GetInt("R4") == 1)
        {
            R4.isOn = true;
        }
        else
        {
            R4.isOn = false;
        }

        // Load Check R5
        if (PlayerPrefs.GetInt("R5") == 1)
        {
            R5.isOn = true;
        }
        else
        {
            R5.isOn = false;
        }
    }


    public void CheckRedManager()
    {
        // Missions Red Titre
        if (checkRed.isOn == true)
        {
            PlayerPrefs.SetInt("checkRouge", 1);
        }
        else
        {
            PlayerPrefs.SetInt("checkRouge", 0);
        }
    }
    public void CheckR1()
    {
        // Missions Red 1
        if (R1.isOn == true)
        {
            PlayerPrefs.SetInt("R1", 1);
        }
        else
        {
            PlayerPrefs.SetInt("R1", 0);
        }
    }
    public void CheckR2()
    {
        // Missions Red 2
        if (R2.isOn == true)
        {
            PlayerPrefs.SetInt("R2", 1);
        }
        else
        {
            PlayerPrefs.SetInt("R2", 0);
        }

    }

    public void CheckR3()
    {   // Missions Red 3
        if (R3.isOn == true)
        {
            PlayerPrefs.SetInt("R3", 1);
        }
        else
        {
            PlayerPrefs.SetInt("R3", 0);
        }

    }  
        
    public void CheckR4()
    {
        // Missions Red 4
        if (R4.isOn == true)
        {
            PlayerPrefs.SetInt("R4", 1);
        }
        else
        {
            PlayerPrefs.SetInt("R4", 0);
        }
    }
        
    public void CheckR5()
    {
        // Missions Red 5
        if (R5.isOn == true)
        {
            PlayerPrefs.SetInt("R5", 1);
        }
        else
        {
            PlayerPrefs.SetInt("R5", 0);
        }

    }
}
