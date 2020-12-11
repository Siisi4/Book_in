using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LoadChat : MonoBehaviour
{
    
    public TMP_InputField MonLivre;
    // Start is called before the first frame update
    void Start()
    {
         MonLivre.text = TextManager.GetBook("SiChat");
    }

     public void SauvegardeLivre()
    {
        TextManager.SetBook("SiChat", MonLivre);
    }
}
