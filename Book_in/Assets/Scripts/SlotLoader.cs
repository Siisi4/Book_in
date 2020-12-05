using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SlotLoader : MonoBehaviour
{

    void Start()
    {
        
    }


    void Update()
    {
        
    }

    public void Livre1Load()
    {
        SceneManager.LoadScene("Personnal 1");
    }


    public void Livre2Load()
    {
        SceneManager.LoadScene("Personnal 2");
    }

    public void Livre3Load(){
        SceneManager.LoadScene("Personnal 3");
    }
    public void Livre4Load(){
        SceneManager.LoadScene("Personnal 4");
    }
    public void Livre5Load(){
        SceneManager.LoadScene("Personnal 5");
    }

    public void GoToMainScene()
    {
        SceneManager.LoadScene("Main Scene");
    }
}
