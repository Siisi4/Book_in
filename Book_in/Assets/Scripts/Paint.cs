using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paint : MonoBehaviour
{
    public GameObject projectile;
    public Transform spawnPoint;
    public Transform LaToile;
    public GameObject Toile;

    private void Paintme()
    {
        Vector3 position = spawnPoint.position;
        Quaternion rotation = spawnPoint.rotation;

        
        Instantiate(projectile, position, rotation, LaToile);
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

}
