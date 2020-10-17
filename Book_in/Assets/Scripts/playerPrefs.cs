using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class playerPrefs : MonoBehaviour
{
    public TMP_Text MonTexte;
    public TMP_Text MonTexte1;

    public TMP_Text TextReload;
    public TMP_Text TextReload1;


    void Start()
    {
        
    }

    // Save du texte outputzone
    

    // On va créer une fonction qui va être déclanché via un bouton (on va link la fonction au click sur le bouton)
    // Quand tu clicques sur le bouton ("save") ça va SetString ce que tu as dans le "Outputzone"

    public void SaveText()
    {
        PlayerPrefs.SetString("TexteLivre", MonTexte.text);
        // On va voir si la fonction marche avec un Debug :
        Debug.Log("Tu viens d'enregistrer ton texte ! : " + MonTexte.text);
    }


    public void LoadText()
    {

        TextReload.text = PlayerPrefs.GetString("TexteLivre", "");
        Debug.Log("Click load text " + TextReload.text);

    }

    public void SaveSlot1()
    {
        PlayerPrefs.SetString("Slot1", MonTexte1.text);
    }

    

}