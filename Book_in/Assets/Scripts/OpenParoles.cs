using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OpenParoles : MonoBehaviour
{
    
    public GameObject ParoleActive;
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ParoleActive.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ParoleActive.SetActive(false);
        }
    }

}
