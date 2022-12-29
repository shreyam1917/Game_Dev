using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class City_HighScore : MonoBehaviour
{
    int city_high_score = 0;
    public TMP_Text city_hs_text;
    // Start is called before the first frame update
    void Start()
    {
       // SceneManager.LoadScene(1);
        city_hs_text.text = PlayerPrefs.GetInt("High_Score", 0).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        city_high_score = City_Player_Mov.City_score_value;
        
        if (city_high_score > PlayerPrefs.GetInt("High_Score", 0))
        {
            PlayerPrefs.SetInt("High_Score", city_high_score);
            city_hs_text.text = city_high_score.ToString();
        }
    }
}
