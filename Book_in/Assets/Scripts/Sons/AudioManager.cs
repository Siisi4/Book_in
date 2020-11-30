using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using TMPro;

public class AudioManager : MonoBehaviour
{
    public AudioClip[] musicClips;
    private int currentTrack;
    private AudioSource source;



    public TMP_Text clipTitleText;
    public TMP_Text clipTimeText;


    private int fullLenght;
    private int playTime;
    private int seconds;
    private int minutes;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();

        // commencer
        PlayMusic();
    }

    public void PlayMusic(){
        if(source.isPlaying){
            return;
        }
        currentTrack--;
        if(currentTrack < 0){
            currentTrack = musicClips.Length -1;
        }
        StartCoroutine("WaitForMusicEnd");
    }

    IEnumerator WaitForMusicEnd(){
        while (source.isPlaying){
            
            playTime = (int)source.time;
            ShowPlayTime();
            yield return null;
        }
        
        NextTitle();
    }

    public void NextTitle(){
        source.Stop();
        currentTrack++;
        if(currentTrack > musicClips.Length -1){
            currentTrack = 0;
        }
        source.clip = musicClips[currentTrack];
        source.Play();

        ShowCurrentTitle();

        // montrer le titre
        StartCoroutine("WaitForMusicEnd");
    }

    public void PreviousTitle(){
        source.Stop();
        currentTrack--;
        if(currentTrack < 0){
            currentTrack = musicClips.Length - 1;
        }
        source.clip = musicClips[currentTrack];
        source.Play();

        ShowCurrentTitle();

        // montrer le titre
        StartCoroutine("WaitForMusicEnd");
    }
    
    public void StopMusic(){

        //StopAllCoroutines();
        StopCoroutine("WaitForMusicEnd");
        source.Stop();
    }

    public void MuteMusic(){
        
        source.mute = !source.mute;      
    }

    void ShowCurrentTitle(){
        clipTitleText.text = source.clip.name;
        fullLenght = (int)source.clip.length;
    }

    void ShowPlayTime(){

        seconds = playTime %60; 
        minutes = (playTime /60) %60;
        clipTimeText.text = minutes + ":" + seconds.ToString("D2") + "/" + ((fullLenght /60) %60) + ":" + (fullLenght %60).ToString("D2");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
