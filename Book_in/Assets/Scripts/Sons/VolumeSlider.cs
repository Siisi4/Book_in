using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class VolumeSlider : MonoBehaviour
{
    // chercher l'audio source
    private AudioSource source;

    // Valeur du slider
    private float musicVolume = 1f;

    // Start is called before the first frame update
    void Start()
    {
        // définir la source audio 
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // option de volume de source = valeur du slider
        source.volume = musicVolume;
    }

    // fonction à ajouter au slider avec un float en paramètre
    public void VolumeMusique(float vol){
        musicVolume = vol;
    }

}
