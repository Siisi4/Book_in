using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Livre1 : MonoBehaviour
{
    public TMP_InputField MonLivre;
    // Start is called before the first frame update
    void Start()
    {
        MonLivre.text = TextManager.GetBook("Personnal1");
    }

    public void SauvegardeLivre()
    {
        TextManager.SetBook("Personnal1", MonLivre);
    }
}
