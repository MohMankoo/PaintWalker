using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startbutton : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartGame()
    {
        SceneManager.LoadScene("DesignDoc");
    }

    public void StartTutorial()
    {
        SceneManager.LoadScene("TutorialColors");
    }
}