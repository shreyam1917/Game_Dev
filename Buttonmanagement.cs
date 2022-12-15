using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttonmanagement : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject FOREST;
    public GameObject CITY;
    public GameObject panel;
    public GameObject playbuttonForcity;
    public GameObject playbuttonForforest;
    public GameObject PausePanel;


    public void city()
    {
        CITY.SetActive(true);
        FOREST.SetActive(false);
        panel.SetActive(false);
        playbuttonForcity.SetActive(true);
        playbuttonForforest.SetActive(false);
    }
    public void forest()
    {
        FOREST.SetActive(true);
        CITY.SetActive(false);
        panel.SetActive(false);
        playbuttonForforest.SetActive(true);
        playbuttonForcity.SetActive(false);
    }

    public void themebutton()
    {
        panel.SetActive(true);
    }
    public void playbutton1()
    {
        SceneManager.LoadScene(1);

    }
    public void playbutton2()
    {
        SceneManager.LoadScene(2);
    }
    public void PlayCity()
    {
        Time.timeScale = 1;
        PausePanel.SetActive(false);
    }
    public void PlayForest()
    {
        Time.timeScale = 1;
        PausePanel.SetActive(false);
       
    }
    public void RestartCity()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }

    public void RestartForest()
    {
        SceneManager.LoadScene(2);
        Time.timeScale = 1;
    }

    public void ExitCity_Forest()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

    public void ExitGame()
    {
        Application.Quit();
    }

}
