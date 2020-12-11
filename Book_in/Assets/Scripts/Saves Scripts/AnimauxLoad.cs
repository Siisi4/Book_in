using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AnimauxLoad : MonoBehaviour
{
    public TMP_InputField MonLivre;

    // Start is called before the first frame update
    void Start()
    {
        MonLivre.text = TextManager.GetBook("animaux");
    }


    public void SauvegardeLivre()
    {
        TextManager.SetBook("animaux", MonLivre);
    }
}
