using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sceneloader : MonoBehaviour
{
    public void PLAY()
    {
        SceneManager.LoadScene(1);
    }
    public void Exit()
    {
        SceneManager.LoadScene(0);
    }
    public void nextLevel_2()
    {
        SceneManager.LoadScene(2);
    }
    public void nextlevel_3()
    {
        SceneManager.LoadScene(3);
    }
}

