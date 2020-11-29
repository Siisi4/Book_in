using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AcrosticheLoad : MonoBehaviour
{

    public TMP_InputField LivreEcrit;
    // Start is called before the first frame update
    void Start()
    {
        LivreEcrit.text = TextManager.GetBook("acrostiche");
    }

    public void SauvegardeLivre()
    {
        // Vas sauvegarder à la clé "essay", le TMP_Text Livreecrit
        TextManager.SetBook("acrostiche", LivreEcrit);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
