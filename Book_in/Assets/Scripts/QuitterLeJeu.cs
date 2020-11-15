using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitterLeJeu : MonoBehaviour
{
   public void Quitter()
    {
        Application.Quit();
        Debug.Log("le jeu est sensé quitter");
    }
}
