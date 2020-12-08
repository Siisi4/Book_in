using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LoadBookIn : MonoBehaviour
{
    public TMP_Text BookInLoadText;
    public GameObject LoadingScreen;
    float textsize;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textsize = 76;
        if(BookInLoadText.fontSize == textsize ){
            LoadingScreen.SetActive(false);
        }
    }
}
