using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class playerPrefs : MonoBehaviour
{
    //TMP_Text Outputzone;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.Save();
    }
}
