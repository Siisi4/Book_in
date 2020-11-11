using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Writing1Load : MonoBehaviour
{

    public TMP_Text Livreecrit;
    // Start is called before the first frame update
    void Start()
    {
        //Livreecrit.text = PlayerPrefs.GetString("Slot1", "");

        // Je load le texte enregistré sous la clé "essay"

        Livreecrit.text = TextManager.GetBook("essay");

    }

    // Fonction appelée quand cliquer sur "sauvegarder"
    public void SauvegardeLivre()
    {
        // Vas sauvegarder à la clé "essay", le TMP_Text Livreecrit
        TextManager.SetBook("essay", Livreecrit);
    }


}
