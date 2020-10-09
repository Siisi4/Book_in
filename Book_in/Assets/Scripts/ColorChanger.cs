using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{

    public GameObject projectile;

    // script à faire si interface fail trop longtemps.
    // Si pinceau trigger enter avec un objet tag "pot" :
    // -> pinceau material devient pot material
    // ET l'obj instantié material = pot material         => mettre l'objet public et le glisser dans inspector

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("pot"))
        {

        }
    }



    void Start()
    {
        
    }


    void Update()
    {
        
    }
}
