using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnPageSound : MonoBehaviour
{
    AudioSource pageSound;

    public void SurLeBouton() {
        pageSound.Play();
    }
    
    // Start is called before the first frame update
    void Start()
    {
         pageSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
