using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TableauLoad : MonoBehaviour
{
    public TMP_InputField MonLivre;
    // Start is called before the first frame update
    void Start()
    {
        MonLivre.text = TextManager.GetBook("tableau");
    }

    public void SauvegardeLivre()
    {
        TextManager.SetBook("tableau", MonLivre);
    }
}
