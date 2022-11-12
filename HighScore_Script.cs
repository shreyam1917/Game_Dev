using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighScore_Script : MonoBehaviour
{
    int boat_high_score = 0;
    public TMP_Text boat_hs_text;
    // Start is called before the first frame update
    void Start()
    {
        boat_hs_text.text = PlayerPrefs.GetInt("High_Score", 0).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        boat_high_score = Boat_mov.score_value;
        if (boat_high_score > PlayerPrefs.GetInt("High_Score", 0))
        {
            PlayerPrefs.SetInt("High_Score", boat_high_score);
            boat_hs_text.text = boat_high_score.ToString();
        }
    }
}
