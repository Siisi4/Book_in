using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PseudoJoueur : MonoBehaviour
{
    public TMP_Text Pseudo;
    public TMP_Text NameReload;
   
    void Start()
    {
        
    }

    // Save pseudo du joueur 
    public void SavePseudo()
    {
        PlayerPrefs.SetString("Pseudo", Pseudo.text);
        Debug.Log("Pseudo enregistré sous : " + Pseudo.text);
    }

    public void LoadPseudo()
    {
        NameReload.text = PlayerPrefs.GetString("Pseudo", "Anonyme");
        Debug.Log("ton pseudo est : " + NameReload.text);
    }
}
