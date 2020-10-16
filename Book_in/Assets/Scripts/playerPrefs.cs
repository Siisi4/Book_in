using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using UnityEngine.Events;

public class playerPrefs : MonoBehaviour
{
    public TMP_Text MonTexte;
    

    void Start()
    {
        
    }

    // Save du texte outputzone
    public void LoadText()
    {
        
        MonTexte.text = PlayerPrefs.GetString("TexteLivre", "Vous n'avez encore rien écrit !");

    }

    // On va créer une fonction qui va être déclanché via un bouton (on va link la fonction au click sur le bouton)
    // Quand tu clicques sur le bouton ("save") ça va SetString ce que tu as dans le "Outputzone"

    public void SaveText()
    {
        PlayerPrefs.SetString("TexteLivre", MonTexte.text);
        // On va voir si la fonction marche avec un Debug :
        Debug.Log("Tu viens d'enregistrer ton texte ! : " + MonTexte.text);
    }
    

}