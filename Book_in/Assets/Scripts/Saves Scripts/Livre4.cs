using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Livre4 : MonoBehaviour
{
    public TMP_InputField MonLivre;
    // Start is called before the first frame update
    void Start()
    {
        MonLivre.text = TextManager.GetBook("Personnal4");
    }

    public void SauvegardeLivre()
    {
        TextManager.SetBook("Personnal4", MonLivre);
    }
}
