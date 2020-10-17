using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WritingLoad : MonoBehaviour
{

    public TMP_Text TextReload;
    // Start is called before the first frame update
    void Start()
    {
        TextReload.text = PlayerPrefs.GetString("TexteLivre", "");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
