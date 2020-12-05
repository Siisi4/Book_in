using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickonLogo : MonoBehaviour
{

    public AudioSource pencilsound;
    public Animation anim1;
    public Animation anim2;
    public Animation anim3;
    public Animation anim4;
    public Animation anim5;

    public GameObject choixC;
    public GameObject choisisC;

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
        choixC.SetActive(false);
        choisisC.SetActive(true);
    }

    public void PlayGrowingAnimation1(){
        anim1.Play();
    }
    public void PlayGrowingAnimation2(){
        anim2.Play();
    }
    public void PlayGrowingAnimation3(){
        anim3.Play();
    }

    public void PlayGrowingAnimation4(){
        anim4.Play();
    }
    public void PlayGrowingAnimation5(){
        anim5.Play();
    }
}
