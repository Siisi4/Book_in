using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadTextOnPress : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    

    public void LibrairieTextes()
    {
        SceneManager.LoadScene("SavesMenu");
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            SceneManager.LoadScene("SavesMenu");
        }
    }
}
