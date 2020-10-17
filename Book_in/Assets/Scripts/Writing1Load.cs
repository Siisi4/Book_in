using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Writing1Load : MonoBehaviour
{

    public TMP_Text ouvrir;
    // Start is called before the first frame update
    void Start()
    {
        ouvrir.text = PlayerPrefs.GetString("Slot1", "");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
