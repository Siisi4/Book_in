using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KeepToile : MonoBehaviour
{
    public GameObject ActToile;

    [HideInInspector]
    public GameObject[] toile;
    
    // Start is called before the first frame update
    void Start()
    {
        ActToile.SetActive(true);
    }
    public void ToMainScene()
    {
        SceneManager.LoadScene("Main Scene");
        toile = GameObject.FindGameObjectsWithTag("toile");
        
        for(int i = 0; i<10; i++)
        {
            toile[i].SetActive(false);
        }
    }

    public void LoadPaintScene()
    {
        toile = GameObject.FindGameObjectsWithTag("toile");
        if (toile != null)
        {
            Debug.Log("une toile existe bel et bien.");
            for (int i = 0; i < toile.Length; i++)
            {
                toile[i].SetActive(true);
            }
        }
    }




    // Update is called once per frame
    void Update()
    {
        
    }
}
