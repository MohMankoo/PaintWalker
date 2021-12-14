using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicClipSwapTutorial3 : MonoBehaviour
{
    public AudioSource music;
    public AudioClip tutorial;
    
    void Start()
    {
        music.clip = tutorial;
        music.Play();
    }
}
