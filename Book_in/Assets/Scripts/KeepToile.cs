using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KeepToile : MonoBehaviour
{
 
    public void SaveToile()
    {
        GameObject encres = GameObject.FindGameObjectWithTag("Encre");
        DontDestroyOnLoad(encres);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
