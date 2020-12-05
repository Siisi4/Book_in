using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Livre3 : MonoBehaviour
{
    public TMP_InputField MonLivre;
    // Start is called before the first frame update
    void Start()
    {
        MonLivre.text = TextManager.GetBook("Personnal3");
    }

    public void SauvegardeLivre()
    {
        TextManager.SetBook("Personnal3", MonLivre);
    }
}
