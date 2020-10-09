using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChevaletManager : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            SceneManager.LoadScene("Painting");
        }
    }

    public void ToArtScene()
    {
        SceneManager.LoadScene("Art");
    }

    public void ToMainScene()
    {
        SceneManager.LoadScene("Main Scene");
    }

    public void ToPaintScene()
    {
        SceneManager.LoadScene("Painting");
    }

}
