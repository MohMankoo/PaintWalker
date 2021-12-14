using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Exit : MonoBehaviour
{
    private UpdateUI _updateUI;
    public LevelManager manager;
    public AudioSource _winAudioSource;
    private CutsceneManager _cutsceneManager;
    private PauseMenu _pauseMenu;
    private RestartDontDeleteManager restartDontDeleteManager;
    private GameObject _player;
    public AudioMixerSnapshot bgmfade;
    public AudioMixer bgm;
   
    
    // Start is called before the first frame update
    void Start()
    {
        _updateUI = FindObjectOfType<UpdateUI>();
        restartDontDeleteManager = FindObjectOfType<RestartDontDeleteManager>();
        _winAudioSource = this.GetComponent<AudioSource>();
        _cutsceneManager = FindObjectOfType<CutsceneManager>();
        _pauseMenu = FindObjectOfType<PauseMenu>();
        _player = GameObject.FindWithTag("Player");
    }
    
    private void OnTriggerEnter(Collider collision)
    {
        Scene scene = SceneManager.GetActiveScene();
        bool playerCollision = collision.gameObject.GetComponent<Collider>().CompareTag("Player");
        if (playerCollision)
        {
            bgmfade.TransitionTo(3f);
            _player.SetActive(false);
            _winAudioSource.Play();

            if (scene.name == "Tutorial1" || scene.name == "Tutorial2" || scene.name == "Tutorial3")
            {
                _player.SetActive(false);
                _updateUI.SetInfoText("Tutorial Complete", true);
            }
            else if (scene.name == "Level1" || scene.name == "Level2" || scene.name == "Level3")
            {
                _player.SetActive(false);
                _updateUI.SetInfoText("Level Complete", true);
            }
            StartCoroutine(ReturnToMenu(scene));
        }
    }

    private IEnumerator ReturnToMenu(Scene scene)
    {
        restartDontDeleteManager = FindObjectOfType<RestartDontDeleteManager>();
        restartDontDeleteManager.isRestarting = false;
        yield return new WaitForSeconds(1);
        if (scene.name == "Level3")
        {
            _cutsceneManager.TriggerEndCutScene();
        }
        while (_cutsceneManager != null &&
               _cutsceneManager.gameObject.activeSelf)
        {
            yield return null;
        }
        _pauseMenu.FadeOut();
    }
}
