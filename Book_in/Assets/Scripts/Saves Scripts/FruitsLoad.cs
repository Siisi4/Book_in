using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FruitsLoad : MonoBehaviour
{
    public TMP_InputField LivreEcrit;
    // Start is called before the first frame update
    void Start()
    {
        LivreEcrit.text = TextManager.GetBook("fruits");
    }

     public void SauvegardeLivre()
    {
        // Vas sauvegarder à la clé "essay", le TMP_Text Livreecrit
        TextManager.SetBook("fruits", LivreEcrit);
    }
    
}
