using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paint : MonoBehaviour
{
    public GameObject projectile;
    public Transform spawnPoint;

    private void Paintme()
    {
        Vector3 position = spawnPoint.position;
        Quaternion rotation = spawnPoint.rotation;

        Instantiate(projectile, position, rotation);
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
            Paintme();
    }
}
