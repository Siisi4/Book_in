using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BureauManager : MonoBehaviour
{

    int activeScene;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            int activeScene = PlayerPrefs.GetInt("ActiveScene");
            SceneManager.LoadScene(activeScene);
        }
    }
}
