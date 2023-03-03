using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    [SerializeField] Button pauseAudio;
    [SerializeField] Button unpauseAudio;
    [SerializeField] Button playAudio;
    [SerializeField] Button stopAudio;
    [SerializeField] Button pauseGame;
    [SerializeField] Button unpauseGame;
    [SerializeField] Button togglePlayWhilePaused;
    [SerializeField] Text statusText;
    [SerializeField] Text timerText;
    [SerializeField] AudioSource audioSource;

    void Update() {
        
        if(audioSource.isPlaying){
            statusText.text = "Audio Playing";
        }   
        else{
            statusText.text = "Audio Stoppped";
        }

        timerText.text = $"{audioSource.time}";
    }

    public void OnPauseAudioClick(){
        audioSource.Pause();
    }

    public void OnUnPauseAudioClick(){
        audioSource.UnPause();
    }

    public void OnPlayAudioClick(){
        audioSource.Play();
    }

    public void OnStopAudioClick(){
        audioSource.Stop();
    }

    public void OnPauseGameClick(){
        AudioListener.pause = true;
    }

    public void OnUnPauseGameClick(){
        AudioListener.pause = false;
    }

    public void TogglePlayWhilePaused(){
        audioSource.ignoreListenerPause = !audioSource.ignoreListenerPause;
    }
}
