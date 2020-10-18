using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Paint : MonoBehaviour
{
    public GameObject projectile;
    public Transform spawnPoint;
    public Transform LaToile;
    public GameObject Toile;
    [HideInInspector]
    public GameObject[] toile;

    private void Paintme()
    {
        Vector3 position = spawnPoint.position;
        Quaternion rotation = spawnPoint.rotation;

        
        Instantiate(projectile, position, rotation, LaToile);
    }

    private void Start()
    {
        toile = GameObject.FindGameObjectsWithTag("toile");
    }
    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
            Paintme();
    }



    public void SaveToile()
    {
        DontDestroyOnLoad(Toile);
    }

    public void ToMainScene()
    {
        SceneManager.LoadScene("Main Scene");
        toile = GameObject.FindGameObjectsWithTag("toile");

       
    }

}
