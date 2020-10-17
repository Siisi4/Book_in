using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadTextOnPress : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TextReload.text = PlayerPrefs.GetString("TexteLivre", "Vous n'avez encore rien écrit !");
        Debug.Log("Click load text " + TextReload.text);
    }

    public TMP_Text TextReload;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            SceneManager.LoadScene("SavesMenu");
        }
    }
}
