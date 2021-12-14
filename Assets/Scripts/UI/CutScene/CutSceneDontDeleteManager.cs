using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutSceneDontDeleteManager : MonoBehaviour
{
    private static GameObject instance;
    public bool cutScenesSeen;
    public bool endCutScenesSeen;
    
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        if (instance == null)
        {
            instance = gameObject;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
