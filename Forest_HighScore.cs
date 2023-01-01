using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Forest_HighScore : MonoBehaviour
{
    int forest_high_score = 0;
    public TMP_Text forest_hs_text;
    // Start is called before the first frame update
    void Start()
    {
        //SceneManager.LoadScene(2);
        forest_hs_text.text = PlayerPrefs.GetInt("High_Score", 0).ToString();

    }

    // Update is called once per frame
    void Update()
    {
        forest_high_score = Forest_Player_Mov.Forest_score_value;

        if (forest_high_score > PlayerPrefs.GetInt("High_Score", 0))
        {
            PlayerPrefs.SetInt("High_Score", forest_high_score);
            forest_hs_text.text = forest_high_score.ToString();
        }
    }
}
