using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitterLeJeu : MonoBehaviour
{
   public void Quitter()
    {
        Application.Quit();
        Debug.Log("le jeu est sensé quitter");
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
            Debug.Log("le jeu est sensé quitter");
        }
    }
}
