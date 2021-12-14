using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicClipSwapTutorial2 : MonoBehaviour
{
    public AudioSource music;
    public AudioClip tutorial;
    
    void Start()
    {
        music.clip = tutorial;
        music.Play();
    }
}
