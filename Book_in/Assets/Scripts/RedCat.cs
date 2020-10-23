using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCat : MonoBehaviour
{

    public GameObject CanvasM;
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CanvasM.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CanvasM.SetActive(false);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
