using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class High_score : MonoBehaviour
{
    int high_score = 0;
    public TMP_Text hs_text;
    // Start is called before the first frame update
    void Start()
    {
        hs_text.text = PlayerPrefs.GetInt("High_Sc", 0).ToString();
    }

    // Update is called once per frame
    void Update()
    {
         high_score = Spaceship_mov.score_value;
        if(high_score > PlayerPrefs.GetInt("High_Sc" , 0) )
        {
            PlayerPrefs.SetInt("High_Sc", high_score);
            hs_text.text = high_score.ToString();
        }
    }
}
