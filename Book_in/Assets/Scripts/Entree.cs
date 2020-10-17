using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entree : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject Player;
    public Transform tp;
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CharacterController cc = Player.GetComponent<CharacterController>();
            cc.enabled = false;
            Player.transform.position = tp.position;
            cc.enabled = true;
        }   
    }
}
