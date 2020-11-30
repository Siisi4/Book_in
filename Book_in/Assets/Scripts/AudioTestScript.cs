using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTestScript : MonoBehaviour
{
    
    public AudioSource key1;
    public AudioSource key2;
    public AudioSource music1;
    public AudioSource music2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Music1(){
        music1.Play();
    }
    public void Unpause(){
        music1.UnPause();
    }

    public void Pause(){
        music1.Pause();
        music2.Pause();
    }
    

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.A))
        {
            key1.Play();
        }
        if(Input.GetKeyUp(KeyCode.Z))
        {
            key2.Play();
        }
    }
}
