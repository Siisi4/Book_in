using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChevaletManager : MonoBehaviour
{
    [HideInInspector]
    public GameObject[] toile;

    private void Start()
    {
        toile = GameObject.FindGameObjectsWithTag("toile");
    }
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
