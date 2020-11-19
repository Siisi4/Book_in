using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickonLogo : MonoBehaviour
{

    public AudioSource pencilsound;
    public Animation anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayPencilSound(){
        pencilsound.Play() ;
    }

    public void PlayGrowingAnimation(){
        anim.Play();
    }



}
