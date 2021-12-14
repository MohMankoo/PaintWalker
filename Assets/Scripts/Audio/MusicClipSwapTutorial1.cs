using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicClipSwapTutorial1 : MonoBehaviour
{
    public AudioSource music;
    public AudioClip tutorial;
    public AudioSource cutsceneMusic;
    public AudioClip cutsceneTutorial;

    void Start()
    {
        music.clip = tutorial;
        music.Play();

        cutsceneMusic.clip = cutsceneTutorial;
        cutsceneMusic.Play();
    }
}
