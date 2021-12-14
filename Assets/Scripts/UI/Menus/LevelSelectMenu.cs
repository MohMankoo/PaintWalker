using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static GameConstants;
using UnityEngine.Audio;

// NOTE: This class need constant maintenance and
// addition/removal of level-loading methods as new
// ones are added and old ones are removed.
public class LevelSelectMenu : SecondaryMenu
{
    private Levels levelToLoad;
    public AudioSource menuMusic;
    public AudioMixerSnapshot menuMusicOut;
    
    public void LoadTutorial1()
    {
        PlayTransitionAnimation();
        levelToLoad = Levels.Tutorial1;
        menuMusicOut.TransitionTo(2f);
    }

    public void LoadTutorial2()
    {
        PlayTransitionAnimation();
        levelToLoad = Levels.Tutorial2;
        menuMusicOut.TransitionTo(2f);
    }
    
    public void LoadTutorial3()
    {
        PlayTransitionAnimation();
        levelToLoad = Levels.Tutorial3;
        menuMusicOut.TransitionTo(2f);
    }

    public void LoadLevel1()
    {
        PlayTransitionAnimation();
        levelToLoad = Levels.Level1;
        menuMusicOut.TransitionTo(2f);
    }
    
    public void LoadLevel2()
    {
        base.transitionAnimation.SetTrigger("FadeOut");
        levelToLoad = Levels.Level2;
        menuMusicOut.TransitionTo(2f);
    }
    
    public void LoadLevel3()
    {
        base.transitionAnimation.SetTrigger("FadeOut");
        levelToLoad = Levels.Level3;
        menuMusicOut.TransitionTo(2f);
    }

    private void PlayTransitionAnimation()
    {
        base.transitionAnimation.SetTrigger("FadeOut");
    }

    public void OnFadeComplete()
    {
        SceneLoader.LoadLevel(levelToLoad);
    }
}
