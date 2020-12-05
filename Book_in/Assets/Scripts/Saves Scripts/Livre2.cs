using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Livre2 : MonoBehaviour
{
    public TMP_InputField MonLivre;
    // Start is called before the first frame update
    void Start()
    {
        MonLivre.text = TextManager.GetBook("Personnal2");
    }

    public void SauvegardeLivre()
    {
        TextManager.SetBook("Personnal2", MonLivre);
    }
}
